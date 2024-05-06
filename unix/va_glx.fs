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

c-library va_glx
s" va-glx" add-lib
\c #include <va/va_glx.h>

\ ------===< functions >===-------
c-function vaGetDisplayGLX vaGetDisplayGLX a -- a	( dpy -- )
c-function vaCreateSurfaceGLX vaCreateSurfaceGLX a n n a -- n	( dpy target texture gl_surface -- )
c-function vaDestroySurfaceGLX vaDestroySurfaceGLX a a -- n	( dpy gl_surface -- )
c-function vaCopySurfaceGLX vaCopySurfaceGLX a a n u -- n	( dpy gl_surface surface flags -- )

\ ----===< postfix >===-----
end-c-library
previous set-current
