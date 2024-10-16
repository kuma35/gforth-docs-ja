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


#include <va/va_drm.h>
#include <va/va_drmcommon.h>

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
  int fd;
  
  uint32_t size;
  
  uint64_t drm_format_modifier;
} _VADRMPRIMESurfaceDescriptor_objects;

typedef struct {
  uint32_t drm_format;
  
  uint32_t num_planes;
  
  uint32_t object_index[4];
  
  uint32_t offset[4];
  
  uint32_t pitch[4];
} _VADRMPRIMESurfaceDescriptor_layers;


	swigNewline();

	swigComment("----===< prefix >===-----\n");

	swigPrint( "c-library va_drm\ns\" va_drm\" add-lib\n\\c #include <va/va_drm.h>\n\\c #include <va/va_drmcommon.h>", "( none )", "( none )" );

	swigNewline();

	swigComment("----===< int constants >===-----\n");
	#ifdef VA_SURFACE_ATTRIB_MEM_TYPE_KERNEL_DRM
		swigIntConstant( VA_SURFACE_ATTRIB_MEM_TYPE_KERNEL_DRM, "VA_SURFACE_ATTRIB_MEM_TYPE_KERNEL_DRM" );
	#endif
	#ifdef VA_SURFACE_ATTRIB_MEM_TYPE_DRM_PRIME
		swigIntConstant( VA_SURFACE_ATTRIB_MEM_TYPE_DRM_PRIME, "VA_SURFACE_ATTRIB_MEM_TYPE_DRM_PRIME" );
	#endif
	#ifdef VA_SURFACE_ATTRIB_MEM_TYPE_DRM_PRIME_2
		swigIntConstant( VA_SURFACE_ATTRIB_MEM_TYPE_DRM_PRIME_2, "VA_SURFACE_ATTRIB_MEM_TYPE_DRM_PRIME_2" );
	#endif

	swigNewline();

	swigComment("--------===< enums >===---------\n");
	swigIntConstant( VA_DRM_AUTH_NONE, "VA_DRM_AUTH_NONE" );
	swigIntConstant( VA_DRM_AUTH_DRI1, "VA_DRM_AUTH_DRI1" );
	swigIntConstant( VA_DRM_AUTH_DRI2, "VA_DRM_AUTH_DRI2" );
	swigIntConstant( VA_DRM_AUTH_CUSTOM, "VA_DRM_AUTH_CUSTOM" );

	swigNewline();

	swigComment("-------===< structs >===--------\n");

	swigComment("drm_state\n");
	printf( "begin-structure drm_state\n" );
	swigStructField( "drm_state-va_reserved", offsetof( struct drm_state, va_reserved ), sizeof( int [8] ) );
	swigStructField( "drm_state-auth_type", offsetof( struct drm_state, auth_type ), sizeof( int ) );
	swigStructField( "drm_state-fd", offsetof( struct drm_state, fd ), sizeof( int ) );
	printf( "drop %zu end-structure\n", sizeof( struct drm_state ) );

	swigComment("VADRMPRIMESurfaceDescriptor\n");
	printf( "begin-structure VADRMPRIMESurfaceDescriptor\n" );
	printf( "drop %zu end-structure\n", sizeof( struct _VADRMPRIMESurfaceDescriptor ) );

	swigComment("_VADRMPRIMESurfaceDescriptor_layers\n");
	printf( "begin-structure _VADRMPRIMESurfaceDescriptor_layers\n" );
	swigStructField( "_VADRMPRIMESurfaceDescriptor_layers-object_index", offsetof( _VADRMPRIMESurfaceDescriptor_layers, object_index ), sizeof( uint32_t [4] ) );
	swigStructField( "_VADRMPRIMESurfaceDescriptor_layers-offset", offsetof( _VADRMPRIMESurfaceDescriptor_layers, offset ), sizeof( uint32_t [4] ) );
	swigStructField( "_VADRMPRIMESurfaceDescriptor_layers-drm_format", offsetof( _VADRMPRIMESurfaceDescriptor_layers, drm_format ), sizeof( uint32_t ) );
	swigStructField( "_VADRMPRIMESurfaceDescriptor_layers-pitch", offsetof( _VADRMPRIMESurfaceDescriptor_layers, pitch ), sizeof( uint32_t [4] ) );
	swigStructField( "_VADRMPRIMESurfaceDescriptor_layers-num_planes", offsetof( _VADRMPRIMESurfaceDescriptor_layers, num_planes ), sizeof( uint32_t ) );
	printf( "drop %zu end-structure\n", sizeof( _VADRMPRIMESurfaceDescriptor_layers ) );

	swigComment("_VADRMPRIMESurfaceDescriptor_objects\n");
	printf( "begin-structure _VADRMPRIMESurfaceDescriptor_objects\n" );
	swigStructField( "_VADRMPRIMESurfaceDescriptor_objects-fd", offsetof( _VADRMPRIMESurfaceDescriptor_objects, fd ), sizeof( int ) );
	swigStructField( "_VADRMPRIMESurfaceDescriptor_objects-size", offsetof( _VADRMPRIMESurfaceDescriptor_objects, size ), sizeof( uint32_t ) );
	swigStructField( "_VADRMPRIMESurfaceDescriptor_objects-drm_format_modifier", offsetof( _VADRMPRIMESurfaceDescriptor_objects, drm_format_modifier ), sizeof( uint64_t ) );
	printf( "drop %zu end-structure\n", sizeof( _VADRMPRIMESurfaceDescriptor_objects ) );

	swigComment("VADRMFormatModifierList\n");
	printf( "begin-structure VADRMFormatModifierList\n" );
	printf( "drop %zu end-structure\n", sizeof( struct _VADRMFormatModifierList ) );

	swigNewline();

	swigComment("------===< functions >===-------\n");
	swigFunction( "c-function vaGetDisplayDRM vaGetDisplayDRM n -- a", "FUNCTION: vaGetDisplayDRM ( fd -- a )", "EXTERN: \"C\" void * vaGetDisplayDRM( int fd );", "	( fd -- )" );

	swigNewline();

	swigComment("----===< postfix >===-----\n");

	swigPrint( "end-c-library", "( none )", "( none )" );
	
	return 0;
} /* end of main */



