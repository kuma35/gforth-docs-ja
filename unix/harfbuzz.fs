\ This file has been generated using SWIG and fsi,
\ and is already platform dependent, search for the corresponding
\ fsi-file to compile it where no one has compiled it before ;)
\ Forth systems have their own own dynamic loader and don't need addional C-Code.
\ That's why this file will just print normal forth-code once compiled
\ and can be used directly with include or require.
\ As all comments are stripped during the compilation, please
\ insert the copyright notice of the original file here.

\ ----===< prefix >===-----
cs-vocabulary harfbuzz

get-current also harfbuzz definitions

c-library harfbuzz
e? os-type s" linux-android" string-prefix? [IF] s" typeset" [ELSE] s" harfbuzz" [THEN] add-lib
\c #include <harfbuzz/hb.h>
\c #include <harfbuzz/hb-ft.h>
\c #ifdef __gnu_linux__
\c #undef stderr
\c extern struct _IO_FILE *stderr;
\c #endif
\c #undef hb_glyph_info_get_glyph_flags
\c #define HB_MIN_VER(x, y) (HB_VERSION_MAJOR > x || (HB_VERSION_MAJOR == x && HB_VERSION_MINOR >= y))

\ ----===< int constants >===-----
#65533	constant HB_BUFFER_REPLACEMENT_CODEPOINT_DEFAULT
#0	constant HB_FEATURE_GLOBAL_START
#1114111	constant HB_UNICODE_MAX
#2	constant HB_VERSION_MAJOR
#7	constant HB_VERSION_MINOR
#4	constant HB_VERSION_MICRO

\ --------===< enums >===---------
#0	constant HB_MEMORY_MODE_DUPLICATE
#1	constant HB_MEMORY_MODE_READONLY
#2	constant HB_MEMORY_MODE_WRITABLE
#3	constant HB_MEMORY_MODE_READONLY_MAY_MAKE_WRITABLE
#1	constant HB_GLYPH_FLAG_UNSAFE_TO_BREAK
#1	constant HB_GLYPH_FLAG_DEFINED
#0	constant HB_BUFFER_CONTENT_TYPE_INVALID
#1	constant HB_BUFFER_CONTENT_TYPE_UNICODE
#2	constant HB_BUFFER_CONTENT_TYPE_GLYPHS
#0	constant HB_BUFFER_FLAG_DEFAULT
#1	constant HB_BUFFER_FLAG_BOT
#2	constant HB_BUFFER_FLAG_EOT
#4	constant HB_BUFFER_FLAG_PRESERVE_DEFAULT_IGNORABLES
#8	constant HB_BUFFER_FLAG_REMOVE_DEFAULT_IGNORABLES
#16	constant HB_BUFFER_FLAG_DO_NOT_INSERT_DOTTED_CIRCLE
#0	constant HB_BUFFER_CLUSTER_LEVEL_MONOTONE_GRAPHEMES
#1	constant HB_BUFFER_CLUSTER_LEVEL_MONOTONE_CHARACTERS
#2	constant HB_BUFFER_CLUSTER_LEVEL_CHARACTERS
#0	constant HB_BUFFER_CLUSTER_LEVEL_DEFAULT
#0	constant HB_BUFFER_SERIALIZE_FLAG_DEFAULT
#1	constant HB_BUFFER_SERIALIZE_FLAG_NO_CLUSTERS
#2	constant HB_BUFFER_SERIALIZE_FLAG_NO_POSITIONS
#4	constant HB_BUFFER_SERIALIZE_FLAG_NO_GLYPH_NAMES
#8	constant HB_BUFFER_SERIALIZE_FLAG_GLYPH_EXTENTS
#16	constant HB_BUFFER_SERIALIZE_FLAG_GLYPH_FLAGS
#32	constant HB_BUFFER_SERIALIZE_FLAG_NO_ADVANCES
#1413830740	constant HB_BUFFER_SERIALIZE_FORMAT_TEXT
#1246973774	constant HB_BUFFER_SERIALIZE_FORMAT_JSON
#0	constant HB_BUFFER_SERIALIZE_FORMAT_INVALID
#0	constant HB_BUFFER_DIFF_FLAG_EQUAL
#1	constant HB_BUFFER_DIFF_FLAG_CONTENT_TYPE_MISMATCH
#2	constant HB_BUFFER_DIFF_FLAG_LENGTH_MISMATCH
#4	constant HB_BUFFER_DIFF_FLAG_NOTDEF_PRESENT
#8	constant HB_BUFFER_DIFF_FLAG_DOTTED_CIRCLE_PRESENT
#16	constant HB_BUFFER_DIFF_FLAG_CODEPOINT_MISMATCH
#32	constant HB_BUFFER_DIFF_FLAG_CLUSTER_MISMATCH
#64	constant HB_BUFFER_DIFF_FLAG_GLYPH_FLAGS_MISMATCH
#128	constant HB_BUFFER_DIFF_FLAG_POSITION_MISMATCH
#0	constant HB_DIRECTION_INVALID
#4	constant HB_DIRECTION_LTR
#5	constant HB_DIRECTION_RTL
#6	constant HB_DIRECTION_TTB
#7	constant HB_DIRECTION_BTT
#1517910393	constant HB_SCRIPT_COMMON
#1516858984	constant HB_SCRIPT_INHERITED
#1517976186	constant HB_SCRIPT_UNKNOWN
#1098015074	constant HB_SCRIPT_ARABIC
#1098018158	constant HB_SCRIPT_ARMENIAN
#1113943655	constant HB_SCRIPT_BENGALI
#1132032620	constant HB_SCRIPT_CYRILLIC
#1147500129	constant HB_SCRIPT_DEVANAGARI
#1197830002	constant HB_SCRIPT_GEORGIAN
#1198679403	constant HB_SCRIPT_GREEK
#1198877298	constant HB_SCRIPT_GUJARATI
#1198879349	constant HB_SCRIPT_GURMUKHI
#1214344807	constant HB_SCRIPT_HANGUL
#1214344809	constant HB_SCRIPT_HAN
#1214603890	constant HB_SCRIPT_HEBREW
#1214870113	constant HB_SCRIPT_HIRAGANA
#1265525857	constant HB_SCRIPT_KANNADA
#1264676449	constant HB_SCRIPT_KATAKANA
#1281453935	constant HB_SCRIPT_LAO
#1281455214	constant HB_SCRIPT_LATIN
#1298954605	constant HB_SCRIPT_MALAYALAM
#1332902241	constant HB_SCRIPT_ORIYA
#1415671148	constant HB_SCRIPT_TAMIL
#1415933045	constant HB_SCRIPT_TELUGU
#1416126825	constant HB_SCRIPT_THAI
#1416192628	constant HB_SCRIPT_TIBETAN
#1114599535	constant HB_SCRIPT_BOPOMOFO
#1114792297	constant HB_SCRIPT_BRAILLE
#1130458739	constant HB_SCRIPT_CANADIAN_SYLLABICS
#1130915186	constant HB_SCRIPT_CHEROKEE
#1165256809	constant HB_SCRIPT_ETHIOPIC
#1265134962	constant HB_SCRIPT_KHMER
#1299148391	constant HB_SCRIPT_MONGOLIAN
#1299803506	constant HB_SCRIPT_MYANMAR
#1332175213	constant HB_SCRIPT_OGHAM
#1383427698	constant HB_SCRIPT_RUNIC
#1399418472	constant HB_SCRIPT_SINHALA
#1400468067	constant HB_SCRIPT_SYRIAC
#1416126817	constant HB_SCRIPT_THAANA
#1500080489	constant HB_SCRIPT_YI
#1148416628	constant HB_SCRIPT_DESERET
#1198486632	constant HB_SCRIPT_GOTHIC
#1232363884	constant HB_SCRIPT_OLD_ITALIC
#1114990692	constant HB_SCRIPT_BUHID
#1214344815	constant HB_SCRIPT_HANUNOO
#1416064103	constant HB_SCRIPT_TAGALOG
#1415669602	constant HB_SCRIPT_TAGBANWA
#1131442804	constant HB_SCRIPT_CYPRIOT
#1281977698	constant HB_SCRIPT_LIMBU
#1281977954	constant HB_SCRIPT_LINEAR_B
#1332964705	constant HB_SCRIPT_OSMANYA
#1399349623	constant HB_SCRIPT_SHAVIAN
#1415670885	constant HB_SCRIPT_TAI_LE
#1432838514	constant HB_SCRIPT_UGARITIC
#1114990441	constant HB_SCRIPT_BUGINESE
#1131376756	constant HB_SCRIPT_COPTIC
#1198285159	constant HB_SCRIPT_GLAGOLITIC
#1265131890	constant HB_SCRIPT_KHAROSHTHI
#1415670901	constant HB_SCRIPT_NEW_TAI_LUE
#1483761007	constant HB_SCRIPT_OLD_PERSIAN
#1400466543	constant HB_SCRIPT_SYLOTI_NAGRI
#1415999079	constant HB_SCRIPT_TIFINAGH
#1113681001	constant HB_SCRIPT_BALINESE
#1483961720	constant HB_SCRIPT_CUNEIFORM
#1315663727	constant HB_SCRIPT_NKO
#1349017959	constant HB_SCRIPT_PHAGS_PA
#1349021304	constant HB_SCRIPT_PHOENICIAN
#1130459753	constant HB_SCRIPT_CARIAN
#1130914157	constant HB_SCRIPT_CHAM
#1264675945	constant HB_SCRIPT_KAYAH_LI
#1281716323	constant HB_SCRIPT_LEPCHA
#1283023721	constant HB_SCRIPT_LYCIAN
#1283023977	constant HB_SCRIPT_LYDIAN
#1332503403	constant HB_SCRIPT_OL_CHIKI
#1382706791	constant HB_SCRIPT_REJANG
#1398895986	constant HB_SCRIPT_SAURASHTRA
#1400204900	constant HB_SCRIPT_SUNDANESE
#1449224553	constant HB_SCRIPT_VAI
#1098281844	constant HB_SCRIPT_AVESTAN
#1113681269	constant HB_SCRIPT_BAMUM
#1164409200	constant HB_SCRIPT_EGYPTIAN_HIEROGLYPHS
#1098018153	constant HB_SCRIPT_IMPERIAL_ARAMAIC
#1349020777	constant HB_SCRIPT_INSCRIPTIONAL_PAHLAVI
#1349678185	constant HB_SCRIPT_INSCRIPTIONAL_PARTHIAN
#1247901281	constant HB_SCRIPT_JAVANESE
#1265920105	constant HB_SCRIPT_KAITHI
#1281979253	constant HB_SCRIPT_LISU
#1299473769	constant HB_SCRIPT_MEETEI_MAYEK
#1398895202	constant HB_SCRIPT_OLD_SOUTH_ARABIAN
#1332898664	constant HB_SCRIPT_OLD_TURKIC
#1398893938	constant HB_SCRIPT_SAMARITAN
#1281453665	constant HB_SCRIPT_TAI_THAM
#1415673460	constant HB_SCRIPT_TAI_VIET
#1113683051	constant HB_SCRIPT_BATAK
#1114792296	constant HB_SCRIPT_BRAHMI
#1298230884	constant HB_SCRIPT_MANDAIC
#1130457965	constant HB_SCRIPT_CHAKMA
#1298494051	constant HB_SCRIPT_MEROITIC_CURSIVE
#1298494063	constant HB_SCRIPT_MEROITIC_HIEROGLYPHS
#1349284452	constant HB_SCRIPT_MIAO
#1399353956	constant HB_SCRIPT_SHARADA
#1399812705	constant HB_SCRIPT_SORA_SOMPENG
#1415670642	constant HB_SCRIPT_TAKRI
#1113682803	constant HB_SCRIPT_BASSA_VAH
#1097295970	constant HB_SCRIPT_CAUCASIAN_ALBANIAN
#1148547180	constant HB_SCRIPT_DUPLOYAN
#1164730977	constant HB_SCRIPT_ELBASAN
#1198678382	constant HB_SCRIPT_GRANTHA
#1265135466	constant HB_SCRIPT_KHOJKI
#1399418468	constant HB_SCRIPT_KHUDAWADI
#1281977953	constant HB_SCRIPT_LINEAR_A
#1298229354	constant HB_SCRIPT_MAHAJANI
#1298230889	constant HB_SCRIPT_MANICHAEAN
#1298493028	constant HB_SCRIPT_MENDE_KIKAKUI
#1299145833	constant HB_SCRIPT_MODI
#1299345263	constant HB_SCRIPT_MRO
#1315070324	constant HB_SCRIPT_NABATAEAN
#1315009122	constant HB_SCRIPT_OLD_NORTH_ARABIAN
#1348825709	constant HB_SCRIPT_OLD_PERMIC
#1215131239	constant HB_SCRIPT_PAHAWH_HMONG
#1348562029	constant HB_SCRIPT_PALMYRENE
#1348564323	constant HB_SCRIPT_PAU_CIN_HAU
#1349020784	constant HB_SCRIPT_PSALTER_PAHLAVI
#1399415908	constant HB_SCRIPT_SIDDHAM
#1416196712	constant HB_SCRIPT_TIRHUTA
#1466004065	constant HB_SCRIPT_WARANG_CITI
#1097363309	constant HB_SCRIPT_AHOM
#1215067511	constant HB_SCRIPT_ANATOLIAN_HIEROGLYPHS
#1214346354	constant HB_SCRIPT_HATRAN
#1299541108	constant HB_SCRIPT_MULTANI
#1215655527	constant HB_SCRIPT_OLD_HUNGARIAN
#1399287415	constant HB_SCRIPT_SIGNWRITING
#1097100397	constant HB_SCRIPT_ADLAM
#1114139507	constant HB_SCRIPT_BHAIKSUKI
#1298231907	constant HB_SCRIPT_MARCHEN
#1332963173	constant HB_SCRIPT_OSAGE
#1415671399	constant HB_SCRIPT_TANGUT
#1315272545	constant HB_SCRIPT_NEWA
#1198485101	constant HB_SCRIPT_MASARAM_GONDI
#1316186229	constant HB_SCRIPT_NUSHU
#1399814511	constant HB_SCRIPT_SOYOMBO
#1516334690	constant HB_SCRIPT_ZANABAZAR_SQUARE
#1148151666	constant HB_SCRIPT_DOGRA
#1198485095	constant HB_SCRIPT_GUNJALA_GONDI
#1383032935	constant HB_SCRIPT_HANIFI_ROHINGYA
#1298230113	constant HB_SCRIPT_MAKASAR
#1298490470	constant HB_SCRIPT_MEDEFAIDRIN
#1399809903	constant HB_SCRIPT_OLD_SOGDIAN
#1399809892	constant HB_SCRIPT_SOGDIAN
#1164736877	constant HB_SCRIPT_ELYMAIC
#1315008100	constant HB_SCRIPT_NANDINAGARI
#1215131248	constant HB_SCRIPT_NYIAKENG_PUACHUE_HMONG
#1466132591	constant HB_SCRIPT_WANCHO
#1130918515	constant HB_SCRIPT_CHORASMIAN
#1147756907	constant HB_SCRIPT_DIVES_AKURU
#1265202291	constant HB_SCRIPT_KHITAN_SMALL_SCRIPT
#1499822697	constant HB_SCRIPT_YEZIDI
#0	constant HB_SCRIPT_INVALID
#2147483647	constant _HB_SCRIPT_MAX_VALUE
#2147483647	constant _HB_SCRIPT_MAX_VALUE_SIGNED
#0	constant HB_UNICODE_GENERAL_CATEGORY_CONTROL
#1	constant HB_UNICODE_GENERAL_CATEGORY_FORMAT
#2	constant HB_UNICODE_GENERAL_CATEGORY_UNASSIGNED
#3	constant HB_UNICODE_GENERAL_CATEGORY_PRIVATE_USE
#4	constant HB_UNICODE_GENERAL_CATEGORY_SURROGATE
#5	constant HB_UNICODE_GENERAL_CATEGORY_LOWERCASE_LETTER
#6	constant HB_UNICODE_GENERAL_CATEGORY_MODIFIER_LETTER
#7	constant HB_UNICODE_GENERAL_CATEGORY_OTHER_LETTER
#8	constant HB_UNICODE_GENERAL_CATEGORY_TITLECASE_LETTER
#9	constant HB_UNICODE_GENERAL_CATEGORY_UPPERCASE_LETTER
#10	constant HB_UNICODE_GENERAL_CATEGORY_SPACING_MARK
#11	constant HB_UNICODE_GENERAL_CATEGORY_ENCLOSING_MARK
#12	constant HB_UNICODE_GENERAL_CATEGORY_NON_SPACING_MARK
#13	constant HB_UNICODE_GENERAL_CATEGORY_DECIMAL_NUMBER
#14	constant HB_UNICODE_GENERAL_CATEGORY_LETTER_NUMBER
#15	constant HB_UNICODE_GENERAL_CATEGORY_OTHER_NUMBER
#16	constant HB_UNICODE_GENERAL_CATEGORY_CONNECT_PUNCTUATION
#17	constant HB_UNICODE_GENERAL_CATEGORY_DASH_PUNCTUATION
#18	constant HB_UNICODE_GENERAL_CATEGORY_CLOSE_PUNCTUATION
#19	constant HB_UNICODE_GENERAL_CATEGORY_FINAL_PUNCTUATION
#20	constant HB_UNICODE_GENERAL_CATEGORY_INITIAL_PUNCTUATION
#21	constant HB_UNICODE_GENERAL_CATEGORY_OTHER_PUNCTUATION
#22	constant HB_UNICODE_GENERAL_CATEGORY_OPEN_PUNCTUATION
#23	constant HB_UNICODE_GENERAL_CATEGORY_CURRENCY_SYMBOL
#24	constant HB_UNICODE_GENERAL_CATEGORY_MODIFIER_SYMBOL
#25	constant HB_UNICODE_GENERAL_CATEGORY_MATH_SYMBOL
#26	constant HB_UNICODE_GENERAL_CATEGORY_OTHER_SYMBOL
#27	constant HB_UNICODE_GENERAL_CATEGORY_LINE_SEPARATOR
#28	constant HB_UNICODE_GENERAL_CATEGORY_PARAGRAPH_SEPARATOR
#29	constant HB_UNICODE_GENERAL_CATEGORY_SPACE_SEPARATOR
#0	constant HB_UNICODE_COMBINING_CLASS_NOT_REORDERED
#1	constant HB_UNICODE_COMBINING_CLASS_OVERLAY
#7	constant HB_UNICODE_COMBINING_CLASS_NUKTA
#8	constant HB_UNICODE_COMBINING_CLASS_KANA_VOICING
#9	constant HB_UNICODE_COMBINING_CLASS_VIRAMA
#10	constant HB_UNICODE_COMBINING_CLASS_CCC10
#11	constant HB_UNICODE_COMBINING_CLASS_CCC11
#12	constant HB_UNICODE_COMBINING_CLASS_CCC12
#13	constant HB_UNICODE_COMBINING_CLASS_CCC13
#14	constant HB_UNICODE_COMBINING_CLASS_CCC14
#15	constant HB_UNICODE_COMBINING_CLASS_CCC15
#16	constant HB_UNICODE_COMBINING_CLASS_CCC16
#17	constant HB_UNICODE_COMBINING_CLASS_CCC17
#18	constant HB_UNICODE_COMBINING_CLASS_CCC18
#19	constant HB_UNICODE_COMBINING_CLASS_CCC19
#20	constant HB_UNICODE_COMBINING_CLASS_CCC20
#21	constant HB_UNICODE_COMBINING_CLASS_CCC21
#22	constant HB_UNICODE_COMBINING_CLASS_CCC22
#23	constant HB_UNICODE_COMBINING_CLASS_CCC23
#24	constant HB_UNICODE_COMBINING_CLASS_CCC24
#25	constant HB_UNICODE_COMBINING_CLASS_CCC25
#26	constant HB_UNICODE_COMBINING_CLASS_CCC26
#27	constant HB_UNICODE_COMBINING_CLASS_CCC27
#28	constant HB_UNICODE_COMBINING_CLASS_CCC28
#29	constant HB_UNICODE_COMBINING_CLASS_CCC29
#30	constant HB_UNICODE_COMBINING_CLASS_CCC30
#31	constant HB_UNICODE_COMBINING_CLASS_CCC31
#32	constant HB_UNICODE_COMBINING_CLASS_CCC32
#33	constant HB_UNICODE_COMBINING_CLASS_CCC33
#34	constant HB_UNICODE_COMBINING_CLASS_CCC34
#35	constant HB_UNICODE_COMBINING_CLASS_CCC35
#36	constant HB_UNICODE_COMBINING_CLASS_CCC36
#84	constant HB_UNICODE_COMBINING_CLASS_CCC84
#91	constant HB_UNICODE_COMBINING_CLASS_CCC91
#103	constant HB_UNICODE_COMBINING_CLASS_CCC103
#107	constant HB_UNICODE_COMBINING_CLASS_CCC107
#118	constant HB_UNICODE_COMBINING_CLASS_CCC118
#122	constant HB_UNICODE_COMBINING_CLASS_CCC122
#129	constant HB_UNICODE_COMBINING_CLASS_CCC129
#130	constant HB_UNICODE_COMBINING_CLASS_CCC130
#132	constant HB_UNICODE_COMBINING_CLASS_CCC133
#200	constant HB_UNICODE_COMBINING_CLASS_ATTACHED_BELOW_LEFT
#202	constant HB_UNICODE_COMBINING_CLASS_ATTACHED_BELOW
#214	constant HB_UNICODE_COMBINING_CLASS_ATTACHED_ABOVE
#216	constant HB_UNICODE_COMBINING_CLASS_ATTACHED_ABOVE_RIGHT
#218	constant HB_UNICODE_COMBINING_CLASS_BELOW_LEFT
#220	constant HB_UNICODE_COMBINING_CLASS_BELOW
#222	constant HB_UNICODE_COMBINING_CLASS_BELOW_RIGHT
#224	constant HB_UNICODE_COMBINING_CLASS_LEFT
#226	constant HB_UNICODE_COMBINING_CLASS_RIGHT
#228	constant HB_UNICODE_COMBINING_CLASS_ABOVE_LEFT
#230	constant HB_UNICODE_COMBINING_CLASS_ABOVE
#232	constant HB_UNICODE_COMBINING_CLASS_ABOVE_RIGHT
#233	constant HB_UNICODE_COMBINING_CLASS_DOUBLE_BELOW
#234	constant HB_UNICODE_COMBINING_CLASS_DOUBLE_ABOVE
#240	constant HB_UNICODE_COMBINING_CLASS_IOTA_SUBSCRIPT
#255	constant HB_UNICODE_COMBINING_CLASS_INVALID

\ -------===< structs >===--------
\ hb_glyph_info_t
begin-structure hb_glyph_info_t
	drop 4 4 +field hb_glyph_info_t-mask
	drop 12 4 +field hb_glyph_info_t-var1
	drop 0 4 +field hb_glyph_info_t-codepoint
	drop 8 4 +field hb_glyph_info_t-cluster
	drop 16 4 +field hb_glyph_info_t-var2
drop 20 end-structure
\ hb_glyph_position_t
begin-structure hb_glyph_position_t
	drop 8 4 +field hb_glyph_position_t-x_offset
	drop 12 4 +field hb_glyph_position_t-y_offset
	drop 16 4 +field hb_glyph_position_t-var
	drop 0 4 +field hb_glyph_position_t-x_advance
	drop 4 4 +field hb_glyph_position_t-y_advance
drop 20 end-structure
\ hb_segment_properties_t
begin-structure hb_segment_properties_t
	drop 4 4 +field hb_segment_properties_t-script
	drop 16 8 +field hb_segment_properties_t-reserved1
	drop 8 8 +field hb_segment_properties_t-language
	drop 24 8 +field hb_segment_properties_t-reserved2
	drop 0 4 +field hb_segment_properties_t-direction
drop 32 end-structure
\ hb_var_int_t
begin-structure hb_var_int_t
drop 4 end-structure
\ hb_user_data_key_t
begin-structure hb_user_data_key_t
	drop 0 1 +field hb_user_data_key_t-unused
drop 1 end-structure
\ hb_feature_t
begin-structure hb_feature_t
	drop 12 4 +field hb_feature_t-end
	drop 0 4 +field hb_feature_t-tag
	drop 4 4 +field hb_feature_t-value
	drop 8 4 +field hb_feature_t-start
drop 16 end-structure
\ hb_variation_t
begin-structure hb_variation_t
	drop 0 4 +field hb_variation_t-tag
	drop 4 4 +field hb_variation_t-value
drop 8 end-structure
\ hb_font_extents_t
begin-structure hb_font_extents_t
	drop 28 4 +field hb_font_extents_t-reserved5
	drop 8 4 +field hb_font_extents_t-line_gap
	drop 24 4 +field hb_font_extents_t-reserved6
	drop 20 4 +field hb_font_extents_t-reserved7
	drop 16 4 +field hb_font_extents_t-reserved8
	drop 44 4 +field hb_font_extents_t-reserved1
	drop 12 4 +field hb_font_extents_t-reserved9
	drop 40 4 +field hb_font_extents_t-reserved2
	drop 36 4 +field hb_font_extents_t-reserved3
	drop 0 4 +field hb_font_extents_t-ascender
	drop 4 4 +field hb_font_extents_t-descender
	drop 32 4 +field hb_font_extents_t-reserved4
drop 48 end-structure
\ hb_glyph_extents_t
begin-structure hb_glyph_extents_t
	drop 12 4 +field hb_glyph_extents_t-height
	drop 8 4 +field hb_glyph_extents_t-width
	drop 0 4 +field hb_glyph_extents_t-x_bearing
	drop 4 4 +field hb_glyph_extents_t-y_bearing
drop 16 end-structure

\ ------===< callbacks >===-------
c-callback hb_buffer_message_func_t: a a s a -- n	( buffer font message user_data -- )
c-callback hb_destroy_func_t: a -- void	( user_data -- )
c-callback hb_reference_table_func_t: a u a -- a	( face tag user_data -- )
c-callback hb_font_get_font_extents_func_t: a a a a -- n	( font font_data extents user_data -- )
c-callback hb_font_get_nominal_glyph_func_t: a a u a a -- n	( font font_data unicode glyph user_data -- )
c-callback hb_font_get_variation_glyph_func_t: a a u u a a -- n	( font font_data unicode variation_selector glyph user_data -- )
c-callback hb_font_get_nominal_glyphs_func_t: a a u a u a u a -- u	( font font_data count first_unicode unicode_stride first_glyph glyph_stride user_data -- )
c-callback hb_font_get_glyph_advance_func_t: a a u a -- n	( font font_data glyph user_data -- )
c-callback hb_font_get_glyph_advances_func_t: a a u a u a u a -- void	( font font_data count first_glyph glyph_stride first_advance advance_stride user_data -- )
c-callback hb_font_get_glyph_origin_func_t: a a u a a a -- n	( font font_data glyph x y user_data -- )
c-callback hb_font_get_glyph_kerning_func_t: a a u u a -- n	( font font_data first_glyph second_glyph user_data -- )
c-callback hb_font_get_glyph_extents_func_t: a a u a a -- n	( font font_data glyph extents user_data -- )
c-callback hb_font_get_glyph_contour_point_func_t: a a u u a a a -- n	( font font_data glyph point_index x y user_data -- )
c-callback hb_font_get_glyph_name_func_t: a a u a u a -- n	( font font_data glyph name size user_data -- )
c-callback hb_font_get_glyph_from_name_func_t: a a a n a a -- n	( font font_data name len glyph user_data -- )
c-callback hb_unicode_combining_class_func_t: a u a -- n	( ufuncs unicode user_data -- )
c-callback hb_unicode_general_category_func_t: a u a -- n	( ufuncs unicode user_data -- )
c-callback hb_unicode_mirroring_func_t: a u a -- u	( ufuncs unicode user_data -- )
c-callback hb_unicode_script_func_t: a u a -- n	( ufuncs unicode user_data -- )
c-callback hb_unicode_compose_func_t: a u u a a -- n	( ufuncs a b ab user_data -- )
c-callback hb_unicode_decompose_func_t: a u a a a -- n	( ufuncs ab a b user_data -- )

\ ------===< functions >===-------
c-function hb_blob_create hb_blob_create s u n a a -- a	( data length mode user_data destroy -- )
c-function hb_blob_create_from_file hb_blob_create_from_file s -- a	( file_name -- )
c-function hb_blob_create_sub_blob hb_blob_create_sub_blob a u u -- a	( parent offset length -- )
c-function hb_blob_copy_writable_or_fail hb_blob_copy_writable_or_fail a -- a	( blob -- )
c-function hb_blob_get_empty hb_blob_get_empty  -- a	( -- )
c-function hb_blob_reference hb_blob_reference a -- a	( blob -- )
c-function hb_blob_destroy hb_blob_destroy a -- void	( blob -- )
c-function hb_blob_set_user_data hb_blob_set_user_data a a a a n -- n	( blob key data destroy replace -- )
c-function hb_blob_get_user_data hb_blob_get_user_data a a -- a	( blob key -- )
c-function hb_blob_make_immutable hb_blob_make_immutable a -- void	( blob -- )
c-function hb_blob_is_immutable hb_blob_is_immutable a -- n	( blob -- )
c-function hb_blob_get_length hb_blob_get_length a -- u	( blob -- )
c-function hb_blob_get_data hb_blob_get_data a a -- s	( blob length -- )
c-function hb_blob_get_data_writable hb_blob_get_data_writable a a -- a	( blob length -- )
c-function hb_glyph_info_get_glyph_flags hb_glyph_info_get_glyph_flags a -- n	( info -- )
c-function hb_segment_properties_equal hb_segment_properties_equal a a -- n	( a b -- )
c-function hb_segment_properties_hash hb_segment_properties_hash a -- u	( p -- )
c-function hb_buffer_create hb_buffer_create  -- a	( -- )
c-function hb_buffer_get_empty hb_buffer_get_empty  -- a	( -- )
c-function hb_buffer_reference hb_buffer_reference a -- a	( buffer -- )
c-function hb_buffer_destroy hb_buffer_destroy a -- void	( buffer -- )
c-function hb_buffer_set_user_data hb_buffer_set_user_data a a a a n -- n	( buffer key data destroy replace -- )
c-function hb_buffer_get_user_data hb_buffer_get_user_data a a -- a	( buffer key -- )
c-function hb_buffer_set_content_type hb_buffer_set_content_type a n -- void	( buffer content_type -- )
c-function hb_buffer_get_content_type hb_buffer_get_content_type a -- n	( buffer -- )
c-function hb_buffer_set_unicode_funcs hb_buffer_set_unicode_funcs a a -- void	( buffer unicode_funcs -- )
c-function hb_buffer_get_unicode_funcs hb_buffer_get_unicode_funcs a -- a	( buffer -- )
c-function hb_buffer_set_direction hb_buffer_set_direction a n -- void	( buffer direction -- )
c-function hb_buffer_get_direction hb_buffer_get_direction a -- n	( buffer -- )
c-function hb_buffer_set_script hb_buffer_set_script a n -- void	( buffer script -- )
c-function hb_buffer_get_script hb_buffer_get_script a -- n	( buffer -- )
c-function hb_buffer_set_language hb_buffer_set_language a a -- void	( buffer language -- )
c-function hb_buffer_get_language hb_buffer_get_language a -- a	( buffer -- )
c-function hb_buffer_set_segment_properties hb_buffer_set_segment_properties a a -- void	( buffer props -- )
c-function hb_buffer_get_segment_properties hb_buffer_get_segment_properties a a -- void	( buffer props -- )
c-function hb_buffer_guess_segment_properties hb_buffer_guess_segment_properties a -- void	( buffer -- )
c-function hb_buffer_set_flags hb_buffer_set_flags a n -- void	( buffer flags -- )
c-function hb_buffer_get_flags hb_buffer_get_flags a -- n	( buffer -- )
c-function hb_buffer_set_cluster_level hb_buffer_set_cluster_level a n -- void	( buffer cluster_level -- )
c-function hb_buffer_get_cluster_level hb_buffer_get_cluster_level a -- n	( buffer -- )
c-function hb_buffer_set_replacement_codepoint hb_buffer_set_replacement_codepoint a u -- void	( buffer replacement -- )
c-function hb_buffer_get_replacement_codepoint hb_buffer_get_replacement_codepoint a -- u	( buffer -- )
c-function hb_buffer_set_invisible_glyph hb_buffer_set_invisible_glyph a u -- void	( buffer invisible -- )
c-function hb_buffer_get_invisible_glyph hb_buffer_get_invisible_glyph a -- u	( buffer -- )
c-function hb_buffer_reset hb_buffer_reset a -- void	( buffer -- )
c-function hb_buffer_clear_contents hb_buffer_clear_contents a -- void	( buffer -- )
c-function hb_buffer_pre_allocate hb_buffer_pre_allocate a u -- n	( buffer size -- )
c-function hb_buffer_allocation_successful hb_buffer_allocation_successful a -- n	( buffer -- )
c-function hb_buffer_reverse hb_buffer_reverse a -- void	( buffer -- )
c-function hb_buffer_reverse_range hb_buffer_reverse_range a u u -- void	( buffer start end -- )
c-function hb_buffer_reverse_clusters hb_buffer_reverse_clusters a -- void	( buffer -- )
c-function hb_buffer_add hb_buffer_add a u u -- void	( buffer codepoint cluster -- )
c-function hb_buffer_add_utf8 hb_buffer_add_utf8 a a n u n -- void	( buffer text text_length item_offset item_length -- )
c-function hb_buffer_add_utf16 hb_buffer_add_utf16 a a n u n -- void	( buffer text text_length item_offset item_length -- )
c-function hb_buffer_add_utf32 hb_buffer_add_utf32 a a n u n -- void	( buffer text text_length item_offset item_length -- )
c-function hb_buffer_add_latin1 hb_buffer_add_latin1 a a n u n -- void	( buffer text text_length item_offset item_length -- )
c-function hb_buffer_add_codepoints hb_buffer_add_codepoints a a n u n -- void	( buffer text text_length item_offset item_length -- )
c-function hb_buffer_append hb_buffer_append a a u u -- void	( buffer source start end -- )
c-function hb_buffer_set_length hb_buffer_set_length a u -- n	( buffer length -- )
c-function hb_buffer_get_length hb_buffer_get_length a -- u	( buffer -- )
c-function hb_buffer_get_glyph_infos hb_buffer_get_glyph_infos a a -- a	( buffer length -- )
c-function hb_buffer_get_glyph_positions hb_buffer_get_glyph_positions a a -- a	( buffer length -- )
c-function hb_buffer_has_positions hb_buffer_has_positions a -- n	( buffer -- )
c-function hb_buffer_normalize_glyphs hb_buffer_normalize_glyphs a -- void	( buffer -- )
c-function hb_buffer_serialize_format_from_string hb_buffer_serialize_format_from_string a n -- n	( str len -- )
c-function hb_buffer_serialize_format_to_string hb_buffer_serialize_format_to_string n -- s	( format -- )
c-function hb_buffer_serialize_list_formats hb_buffer_serialize_list_formats  -- a	( -- )
c-function hb_buffer_serialize_glyphs hb_buffer_serialize_glyphs a u u a u a a n n -- u	( buffer start end buf buf_size buf_consumed font format flags -- )
c-function hb_buffer_serialize_unicode hb_buffer_serialize_unicode a u u a u a n n -- u	( buffer start end buf buf_size buf_consumed format flags -- )
c-function hb_buffer_serialize hb_buffer_serialize a u u a u a a n n -- u	( buffer start end buf buf_size buf_consumed font format flags -- )
c-function hb_buffer_deserialize_glyphs hb_buffer_deserialize_glyphs a a n a a n -- n	( buffer buf buf_len end_ptr font format -- )
c-function hb_buffer_deserialize_unicode hb_buffer_deserialize_unicode a a n a n -- n	( buffer buf buf_len end_ptr format -- )
c-function hb_buffer_diff hb_buffer_diff a a u u -- n	( buffer reference dottedcircle_glyph position_fuzz -- )
c-function hb_buffer_set_message_func hb_buffer_set_message_func a a a a -- void	( buffer func user_data destroy -- )
c-function hb_tag_from_string hb_tag_from_string a n -- u	( str len -- )
c-function hb_tag_to_string hb_tag_to_string u a -- void	( tag buf -- )
c-function hb_direction_from_string hb_direction_from_string a n -- n	( str len -- )
c-function hb_direction_to_string hb_direction_to_string n -- s	( direction -- )
c-function hb_language_from_string hb_language_from_string a n -- a	( str len -- )
c-function hb_language_to_string hb_language_to_string a -- s	( language -- )
c-function hb_language_get_default hb_language_get_default  -- a	( -- )
c-function hb_script_from_iso15924_tag hb_script_from_iso15924_tag u -- n	( tag -- )
c-function hb_script_from_string hb_script_from_string a n -- n	( str len -- )
c-function hb_script_to_iso15924_tag hb_script_to_iso15924_tag n -- u	( script -- )
c-function hb_script_get_horizontal_direction hb_script_get_horizontal_direction n -- n	( script -- )
c-function hb_feature_from_string hb_feature_from_string a n a -- n	( str len feature -- )
c-function hb_feature_to_string hb_feature_to_string a a u -- void	( feature buf size -- )
c-function hb_variation_from_string hb_variation_from_string a n a -- n	( str len variation -- )
c-function hb_variation_to_string hb_variation_to_string a a u -- void	( variation buf size -- )
c-function hb_color_get_alpha hb_color_get_alpha u -- u	( color -- )
c-function hb_color_get_red hb_color_get_red u -- u	( color -- )
c-function hb_color_get_green hb_color_get_green u -- u	( color -- )
c-function hb_color_get_blue hb_color_get_blue u -- u	( color -- )
c-function hb_face_count hb_face_count a -- u	( blob -- )
c-function hb_face_create hb_face_create a u -- a	( blob index -- )
c-function hb_face_create_for_tables hb_face_create_for_tables a a a -- a	( reference_table_func user_data destroy -- )
c-function hb_face_get_empty hb_face_get_empty  -- a	( -- )
c-function hb_face_reference hb_face_reference a -- a	( face -- )
c-function hb_face_destroy hb_face_destroy a -- void	( face -- )
c-function hb_face_set_user_data hb_face_set_user_data a a a a n -- n	( face key data destroy replace -- )
c-function hb_face_get_user_data hb_face_get_user_data a a -- a	( face key -- )
c-function hb_face_make_immutable hb_face_make_immutable a -- void	( face -- )
c-function hb_face_is_immutable hb_face_is_immutable a -- n	( face -- )
c-function hb_face_reference_table hb_face_reference_table a u -- a	( face tag -- )
c-function hb_face_reference_blob hb_face_reference_blob a -- a	( face -- )
c-function hb_face_set_index hb_face_set_index a u -- void	( face index -- )
c-function hb_face_get_index hb_face_get_index a -- u	( face -- )
c-function hb_face_set_upem hb_face_set_upem a u -- void	( face upem -- )
c-function hb_face_get_upem hb_face_get_upem a -- u	( face -- )
c-function hb_face_set_glyph_count hb_face_set_glyph_count a u -- void	( face glyph_count -- )
c-function hb_face_get_glyph_count hb_face_get_glyph_count a -- u	( face -- )
c-function hb_face_get_table_tags hb_face_get_table_tags a u a a -- u	( face start_offset table_count table_tags -- )
c-function hb_face_collect_unicodes hb_face_collect_unicodes a a -- void	( face out -- )
c-function hb_face_collect_variation_selectors hb_face_collect_variation_selectors a a -- void	( face out -- )
c-function hb_face_collect_variation_unicodes hb_face_collect_variation_unicodes a u a -- void	( face variation_selector out -- )
c-function hb_face_builder_create hb_face_builder_create  -- a	( -- )
c-function hb_face_builder_add_table hb_face_builder_add_table a u a -- n	( face tag blob -- )
c-function hb_font_funcs_create hb_font_funcs_create  -- a	( -- )
c-function hb_font_funcs_get_empty hb_font_funcs_get_empty  -- a	( -- )
c-function hb_font_funcs_reference hb_font_funcs_reference a -- a	( ffuncs -- )
c-function hb_font_funcs_destroy hb_font_funcs_destroy a -- void	( ffuncs -- )
c-function hb_font_funcs_set_user_data hb_font_funcs_set_user_data a a a a n -- n	( ffuncs key data destroy replace -- )
c-function hb_font_funcs_get_user_data hb_font_funcs_get_user_data a a -- a	( ffuncs key -- )
c-function hb_font_funcs_make_immutable hb_font_funcs_make_immutable a -- void	( ffuncs -- )
c-function hb_font_funcs_is_immutable hb_font_funcs_is_immutable a -- n	( ffuncs -- )
c-function hb_font_funcs_set_font_h_extents_func hb_font_funcs_set_font_h_extents_func a a a a -- void	( ffuncs func user_data destroy -- )
c-function hb_font_funcs_set_font_v_extents_func hb_font_funcs_set_font_v_extents_func a a a a -- void	( ffuncs func user_data destroy -- )
c-function hb_font_funcs_set_nominal_glyph_func hb_font_funcs_set_nominal_glyph_func a a a a -- void	( ffuncs func user_data destroy -- )
c-function hb_font_funcs_set_nominal_glyphs_func hb_font_funcs_set_nominal_glyphs_func a a a a -- void	( ffuncs func user_data destroy -- )
c-function hb_font_funcs_set_variation_glyph_func hb_font_funcs_set_variation_glyph_func a a a a -- void	( ffuncs func user_data destroy -- )
c-function hb_font_funcs_set_glyph_h_advance_func hb_font_funcs_set_glyph_h_advance_func a a a a -- void	( ffuncs func user_data destroy -- )
c-function hb_font_funcs_set_glyph_v_advance_func hb_font_funcs_set_glyph_v_advance_func a a a a -- void	( ffuncs func user_data destroy -- )
c-function hb_font_funcs_set_glyph_h_advances_func hb_font_funcs_set_glyph_h_advances_func a a a a -- void	( ffuncs func user_data destroy -- )
c-function hb_font_funcs_set_glyph_v_advances_func hb_font_funcs_set_glyph_v_advances_func a a a a -- void	( ffuncs func user_data destroy -- )
c-function hb_font_funcs_set_glyph_h_origin_func hb_font_funcs_set_glyph_h_origin_func a a a a -- void	( ffuncs func user_data destroy -- )
c-function hb_font_funcs_set_glyph_v_origin_func hb_font_funcs_set_glyph_v_origin_func a a a a -- void	( ffuncs func user_data destroy -- )
c-function hb_font_funcs_set_glyph_h_kerning_func hb_font_funcs_set_glyph_h_kerning_func a a a a -- void	( ffuncs func user_data destroy -- )
c-function hb_font_funcs_set_glyph_extents_func hb_font_funcs_set_glyph_extents_func a a a a -- void	( ffuncs func user_data destroy -- )
c-function hb_font_funcs_set_glyph_contour_point_func hb_font_funcs_set_glyph_contour_point_func a a a a -- void	( ffuncs func user_data destroy -- )
c-function hb_font_funcs_set_glyph_name_func hb_font_funcs_set_glyph_name_func a a a a -- void	( ffuncs func user_data destroy -- )
c-function hb_font_funcs_set_glyph_from_name_func hb_font_funcs_set_glyph_from_name_func a a a a -- void	( ffuncs func user_data destroy -- )
c-function hb_font_get_h_extents hb_font_get_h_extents a a -- n	( font extents -- )
c-function hb_font_get_v_extents hb_font_get_v_extents a a -- n	( font extents -- )
c-function hb_font_get_nominal_glyph hb_font_get_nominal_glyph a u a -- n	( font unicode glyph -- )
c-function hb_font_get_variation_glyph hb_font_get_variation_glyph a u u a -- n	( font unicode variation_selector glyph -- )
c-function hb_font_get_nominal_glyphs hb_font_get_nominal_glyphs a u a u a u -- u	( font count first_unicode unicode_stride first_glyph glyph_stride -- )
c-function hb_font_get_glyph_h_advance hb_font_get_glyph_h_advance a u -- n	( font glyph -- )
c-function hb_font_get_glyph_v_advance hb_font_get_glyph_v_advance a u -- n	( font glyph -- )
c-function hb_font_get_glyph_h_advances hb_font_get_glyph_h_advances a u a u a u -- void	( font count first_glyph glyph_stride first_advance advance_stride -- )
c-function hb_font_get_glyph_v_advances hb_font_get_glyph_v_advances a u a u a u -- void	( font count first_glyph glyph_stride first_advance advance_stride -- )
c-function hb_font_get_glyph_h_origin hb_font_get_glyph_h_origin a u a a -- n	( font glyph x y -- )
c-function hb_font_get_glyph_v_origin hb_font_get_glyph_v_origin a u a a -- n	( font glyph x y -- )
c-function hb_font_get_glyph_h_kerning hb_font_get_glyph_h_kerning a u u -- n	( font left_glyph right_glyph -- )
c-function hb_font_get_glyph_extents hb_font_get_glyph_extents a u a -- n	( font glyph extents -- )
c-function hb_font_get_glyph_contour_point hb_font_get_glyph_contour_point a u u a a -- n	( font glyph point_index x y -- )
c-function hb_font_get_glyph_name hb_font_get_glyph_name a u a u -- n	( font glyph name size -- )
c-function hb_font_get_glyph_from_name hb_font_get_glyph_from_name a a n a -- n	( font name len glyph -- )
c-function hb_font_get_glyph hb_font_get_glyph a u u a -- n	( font unicode variation_selector glyph -- )
c-function hb_font_get_extents_for_direction hb_font_get_extents_for_direction a n a -- void	( font direction extents -- )
c-function hb_font_get_glyph_advance_for_direction hb_font_get_glyph_advance_for_direction a u n a a -- void	( font glyph direction x y -- )
c-function hb_font_get_glyph_advances_for_direction hb_font_get_glyph_advances_for_direction a n u a u a u -- void	( font direction count first_glyph glyph_stride first_advance advance_stride -- )
c-function hb_font_get_glyph_origin_for_direction hb_font_get_glyph_origin_for_direction a u n a a -- void	( font glyph direction x y -- )
c-function hb_font_add_glyph_origin_for_direction hb_font_add_glyph_origin_for_direction a u n a a -- void	( font glyph direction x y -- )
c-function hb_font_subtract_glyph_origin_for_direction hb_font_subtract_glyph_origin_for_direction a u n a a -- void	( font glyph direction x y -- )
c-function hb_font_get_glyph_kerning_for_direction hb_font_get_glyph_kerning_for_direction a u u n a a -- void	( font first_glyph second_glyph direction x y -- )
c-function hb_font_get_glyph_extents_for_origin hb_font_get_glyph_extents_for_origin a u n a -- n	( font glyph direction extents -- )
c-function hb_font_get_glyph_contour_point_for_origin hb_font_get_glyph_contour_point_for_origin a u u n a a -- n	( font glyph point_index direction x y -- )
c-function hb_font_glyph_to_string hb_font_glyph_to_string a u a u -- void	( font glyph s size -- )
c-function hb_font_glyph_from_string hb_font_glyph_from_string a a n a -- n	( font s len glyph -- )
c-function hb_font_create hb_font_create a -- a	( face -- )
c-function hb_font_create_sub_font hb_font_create_sub_font a -- a	( parent -- )
c-function hb_font_get_empty hb_font_get_empty  -- a	( -- )
c-function hb_font_reference hb_font_reference a -- a	( font -- )
c-function hb_font_destroy hb_font_destroy a -- void	( font -- )
c-function hb_font_set_user_data hb_font_set_user_data a a a a n -- n	( font key data destroy replace -- )
c-function hb_font_get_user_data hb_font_get_user_data a a -- a	( font key -- )
c-function hb_font_make_immutable hb_font_make_immutable a -- void	( font -- )
c-function hb_font_is_immutable hb_font_is_immutable a -- n	( font -- )
c-function hb_font_set_parent hb_font_set_parent a a -- void	( font parent -- )
c-function hb_font_get_parent hb_font_get_parent a -- a	( font -- )
c-function hb_font_set_face hb_font_set_face a a -- void	( font face -- )
c-function hb_font_get_face hb_font_get_face a -- a	( font -- )
c-function hb_font_set_funcs hb_font_set_funcs a a a a -- void	( font klass font_data destroy -- )
c-function hb_font_set_funcs_data hb_font_set_funcs_data a a a -- void	( font font_data destroy -- )
c-function hb_font_set_scale hb_font_set_scale a n n -- void	( font x_scale y_scale -- )
c-function hb_font_get_scale hb_font_get_scale a a a -- void	( font x_scale y_scale -- )
c-function hb_font_set_ppem hb_font_set_ppem a u u -- void	( font x_ppem y_ppem -- )
c-function hb_font_get_ppem hb_font_get_ppem a a a -- void	( font x_ppem y_ppem -- )
c-function hb_font_set_ptem hb_font_set_ptem a r -- void	( font ptem -- )
c-function hb_font_get_ptem hb_font_get_ptem a -- r	( font -- )
c-function hb_font_set_var_coords_design hb_font_set_var_coords_design a a u -- void	( font coords coords_length -- )
c-function hb_font_set_var_coords_normalized hb_font_set_var_coords_normalized a a u -- void	( font coords coords_length -- )
c-function hb_font_get_var_coords_normalized hb_font_get_var_coords_normalized a a -- a	( font length -- )
c-function hb_font_set_var_named_instance hb_font_set_var_named_instance a u -- void	( font instance_index -- )
c-function hb_set_create hb_set_create  -- a	( -- )
c-function hb_set_get_empty hb_set_get_empty  -- a	( -- )
c-function hb_set_reference hb_set_reference a -- a	( set -- )
c-function hb_set_destroy hb_set_destroy a -- void	( set -- )
c-function hb_set_set_user_data hb_set_set_user_data a a a a n -- n	( set key data destroy replace -- )
c-function hb_set_get_user_data hb_set_get_user_data a a -- a	( set key -- )
c-function hb_set_allocation_successful hb_set_allocation_successful a -- n	( set -- )
c-function hb_set_clear hb_set_clear a -- void	( set -- )
c-function hb_set_is_empty hb_set_is_empty a -- n	( set -- )
c-function hb_set_has hb_set_has a u -- n	( set codepoint -- )
c-function hb_set_add hb_set_add a u -- void	( set codepoint -- )
c-function hb_set_add_range hb_set_add_range a u u -- void	( set first last -- )
c-function hb_set_del hb_set_del a u -- void	( set codepoint -- )
c-function hb_set_del_range hb_set_del_range a u u -- void	( set first last -- )
c-function hb_set_is_equal hb_set_is_equal a a -- n	( set other -- )
c-function hb_set_is_subset hb_set_is_subset a a -- n	( set larger_set -- )
c-function hb_set_set hb_set_set a a -- void	( set other -- )
c-function hb_set_union hb_set_union a a -- void	( set other -- )
c-function hb_set_intersect hb_set_intersect a a -- void	( set other -- )
c-function hb_set_subtract hb_set_subtract a a -- void	( set other -- )
c-function hb_set_symmetric_difference hb_set_symmetric_difference a a -- void	( set other -- )
c-function hb_set_get_population hb_set_get_population a -- u	( set -- )
c-function hb_set_get_min hb_set_get_min a -- u	( set -- )
c-function hb_set_get_max hb_set_get_max a -- u	( set -- )
c-function hb_set_next hb_set_next a a -- n	( set codepoint -- )
c-function hb_set_previous hb_set_previous a a -- n	( set codepoint -- )
c-function hb_set_next_range hb_set_next_range a a a -- n	( set first last -- )
c-function hb_set_previous_range hb_set_previous_range a a a -- n	( set first last -- )
c-function hb_shape hb_shape a a a u -- void	( font buffer features num_features -- )
c-function hb_shape_full hb_shape_full a a a u a -- n	( font buffer features num_features shaper_list -- )
c-function hb_shape_list_shapers hb_shape_list_shapers  -- a	( -- )
c-function hb_shape_plan_create hb_shape_plan_create a a a u a -- a	( face props user_features num_user_features shaper_list -- )
c-function hb_shape_plan_create_cached hb_shape_plan_create_cached a a a u a -- a	( face props user_features num_user_features shaper_list -- )
c-function hb_shape_plan_create2 hb_shape_plan_create2 a a a u a u a -- a	( face props user_features num_user_features coords num_coords shaper_list -- )
c-function hb_shape_plan_create_cached2 hb_shape_plan_create_cached2 a a a u a u a -- a	( face props user_features num_user_features coords num_coords shaper_list -- )
c-function hb_shape_plan_get_empty hb_shape_plan_get_empty  -- a	( -- )
c-function hb_shape_plan_reference hb_shape_plan_reference a -- a	( shape_plan -- )
c-function hb_shape_plan_destroy hb_shape_plan_destroy a -- void	( shape_plan -- )
c-function hb_shape_plan_set_user_data hb_shape_plan_set_user_data a a a a n -- n	( shape_plan key data destroy replace -- )
c-function hb_shape_plan_get_user_data hb_shape_plan_get_user_data a a -- a	( shape_plan key -- )
c-function hb_shape_plan_execute hb_shape_plan_execute a a a a u -- n	( shape_plan font buffer features num_features -- )
c-function hb_shape_plan_get_shaper hb_shape_plan_get_shaper a -- s	( shape_plan -- )
c-function hb_unicode_funcs_get_default hb_unicode_funcs_get_default  -- a	( -- )
c-function hb_unicode_funcs_create hb_unicode_funcs_create a -- a	( parent -- )
c-function hb_unicode_funcs_get_empty hb_unicode_funcs_get_empty  -- a	( -- )
c-function hb_unicode_funcs_reference hb_unicode_funcs_reference a -- a	( ufuncs -- )
c-function hb_unicode_funcs_destroy hb_unicode_funcs_destroy a -- void	( ufuncs -- )
c-function hb_unicode_funcs_set_user_data hb_unicode_funcs_set_user_data a a a a n -- n	( ufuncs key data destroy replace -- )
c-function hb_unicode_funcs_get_user_data hb_unicode_funcs_get_user_data a a -- a	( ufuncs key -- )
c-function hb_unicode_funcs_make_immutable hb_unicode_funcs_make_immutable a -- void	( ufuncs -- )
c-function hb_unicode_funcs_is_immutable hb_unicode_funcs_is_immutable a -- n	( ufuncs -- )
c-function hb_unicode_funcs_get_parent hb_unicode_funcs_get_parent a -- a	( ufuncs -- )
c-function hb_unicode_funcs_set_combining_class_func hb_unicode_funcs_set_combining_class_func a a a a -- void	( ufuncs func user_data destroy -- )
c-function hb_unicode_funcs_set_general_category_func hb_unicode_funcs_set_general_category_func a a a a -- void	( ufuncs func user_data destroy -- )
c-function hb_unicode_funcs_set_mirroring_func hb_unicode_funcs_set_mirroring_func a a a a -- void	( ufuncs func user_data destroy -- )
c-function hb_unicode_funcs_set_script_func hb_unicode_funcs_set_script_func a a a a -- void	( ufuncs func user_data destroy -- )
c-function hb_unicode_funcs_set_compose_func hb_unicode_funcs_set_compose_func a a a a -- void	( ufuncs func user_data destroy -- )
c-function hb_unicode_funcs_set_decompose_func hb_unicode_funcs_set_decompose_func a a a a -- void	( ufuncs func user_data destroy -- )
c-function hb_unicode_combining_class hb_unicode_combining_class a u -- n	( ufuncs unicode -- )
c-function hb_unicode_general_category hb_unicode_general_category a u -- n	( ufuncs unicode -- )
c-function hb_unicode_mirroring hb_unicode_mirroring a u -- u	( ufuncs unicode -- )
c-function hb_unicode_script hb_unicode_script a u -- n	( ufuncs unicode -- )
c-function hb_unicode_compose hb_unicode_compose a u u a -- n	( ufuncs a b ab -- )
c-function hb_unicode_decompose hb_unicode_decompose a u a a -- n	( ufuncs ab a b -- )
c-function hb_version hb_version a a a -- void	( major minor micro -- )
c-function hb_version_string hb_version_string  -- s	( -- )
c-function hb_version_atleast hb_version_atleast u u u -- n	( major minor micro -- )
c-function hb_ft_face_create hb_ft_face_create a a -- a	( ft_face destroy -- )
c-function hb_ft_face_create_cached hb_ft_face_create_cached a -- a	( ft_face -- )
c-function hb_ft_face_create_referenced hb_ft_face_create_referenced a -- a	( ft_face -- )
c-function hb_ft_font_create hb_ft_font_create a a -- a	( ft_face destroy -- )
c-function hb_ft_font_create_referenced hb_ft_font_create_referenced a -- a	( ft_face -- )
c-function hb_ft_font_get_face hb_ft_font_get_face a -- a	( font -- )
c-function hb_ft_font_lock_face hb_ft_font_lock_face a -- a	( font -- )
c-function hb_ft_font_unlock_face hb_ft_font_unlock_face a -- void	( font -- )
c-function hb_ft_font_set_load_flags hb_ft_font_set_load_flags a n -- void	( font load_flags -- )
c-function hb_ft_font_get_load_flags hb_ft_font_get_load_flags a -- n	( font -- )
c-function hb_ft_font_changed hb_ft_font_changed a -- void	( font -- )
c-function hb_ft_font_set_funcs hb_ft_font_set_funcs a -- void	( font -- )

\ ----===< postfix >===-----
end-c-library
previous set-current
