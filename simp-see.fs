\ simple-minded see (good for seeing what the compiler produces)

\ Authors: Anton Ertl, Bernd Paysan
\ Copyright (C) 2001,2003,2007,2014,2017,2019,2021,2022 Free Software Foundation, Inc.

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

require see.fs

get-current also see-voc definitions

: xt-range ( xt -- addr1 addr2 )
    \ get the range of threaded-code addresses for (possibly deferred)
    \ colon def xt
    begin
	dup >definer dodefer: = while
	    cr ." defer " dup >name id.
	    defer@ repeat
    dup >definer docol: = if
	>body dup next-head
    else
	cr ." not a colon definition" dup \ ensure 0 iterations
    then ;

: see-word.addr ( addr -- )
    xpos off hex. ;

: simple-see-word { addr -- }
    addr see-word.addr addr cell+ addr @ .word drop ;

set-current

: simple-see-range ( addr1 addr2 -- ) \ gforth
    \G Decompile code in [@i{addr1},@i{addr2}) like @code{simple-see}
    swap u+do
	cr i simple-see-word
    cell +loop ;

: xt-simple-see ( xt -- ) \ gforth
    \G Decompile the colon definition @i{xt} like
    \G @code{simple-see}
    xt-range simple-see-range ;

: simple-see ( "name" -- ) \ gforth
    \G Decompile the colon definition @i{name}, showing a line for
    \G each cell, and try to guess a meaning for the cell, and show
    \G that.
    ' xt-simple-see ;

: see-code-range { addr1 addr2 -- } \ gforth
    \G Decompile code in [@i{addr1},@i{addr2}) like @code{see-code}.
    0 addr1 0 0 ['] noop begin { nseqlen  addr d: codeblock xt: cr? }
        addr addr2 u< while
            addr @ decompile-prim2 { ulen } ulen 0< if
                drop 2drop 2drop
                cr? addr simple-see-word
                nseqlen
            else
                nseqlen 0= if
                    codeblock discode 0 0 to codeblock ['] noop to cr? then
                cr? addr see-word.addr type { nseqlen1 ustart uend } ulen if
                    ustart 4 spaces 0 .r ." ->" uend .
                    assert( codeblock nip 0= )
                    addr @ ulen to codeblock then
                nseqlen nseqlen1 max 1-
            then
            ( nseqlen2 ) addr cell+ codeblock ['] cr
    repeat
    codeblock discode ;

: xt-see-code ( xt -- ) \ gforth
    \G Decompile the colon definition @i{xt} like @code{see-code}.
    xt-range see-code-range ;

: see-code ( "name" -- ) \ gforth
\G Like @code{simple-see}, but also shows the dynamic native code for
\G the inlined primitives.  For static superinstructions, it shows the
\G primitive sequence instead of the first primitive (the other
\G primitives of the superinstruction are shown, too).  For primitives
\G for which native code is generated, it shows the number of stack
\G items in registers at the beginning and at the end (e.g.,
\G @code{1->1} means 1 stack item is in a register at the start and at
\G the end).  For each primitive or superinstruction with native code,
\G the inline arguments and component primitives are shown first, then
\G the native code.
    ' xt-see-code ;
    
previous
