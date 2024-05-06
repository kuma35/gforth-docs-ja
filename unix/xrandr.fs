\ This file has been generated using SWIG and fsi,
\ and is already platform dependent, search for the corresponding
\ fsi-file to compile it where no one has compiled it before ;)
\ Forth systems have their own own dynamic loader and don't need addional C-Code.
\ That's why this file will just print normal forth-code once compiled
\ and can be used directly with include or require.
\ As all comments are stripped during the compilation, please
\ insert the copyright notice of the original file here.

\ ----===< prefix >===-----
cs-vocabulary Xrandr

get-current also Xrandr definitions

c-library xrandr
s" a a 0" vararg$ $!
s" Xrandr" add-lib
\c #include <X11/extensions/Xrandr.h>
\c #define _EVDEVK(x) x

\ -------===< structs >===--------
\ XRRScreenSize
begin-structure XRRScreenSize
	drop 12 4 +field XRRScreenSize-mheight
	drop 4 4 +field XRRScreenSize-height
	drop 8 4 +field XRRScreenSize-mwidth
	drop 0 4 +field XRRScreenSize-width
drop 16 end-structure
\ XRRScreenChangeNotifyEvent
begin-structure XRRScreenChangeNotifyEvent
	drop 32 8 +field XRRScreenChangeNotifyEvent-window
	drop 8 8 +field XRRScreenChangeNotifyEvent-serial
	drop 68 2 +field XRRScreenChangeNotifyEvent-rotation
	drop 76 4 +field XRRScreenChangeNotifyEvent-height
	drop 40 8 +field XRRScreenChangeNotifyEvent-root
	drop 84 4 +field XRRScreenChangeNotifyEvent-mheight
	drop 24 8 +field XRRScreenChangeNotifyEvent-display
	drop 72 4 +field XRRScreenChangeNotifyEvent-width
	drop 64 2 +field XRRScreenChangeNotifyEvent-size_index
	drop 0 4 +field XRRScreenChangeNotifyEvent-type
	drop 56 8 +field XRRScreenChangeNotifyEvent-config_timestamp
	drop 48 8 +field XRRScreenChangeNotifyEvent-timestamp
	drop 16 4 +field XRRScreenChangeNotifyEvent-send_event
	drop 66 2 +field XRRScreenChangeNotifyEvent-subpixel_order
	drop 80 4 +field XRRScreenChangeNotifyEvent-mwidth
drop 88 end-structure
\ XRRNotifyEvent
begin-structure XRRNotifyEvent
	drop 24 8 +field XRRNotifyEvent-display
	drop 8 8 +field XRRNotifyEvent-serial
	drop 32 8 +field XRRNotifyEvent-window
	drop 0 4 +field XRRNotifyEvent-type
	drop 40 4 +field XRRNotifyEvent-subtype
	drop 16 4 +field XRRNotifyEvent-send_event
drop 48 end-structure
\ XRROutputChangeNotifyEvent
begin-structure XRROutputChangeNotifyEvent
	drop 24 8 +field XRROutputChangeNotifyEvent-display
	drop 56 8 +field XRROutputChangeNotifyEvent-crtc
	drop 76 2 +field XRROutputChangeNotifyEvent-subpixel_order
	drop 48 8 +field XRROutputChangeNotifyEvent-output
	drop 8 8 +field XRROutputChangeNotifyEvent-serial
	drop 32 8 +field XRROutputChangeNotifyEvent-window
	drop 0 4 +field XRROutputChangeNotifyEvent-type
	drop 40 4 +field XRROutputChangeNotifyEvent-subtype
	drop 16 4 +field XRROutputChangeNotifyEvent-send_event
	drop 64 8 +field XRROutputChangeNotifyEvent-mode
	drop 72 2 +field XRROutputChangeNotifyEvent-rotation
	drop 74 2 +field XRROutputChangeNotifyEvent-connection
drop 80 end-structure
\ XRRCrtcChangeNotifyEvent
begin-structure XRRCrtcChangeNotifyEvent
	drop 24 8 +field XRRCrtcChangeNotifyEvent-display
	drop 48 8 +field XRRCrtcChangeNotifyEvent-crtc
	drop 68 4 +field XRRCrtcChangeNotifyEvent-x
	drop 72 4 +field XRRCrtcChangeNotifyEvent-y
	drop 8 8 +field XRRCrtcChangeNotifyEvent-serial
	drop 32 8 +field XRRCrtcChangeNotifyEvent-window
	drop 0 4 +field XRRCrtcChangeNotifyEvent-type
	drop 40 4 +field XRRCrtcChangeNotifyEvent-subtype
	drop 80 4 +field XRRCrtcChangeNotifyEvent-height
	drop 16 4 +field XRRCrtcChangeNotifyEvent-send_event
	drop 76 4 +field XRRCrtcChangeNotifyEvent-width
	drop 56 8 +field XRRCrtcChangeNotifyEvent-mode
	drop 64 2 +field XRRCrtcChangeNotifyEvent-rotation
drop 88 end-structure
\ XRROutputPropertyNotifyEvent
begin-structure XRROutputPropertyNotifyEvent
	drop 24 8 +field XRROutputPropertyNotifyEvent-display
	drop 56 8 +field XRROutputPropertyNotifyEvent-property
	drop 48 8 +field XRROutputPropertyNotifyEvent-output
	drop 8 8 +field XRROutputPropertyNotifyEvent-serial
	drop 32 8 +field XRROutputPropertyNotifyEvent-window
	drop 0 4 +field XRROutputPropertyNotifyEvent-type
	drop 40 4 +field XRROutputPropertyNotifyEvent-subtype
	drop 16 4 +field XRROutputPropertyNotifyEvent-send_event
	drop 64 8 +field XRROutputPropertyNotifyEvent-timestamp
	drop 72 4 +field XRROutputPropertyNotifyEvent-state
drop 80 end-structure
\ XRRProviderChangeNotifyEvent
begin-structure XRRProviderChangeNotifyEvent
	drop 24 8 +field XRRProviderChangeNotifyEvent-display
	drop 64 4 +field XRRProviderChangeNotifyEvent-current_role
	drop 8 8 +field XRRProviderChangeNotifyEvent-serial
	drop 32 8 +field XRRProviderChangeNotifyEvent-window
	drop 48 8 +field XRRProviderChangeNotifyEvent-provider
	drop 0 4 +field XRRProviderChangeNotifyEvent-type
	drop 40 4 +field XRRProviderChangeNotifyEvent-subtype
	drop 16 4 +field XRRProviderChangeNotifyEvent-send_event
	drop 56 8 +field XRRProviderChangeNotifyEvent-timestamp
drop 72 end-structure
\ XRRProviderPropertyNotifyEvent
begin-structure XRRProviderPropertyNotifyEvent
	drop 24 8 +field XRRProviderPropertyNotifyEvent-display
	drop 56 8 +field XRRProviderPropertyNotifyEvent-property
	drop 8 8 +field XRRProviderPropertyNotifyEvent-serial
	drop 32 8 +field XRRProviderPropertyNotifyEvent-window
	drop 48 8 +field XRRProviderPropertyNotifyEvent-provider
	drop 0 4 +field XRRProviderPropertyNotifyEvent-type
	drop 40 4 +field XRRProviderPropertyNotifyEvent-subtype
	drop 16 4 +field XRRProviderPropertyNotifyEvent-send_event
	drop 64 8 +field XRRProviderPropertyNotifyEvent-timestamp
	drop 72 4 +field XRRProviderPropertyNotifyEvent-state
drop 80 end-structure
\ XRRResourceChangeNotifyEvent
begin-structure XRRResourceChangeNotifyEvent
	drop 24 8 +field XRRResourceChangeNotifyEvent-display
	drop 8 8 +field XRRResourceChangeNotifyEvent-serial
	drop 32 8 +field XRRResourceChangeNotifyEvent-window
	drop 0 4 +field XRRResourceChangeNotifyEvent-type
	drop 40 4 +field XRRResourceChangeNotifyEvent-subtype
	drop 16 4 +field XRRResourceChangeNotifyEvent-send_event
	drop 48 8 +field XRRResourceChangeNotifyEvent-timestamp
drop 56 end-structure
\ XRRModeInfo
begin-structure XRRModeInfo
	drop 44 4 +field XRRModeInfo-vSyncEnd
	drop 28 4 +field XRRModeInfo-hSyncEnd
	drop 36 4 +field XRRModeInfo-hSkew
	drop 64 4 +field XRRModeInfo-nameLength
	drop 12 4 +field XRRModeInfo-height
	drop 56 8 +field XRRModeInfo-name
	drop 16 8 +field XRRModeInfo-dotClock
	drop 48 4 +field XRRModeInfo-vTotal
	drop 0 8 +field XRRModeInfo-id
	drop 8 4 +field XRRModeInfo-width
	drop 32 4 +field XRRModeInfo-hTotal
	drop 40 4 +field XRRModeInfo-vSyncStart
	drop 24 4 +field XRRModeInfo-hSyncStart
	drop 72 8 +field XRRModeInfo-modeFlags
drop 80 end-structure
\ XRRScreenResources
begin-structure XRRScreenResources
	drop 16 4 +field XRRScreenResources-ncrtc
	drop 24 8 +field XRRScreenResources-crtcs
	drop 32 4 +field XRRScreenResources-noutput
	drop 40 8 +field XRRScreenResources-outputs
	drop 0 8 +field XRRScreenResources-timestamp
	drop 8 8 +field XRRScreenResources-configTimestamp
	drop 48 4 +field XRRScreenResources-nmode
	drop 56 8 +field XRRScreenResources-modes
drop 64 end-structure
\ XRROutputInfo
begin-structure XRROutputInfo
	drop 48 2 +field XRROutputInfo-connection
	drop 16 8 +field XRROutputInfo-name
	drop 72 8 +field XRROutputInfo-clones
	drop 40 8 +field XRROutputInfo-mm_height
	drop 24 4 +field XRROutputInfo-nameLen
	drop 8 8 +field XRROutputInfo-crtc
	drop 32 8 +field XRROutputInfo-mm_width
	drop 80 4 +field XRROutputInfo-nmode
	drop 88 8 +field XRROutputInfo-modes
	drop 0 8 +field XRROutputInfo-timestamp
	drop 50 2 +field XRROutputInfo-subpixel_order
	drop 64 4 +field XRROutputInfo-nclone
	drop 84 4 +field XRROutputInfo-npreferred
	drop 56 8 +field XRROutputInfo-crtcs
	drop 52 4 +field XRROutputInfo-ncrtc
drop 96 end-structure
\ XRRPropertyInfo
begin-structure XRRPropertyInfo
	drop 0 4 +field XRRPropertyInfo-pending
	drop 8 4 +field XRRPropertyInfo-immutable
	drop 4 4 +field XRRPropertyInfo-range
	drop 12 4 +field XRRPropertyInfo-num_values
	drop 16 8 +field XRRPropertyInfo-values
drop 24 end-structure
\ XRRCrtcInfo
begin-structure XRRCrtcInfo
	drop 8 4 +field XRRCrtcInfo-x
	drop 12 4 +field XRRCrtcInfo-y
	drop 36 4 +field XRRCrtcInfo-noutput
	drop 52 4 +field XRRCrtcInfo-npossible
	drop 56 8 +field XRRCrtcInfo-possible
	drop 40 8 +field XRRCrtcInfo-outputs
	drop 20 4 +field XRRCrtcInfo-height
	drop 0 8 +field XRRCrtcInfo-timestamp
	drop 16 4 +field XRRCrtcInfo-width
	drop 48 2 +field XRRCrtcInfo-rotations
	drop 24 8 +field XRRCrtcInfo-mode
	drop 32 2 +field XRRCrtcInfo-rotation
drop 64 end-structure
\ XRRCrtcGamma
begin-structure XRRCrtcGamma
	drop 24 8 +field XRRCrtcGamma-blue
	drop 16 8 +field XRRCrtcGamma-green
	drop 0 4 +field XRRCrtcGamma-size
	drop 8 8 +field XRRCrtcGamma-red
drop 32 end-structure
\ XRRCrtcTransformAttributes
begin-structure XRRCrtcTransformAttributes
	drop 104 8 +field XRRCrtcTransformAttributes-currentFilter
	drop 40 8 +field XRRCrtcTransformAttributes-pendingFilter
	drop 0 36 +field XRRCrtcTransformAttributes-pendingTransform
	drop 64 36 +field XRRCrtcTransformAttributes-currentTransform
	drop 120 8 +field XRRCrtcTransformAttributes-currentParams
	drop 48 4 +field XRRCrtcTransformAttributes-pendingNparams
	drop 56 8 +field XRRCrtcTransformAttributes-pendingParams
	drop 112 4 +field XRRCrtcTransformAttributes-currentNparams
drop 128 end-structure
\ XRRPanning
begin-structure XRRPanning
	drop 8 4 +field XRRPanning-left
	drop 28 4 +field XRRPanning-track_top
	drop 32 4 +field XRRPanning-track_width
	drop 36 4 +field XRRPanning-track_height
	drop 48 4 +field XRRPanning-border_right
	drop 12 4 +field XRRPanning-top
	drop 20 4 +field XRRPanning-height
	drop 24 4 +field XRRPanning-track_left
	drop 40 4 +field XRRPanning-border_left
	drop 0 8 +field XRRPanning-timestamp
	drop 16 4 +field XRRPanning-width
	drop 52 4 +field XRRPanning-border_bottom
	drop 44 4 +field XRRPanning-border_top
drop 56 end-structure
\ XRRProviderResources
begin-structure XRRProviderResources
	drop 8 4 +field XRRProviderResources-nproviders
	drop 16 8 +field XRRProviderResources-providers
	drop 0 8 +field XRRProviderResources-timestamp
drop 24 end-structure
\ XRRProviderInfo
begin-structure XRRProviderInfo
	drop 8 8 +field XRRProviderInfo-crtcs
	drop 40 4 +field XRRProviderInfo-nassociatedproviders
	drop 48 8 +field XRRProviderInfo-associated_providers
	drop 0 4 +field XRRProviderInfo-capabilities
	drop 4 4 +field XRRProviderInfo-ncrtcs
	drop 32 8 +field XRRProviderInfo-name
	drop 64 4 +field XRRProviderInfo-nameLen
	drop 16 4 +field XRRProviderInfo-noutputs
	drop 24 8 +field XRRProviderInfo-outputs
	drop 56 8 +field XRRProviderInfo-associated_capability
drop 72 end-structure
\ XRRMonitorInfo
begin-structure XRRMonitorInfo
	drop 8 4 +field XRRMonitorInfo-primary
	drop 0 8 +field XRRMonitorInfo-name
	drop 20 4 +field XRRMonitorInfo-x
	drop 16 4 +field XRRMonitorInfo-noutput
	drop 24 4 +field XRRMonitorInfo-y
	drop 40 4 +field XRRMonitorInfo-mheight
	drop 48 8 +field XRRMonitorInfo-outputs
	drop 32 4 +field XRRMonitorInfo-height
	drop 36 4 +field XRRMonitorInfo-mwidth
	drop 28 4 +field XRRMonitorInfo-width
	drop 12 4 +field XRRMonitorInfo-automatic
drop 56 end-structure

\ ------===< functions >===-------
c-function XRRQueryExtension XRRQueryExtension a a a -- n	( dpy event_base_return error_base_return -- )
c-function XRRQueryVersion XRRQueryVersion a a a -- n	( dpy major_version_return minor_version_return -- )
c-function XRRGetScreenInfo XRRGetScreenInfo a u -- a	( dpy window -- )
c-function XRRFreeScreenConfigInfo XRRFreeScreenConfigInfo a -- void	( config -- )
c-function XRRSetScreenConfig XRRSetScreenConfig a a u n n u -- n	( dpy config draw size_index rotation timestamp -- )
c-function XRRSetScreenConfigAndRate XRRSetScreenConfigAndRate a a u n n n u -- n	( dpy config draw size_index rotation rate timestamp -- )
c-function XRRConfigRotations XRRConfigRotations a a -- n	( config current_rotation -- )
c-function XRRConfigTimes XRRConfigTimes a a -- u	( config config_timestamp -- )
c-function XRRConfigSizes XRRConfigSizes a a -- a	( config nsizes -- )
c-function XRRConfigRates XRRConfigRates a n a -- a	( config sizeID nrates -- )
c-function XRRConfigCurrentConfiguration XRRConfigCurrentConfiguration a a -- u	( config rotation -- )
c-function XRRConfigCurrentRate XRRConfigCurrentRate a -- n	( config -- )
c-function XRRRootToScreen XRRRootToScreen a u -- n	( dpy root -- )
c-function XRRSelectInput XRRSelectInput a u n -- void	( dpy window mask -- )
c-function XRRRotations XRRRotations a n a -- n	( dpy screen current_rotation -- )
c-function XRRSizes XRRSizes a n a -- a	( dpy screen nsizes -- )
c-function XRRRates XRRRates a n n a -- a	( dpy screen sizeID nrates -- )
c-function XRRTimes XRRTimes a n a -- u	( dpy screen config_timestamp -- )
c-function XRRGetScreenSizeRange XRRGetScreenSizeRange a u a a a a -- n	( dpy window minWidth minHeight maxWidth maxHeight -- )
c-function XRRSetScreenSize XRRSetScreenSize a u n n n n -- void	( dpy window width height mmWidth mmHeight -- )
c-function XRRGetScreenResources XRRGetScreenResources a u -- a	( dpy window -- )
c-function XRRFreeScreenResources XRRFreeScreenResources a -- void	( resources -- )
c-function XRRGetOutputInfo XRRGetOutputInfo a a u -- a	( dpy resources output -- )
c-function XRRFreeOutputInfo XRRFreeOutputInfo a -- void	( outputInfo -- )
c-function XRRListOutputProperties XRRListOutputProperties a u a -- a	( dpy output nprop -- )
c-function XRRQueryOutputProperty XRRQueryOutputProperty a u u -- a	( dpy output property -- )
c-function XRRConfigureOutputProperty XRRConfigureOutputProperty a u u n n n a -- void	( dpy output property pending range num_values values -- )
c-function XRRChangeOutputProperty XRRChangeOutputProperty a u u u n n a n -- void	( dpy output property type format mode data nelements -- )
c-function XRRDeleteOutputProperty XRRDeleteOutputProperty a u u -- void	( dpy output property -- )
c-function XRRGetOutputProperty XRRGetOutputProperty a u u n n n n u a a a a a -- n	( dpy output property offset length _delete pending req_type actual_type actual_format nitems bytes_after prop -- )
c-function XRRAllocModeInfo XRRAllocModeInfo s n -- a	( name nameLength -- )
c-function XRRCreateMode XRRCreateMode a u a -- u	( dpy window modeInfo -- )
c-function XRRDestroyMode XRRDestroyMode a u -- void	( dpy mode -- )
c-function XRRAddOutputMode XRRAddOutputMode a u u -- void	( dpy output mode -- )
c-function XRRDeleteOutputMode XRRDeleteOutputMode a u u -- void	( dpy output mode -- )
c-function XRRFreeModeInfo XRRFreeModeInfo a -- void	( modeInfo -- )
c-function XRRGetCrtcInfo XRRGetCrtcInfo a a u -- a	( dpy resources crtc -- )
c-function XRRFreeCrtcInfo XRRFreeCrtcInfo a -- void	( crtcInfo -- )
c-function XRRSetCrtcConfig XRRSetCrtcConfig a a u u n n u n a n -- n	( dpy resources crtc timestamp x y mode rotation outputs noutputs -- )
c-function XRRGetCrtcGammaSize XRRGetCrtcGammaSize a u -- n	( dpy crtc -- )
c-function XRRGetCrtcGamma XRRGetCrtcGamma a u -- a	( dpy crtc -- )
c-function XRRAllocGamma XRRAllocGamma n -- a	( size -- )
c-function XRRSetCrtcGamma XRRSetCrtcGamma a u a -- void	( dpy crtc gamma -- )
c-function XRRFreeGamma XRRFreeGamma a -- void	( gamma -- )
c-function XRRGetScreenResourcesCurrent XRRGetScreenResourcesCurrent a u -- a	( dpy window -- )
c-function XRRSetCrtcTransform XRRSetCrtcTransform a u a s a n -- void	( dpy crtc transform filter params nparams -- )
c-function XRRGetCrtcTransform XRRGetCrtcTransform a u a -- n	( dpy crtc attributes -- )
c-function XRRUpdateConfiguration XRRUpdateConfiguration a -- n	( event -- )
c-function XRRGetPanning XRRGetPanning a a u -- a	( dpy resources crtc -- )
c-function XRRFreePanning XRRFreePanning a -- void	( panning -- )
c-function XRRSetPanning XRRSetPanning a a u a -- n	( dpy resources crtc panning -- )
c-function XRRSetOutputPrimary XRRSetOutputPrimary a u u -- void	( dpy window output -- )
c-function XRRGetOutputPrimary XRRGetOutputPrimary a u -- u	( dpy window -- )
c-function XRRGetProviderResources XRRGetProviderResources a u -- a	( dpy window -- )
c-function XRRFreeProviderResources XRRFreeProviderResources a -- void	( resources -- )
c-function XRRGetProviderInfo XRRGetProviderInfo a a u -- a	( dpy resources provider -- )
c-function XRRFreeProviderInfo XRRFreeProviderInfo a -- void	( provider -- )
c-function XRRSetProviderOutputSource XRRSetProviderOutputSource a u u -- n	( dpy provider source_provider -- )
c-function XRRSetProviderOffloadSink XRRSetProviderOffloadSink a u u -- n	( dpy provider sink_provider -- )
c-function XRRListProviderProperties XRRListProviderProperties a u a -- a	( dpy provider nprop -- )
c-function XRRQueryProviderProperty XRRQueryProviderProperty a u u -- a	( dpy provider property -- )
c-function XRRConfigureProviderProperty XRRConfigureProviderProperty a u u n n n a -- void	( dpy provider property pending range num_values values -- )
c-function XRRChangeProviderProperty XRRChangeProviderProperty a u u u n n a n -- void	( dpy provider property type format mode data nelements -- )
c-function XRRDeleteProviderProperty XRRDeleteProviderProperty a u u -- void	( dpy provider property -- )
c-function XRRGetProviderProperty XRRGetProviderProperty a u u n n n n u a a a a a -- n	( dpy provider property offset length _delete pending req_type actual_type actual_format nitems bytes_after prop -- )
c-function XRRAllocateMonitor XRRAllocateMonitor a n -- a	( dpy noutput -- )
c-function XRRGetMonitors XRRGetMonitors a u n a -- a	( dpy window get_active nmonitors -- )
c-function XRRSetMonitor XRRSetMonitor a u a -- void	( dpy window monitor -- )
c-function XRRDeleteMonitor XRRDeleteMonitor a u u -- void	( dpy window name -- )
c-function XRRFreeMonitors XRRFreeMonitors a -- void	( monitors -- )

\ ----===< postfix >===-----
end-c-library
previous set-current
