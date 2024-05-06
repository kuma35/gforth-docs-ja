\ This file has been generated using SWIG and fsi,
\ and is already platform dependent, search for the corresponding
\ fsi-file to compile it where no one has compiled it before ;)
\ Forth systems have their own own dynamic loader and don't need addional C-Code.
\ That's why this file will just print normal forth-code once compiled
\ and can be used directly with include or require.
\ As all comments are stripped during the compilation, please
\ insert the copyright notice of the original file here.

\ ----===< prefix >===-----
cs-vocabulary freetype-gl

get-current also freetype-gl definitions

c-library freetype_gl
s" freetype-gl" open-fpath-file 0= [IF] rot close-file throw add-incdir [THEN]
e? os-type s" linux-android" string-prefix? [IF] s" typeset -lm -lz " [ELSE] s" freetype -lm -lz " [THEN] add-lib
\c #define IMPLEMENT_FREETYPE_GL
\c #include "freetype-gl/freetype-gl.h"
\c #ifdef __gnu_linux__
\c #undef stderr
\c extern struct _IO_FILE *stderr;
\c #endif

\ ----===< int constants >===-----
#224	constant FTGL_ERR_BASE
#255	constant FTGL_ERR_MAX

\ --------===< enums >===---------
#0	constant RENDER_NORMAL
#1	constant RENDER_OUTLINE_EDGE
#2	constant RENDER_OUTLINE_POSITIVE
#3	constant RENDER_OUTLINE_NEGATIVE
#4	constant RENDER_SIGNED_DISTANCE_FIELD
#0	constant GLYPH_END
#1	constant GLYPH_CONT
#0	constant TEXTURE_FONT_FILE
#1	constant TEXTURE_FONT_MEMORY
#0	constant MODE_AUTO_CLOSE
#1	constant MODE_GLYPHS_CLOSE
#2	constant MODE_FREE_CLOSE
#3	constant MODE_MANUAL_CLOSE
#4	constant MODE_ALWAYS_OPEN

\ -------===< structs >===--------
\ ivec4
begin-structure ivec4
	drop 12 4 +field ivec4-w
	drop 4 4 +field ivec4-g
	drop 0 4 +field ivec4-x
	drop 4 4 +field ivec4-y
	drop 12 4 +field ivec4-height
	drop 8 4 +field ivec4-z
	drop 12 4 +field ivec4-icount
	drop 0 4 +field ivec4-vstart
	drop 12 4 +field ivec4-alpha
	drop 4 4 +field ivec4-y_
	drop 0 4 +field ivec4-x_
	drop 8 4 +field ivec4-blue
	drop 8 4 +field ivec4-width
	drop 4 4 +field ivec4-green
	drop 12 4 +field ivec4-a
	drop 0 4 +field ivec4-r
	drop 4 4 +field ivec4-vcount
	drop 8 4 +field ivec4-istart
	drop 8 4 +field ivec4-b
	drop 0 4 +field ivec4-red
	drop 0 16 +field ivec4-data
drop 16 end-structure
\ ivec3
begin-structure ivec3
	drop 8 4 +field ivec3-b
	drop 0 12 +field ivec3-data
	drop 0 4 +field ivec3-x
	drop 8 4 +field ivec3-blue
	drop 4 4 +field ivec3-y
	drop 0 4 +field ivec3-r
	drop 8 4 +field ivec3-z
	drop 4 4 +field ivec3-green
	drop 0 4 +field ivec3-red
	drop 4 4 +field ivec3-g
drop 12 end-structure
\ ivec2
begin-structure ivec2
	drop 4 4 +field ivec2-end
	drop 0 8 +field ivec2-data
	drop 0 4 +field ivec2-x
	drop 4 4 +field ivec2-y
	drop 0 4 +field ivec2-s
	drop 4 4 +field ivec2-t
	drop 0 4 +field ivec2-start
drop 8 end-structure
\ vec4
begin-structure vec4
	drop 12 4 +field vec4-w
	drop 4 4 +field vec4-g
	drop 0 4 +field vec4-x
	drop 4 4 +field vec4-y
	drop 12 4 +field vec4-height
	drop 8 4 +field vec4-z
	drop 12 4 +field vec4-alpha
	drop 8 4 +field vec4-blue
	drop 8 4 +field vec4-width
	drop 4 4 +field vec4-green
	drop 12 4 +field vec4-a
	drop 0 4 +field vec4-r
	drop 0 4 +field vec4-left
	drop 8 4 +field vec4-b
	drop 0 4 +field vec4-red
	drop 4 4 +field vec4-top
	drop 0 16 +field vec4-data
drop 16 end-structure
\ vec3
begin-structure vec3
	drop 8 4 +field vec3-b
	drop 0 12 +field vec3-data
	drop 0 4 +field vec3-x
	drop 8 4 +field vec3-blue
	drop 4 4 +field vec3-y
	drop 0 4 +field vec3-r
	drop 8 4 +field vec3-z
	drop 4 4 +field vec3-green
	drop 0 4 +field vec3-red
	drop 4 4 +field vec3-g
drop 12 end-structure
\ vec2
begin-structure vec2
	drop 0 8 +field vec2-data
	drop 0 4 +field vec2-x
	drop 4 4 +field vec2-y
	drop 0 4 +field vec2-s
	drop 4 4 +field vec2-t
drop 8 end-structure
\ vector_t
begin-structure vector_t
	drop 0 8 +field vector_t-items
	drop 16 8 +field vector_t-size
	drop 24 8 +field vector_t-item_size
	drop 8 8 +field vector_t-capacity
drop 32 end-structure
\ texture_atlas_t
begin-structure texture_atlas_t
	drop 48 8 +field texture_atlas_t-data
	drop 40 4 +field texture_atlas_t-id
	drop 64 8 +field texture_atlas_t-special
	drop 0 8 +field texture_atlas_t-nodes
	drop 16 8 +field texture_atlas_t-height
	drop 32 8 +field texture_atlas_t-used
	drop 8 8 +field texture_atlas_t-width
	drop 24 8 +field texture_atlas_t-depth
	drop 56 1 +field texture_atlas_t-modified
drop 72 end-structure
\ texture_glyph_t
begin-structure texture_glyph_t
	drop 0 4 +field texture_glyph_t-codepoint
	drop 16 8 +field texture_glyph_t-height
	drop 44 4 +field texture_glyph_t-t0
	drop 52 4 +field texture_glyph_t-t1
	drop 68 4 +field texture_glyph_t-outline_thickness
	drop 40 4 +field texture_glyph_t-s0
	drop 48 4 +field texture_glyph_t-s1
	drop 24 4 +field texture_glyph_t-offset_x
	drop 28 4 +field texture_glyph_t-offset_y
	drop 32 4 +field texture_glyph_t-advance_x
	drop 36 4 +field texture_glyph_t-advance_y
	drop 8 8 +field texture_glyph_t-width
	drop 64 4 +field texture_glyph_t-rendermode
	drop 72 4 +field texture_glyph_t-glyphmode
	drop 56 8 +field texture_glyph_t-kerning
drop 80 end-structure
\ texture_font_library_t
begin-structure texture_font_library_t
	drop 8 8 +field texture_font_library_t-library
	drop 0 4 +field texture_font_library_t-mode
drop 16 end-structure
\ texture_font_t
begin-structure texture_font_t
	drop 80 4 +field texture_font_t-ascender
	drop 84 4 +field texture_font_t-descender
	drop 100 4 +field texture_font_t-mode
	drop 104 8 +field texture_font_t-face
	drop 48 4 +field texture_font_t-size
	drop 16 4 +field texture_font_t-location
	drop 0 8 +field texture_font_t-glyphs
	drop 72 4 +field texture_font_t-height
	drop 76 4 +field texture_font_t-linegap
	drop 56 4 +field texture_font_t-outline_thickness
	drop 92 4 +field texture_font_t-underline_thickness
	drop 60 1 +field texture_font_t-filtering
	drop 120 8 +field texture_font_t-hb_font
	drop 8 8 +field texture_font_t-atlas
	drop 64 5 +field texture_font_t-lcd_weights
	drop 62 1 +field texture_font_t-hinting
	drop 88 4 +field texture_font_t-underline_position
	drop 52 4 +field texture_font_t-rendermode
	drop 24 8 +field texture_font_t-filename
	drop 63 1 +field texture_font_t-scaletex
	drop 112 8 +field texture_font_t-ft_size
	drop 128 4 +field texture_font_t-scale
	drop 96 4 +field texture_font_t-padding
	drop 24 16 +field texture_font_t-memory
	drop 61 1 +field texture_font_t-kerning
	drop 40 8 +field texture_font_t-library
drop 136 end-structure

\ ------===< callbacks >===-------
c-callback error_callback_t: s ... -- void	( fmt <noname> -- )

\ ------===< functions >===-------
c-function vector_new vector_new n -- a	( item_size -- )
c-function vector_delete vector_delete a -- void	( self -- )
c-function vector_get vector_get a n -- a	( self index -- )
c-function vector_front vector_front a -- a	( self -- )
c-function vector_back vector_back a -- a	( self -- )
c-function vector_contains vector_contains a a a -- n	( self item cmp -- )
c-function vector_empty vector_empty a -- n	( self -- )
c-function vector_size vector_size a -- n	( self -- )
c-function vector_reserve vector_reserve a n -- void	( self size -- )
c-function vector_capacity vector_capacity a -- n	( self -- )
c-function vector_shrink vector_shrink a -- void	( self -- )
c-function vector_clear vector_clear a -- void	( self -- )
c-function vector_set vector_set a n a -- void	( self index item -- )
c-function vector_erase vector_erase a n -- void	( self index -- )
c-function vector_erase_range vector_erase_range a n n -- void	( self first last -- )
c-function vector_push_back vector_push_back a a -- void	( self item -- )
c-function vector_pop_back vector_pop_back a -- void	( self -- )
c-function vector_resize vector_resize a n -- void	( self size -- )
c-function vector_insert vector_insert a n a -- void	( self index item -- )
c-function vector_insert_data vector_insert_data a n a n -- void	( self index data count -- )
c-function vector_push_back_data vector_push_back_data a a n -- void	( self data count -- )
c-function vector_sort vector_sort a a -- void	( self cmp -- )
c-function texture_atlas_new texture_atlas_new n n n -- a	( width height depth -- )
c-function texture_atlas_delete texture_atlas_delete a -- void	( self -- )
c-function texture_atlas_get_region texture_atlas_get_region a n n -- t{*(ivec4*)}	( self width height -- )
c-function texture_atlas_set_region texture_atlas_set_region a n n n n a n -- void	( self x y width height data stride -- )
c-function texture_atlas_clear texture_atlas_clear a -- void	( self -- )
c-function texture_atlas_enlarge_texture texture_atlas_enlarge_texture a n n -- void	( self width_new height_new -- )
c-function texture_font_default_mode texture_font_default_mode n -- void	( mode -- )
c-function texture_library_new texture_library_new  -- a	( -- )
c-function texture_font_new_from_file texture_font_new_from_file a r s -- a	( atlas pt_size filename -- )
c-function texture_font_new_from_memory texture_font_new_from_memory a r a n -- a	( atlas pt_size memory_base memory_size -- )
c-function texture_font_clone texture_font_clone a r -- a	( self size -- )
c-function texture_font_activate_size texture_font_activate_size a -- n	( self -- )
c-function texture_font_close texture_font_close a n n -- void	( self face_mode library_mode -- )
c-function texture_font_delete texture_font_delete a -- void	( self -- )
c-function texture_font_load_face texture_font_load_face a r -- n	( self size -- )
c-function texture_font_is_variable texture_font_is_variable a -- n	( self -- )
c-function texture_font_get_weight texture_font_get_weight a a a a -- n	( self def min max -- )
c-function texture_font_set_weight texture_font_set_weight a n -- n	( self wght -- )
c-function texture_font_get_glyph texture_font_get_glyph a a -- a	( self codepoint -- )
c-function texture_font_find_glyph texture_font_find_glyph a s -- a	( self codepoint -- )
c-function texture_font_index_glyph texture_font_index_glyph a a u -- n	( self glyph codepoint -- )
c-function texture_font_load_glyph texture_font_load_glyph a s -- n	( self codepoint -- )
c-function texture_font_get_glyph_gi texture_font_get_glyph_gi a u -- a	( self glyph_index -- )
c-function texture_font_find_glyph_gi texture_font_find_glyph_gi a u -- a	( self glyph_index -- )
c-function texture_font_load_glyph_gi texture_font_load_glyph_gi a u u -- n	( self glyph_index ucodepoint -- )
c-function texture_font_load_glyphs texture_font_load_glyphs a s -- n	( self codepoints -- )
c-function texture_font_enlarge_atlas texture_font_enlarge_atlas a n n -- void	( self width_new height_new -- )
c-function texture_font_enlarge_glyphs texture_font_enlarge_glyphs a r r -- void	( self mulw mulh -- )
c-function texture_font_enlarge_texture texture_font_enlarge_texture a n n -- void	( self width_new height_new -- )
c-function texture_glyph_get_kerning texture_glyph_get_kerning a a -- r	( self codepoint -- )
c-function texture_glyph_new texture_glyph_new  -- a	( -- )
c-function texture_glyph_delete texture_glyph_delete a -- void	( self -- )
c-function texture_glyph_clone texture_glyph_clone a -- a	( self -- )
c-function error_callback_default error_callback_default s ... -- void	( fmt <noname> -- )
c-function set_error_callback set_error_callback a -- void	( error_cb -- )
c-function FTGL_Error_String FTGL_Error_String u -- s	( error_code -- )
c-value freetype_gl_errno freetype_gl_errno -- n
c-variable freetype_gl_warnings freetype_gl_warnings ( -- addr )

\ ----===< postfix >===-----
end-c-library
previous set-current
