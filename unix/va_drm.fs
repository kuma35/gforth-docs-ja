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

c-library va_drm
s" va-drm" add-lib
\c #include <va/va_drm.h>
\c #include <va/va_drmcommon.h>

\ ----===< int constants >===-----
#268435456	constant VA_SURFACE_ATTRIB_MEM_TYPE_KERNEL_DRM
#536870912	constant VA_SURFACE_ATTRIB_MEM_TYPE_DRM_PRIME
#1073741824	constant VA_SURFACE_ATTRIB_MEM_TYPE_DRM_PRIME_2

\ --------===< enums >===---------
#0	constant VA_DRM_AUTH_NONE
#1	constant VA_DRM_AUTH_DRI1
#2	constant VA_DRM_AUTH_DRI2
#3	constant VA_DRM_AUTH_CUSTOM

\ -------===< structs >===--------
\ drm_state
begin-structure drm_state
	drop 8 32 +field drm_state-va_reserved
	drop 4 4 +field drm_state-auth_type
	drop 0 4 +field drm_state-fd
drop 40 end-structure
\ VADRMPRIMESurfaceDescriptor
begin-structure VADRMPRIMESurfaceDescriptor
drop 312 end-structure
\ _VADRMPRIMESurfaceDescriptor_layers
begin-structure _VADRMPRIMESurfaceDescriptor_layers
	drop 8 16 +field _VADRMPRIMESurfaceDescriptor_layers-object_index
	drop 24 16 +field _VADRMPRIMESurfaceDescriptor_layers-offset
	drop 0 4 +field _VADRMPRIMESurfaceDescriptor_layers-drm_format
	drop 40 16 +field _VADRMPRIMESurfaceDescriptor_layers-pitch
	drop 4 4 +field _VADRMPRIMESurfaceDescriptor_layers-num_planes
drop 56 end-structure
\ _VADRMPRIMESurfaceDescriptor_objects
begin-structure _VADRMPRIMESurfaceDescriptor_objects
	drop 0 4 +field _VADRMPRIMESurfaceDescriptor_objects-fd
	drop 4 4 +field _VADRMPRIMESurfaceDescriptor_objects-size
	drop 8 8 +field _VADRMPRIMESurfaceDescriptor_objects-drm_format_modifier
drop 16 end-structure
\ VADRMFormatModifierList
begin-structure VADRMFormatModifierList
drop 16 end-structure

\ ------===< functions >===-------
c-function vaGetDisplayDRM vaGetDisplayDRM n -- a	( fd -- )

\ ----===< postfix >===-----
end-c-library
previous set-current
