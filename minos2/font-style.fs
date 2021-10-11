\ MINOS2 font style

\ Author: Bernd Paysan
\ Copyright (C) 2018,2019,2020 Free Software Foundation, Inc.

\ This file is part of Gforth.

\ Gforth is free software; you can redistribute it and/or
\ modify it under the terms of the GNU General Public License
\ as published by the Free Software Foundation, either version 3
\ of the License, or (at your option) any later version.

\ This program is distributed in the hope that it will be useful,
\ but WITHOUT ANY WARRANTY; without even the implied warranty of
\ MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
\ GNU General Public License for more details.

\ You should have received a copy of the GNU General Public License
\ along with this program. If not, see http://www.gnu.org/licenses/.

\ font array

require cstr.fs

get-current also minos definitions

Variable font[]     \ array of fonts
Variable fontname[] \ array of fontnames

0 Value font-size
0 Value font-shape
0 Value font-family
0 Value font-lang

12e FValue font-size# \ basic font size
16e FValue baseline#  \ basic baseline size
1e FValue pixelsize#  \ basic pixel size

: update-size# { f: lines -- }
    dpy-w @ s>f lines f/ fround to font-size#
    font-size# 16e f/ m2c:curminwidth% f!
    font-size# 133% f* fround to baseline#
    dpy-w @ s>f 1280e f/ to pixelsize# ;

: fontsize: ( n "name" -- n+1 )
    Create dup , 1+ DOES> @ to font-size ;
: fontshape: ( n "name" -- n+1 )
    Create dup , 1+ DOES> @ to font-shape ;
: fontfamily: ( n "name" -- n+1 )
    Create dup , 1+ DOES> @ to font-family ;
: fontlang: ( n "name" -- n+1 )
    Create dup , 1+ DOES> @ to font-lang ;

Create font-size%
100% f, 33% f, 50% f, 70% f, 80% f, 90% f, 140% f, 200% f,
DOES> ( n -- ) swap floats + f@ ;

: current-font-size% ( -- float )
    font-size# font-size font-size% f* fround ;

0
fontsize: \normal
fontsize: \micro
fontsize: \tiny
fontsize: \script
fontsize: \footnote
fontsize: \small
fontsize: \large
fontsize: \huge
Value font-sizes#

\normal

0
fontshape: \regular
fontshape: \bold
fontshape: \italic
fontshape: \bold-italic
Value font-shapes#

\regular

0
fontfamily: \sans
fontfamily: \serif
fontfamily: \mono
Value font-families#

\sans

0
fontlang: \latin
fontlang: \simplified-chinese
fontlang: \traditional-chinese
fontlang: \japanese
fontlang: \hangul
fontlang: \emoji
fontlang: \icons
fontlang: \devanagari
Value font-langs#

\latin

\ font load on demand

: font-index ( size -- index )
    font-families# * font-family +
    font-shapes#   * font-shape  +
    font-langs#    * font-lang   + ;
: font[]# ( -- n ) \ size of font array
    font-sizes# font-shapes# font-families# font-langs# * * * ;
: fontnames[]# ( -- n ) \ size of font array
    font-shapes# font-families# font-langs# * * ;

also freetype-gl also harfbuzz
: referenced ( font -- font )
    dup texture_font_t-face @ hb_ft_font_create_referenced
    over texture_font_t-hb_font ! ;
: ?referenced ( font -- font )
    dup texture_font_t-hb_font @ ?EXIT referenced ;

: fonts! ( font-addr addr -- )
    \ set current font for all sizes
    over font[] $@ drop - cell/ fontnames[]# mod { idx }
    font-sizes# 0 U+DO
	dup I fontnames[]# * idx + font[] $[] !  ?referenced
	I 1+ I' <> IF
	    I 1+ font-size% font-size# f* fround clone-font
	    referenced
	THEN
    LOOP  drop ;
: fontsfs! ( font-addr addr -- )
    \ set current font for all sizes+family+shape
    over font[] $@ drop - cell/ font-langs# mod { idx }
    font-sizes# font-families# * font-shapes# * 0 U+DO
	dup I font-langs# * idx + font[] $[] !  ?referenced
	I font-families# font-shapes# * /
	I 1+ font-families# font-shapes# * / <>
	I 1+ I' <> and IF
	    I 1+ font-families# font-shapes# * /
	    font-size% font-size# f* fround clone-font
	    referenced
	THEN
    LOOP  drop ;
previous previous

: fontname@ ( -- addr )
    0 font-index fontname[] $[] ;

s" No font specified" exception constant !!no-font!!
s" No suitable font found" exception constant !!no-suitable-font!!

also freetype-gl
: font-load ( font-addr -- font-addr )
    dup font[] $@ drop - cell/ dup >r fontnames[]# mod >r \ font index size 0
    atlas-bgra atlas r@ font-langs# mod [ ' \emoji >body @ ]L = select
    r@ fontname[] $[]@ 2dup d0= IF
	." font matrix: " r@
	font-langs# /mod font-shapes# /mod font-families# /mod . . . . cr
	!!no-font!! throw
    THEN
    font-size# 0 font-size% f* fround open-font
    r@ font-langs# mod 2 u< IF  fonts!  ELSE  fontsfs!  THEN  rdrop
    drop r> font[] $[] ;
previous

: ?font-load ( font-addr -- font-addr )
    dup @ 0= IF  font-load  THEN ;

\ font selector

\ other combiners are within their language block, and don't need
\ special care

: xc>font# ( xc-addr -- xc-addr font# )
    dup ['] xc@ catch IF  drop 0  EXIT  THEN
    case
	dup bl/null? = swap range@ or
	-1 of  last-font# @  endof
	dup 2 4 within IF  -1  ELSE  bl  THEN  to bl/null?
	0 endcase ;

:noname ( font# -- font )
    cells font + ?font-load @ ; is font#-load
' xc>font# IS font-select#
\ ' @ IS font-select

\ font indices

: font@ ( -- addr )
    font-size font-index font[] $[] ?font-load ;

: font@h ( -- height )
    font@ @ freetype-gl:texture_font_t-height  sf@ ;
: font@gap ( -- gap )
    font@ @ freetype-gl:texture_font_t-linegap sf@ ;

: current-baseline% ( -- float )
    baseline# font-size font-size% f* font@h fmax fround ;

\ font paths

Variable font-path
Variable font-prefix$

"GFORTHFONTS" getenv 2dup d0= [IF] 2drop "/usr/share/fonts/" [THEN]
font-prefix$ $!

: font-path+ ( "font" -- )
    parse-name
    2dup absolut-path? 0= IF  [: font-prefix$ $. type ;] $tmp  THEN
    2dup open-dir 0= IF
	close-dir throw font-path also-path
    ELSE  drop 2drop  THEN ;
: ?font ( addr u -- addr' u' true / false )
    font-path open-path-file 0= IF
	rot close-file throw tilde_cstr cstring>sstring true
    ELSE
	false
    THEN ;
: fonts= ( "font1|font2|..." -- addr u )
    parse-name  BEGIN  dup  WHILE  '|' $split 2swap ?font  UNTIL  2nip
    ELSE  !!no-suitable-font!! throw  THEN
    fontname@ $! ;

font-path+ ~/.fonts

[IFDEF] android
    font-prefix$ $free
    font-path+ /system/fonts
    "minos2/fonts" open-fpath-file 0=
    [IF]  font-path also-path close-file throw  [THEN]
[ELSE]
    font-path+ ttf/
    font-path+ truetype/
    font-path+ truetype/dejavu
    font-path+ truetype/noto
    font-path+ truetype/droid
    font-path+ truetype/liberation
    font-path+ truetype/arphic-gkai00mp
    font-path+ truetype/emoji
    font-path+ opentype/
    font-path+ opentype/noto
[THEN]

Vocabulary fonts

also fonts definitions

\ default font selection

\sans
\regular fonts= DejaVuSans.ttf|LiberationSans-Regular.ttf|NotoSans-Regular.ttf|DroidSans.ttf|Roboto-Medium.ttf
\italic fonts= DejaVuSans-Oblique.ttf|LiberationSans-Italic.ttf|NotoSans-Italic.ttf|Roboto-Italic.ttf
\bold fonts= DejaVuSans-Bold.ttf|LiberationSans-Bold.ttf|NotoSans-Bold.ttf|Roboto-Bold.ttf
\bold-italic fonts= DejaVuSans-BoldOblique.ttf|LiberationSans-BoldItalic.ttf|NotoSans-BoldItalic.ttf|Roboto-BoldItalic.ttf

\serif
\regular fonts= DejaVuSerif.ttf|LiberationSerif-Regular.ttf|NotoSerif-Regular.ttf
\bold fonts= DejaVuSerif-Bold.ttf|LiberationSerif-Bold.ttf|NotoSerif-Bold.ttf
\italic fonts= DejaVuSerif-Oblique.ttf|LiberationSerif-Italic.ttf|NotoSerif-Italic.ttf
\bold-italic fonts= DejaVuSerif-BoldOblique.ttf|LiberationSerif-BoldItalic.ttf|NotoSerif-BoldItalic.ttf

\mono
\regular fonts= DejaVuSansMono.ttf|LiberationMono-Regular.ttf|DroidSansMono.ttf
\bold fonts= DejaVuSansMono-Bold.ttf|LiberationMono-Bold.ttf|DroidSansMono.ttf
\italic fonts= DejaVuSansMono-Oblique.ttf|LiberationMono-Italic.ttf|DroidSansMono.ttf
\bold-italic fonts= DejaVuSansMono-BoldOblique.ttf|LiberationMono-BoldItalic.ttf|DroidSansMono.ttf

\simplified-chinese
2 font-lang >breakable
font-lang  $A000  $2E80 +range
font-lang $31390 $20000 +range
font-lang  $FB00  $F900 +range
font-lang  $FFF0  $FF00 +range
\sans
[IFDEF] android
    \regular fonts= NotoSansSC-Regular.otf|NotoSansCJK-Regular.ttc|DroidSansFallback.ttf
    \bold fonts= NotoSansSC-Bold.otf|NotoSansCJK-Bold.ttc|NotoSansSC-Regular.otf|NotoSansCJK-Regular.ttc|DroidSansFallback.ttf
    \italic fonts= NotoSansSC-Regular.otf|NotoSansCJK-Regular.ttc|DroidSansFallback.ttf
    \bold-italic fonts= NotoSansSC-Bold.otf|NotoSansCJK-Bold.ttc|NotoSansSC-Regular.otf|NotoSansCJK-Regular.ttc|DroidSansFallback.ttf
[ELSE]
    \regular fonts= gkai00mp.ttf|NotoSansSC-Regular.otf|NotoSansCJK-Regular.ttc
    \bold fonts= gkai00mp.ttf|NotoSansSC-Bold.otf|NotoSansCJK-Bold.ttc|NotoSansSC-Regular.otf|NotoSansCJK-Regular.ttc
    \italic fonts= gkai00mp.ttf|NotoSansSC-Regular.otf|NotoSansCJK-Regular.ttc
    \bold-italic fonts= gkai00mp.ttf|NotoSansSC-Bold.otf|NotoSansCJK-Bold.ttc|NotoSansSC-Regular.otf|NotoSansCJK-Regular.ttc
[THEN]
\serif
[IFDEF] android
    \regular fonts= NotoSerifSC-Regular.otf|NotoSerifCJK-Regular.ttc|NotoSansSC-Regular.otf|NotoSansCJK-Regular.ttc|DroidSansFallback.ttf
    \bold fonts= NotoSerifSC-Bold.otf|NotoSerifCJK-Bold.ttc|NotoSansSC-Bold.otf|NotoSansCJK-Bold.ttc|NotoSerifSC-Regular.otf|NotoSerifCJK-Regular.ttc|NotoSansSC-Regular.otf|NotoSansCJK-Regular.ttc|DroidSansFallback.ttf
    \italic fonts= NotoSerifSC-Regular.otf|NotoSerifCJK-Regular.ttc|NotoSansSC-Regular.otf|NotoSansCJK-Regular.ttc|DroidSansFallback.ttf
    \bold-italic fonts= NotoSerifSC-Bold.otf|NotoSerifCJK-Bold.ttc|NotoSansSC-Bold.otf|NotoSansCJK-Bold.ttc|NotoSerifSC-Regular.otf|NotoSerifCJK-Regular.ttc|NotoSansSC-Regular.otf|NotoSansCJK-Regular.ttc|DroidSansFallback.ttf
[ELSE]
    \regular fonts= gkai00mp.ttf|NotoSerifSC-Regular.otf|NotoSerifCJK-Regular.ttc|NotoSansSC-Regular.otf|NotoSansCJK-Regular.ttc
    \bold fonts= gkai00mp.ttf|NotoSerifSC-Bold.otf|NotoSerifCJK-Bold.ttc|NotoSansSC-Bold.otf|NotoSansCJK-Bold.ttc|NotoSerifSC-Regular.otf|NotoSerifCJK-Regular.ttc|NotoSansSC-Regular.otf|NotoSansCJK-Regular.ttc
    \italic fonts= gkai00mp.ttf|NotoSerifSC-Regular.otf|NotoSerifCJK-Regular.ttc|NotoSansSC-Regular.otf|NotoSansCJK-Regular.ttc
    \bold-italic fonts= gkai00mp.ttf|NotoSerifSC-Bold.otf|NotoSerifCJK-Bold.ttc|NotoSansSC-Bold.otf|NotoSansCJK-Bold.ttc|NotoSerifSC-Regular.otf|NotoSerifCJK-Regular.ttc|NotoSansSC-Regular.otf|NotoSansCJK-Regular.ttc
[THEN]
\mono
[IFDEF] android
    \regular fonts= NotoSansSC-Regular.otf|NotoSansCJK-Regular.ttc|DroidSansFallback.ttf
    \bold fonts= NotoSansSC-Bold.otf|NotoSansCJK-Bold.ttc|NotoSansSC-Regular.otf|NotoSansCJK-Regular.ttc|DroidSansFallback.ttf
    \italic fonts= NotoSansSC-Regular.otf|NotoSansCJK-Regular.ttc|DroidSansFallback.ttf
    \bold-italic fonts= NotoSansSC-Bold.otf|NotoSansCJK-Bold.ttc|NotoSansSC-Regular.otf|NotoSansCJK-Regular.ttc|DroidSansFallback.ttf
[ELSE]
    \regular fonts= gkai00mp.ttf|NotoSansSC-Regular.otf|NotoSansCJK-Regular.ttc
    \bold fonts= gkai00mp.ttf|NotoSansSC-Bold.otf|NotoSansCJK-Bold.ttc|NotoSansSC-Regular.otf|NotoSansCJK-Regular.ttc
    \italic fonts= gkai00mp.ttf|NotoSansSC-Regular.otf|NotoSansCJK-Regular.ttc
    \bold-italic fonts= gkai00mp.ttf|NotoSansSC-Bold.otf|NotoSansCJK-Bold.ttc|NotoSansSC-Regular.otf|NotoSansCJK-Regular.ttc
[THEN]

\traditional-chinese
2 font-lang >breakable
font-lang  $3130  $3100 +range \ bopomofo
:noname ( traditional simple -- )
    drop dup 1+ swap font-lang -rot +range ; is >sc
:noname ( simple traditional -- )
    2dup = IF  2drop  EXIT  THEN
    nip dup 1+ swap font-lang -rot +range ; is >tc
:noname ( traditional -- )
    dup 1+ swap font-lang -rot +range ; is >tc2
include unihan.fs
\sans
[IFDEF] android
    \regular fonts= NotoSansTC-Regular.otf|NotoSansCJK-Regular.ttc|DroidSansFallback.ttf
    \bold fonts= NotoSansTC-Bold.otf|NotoSansCJK-Bold.ttc|NotoSansTC-Regular.otf|NotoSansCJK-Regular.ttc|DroidSansFallback.ttf
    \italic fonts= NotoSansTC-Regular.otf|NotoSansCJK-Regular.ttc|DroidSansFallback.ttf
    \bold-italic fonts= NotoSansTC-Bold.otf|NotoSansCJK-Bold.ttc|NotoSansTC-Regular.otf|NotoSansCJK-Regular.ttc|DroidSansFallback.ttf
[ELSE]
    \regular fonts= bkai00mp.ttf|NotoSansTC-Regular.otf|NotoSansCJK-Regular.ttc
    \bold fonts= bkai00mp.ttf|NotoSansTC-Bold.otf|NotoSansCJK-Bold.ttc|NotoSansTC-Regular.otf|NotoSansCJK-Regular.ttc
    \italic fonts= bkai00mp.ttf|NotoSansTC-Regular.otf|NotoSansCJK-Regular.ttc
    \bold-italic fonts= bkai00mp.ttf|NotoSansTC-Bold.otf|NotoSansCJK-Bold.ttc|NotoSansTC-Regular.otf|NotoSansCJK-Regular.ttc
[THEN]
\serif
[IFDEF] android
    \regular fonts= NotoSerifTC-Regular.otf|NotoSerifCJK-Regular.ttc|NotoSansTC-Regular.otf|NotoSansCJK-Regular.ttc|DroidSansFallback.ttf
    \bold fonts= NotoSerifTC-Bold.otf|NotoSerifCJK-Bold.ttc|NotoSansTC-Bold.otf|NotoSansCJK-Bold.ttc|NotoSerifTC-Regular.otf|NotoSerifCJK-Regular.ttc|NotoSansTC-Regular.otf|NotoSansCJK-Regular.ttc|DroidSansFallback.ttf
    \italic fonts= NotoSerifTC-Regular.otf|NotoSerifCJK-Regular.ttc|NotoSansTC-Regular.otf|NotoSansCJK-Regular.ttc|DroidSansFallback.ttf
    \bold-italic fonts= NotoSerifTC-Bold.otf|NotoSerifCJK-Bold.ttc|NotoSansTC-Bold.otf|NotoSansCJK-Bold.ttc|NotoSerifTC-Regular.otf|NotoSerifCJK-Regular.ttc|NotoSansTC-Regular.otf|NotoSansCJK-Regular.ttc|DroidSansFallback.ttf
[ELSE]
    \regular fonts= bkai00mp.ttf|NotoSerifTC-Regular.otf|NotoSerifCJK-Regular.ttc|NotoSansTC-Regular.otf|NotoSansCJK-Regular.ttc
    \bold fonts= bkai00mp.ttf|NotoSerifTC-Bold.otf|NotoSerifCJK-Bold.ttc|NotoSansTC-Bold.otf|NotoSansCJK-Bold.ttc|NotoSerifTC-Regular.otf|NotoSerifCJK-Regular.ttc|NotoSansTC-Regular.otf|NotoSansCJK-Regular.ttc
    \italic fonts= bkai00mp.ttf|NotoSerifTC-Regular.otf|NotoSerifCJK-Regular.ttc|NotoSansTC-Regular.otf|NotoSansCJK-Regular.ttc
    \bold-italic fonts= bkai00mp.ttf|NotoSerifTC-Bold.otf|NotoSerifCJK-Bold.ttc|NotoSansTC-Bold.otf|NotoSansCJK-Bold.ttc|NotoSerifTC-Regular.otf|NotoSerifCJK-Regular.ttc|NotoSansTC-Regular.otf|NotoSansCJK-Regular.ttc
[THEN]
\mono
[IFDEF] android
    \regular fonts= NotoSansTC-Regular.otf|NotoSansCJK-Regular.ttc|DroidSansFallback.ttf
    \bold fonts= NotoSansTC-Bold.otf|NotoSansCJK-Bold.ttc|NotoSansTC-Regular.otf|NotoSansCJK-Regular.ttc|DroidSansFallback.ttf
    \italic fonts= NotoSansTC-Regular.otf|NotoSansCJK-Regular.ttc|DroidSansFallback.ttf
    \bold-italic fonts= NotoSansTC-Bold.otf|NotoSansCJK-Bold.ttc|NotoSansTC-Regular.otf|NotoSansCJK-Regular.ttc|DroidSansFallback.ttf
[ELSE]
    \regular fonts= bkai00mp.ttf|NotoSansTC-Regular.otf|NotoSansCJK-Regular.ttc
    \bold fonts= bkai00mp.ttf|NotoSansTC-Bold.otf|NotoSansCJK-Bold.ttc|NotoSansTC-Regular.otf|NotoSansCJK-Regular.ttc
    \italic fonts= bkai00mp.ttf|NotoSansTC-Regular.otf|NotoSansCJK-Regular.ttc
    \bold-italic fonts= bkai00mp.ttf|NotoSansTC-Bold.otf|NotoSansCJK-Bold.ttc|NotoSansTC-Regular.otf|NotoSansCJK-Regular.ttc
[THEN]

\japanese
2 font-lang >breakable
font-lang $3100 $3000 +range \ Japanese-style punctuation, Hiragana, Katakana
font-lang $3200 $31F0 +range
font-lang $3244 $3220 +range
font-lang $3380 $3280 +range
font-lang $FFA0 $FF5F +range \ half width Katakana&punctation
\sans
\regular fonts= gkai00mp.ttf|NotoSansJP-Regular.otf|NotoSansCJK-Regular.ttc|DroidSansFallback.ttf
\bold fonts= gkai00mp.ttf|NotoSansJP-Bold.otf|NotoSansCJK-Bold.ttc|NotoSansJP-Regular.otf|NotoSansCJK-Regular.ttc|DroidSansFallback.ttf
\italic fonts= gkai00mp.ttf|NotoSansJP-Regular.otf|NotoSansCJK-Regular.ttc|DroidSansFallback.ttf
\bold-italic fonts= gkai00mp.ttf|NotoSansJP-Bold.otf|NotoSansCJK-Bold.ttc|NotoSansJP-Regular.otf|NotoSansCJK-Regular.ttc|DroidSansFallback.ttf
\serif
\regular fonts= gkai00mp.ttf|NotoSerifCJKjp-Regular.otf|NotoSerifCJK-Regular.ttc|DroidSansFallback.ttf
\bold fonts= gkai00mp.ttf|NotoSerifCJKjp-Bold.otf|NotoSerifCJK-Bold.ttc|NotoSerifJP-Regular.otf|NotoSerifCJK-Regular.ttc|DroidSansFallback.ttf
\italic fonts= gkai00mp.ttf|NotoSerifCJKjp-Regular.otf|NotoSerifCJK-Regular.ttc|DroidSansFallback.ttf
\bold-italic fonts= gkai00mp.ttf|NotoSerifCJKjp-Bold.otf|NotoSerifCJK-Bold.ttc|NotoSerifJP-Regular.otf|NotoSerifCJK-Regular.ttc|DroidSansFallback.ttf
\mono

\hangul
1 font-lang >breakable \ not breakable for ragged layout
font-lang $1200 $1100 +range
font-lang $3190 $3130 +range
font-lang $A980 $A960 +range
font-lang $D7A4 $AC00 +range
font-lang $D800 $D7B0 +range
\sans
\regular fonts= NotoSansKR-Regular.otf
\bold fonts= NotoSansKR-Bold.otf
\italic fonts= NotoSansKR-Regular.otf
\bold-italic fonts= NotoSansKR-Bold.otf
\serif
\regular fonts= NotoSerifCJKkr-Regular.otf
\bold fonts= NotoSerifCJKkr-Bold.otf
\italic fonts= NotoSerifCJKkr-Regular.otf
\bold-italic fonts= NotoSerifCJKkr-Bold.otf
\mono
\regular fonts= NotoSansMonoCJKkr-Regular.otf
\bold fonts= NotoSansMonoCJKkr-Bold.otf
\italic fonts= NotoSansMonoCJKkr-Regular.otf
\bold-italic fonts= NotoSansMonoCJKkr-Bold.otf

\ emojis and icons don't differ between different shapes and styles

\emoji
2 font-lang >breakable
font-lang  $2C00  $2600 +range
font-lang $20000 $1F000 +range
\sans \regular
fonts= NotoColorEmoji.ttf|emojione-android.ttf|Twemoji.ttf|SamsungColorEmoji.ttf

\icons
2 font-lang >breakable
font-lang $F900 $F000 +range
\sans \regular
fonts= fa-merged-900.ttf

\devanagari
font-lang  $980  $900 +range
font-lang $1D00 $1CD0 +range
font-lang $A840 $A830 +range
font-lang $A900 $A8E0 +range
\sans \regular
fonts= NotoSansDevanagari-Regular.ttf
\bold
fonts= NotoSansDevanagari-Bold.ttf
\serif \regular
fonts= NotoSerifDevanagari-Regular.ttf
\bold
fonts= NotoSerifDevanagari-Bold.ttf

\latin \sans \regular

previous previous set-current
