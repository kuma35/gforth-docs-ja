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


#include <va/va_x11.h>

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



	swigNewline();

	swigComment("----===< prefix >===-----\n");

	swigPrint( "c-library va_x11\ns\" va_x11\" add-lib\n\\c #include <va/va_x11.h>", "( none )", "( none )" );

	swigNewline();

	swigComment("------===< functions >===-------\n");
	swigFunction( "c-function vaGetDisplay vaGetDisplay a -- a", "FUNCTION: vaGetDisplay ( dpy -- a )", "EXTERN: \"C\" void * vaGetDisplay( void * dpy );", "	( dpy -- )" );
	swigFunction( "c-function vaPutSurface vaPutSurface a n n n n u u n n u u a u u -- n", "FUNCTION: vaPutSurface ( dpy surface draw srcx srcy srcw srch destx desty destw desth cliprects number_cliprects flags -- n )", "EXTERN: \"C\" n vaPutSurface( void * dpy, n surface, n draw, short srcx, short srcy, short srcw, short srch, short destx, short desty, short destw, short desth, void * cliprects, int number_cliprects, int flags );", "	( dpy surface draw srcx srcy srcw srch destx desty destw desth cliprects number_cliprects flags -- )" );

	swigNewline();

	swigComment("----===< postfix >===-----\n");

	swigPrint( "end-c-library", "( none )", "( none )" );
	
	return 0;
} /* end of main */



