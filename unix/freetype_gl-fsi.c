/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.9
 *
 * This file is not intended to be easily readable and contains a number of
 * coding conventions designed to improve portability and efficiency. Do not make
 * changes to this file unless you know what you are doing--modify the SWIG
 * interface file instead.
 * ----------------------------------------------------------------------------- */
#include <stdio.h>
#include <string.h>
#include <stddef.h>

// Do not edit below this line
// end-of-default-includes


#include <freetype-gl.h>
#ifdef __gnu_linux__
#undef stderr
extern struct _IO_FILE *stderr;
#endif

typedef enum{ NONE = -1, GFORTH = 0, SWIFTFORTH, VFX } SwigTargetSystem;
SwigTargetSystem swigTargetSystem = NONE;

unsigned char swigPrintStackComments = 1;

/* comments */
void swigNewline()
{
	printf( "\n" );
}

void swigComment( char *comment )
{
	printf( "\\ %s", comment );
}

/* generic print */
void swigPrint( char* gforth, char *swiftForth, char *vfx )
{
	if( swigTargetSystem == GFORTH )
		printf( "%s", gforth );
	else if( swigTargetSystem == SWIFTFORTH )
		printf( "%s", swiftForth );
	else if( swigTargetSystem == VFX )
		printf( "%s", vfx );
	printf( "\n" );
}
void swigPrintSystem( SwigTargetSystem targetSystem, char *text )
{
	if( targetSystem == swigTargetSystem )
	    printf( "%s\n", text );
}

/* constants */
void swigIntConstant( long constant, char *name )
{
	printf( "#%ld\tconstant %s\n", constant, name );
}

void swigUnsignedIntConstant( unsigned long constant, char *name )
{
	printf( "#%lu\tconstant %s\n", constant, name );
}

void swigLongConstant( long long constant, char *name )
{
	printf( "#%lld.\t2constant %s\n", constant, name );
}

void swigUnsignedLongConstant( unsigned long long constant, char *name )
{
	printf( "#%llu.\t2constant %s\n", constant, name );
}

void swigFloatConstant( double constant, char *name )
{
	char buffer[128];
	sprintf( buffer, "%f", constant );

	/* if the constant contains no exponent, add one */
	char *s;
	for( s = buffer; *s != 0; s++ )
		if( *s == 'e' || *s == 'E' )
			break;

	/* exponent found */
	if( *s != 0 )
		printf( "%s\tfconstant %s\n", buffer, name );
	/* not found */
	else
		printf( "%se0\tfconstant %s\n", buffer, name );
}

void swigStringConstant( char* constant, char *name )
{
	char c;
	printf( ": %s s\\\" ", name );
	while(( c = *constant++ ))
	{
		switch(c)
		{
			case '\b': printf( "\\b" ); break;
			case '\n': printf( "\\n" ); break;
			case '\f': printf( "\\f" ); break;
			case '\r': printf( "\\r" ); break;
			case '\t': printf( "\\t" ); break;
			case '"' : printf( "\\q" ); break;
			default:
				if(c < 0x20)
					printf("\\x%02x", c);
				else
					printf("%c", c); break;
		}
	}
	printf(	"\" ;\n" );
}

/* structs */
void swigStructField( char *name, size_t offset, size_t size )
{
	printf( "\tdrop %zu %zu +field %s\n", offset, size, name );
}

/* functions */
void swigFunction( char* gforth, char *swiftForth, char *vfx, char *stackComment )
{
	if( swigTargetSystem == GFORTH )
		printf( "%s", gforth );
	else if( swigTargetSystem == SWIFTFORTH )
		printf( "%s", swiftForth );
	else if( swigTargetSystem == VFX )
		printf( "%s", vfx );

	if( swigPrintStackComments )
		printf( "%s", stackComment );

	printf( "\n" );
}

/* function pointers */
void swigFunctionPointer( char* gforth, char *swiftForth, char *vfx, char *stackComment )
{
	swigFunction( gforth, swiftForth, vfx, stackComment );
}

/* callbacks */
void swigCallback( char* gforth, char *swiftForth, char *vfx, char *stackComment )
{
	swigFunction( gforth, swiftForth, vfx, stackComment );
}

void swigUsage( char **argv )
{
	fprintf( stderr, "Usage: %s [-gforth|-swiftforth|-vfx]\n", argv[0] );
}

int main( int argc, char **argv )
{
	int i;

	/* check arguments */
	for( i = 1; i < argc; i++ )
		if( strcmp( argv[i], "-gforth" ) == 0 )
			swigTargetSystem = GFORTH;
		else if( strcmp( argv[i], "-swiftforth" ) == 0 )
			swigTargetSystem = SWIFTFORTH;
		else if( strcmp( argv[i], "-vfx" ) == 0 )
			swigTargetSystem = VFX;

	if( swigTargetSystem == NONE )
	{
		fprintf( stderr, "Error: no target system specified\n" );
		swigUsage( argv );
		return 1;
	}

	/* primer */
	printf( "\\ This file has been generated using SWIG and fsi,\n"
		"\\ and is already platform dependent, search for the corresponding\n"
		"\\ fsi-file to compile it where no one has compiled it before ;)\n"
		"\\ Forth systems have their own own dynamic loader and don't need addional C-Code.\n"
		"\\ That's why this file will just print normal forth-code once compiled\n"
		"\\ and can be used directly with include or require.\n"
		"\\ As all comments are stripped during the compilation, please\n"
		"\\ insert the copyright notice of the original file here.\n"
	);


typedef struct {
  const void *base;
  size_t size;
} _memory;


	swigNewline();

	swigComment("----===< prefix >===-----\n");

	swigPrint( "c-library freetype_gl\ns\" freetype-gl\" add-lib\n\\c #include <freetype-gl.h>\n\\c #ifdef __gnu_linux__\n\\c #undef stderr\n\\c extern struct _IO_FILE *stderr;\n\\c #endif", "( none )", "( none )" );

	swigNewline();

	swigComment("----===< int constants >===-----\n");
	#ifdef FTGL_ERR_BASE
		swigIntConstant( FTGL_ERR_BASE, "FTGL_ERR_BASE" );
	#endif
	#ifdef FTGL_ERR_MAX
		swigIntConstant( FTGL_ERR_MAX, "FTGL_ERR_MAX" );
	#endif

	swigNewline();

	swigComment("--------===< enums >===---------\n");
	swigIntConstant( RENDER_NORMAL, "RENDER_NORMAL" );
	swigIntConstant( RENDER_OUTLINE_EDGE, "RENDER_OUTLINE_EDGE" );
	swigIntConstant( RENDER_OUTLINE_POSITIVE, "RENDER_OUTLINE_POSITIVE" );
	swigIntConstant( RENDER_OUTLINE_NEGATIVE, "RENDER_OUTLINE_NEGATIVE" );
	swigIntConstant( RENDER_SIGNED_DISTANCE_FIELD, "RENDER_SIGNED_DISTANCE_FIELD" );
	swigIntConstant( GLYPH_END, "GLYPH_END" );
	swigIntConstant( GLYPH_CONT, "GLYPH_CONT" );
	swigIntConstant( TEXTURE_FONT_FILE, "TEXTURE_FONT_FILE" );
	swigIntConstant( TEXTURE_FONT_MEMORY, "TEXTURE_FONT_MEMORY" );
	swigIntConstant( MODE_AUTO_CLOSE, "MODE_AUTO_CLOSE" );
	swigIntConstant( MODE_GLYPHS_CLOSE, "MODE_GLYPHS_CLOSE" );
	swigIntConstant( MODE_FREE_CLOSE, "MODE_FREE_CLOSE" );
	swigIntConstant( MODE_MANUAL_CLOSE, "MODE_MANUAL_CLOSE" );
	swigIntConstant( MODE_ALWAYS_OPEN, "MODE_ALWAYS_OPEN" );

	swigNewline();

	swigComment("-------===< structs >===--------\n");

	swigComment("ivec4\n");
	printf( "begin-structure ivec4\n" );
	swigStructField( "ivec4-w", offsetof( ivec4, w ), sizeof( int ) );
	swigStructField( "ivec4-g", offsetof( ivec4, g ), sizeof( int ) );
	swigStructField( "ivec4-x", offsetof( ivec4, x ), sizeof( int ) );
	swigStructField( "ivec4-y", offsetof( ivec4, y ), sizeof( int ) );
	swigStructField( "ivec4-height", offsetof( ivec4, height ), sizeof( int ) );
	swigStructField( "ivec4-z", offsetof( ivec4, z ), sizeof( int ) );
	swigStructField( "ivec4-icount", offsetof( ivec4, icount ), sizeof( int ) );
	swigStructField( "ivec4-vstart", offsetof( ivec4, vstart ), sizeof( int ) );
	swigStructField( "ivec4-alpha", offsetof( ivec4, alpha ), sizeof( int ) );
	swigStructField( "ivec4-y_", offsetof( ivec4, y_ ), sizeof( int ) );
	swigStructField( "ivec4-x_", offsetof( ivec4, x_ ), sizeof( int ) );
	swigStructField( "ivec4-blue", offsetof( ivec4, blue ), sizeof( int ) );
	swigStructField( "ivec4-width", offsetof( ivec4, width ), sizeof( int ) );
	swigStructField( "ivec4-green", offsetof( ivec4, green ), sizeof( int ) );
	swigStructField( "ivec4-a", offsetof( ivec4, a ), sizeof( int ) );
	swigStructField( "ivec4-r", offsetof( ivec4, r ), sizeof( int ) );
	swigStructField( "ivec4-vcount", offsetof( ivec4, vcount ), sizeof( int ) );
	swigStructField( "ivec4-istart", offsetof( ivec4, istart ), sizeof( int ) );
	swigStructField( "ivec4-b", offsetof( ivec4, b ), sizeof( int ) );
	swigStructField( "ivec4-red", offsetof( ivec4, red ), sizeof( int ) );
	swigStructField( "ivec4-data", offsetof( ivec4, data ), sizeof( int [4] ) );
	printf( "drop %zu end-structure\n", sizeof( ivec4 ) );

	swigComment("ivec3\n");
	printf( "begin-structure ivec3\n" );
	swigStructField( "ivec3-b", offsetof( ivec3, b ), sizeof( int ) );
	swigStructField( "ivec3-data", offsetof( ivec3, data ), sizeof( int [3] ) );
	swigStructField( "ivec3-x", offsetof( ivec3, x ), sizeof( int ) );
	swigStructField( "ivec3-blue", offsetof( ivec3, blue ), sizeof( int ) );
	swigStructField( "ivec3-y", offsetof( ivec3, y ), sizeof( int ) );
	swigStructField( "ivec3-r", offsetof( ivec3, r ), sizeof( int ) );
	swigStructField( "ivec3-z", offsetof( ivec3, z ), sizeof( int ) );
	swigStructField( "ivec3-green", offsetof( ivec3, green ), sizeof( int ) );
	swigStructField( "ivec3-red", offsetof( ivec3, red ), sizeof( int ) );
	swigStructField( "ivec3-g", offsetof( ivec3, g ), sizeof( int ) );
	printf( "drop %zu end-structure\n", sizeof( ivec3 ) );

	swigComment("ivec2\n");
	printf( "begin-structure ivec2\n" );
	swigStructField( "ivec2-end", offsetof( ivec2, end ), sizeof( int ) );
	swigStructField( "ivec2-data", offsetof( ivec2, data ), sizeof( int [2] ) );
	swigStructField( "ivec2-x", offsetof( ivec2, x ), sizeof( int ) );
	swigStructField( "ivec2-y", offsetof( ivec2, y ), sizeof( int ) );
	swigStructField( "ivec2-s", offsetof( ivec2, s ), sizeof( int ) );
	swigStructField( "ivec2-t", offsetof( ivec2, t ), sizeof( int ) );
	swigStructField( "ivec2-start", offsetof( ivec2, start ), sizeof( int ) );
	printf( "drop %zu end-structure\n", sizeof( ivec2 ) );

	swigComment("vec4\n");
	printf( "begin-structure vec4\n" );
	swigStructField( "vec4-w", offsetof( vec4, w ), sizeof( float ) );
	swigStructField( "vec4-g", offsetof( vec4, g ), sizeof( float ) );
	swigStructField( "vec4-x", offsetof( vec4, x ), sizeof( float ) );
	swigStructField( "vec4-y", offsetof( vec4, y ), sizeof( float ) );
	swigStructField( "vec4-height", offsetof( vec4, height ), sizeof( float ) );
	swigStructField( "vec4-z", offsetof( vec4, z ), sizeof( float ) );
	swigStructField( "vec4-alpha", offsetof( vec4, alpha ), sizeof( float ) );
	swigStructField( "vec4-blue", offsetof( vec4, blue ), sizeof( float ) );
	swigStructField( "vec4-width", offsetof( vec4, width ), sizeof( float ) );
	swigStructField( "vec4-green", offsetof( vec4, green ), sizeof( float ) );
	swigStructField( "vec4-a", offsetof( vec4, a ), sizeof( float ) );
	swigStructField( "vec4-r", offsetof( vec4, r ), sizeof( float ) );
	swigStructField( "vec4-left", offsetof( vec4, left ), sizeof( float ) );
	swigStructField( "vec4-b", offsetof( vec4, b ), sizeof( float ) );
	swigStructField( "vec4-red", offsetof( vec4, red ), sizeof( float ) );
	swigStructField( "vec4-top", offsetof( vec4, top ), sizeof( float ) );
	swigStructField( "vec4-data", offsetof( vec4, data ), sizeof( float [4] ) );
	printf( "drop %zu end-structure\n", sizeof( vec4 ) );

	swigComment("vec3\n");
	printf( "begin-structure vec3\n" );
	swigStructField( "vec3-b", offsetof( vec3, b ), sizeof( float ) );
	swigStructField( "vec3-data", offsetof( vec3, data ), sizeof( float [3] ) );
	swigStructField( "vec3-x", offsetof( vec3, x ), sizeof( float ) );
	swigStructField( "vec3-blue", offsetof( vec3, blue ), sizeof( float ) );
	swigStructField( "vec3-y", offsetof( vec3, y ), sizeof( float ) );
	swigStructField( "vec3-r", offsetof( vec3, r ), sizeof( float ) );
	swigStructField( "vec3-z", offsetof( vec3, z ), sizeof( float ) );
	swigStructField( "vec3-green", offsetof( vec3, green ), sizeof( float ) );
	swigStructField( "vec3-red", offsetof( vec3, red ), sizeof( float ) );
	swigStructField( "vec3-g", offsetof( vec3, g ), sizeof( float ) );
	printf( "drop %zu end-structure\n", sizeof( vec3 ) );

	swigComment("vec2\n");
	printf( "begin-structure vec2\n" );
	swigStructField( "vec2-data", offsetof( vec2, data ), sizeof( float [2] ) );
	swigStructField( "vec2-x", offsetof( vec2, x ), sizeof( float ) );
	swigStructField( "vec2-y", offsetof( vec2, y ), sizeof( float ) );
	swigStructField( "vec2-s", offsetof( vec2, s ), sizeof( float ) );
	swigStructField( "vec2-t", offsetof( vec2, t ), sizeof( float ) );
	printf( "drop %zu end-structure\n", sizeof( vec2 ) );

	swigComment("vector_t\n");
	printf( "begin-structure vector_t\n" );
	swigStructField( "vector_t-items", offsetof( struct vector_t, items ), sizeof( void * ) );
	swigStructField( "vector_t-size", offsetof( struct vector_t, size ), sizeof( size_t ) );
	swigStructField( "vector_t-item_size", offsetof( struct vector_t, item_size ), sizeof( size_t ) );
	swigStructField( "vector_t-capacity", offsetof( struct vector_t, capacity ), sizeof( size_t ) );
	printf( "drop %zu end-structure\n", sizeof( struct vector_t ) );

	swigComment("texture_atlas_t\n");
	printf( "begin-structure texture_atlas_t\n" );
	swigStructField( "texture_atlas_t-data", offsetof( struct texture_atlas_t, data ), sizeof( unsigned char * ) );
	swigStructField( "texture_atlas_t-id", offsetof( struct texture_atlas_t, id ), sizeof( unsigned int ) );
	swigStructField( "texture_atlas_t-special", offsetof( struct texture_atlas_t, special ), sizeof( void * ) );
	swigStructField( "texture_atlas_t-nodes", offsetof( struct texture_atlas_t, nodes ), sizeof( vector_t * ) );
	swigStructField( "texture_atlas_t-height", offsetof( struct texture_atlas_t, height ), sizeof( size_t ) );
	swigStructField( "texture_atlas_t-used", offsetof( struct texture_atlas_t, used ), sizeof( size_t ) );
	swigStructField( "texture_atlas_t-width", offsetof( struct texture_atlas_t, width ), sizeof( size_t ) );
	swigStructField( "texture_atlas_t-depth", offsetof( struct texture_atlas_t, depth ), sizeof( size_t ) );
	swigStructField( "texture_atlas_t-modified", offsetof( struct texture_atlas_t, modified ), sizeof( unsigned char ) );
	printf( "drop %zu end-structure\n", sizeof( struct texture_atlas_t ) );

	swigComment("texture_glyph_t\n");
	printf( "begin-structure texture_glyph_t\n" );
	swigStructField( "texture_glyph_t-codepoint", offsetof( struct texture_glyph_t, codepoint ), sizeof( uint32_t ) );
	swigStructField( "texture_glyph_t-height", offsetof( struct texture_glyph_t, height ), sizeof( size_t ) );
	swigStructField( "texture_glyph_t-t0", offsetof( struct texture_glyph_t, t0 ), sizeof( float ) );
	swigStructField( "texture_glyph_t-t1", offsetof( struct texture_glyph_t, t1 ), sizeof( float ) );
	swigStructField( "texture_glyph_t-outline_thickness", offsetof( struct texture_glyph_t, outline_thickness ), sizeof( float ) );
	swigStructField( "texture_glyph_t-s0", offsetof( struct texture_glyph_t, s0 ), sizeof( float ) );
	swigStructField( "texture_glyph_t-s1", offsetof( struct texture_glyph_t, s1 ), sizeof( float ) );
	swigStructField( "texture_glyph_t-offset_x", offsetof( struct texture_glyph_t, offset_x ), sizeof( int ) );
	swigStructField( "texture_glyph_t-offset_y", offsetof( struct texture_glyph_t, offset_y ), sizeof( int ) );
	swigStructField( "texture_glyph_t-advance_x", offsetof( struct texture_glyph_t, advance_x ), sizeof( float ) );
	swigStructField( "texture_glyph_t-advance_y", offsetof( struct texture_glyph_t, advance_y ), sizeof( float ) );
	swigStructField( "texture_glyph_t-width", offsetof( struct texture_glyph_t, width ), sizeof( size_t ) );
	swigStructField( "texture_glyph_t-rendermode", offsetof( struct texture_glyph_t, rendermode ), sizeof( rendermode_t ) );
	swigStructField( "texture_glyph_t-glyphmode", offsetof( struct texture_glyph_t, glyphmode ), sizeof( glyphmode_t ) );
	swigStructField( "texture_glyph_t-kerning", offsetof( struct texture_glyph_t, kerning ), sizeof( vector_t * ) );
	printf( "drop %zu end-structure\n", sizeof( struct texture_glyph_t ) );

	swigComment("texture_font_library_t\n");
	printf( "begin-structure texture_font_library_t\n" );
	swigStructField( "texture_font_library_t-library", offsetof( struct texture_font_library_t, library ), sizeof( FT_Library ) );
	swigStructField( "texture_font_library_t-mode", offsetof( struct texture_font_library_t, mode ), sizeof( font_mode_t ) );
	printf( "drop %zu end-structure\n", sizeof( struct texture_font_library_t ) );

	swigComment("texture_font_t\n");
	printf( "begin-structure texture_font_t\n" );
	swigStructField( "texture_font_t-ascender", offsetof( struct texture_font_t, ascender ), sizeof( float ) );
	swigStructField( "texture_font_t-descender", offsetof( struct texture_font_t, descender ), sizeof( float ) );
	swigStructField( "texture_font_t-mode", offsetof( struct texture_font_t, mode ), sizeof( font_mode_t ) );
	swigStructField( "texture_font_t-face", offsetof( struct texture_font_t, face ), sizeof( FT_Face ) );
	swigStructField( "texture_font_t-size", offsetof( struct texture_font_t, size ), sizeof( float ) );
	swigStructField( "texture_font_t-location", offsetof( struct texture_font_t, location ), sizeof( font_location_t ) );
	swigStructField( "texture_font_t-glyphs", offsetof( struct texture_font_t, glyphs ), sizeof( vector_t * ) );
	swigStructField( "texture_font_t-height", offsetof( struct texture_font_t, height ), sizeof( float ) );
	swigStructField( "texture_font_t-linegap", offsetof( struct texture_font_t, linegap ), sizeof( float ) );
	swigStructField( "texture_font_t-outline_thickness", offsetof( struct texture_font_t, outline_thickness ), sizeof( float ) );
	swigStructField( "texture_font_t-underline_thickness", offsetof( struct texture_font_t, underline_thickness ), sizeof( float ) );
	swigStructField( "texture_font_t-filtering", offsetof( struct texture_font_t, filtering ), sizeof( unsigned char ) );
	swigStructField( "texture_font_t-hb_font", offsetof( struct texture_font_t, hb_font ), sizeof( hb_font_t * ) );
	swigStructField( "texture_font_t-atlas", offsetof( struct texture_font_t, atlas ), sizeof( texture_atlas_t * ) );
	swigStructField( "texture_font_t-lcd_weights", offsetof( struct texture_font_t, lcd_weights ), sizeof( unsigned char [5] ) );
	swigStructField( "texture_font_t-hinting", offsetof( struct texture_font_t, hinting ), sizeof( unsigned char ) );
	swigStructField( "texture_font_t-underline_position", offsetof( struct texture_font_t, underline_position ), sizeof( float ) );
	swigStructField( "texture_font_t-rendermode", offsetof( struct texture_font_t, rendermode ), sizeof( rendermode_t ) );
	swigStructField( "texture_font_t-filename", offsetof( struct texture_font_t, filename ), sizeof( char * ) );
	swigStructField( "texture_font_t-scaletex", offsetof( struct texture_font_t, scaletex ), sizeof( unsigned char ) );
	swigStructField( "texture_font_t-ft_size", offsetof( struct texture_font_t, ft_size ), sizeof( FT_Size ) );
	swigStructField( "texture_font_t-scale", offsetof( struct texture_font_t, scale ), sizeof( float ) );
	swigStructField( "texture_font_t-padding", offsetof( struct texture_font_t, padding ), sizeof( int ) );
	swigStructField( "texture_font_t-memory", offsetof( struct texture_font_t, memory ), sizeof( _memory ) );
	swigStructField( "texture_font_t-kerning", offsetof( struct texture_font_t, kerning ), sizeof( unsigned char ) );
	swigStructField( "texture_font_t-library", offsetof( struct texture_font_t, library ), sizeof( texture_font_library_t * ) );
	printf( "drop %zu end-structure\n", sizeof( struct texture_font_t ) );

	swigNewline();

	swigComment("------===< callbacks >===-------\n");
	swigCallback( "c-callback error_callback_t: s ... -- void", "", "", "	( fmt <noname> -- )" );

	swigNewline();

	swigComment("------===< functions >===-------\n");
	swigFunction( "c-function vector_new vector_new n -- a", "FUNCTION: vector_new ( item_size -- a )", "EXTERN: \"C\" void * vector_new( int item_size );", "	( item_size -- )" );
	swigFunction( "c-function vector_delete vector_delete a -- void", "FUNCTION: vector_delete ( self -- void )", "EXTERN: \"C\" void vector_delete( void * self );", "	( self -- )" );
	swigFunction( "c-function vector_get vector_get a n -- a", "FUNCTION: vector_get ( self index -- a )", "EXTERN: \"C\" void * vector_get( void * self, int index );", "	( self index -- )" );
	swigFunction( "c-function vector_front vector_front a -- a", "FUNCTION: vector_front ( self -- a )", "EXTERN: \"C\" void * vector_front( void * self );", "	( self -- )" );
	swigFunction( "c-function vector_back vector_back a -- a", "FUNCTION: vector_back ( self -- a )", "EXTERN: \"C\" void * vector_back( void * self );", "	( self -- )" );
	swigFunction( "c-function vector_contains vector_contains a a a -- n", "FUNCTION: vector_contains ( self item cmp -- n )", "EXTERN: \"C\" int vector_contains( void * self, void * item, void * cmp );", "	( self item cmp -- )" );
	swigFunction( "c-function vector_empty vector_empty a -- n", "FUNCTION: vector_empty ( self -- n )", "EXTERN: \"C\" int vector_empty( void * self );", "	( self -- )" );
	swigFunction( "c-function vector_size vector_size a -- n", "FUNCTION: vector_size ( self -- n )", "EXTERN: \"C\" int vector_size( void * self );", "	( self -- )" );
	swigFunction( "c-function vector_reserve vector_reserve a n -- void", "FUNCTION: vector_reserve ( self size -- void )", "EXTERN: \"C\" void vector_reserve( void * self, int size );", "	( self size -- )" );
	swigFunction( "c-function vector_capacity vector_capacity a -- n", "FUNCTION: vector_capacity ( self -- n )", "EXTERN: \"C\" int vector_capacity( void * self );", "	( self -- )" );
	swigFunction( "c-function vector_shrink vector_shrink a -- void", "FUNCTION: vector_shrink ( self -- void )", "EXTERN: \"C\" void vector_shrink( void * self );", "	( self -- )" );
	swigFunction( "c-function vector_clear vector_clear a -- void", "FUNCTION: vector_clear ( self -- void )", "EXTERN: \"C\" void vector_clear( void * self );", "	( self -- )" );
	swigFunction( "c-function vector_set vector_set a n a -- void", "FUNCTION: vector_set ( self index item -- void )", "EXTERN: \"C\" void vector_set( void * self, int index, void * item );", "	( self index item -- )" );
	swigFunction( "c-function vector_erase vector_erase a n -- void", "FUNCTION: vector_erase ( self index -- void )", "EXTERN: \"C\" void vector_erase( void * self, int index );", "	( self index -- )" );
	swigFunction( "c-function vector_erase_range vector_erase_range a n n -- void", "FUNCTION: vector_erase_range ( self first last -- void )", "EXTERN: \"C\" void vector_erase_range( void * self, int first, int last );", "	( self first last -- )" );
	swigFunction( "c-function vector_push_back vector_push_back a a -- void", "FUNCTION: vector_push_back ( self item -- void )", "EXTERN: \"C\" void vector_push_back( void * self, void * item );", "	( self item -- )" );
	swigFunction( "c-function vector_pop_back vector_pop_back a -- void", "FUNCTION: vector_pop_back ( self -- void )", "EXTERN: \"C\" void vector_pop_back( void * self );", "	( self -- )" );
	swigFunction( "c-function vector_resize vector_resize a n -- void", "FUNCTION: vector_resize ( self size -- void )", "EXTERN: \"C\" void vector_resize( void * self, int size );", "	( self size -- )" );
	swigFunction( "c-function vector_insert vector_insert a n a -- void", "FUNCTION: vector_insert ( self index item -- void )", "EXTERN: \"C\" void vector_insert( void * self, int index, void * item );", "	( self index item -- )" );
	swigFunction( "c-function vector_insert_data vector_insert_data a n a n -- void", "FUNCTION: vector_insert_data ( self index data count -- void )", "EXTERN: \"C\" void vector_insert_data( void * self, int index, void * data, int count );", "	( self index data count -- )" );
	swigFunction( "c-function vector_push_back_data vector_push_back_data a a n -- void", "FUNCTION: vector_push_back_data ( self data count -- void )", "EXTERN: \"C\" void vector_push_back_data( void * self, void * data, int count );", "	( self data count -- )" );
	swigFunction( "c-function vector_sort vector_sort a a -- void", "FUNCTION: vector_sort ( self cmp -- void )", "EXTERN: \"C\" void vector_sort( void * self, void * cmp );", "	( self cmp -- )" );
	swigFunction( "c-function texture_atlas_new texture_atlas_new n n n -- a", "FUNCTION: texture_atlas_new ( width height depth -- a )", "EXTERN: \"C\" void * texture_atlas_new( int width, int height, int depth );", "	( width height depth -- )" );
	swigFunction( "c-function texture_atlas_delete texture_atlas_delete a -- void", "FUNCTION: texture_atlas_delete ( self -- void )", "EXTERN: \"C\" void texture_atlas_delete( void * self );", "	( self -- )" );
	swigFunction( "c-function texture_atlas_get_region texture_atlas_get_region a n n -- struct", "FUNCTION: texture_atlas_get_region ( self width height -- struct )", "EXTERN: \"C\" struct texture_atlas_get_region( void * self, int width, int height );", "	( self width height -- )" );
	swigFunction( "c-function texture_atlas_set_region texture_atlas_set_region a n n n n a n -- void", "FUNCTION: texture_atlas_set_region ( self x y width height data stride -- void )", "EXTERN: \"C\" void texture_atlas_set_region( void * self, int x, int y, int width, int height, void * data, int stride );", "	( self x y width height data stride -- )" );
	swigFunction( "c-function texture_atlas_clear texture_atlas_clear a -- void", "FUNCTION: texture_atlas_clear ( self -- void )", "EXTERN: \"C\" void texture_atlas_clear( void * self );", "	( self -- )" );
	swigFunction( "c-function texture_atlas_enlarge_texture texture_atlas_enlarge_texture a n n -- void", "FUNCTION: texture_atlas_enlarge_texture ( self width_new height_new -- void )", "EXTERN: \"C\" void texture_atlas_enlarge_texture( void * self, int width_new, int height_new );", "	( self width_new height_new -- )" );
	swigFunction( "c-function texture_font_default_mode texture_font_default_mode n -- void", "FUNCTION: texture_font_default_mode ( mode -- void )", "EXTERN: \"C\" void texture_font_default_mode( int mode );", "	( mode -- )" );
	swigFunction( "c-function texture_library_new texture_library_new  -- a", "FUNCTION: texture_library_new (  -- a )", "EXTERN: \"C\" void * texture_library_new(  );", "	( -- )" );
	swigFunction( "c-function texture_font_new_from_file texture_font_new_from_file a r s -- a", "FUNCTION: texture_font_new_from_file ( atlas pt_size filename -- a )", "EXTERN: \"C\" void * texture_font_new_from_file( void * atlas, float pt_size, char * filename );", "	( atlas pt_size filename -- )" );
	swigFunction( "c-function texture_font_new_from_memory texture_font_new_from_memory a r a n -- a", "FUNCTION: texture_font_new_from_memory ( atlas pt_size memory_base memory_size -- a )", "EXTERN: \"C\" void * texture_font_new_from_memory( void * atlas, float pt_size, void * memory_base, int memory_size );", "	( atlas pt_size memory_base memory_size -- )" );
	swigFunction( "c-function texture_font_clone texture_font_clone a r -- a", "FUNCTION: texture_font_clone ( self size -- a )", "EXTERN: \"C\" void * texture_font_clone( void * self, float size );", "	( self size -- )" );
	swigFunction( "c-function texture_font_activate_size texture_font_activate_size a -- n", "FUNCTION: texture_font_activate_size ( self -- n )", "EXTERN: \"C\" int texture_font_activate_size( void * self );", "	( self -- )" );
	swigFunction( "c-function texture_font_close texture_font_close a n n -- void", "FUNCTION: texture_font_close ( self face_mode library_mode -- void )", "EXTERN: \"C\" void texture_font_close( void * self, int face_mode, int library_mode );", "	( self face_mode library_mode -- )" );
	swigFunction( "c-function texture_font_delete texture_font_delete a -- void", "FUNCTION: texture_font_delete ( self -- void )", "EXTERN: \"C\" void texture_font_delete( void * self );", "	( self -- )" );
	swigFunction( "c-function texture_font_load_face texture_font_load_face a r -- n", "FUNCTION: texture_font_load_face ( self size -- n )", "EXTERN: \"C\" int texture_font_load_face( void * self, float size );", "	( self size -- )" );
	swigFunction( "c-function texture_font_is_variable texture_font_is_variable a -- n", "FUNCTION: texture_font_is_variable ( self -- n )", "EXTERN: \"C\" int texture_font_is_variable( void * self );", "	( self -- )" );
	swigFunction( "c-function texture_font_get_weight texture_font_get_weight a a a a -- n", "FUNCTION: texture_font_get_weight ( self def min max -- n )", "EXTERN: \"C\" int texture_font_get_weight( void * self, void * def, void * min, void * max );", "	( self def min max -- )" );
	swigFunction( "c-function texture_font_set_weight texture_font_set_weight a n -- n", "FUNCTION: texture_font_set_weight ( self wght -- n )", "EXTERN: \"C\" int texture_font_set_weight( void * self, long wght );", "	( self wght -- )" );
	swigFunction( "c-function texture_font_get_glyph texture_font_get_glyph a s -- a", "FUNCTION: texture_font_get_glyph ( self codepoint -- a )", "EXTERN: \"C\" void * texture_font_get_glyph( void * self, char * codepoint );", "	( self codepoint -- )" );
	swigFunction( "c-function texture_font_find_glyph texture_font_find_glyph a s -- a", "FUNCTION: texture_font_find_glyph ( self codepoint -- a )", "EXTERN: \"C\" void * texture_font_find_glyph( void * self, char * codepoint );", "	( self codepoint -- )" );
	swigFunction( "c-function texture_font_index_glyph texture_font_index_glyph a a u -- n", "FUNCTION: texture_font_index_glyph ( self glyph codepoint -- n )", "EXTERN: \"C\" int texture_font_index_glyph( void * self, void * glyph, int codepoint );", "	( self glyph codepoint -- )" );
	swigFunction( "c-function texture_font_load_glyph texture_font_load_glyph a s -- n", "FUNCTION: texture_font_load_glyph ( self codepoint -- n )", "EXTERN: \"C\" int texture_font_load_glyph( void * self, char * codepoint );", "	( self codepoint -- )" );
	swigFunction( "c-function texture_font_get_glyph_gi texture_font_get_glyph_gi a u -- a", "FUNCTION: texture_font_get_glyph_gi ( self glyph_index -- a )", "EXTERN: \"C\" void * texture_font_get_glyph_gi( void * self, int glyph_index );", "	( self glyph_index -- )" );
	swigFunction( "c-function texture_font_find_glyph_gi texture_font_find_glyph_gi a u -- a", "FUNCTION: texture_font_find_glyph_gi ( self glyph_index -- a )", "EXTERN: \"C\" void * texture_font_find_glyph_gi( void * self, int glyph_index );", "	( self glyph_index -- )" );
	swigFunction( "c-function texture_font_load_glyph_gi texture_font_load_glyph_gi a u u -- n", "FUNCTION: texture_font_load_glyph_gi ( self glyph_index ucodepoint -- n )", "EXTERN: \"C\" int texture_font_load_glyph_gi( void * self, int glyph_index, int ucodepoint );", "	( self glyph_index ucodepoint -- )" );
	swigFunction( "c-function texture_font_load_glyphs texture_font_load_glyphs a s -- n", "FUNCTION: texture_font_load_glyphs ( self codepoints -- n )", "EXTERN: \"C\" int texture_font_load_glyphs( void * self, char * codepoints );", "	( self codepoints -- )" );
	swigFunction( "c-function texture_font_enlarge_atlas texture_font_enlarge_atlas a n n -- void", "FUNCTION: texture_font_enlarge_atlas ( self width_new height_new -- void )", "EXTERN: \"C\" void texture_font_enlarge_atlas( void * self, int width_new, int height_new );", "	( self width_new height_new -- )" );
	swigFunction( "c-function texture_font_enlarge_glyphs texture_font_enlarge_glyphs a r r -- void", "FUNCTION: texture_font_enlarge_glyphs ( self mulw mulh -- void )", "EXTERN: \"C\" void texture_font_enlarge_glyphs( void * self, float mulw, float mulh );", "	( self mulw mulh -- )" );
	swigFunction( "c-function texture_font_enlarge_texture texture_font_enlarge_texture a n n -- void", "FUNCTION: texture_font_enlarge_texture ( self width_new height_new -- void )", "EXTERN: \"C\" void texture_font_enlarge_texture( void * self, int width_new, int height_new );", "	( self width_new height_new -- )" );
	swigFunction( "c-function texture_glyph_get_kerning texture_glyph_get_kerning a s -- r", "FUNCTION: texture_glyph_get_kerning ( self codepoint -- r )", "EXTERN: \"C\" float texture_glyph_get_kerning( void * self, char * codepoint );", "	( self codepoint -- )" );
	swigFunction( "c-function texture_glyph_new texture_glyph_new  -- a", "FUNCTION: texture_glyph_new (  -- a )", "EXTERN: \"C\" void * texture_glyph_new(  );", "	( -- )" );
	swigFunction( "c-function texture_glyph_delete texture_glyph_delete a -- void", "FUNCTION: texture_glyph_delete ( self -- void )", "EXTERN: \"C\" void texture_glyph_delete( void * self );", "	( self -- )" );
	swigFunction( "c-function texture_glyph_clone texture_glyph_clone a -- a", "FUNCTION: texture_glyph_clone ( self -- a )", "EXTERN: \"C\" void * texture_glyph_clone( void * self );", "	( self -- )" );
	swigFunction( "c-function error_callback_default error_callback_default s ... -- void", "FUNCTION: error_callback_default ( fmt  -- void )", "EXTERN: \"C\" void error_callback_default( char * fmt, ...  );", "	( fmt <noname> -- )" );
	swigFunction( "c-function set_error_callback set_error_callback a -- void", "FUNCTION: set_error_callback ( error_cb -- void )", "EXTERN: \"C\" void set_error_callback( void * error_cb );", "	( error_cb -- )" );
	swigFunction( "c-function FTGL_Error_String FTGL_Error_String u -- s", "FUNCTION: FTGL_Error_String ( error_code -- s )", "EXTERN: \"C\" char * FTGL_Error_String( int error_code );", "	( error_code -- )" );

	swigNewline();

	swigComment("----===< postfix >===-----\n");

	swigPrint( "end-c-library", "( none )", "( none )" );
	
	return 0;
} /* end of main */



