\ This file has been generated using SWIG and fsi,
\ and is already platform dependent, search for the corresponding
\ fsi-file to compile it where no one has compiled it before ;)
\ Forth systems have their own own dynamic loader and don't need addional C-Code.
\ That's why this file will just print normal forth-code once compiled
\ and can be used directly with include or require.
\ As all comments are stripped during the compilation, please
\ insert the copyright notice of the original file here.

\ ----===< prefix >===-----
get-current also [IFDEF] va va [THEN] definitions

c-library va_x11
s" va-x11" add-lib
\c #include <va/va_x11.h>

\ ------===< functions >===-------
c-function vaGetDisplay vaGetDisplay a -- a	( dpy -- )
c-function vaPutSurface vaPutSurface a n n n n u u n n u u a u u -- n	( dpy surface draw srcx srcy srcw srch destx desty destw desth cliprects number_cliprects flags -- )

\ ----===< postfix >===-----
end-c-library
previous set-current
