\ This file has been generated using SWIG and fsi,
\ and is already platform dependent, search for the corresponding
\ fsi-file to compile it where no one has compiled it before ;)
\ Forth systems have their own own dynamic loader and don't need addional C-Code.
\ That's why this file will just print normal forth-code once compiled
\ and can be used directly with include or require.
\ As all comments are stripped during the compilation, please
\ insert the copyright notice of the original file here.

\ ----===< prefix >===-----
cs-vocabulary SDL2

get-current also SDL2 definitions

c-library SDL
s" a a 0" vararg$ $!
s" SDL2" add-lib
\c #include <SDL2/SDL.h>
\c #ifdef __gnu_linux__
\c #undef stderr
\c extern struct _IO_FILE *stderr;
\c #endif

\ ----===< int constants >===-----
#2	constant SDL_ASSERT_LEVEL
#229	constant SDL_LINE
#0	constant SDL_NULL_WHILE_LOOP_CONDITION
#255	constant SDL_AUDIO_MASK_BITSIZE
#256	constant SDL_AUDIO_MASK_DATATYPE
#4096	constant SDL_AUDIO_MASK_ENDIAN
#32768	constant SDL_AUDIO_MASK_SIGNED
#8	constant AUDIO_U8
#32776	constant AUDIO_S8
#16	constant AUDIO_U16LSB
#32784	constant AUDIO_S16LSB
#4112	constant AUDIO_U16MSB
#36880	constant AUDIO_S16MSB
#16	constant AUDIO_U16
#32784	constant AUDIO_S16
#32800	constant AUDIO_S32LSB
#36896	constant AUDIO_S32MSB
#32800	constant AUDIO_S32
#33056	constant AUDIO_F32LSB
#37152	constant AUDIO_F32MSB
#33056	constant AUDIO_F32
#16	constant AUDIO_U16SYS
#32784	constant AUDIO_S16SYS
#32800	constant AUDIO_S32SYS
#33056	constant AUDIO_F32SYS
#1	constant SDL_AUDIO_ALLOW_FREQUENCY_CHANGE
#2	constant SDL_AUDIO_ALLOW_FORMAT_CHANGE
#4	constant SDL_AUDIO_ALLOW_CHANNELS_CHANGE
#8	constant SDL_AUDIO_ALLOW_SAMPLES_CHANGE
#15	constant SDL_AUDIO_ALLOW_ANY_CHANGE
#9	constant SDL_AUDIOCVT_MAX_FILTERS
#128	constant SDL_MIX_MAXVOLUME
#128	constant SDL_CACHELINE_SIZE
#1234	constant SDL_LIL_ENDIAN
#4321	constant SDL_BIG_ENDIAN
#1234	constant SDL_BYTEORDER
#0	constant SDL_RELEASED
#1	constant SDL_PRESSED
#32	constant SDL_TEXTEDITINGEVENT_TEXT_SIZE
#32	constant SDL_TEXTINPUTEVENT_TEXT_SIZE
#-1	constant SDL_QUERY
#0	constant SDL_IGNORE
#0	constant SDL_DISABLE
#1	constant SDL_ENABLE
#1	constant SDL_HAPTIC_CONSTANT
#2	constant SDL_HAPTIC_SINE
#4	constant SDL_HAPTIC_LEFTRIGHT
#8	constant SDL_HAPTIC_TRIANGLE
#16	constant SDL_HAPTIC_SAWTOOTHUP
#32	constant SDL_HAPTIC_SAWTOOTHDOWN
#64	constant SDL_HAPTIC_RAMP
#128	constant SDL_HAPTIC_SPRING
#256	constant SDL_HAPTIC_DAMPER
#512	constant SDL_HAPTIC_INERTIA
#1024	constant SDL_HAPTIC_FRICTION
#2048	constant SDL_HAPTIC_CUSTOM
#4096	constant SDL_HAPTIC_GAIN
#8192	constant SDL_HAPTIC_AUTOCENTER
#16384	constant SDL_HAPTIC_STATUS
#32768	constant SDL_HAPTIC_PAUSE
#0	constant SDL_HAPTIC_POLAR
#1	constant SDL_HAPTIC_CARTESIAN
#2	constant SDL_HAPTIC_SPHERICAL
#3	constant SDL_HAPTIC_STEERING_AXIS
#4294967295	constant SDL_HAPTIC_INFINITY
#4096	constant SDL_MAX_LOG_MESSAGE
#1	constant SDL_MUTEX_TIMEDOUT
#0	constant SDL_RWOPS_UNKNOWN
#1	constant SDL_RWOPS_WINFILE
#2	constant SDL_RWOPS_STDFILE
#3	constant SDL_RWOPS_JNIFILE
#4	constant SDL_RWOPS_MEMORY
#5	constant SDL_RWOPS_MEMORY_RO
#0	constant RW_SEEK_SET
#1	constant RW_SEEK_CUR
#2	constant RW_SEEK_END
#-1	constant SDL_NONSHAPEABLE_WINDOW
#-2	constant SDL_INVALID_SHAPE_ARGUMENT
#-3	constant SDL_WINDOW_LACKS_SHAPE
#2	constant SDL_MAJOR_VERSION
#0	constant SDL_MINOR_VERSION
#20	constant SDL_PATCHLEVEL
#2020	constant SDL_COMPILEDVERSION
#536805376	constant SDL_WINDOWPOS_UNDEFINED_MASK
#536805376	constant SDL_WINDOWPOS_UNDEFINED
#805240832	constant SDL_WINDOWPOS_CENTERED_MASK
#805240832	constant SDL_WINDOWPOS_CENTERED

\ ---===< float constants >===----
3.141593e0	fconstant M_PI
9.806650e0	fconstant SDL_STANDARD_GRAVITY

\ --------===< enums >===---------
#0	constant SDL_FALSE
#1	constant SDL_TRUE
#0	constant DUMMY_ENUM_VALUE
#0	constant SDL_ASSERTION_RETRY
#1	constant SDL_ASSERTION_BREAK
#2	constant SDL_ASSERTION_ABORT
#3	constant SDL_ASSERTION_IGNORE
#4	constant SDL_ASSERTION_ALWAYS_IGNORE
#0	constant SDL_AUDIO_STOPPED
#1	constant SDL_AUDIO_PLAYING
#2	constant SDL_AUDIO_PAUSED
#0	constant SDL_ENOMEM
#1	constant SDL_EFREAD
#2	constant SDL_EFWRITE
#3	constant SDL_EFSEEK
#4	constant SDL_UNSUPPORTED
#5	constant SDL_LASTERROR
#0	constant SDL_FIRSTEVENT
#256	constant SDL_QUIT
#257	constant SDL_APP_TERMINATING
#258	constant SDL_APP_LOWMEMORY
#259	constant SDL_APP_WILLENTERBACKGROUND
#260	constant SDL_APP_DIDENTERBACKGROUND
#261	constant SDL_APP_WILLENTERFOREGROUND
#262	constant SDL_APP_DIDENTERFOREGROUND
#263	constant SDL_LOCALECHANGED
#336	constant SDL_DISPLAYEVENT
#512	constant SDL_WINDOWEVENT
#513	constant SDL_SYSWMEVENT
#768	constant SDL_KEYDOWN
#769	constant SDL_KEYUP
#770	constant SDL_TEXTEDITING
#771	constant SDL_TEXTINPUT
#772	constant SDL_KEYMAPCHANGED
#1024	constant SDL_MOUSEMOTION
#1025	constant SDL_MOUSEBUTTONDOWN
#1026	constant SDL_MOUSEBUTTONUP
#1027	constant SDL_MOUSEWHEEL
#1536	constant SDL_JOYAXISMOTION
#1537	constant SDL_JOYBALLMOTION
#1538	constant SDL_JOYHATMOTION
#1539	constant SDL_JOYBUTTONDOWN
#1540	constant SDL_JOYBUTTONUP
#1541	constant SDL_JOYDEVICEADDED
#1542	constant SDL_JOYDEVICEREMOVED
#1616	constant SDL_CONTROLLERAXISMOTION
#1617	constant SDL_CONTROLLERBUTTONDOWN
#1618	constant SDL_CONTROLLERBUTTONUP
#1619	constant SDL_CONTROLLERDEVICEADDED
#1620	constant SDL_CONTROLLERDEVICEREMOVED
#1621	constant SDL_CONTROLLERDEVICEREMAPPED
#1622	constant SDL_CONTROLLERTOUCHPADDOWN
#1623	constant SDL_CONTROLLERTOUCHPADMOTION
#1624	constant SDL_CONTROLLERTOUCHPADUP
#1625	constant SDL_CONTROLLERSENSORUPDATE
#1792	constant SDL_FINGERDOWN
#1793	constant SDL_FINGERUP
#1794	constant SDL_FINGERMOTION
#2048	constant SDL_DOLLARGESTURE
#2049	constant SDL_DOLLARRECORD
#2050	constant SDL_MULTIGESTURE
#2304	constant SDL_CLIPBOARDUPDATE
#4096	constant SDL_DROPFILE
#4097	constant SDL_DROPTEXT
#4098	constant SDL_DROPBEGIN
#4099	constant SDL_DROPCOMPLETE
#4352	constant SDL_AUDIODEVICEADDED
#4353	constant SDL_AUDIODEVICEREMOVED
#4608	constant SDL_SENSORUPDATE
#8192	constant SDL_RENDER_TARGETS_RESET
#8193	constant SDL_RENDER_DEVICE_RESET
#32512	constant SDL_POLLSENTINEL
#32768	constant SDL_USEREVENT
#65535	constant SDL_LASTEVENT
#0	constant SDL_ADDEVENT
#1	constant SDL_PEEKEVENT
#2	constant SDL_GETEVENT
#0	constant SDL_HINT_DEFAULT
#1	constant SDL_HINT_NORMAL
#2	constant SDL_HINT_OVERRIDE
#0	constant SDL_LOG_CATEGORY_APPLICATION
#1	constant SDL_LOG_CATEGORY_ERROR
#2	constant SDL_LOG_CATEGORY_ASSERT
#3	constant SDL_LOG_CATEGORY_SYSTEM
#4	constant SDL_LOG_CATEGORY_AUDIO
#5	constant SDL_LOG_CATEGORY_VIDEO
#6	constant SDL_LOG_CATEGORY_RENDER
#7	constant SDL_LOG_CATEGORY_INPUT
#8	constant SDL_LOG_CATEGORY_TEST
#9	constant SDL_LOG_CATEGORY_RESERVED1
#10	constant SDL_LOG_CATEGORY_RESERVED2
#11	constant SDL_LOG_CATEGORY_RESERVED3
#12	constant SDL_LOG_CATEGORY_RESERVED4
#13	constant SDL_LOG_CATEGORY_RESERVED5
#14	constant SDL_LOG_CATEGORY_RESERVED6
#15	constant SDL_LOG_CATEGORY_RESERVED7
#16	constant SDL_LOG_CATEGORY_RESERVED8
#17	constant SDL_LOG_CATEGORY_RESERVED9
#18	constant SDL_LOG_CATEGORY_RESERVED10
#19	constant SDL_LOG_CATEGORY_CUSTOM
#1	constant SDL_LOG_PRIORITY_VERBOSE
#2	constant SDL_LOG_PRIORITY_DEBUG
#3	constant SDL_LOG_PRIORITY_INFO
#4	constant SDL_LOG_PRIORITY_WARN
#5	constant SDL_LOG_PRIORITY_ERROR
#6	constant SDL_LOG_PRIORITY_CRITICAL
#7	constant SDL_NUM_LOG_PRIORITIES
#16	constant SDL_MESSAGEBOX_ERROR
#32	constant SDL_MESSAGEBOX_WARNING
#64	constant SDL_MESSAGEBOX_INFORMATION
#128	constant SDL_MESSAGEBOX_BUTTONS_LEFT_TO_RIGHT
#256	constant SDL_MESSAGEBOX_BUTTONS_RIGHT_TO_LEFT
#1	constant SDL_MESSAGEBOX_BUTTON_RETURNKEY_DEFAULT
#2	constant SDL_MESSAGEBOX_BUTTON_ESCAPEKEY_DEFAULT
#0	constant SDL_MESSAGEBOX_COLOR_BACKGROUND
#1	constant SDL_MESSAGEBOX_COLOR_TEXT
#2	constant SDL_MESSAGEBOX_COLOR_BUTTON_BORDER
#3	constant SDL_MESSAGEBOX_COLOR_BUTTON_BACKGROUND
#4	constant SDL_MESSAGEBOX_COLOR_BUTTON_SELECTED
#5	constant SDL_MESSAGEBOX_COLOR_MAX
#0	constant SDL_POWERSTATE_UNKNOWN
#1	constant SDL_POWERSTATE_ON_BATTERY
#2	constant SDL_POWERSTATE_NO_BATTERY
#3	constant SDL_POWERSTATE_CHARGING
#4	constant SDL_POWERSTATE_CHARGED
#1	constant SDL_RENDERER_SOFTWARE
#2	constant SDL_RENDERER_ACCELERATED
#4	constant SDL_RENDERER_PRESENTVSYNC
#8	constant SDL_RENDERER_TARGETTEXTURE
#0	constant SDL_ScaleModeNearest
#1	constant SDL_ScaleModeLinear
#2	constant SDL_ScaleModeBest
#0	constant SDL_TEXTUREACCESS_STATIC
#1	constant SDL_TEXTUREACCESS_STREAMING
#2	constant SDL_TEXTUREACCESS_TARGET
#0	constant SDL_TEXTUREMODULATE_NONE
#1	constant SDL_TEXTUREMODULATE_COLOR
#2	constant SDL_TEXTUREMODULATE_ALPHA
#0	constant SDL_FLIP_NONE
#1	constant SDL_FLIP_HORIZONTAL
#2	constant SDL_FLIP_VERTICAL
#-1	constant SDL_SENSOR_INVALID
#0	constant SDL_SENSOR_UNKNOWN
#1	constant SDL_SENSOR_ACCEL
#2	constant SDL_SENSOR_GYRO
#0	constant ShapeModeDefault
#1	constant ShapeModeBinarizeAlpha
#2	constant ShapeModeReverseBinarizeAlpha
#3	constant ShapeModeColorKey
#0	constant SDL_THREAD_PRIORITY_LOW
#1	constant SDL_THREAD_PRIORITY_NORMAL
#2	constant SDL_THREAD_PRIORITY_HIGH
#3	constant SDL_THREAD_PRIORITY_TIME_CRITICAL
#1	constant SDL_WINDOW_FULLSCREEN
#2	constant SDL_WINDOW_OPENGL
#4	constant SDL_WINDOW_SHOWN
#8	constant SDL_WINDOW_HIDDEN
#16	constant SDL_WINDOW_BORDERLESS
#32	constant SDL_WINDOW_RESIZABLE
#64	constant SDL_WINDOW_MINIMIZED
#128	constant SDL_WINDOW_MAXIMIZED
#256	constant SDL_WINDOW_MOUSE_GRABBED
#512	constant SDL_WINDOW_INPUT_FOCUS
#1024	constant SDL_WINDOW_MOUSE_FOCUS
#4097	constant SDL_WINDOW_FULLSCREEN_DESKTOP
#2048	constant SDL_WINDOW_FOREIGN
#8192	constant SDL_WINDOW_ALLOW_HIGHDPI
#16384	constant SDL_WINDOW_MOUSE_CAPTURE
#32768	constant SDL_WINDOW_ALWAYS_ON_TOP
#65536	constant SDL_WINDOW_SKIP_TASKBAR
#131072	constant SDL_WINDOW_UTILITY
#262144	constant SDL_WINDOW_TOOLTIP
#524288	constant SDL_WINDOW_POPUP_MENU
#1048576	constant SDL_WINDOW_KEYBOARD_GRABBED
#268435456	constant SDL_WINDOW_VULKAN
#536870912	constant SDL_WINDOW_METAL
#256	constant SDL_WINDOW_INPUT_GRABBED
#0	constant SDL_WINDOWEVENT_NONE
#1	constant SDL_WINDOWEVENT_SHOWN
#2	constant SDL_WINDOWEVENT_HIDDEN
#3	constant SDL_WINDOWEVENT_EXPOSED
#4	constant SDL_WINDOWEVENT_MOVED
#5	constant SDL_WINDOWEVENT_RESIZED
#6	constant SDL_WINDOWEVENT_SIZE_CHANGED
#7	constant SDL_WINDOWEVENT_MINIMIZED
#8	constant SDL_WINDOWEVENT_MAXIMIZED
#9	constant SDL_WINDOWEVENT_RESTORED
#10	constant SDL_WINDOWEVENT_ENTER
#11	constant SDL_WINDOWEVENT_LEAVE
#12	constant SDL_WINDOWEVENT_FOCUS_GAINED
#13	constant SDL_WINDOWEVENT_FOCUS_LOST
#14	constant SDL_WINDOWEVENT_CLOSE
#15	constant SDL_WINDOWEVENT_TAKE_FOCUS
#16	constant SDL_WINDOWEVENT_HIT_TEST
#17	constant SDL_WINDOWEVENT_ICCPROF_CHANGED
#18	constant SDL_WINDOWEVENT_DISPLAY_CHANGED
#0	constant SDL_DISPLAYEVENT_NONE
#1	constant SDL_DISPLAYEVENT_ORIENTATION
#2	constant SDL_DISPLAYEVENT_CONNECTED
#3	constant SDL_DISPLAYEVENT_DISCONNECTED
#0	constant SDL_ORIENTATION_UNKNOWN
#1	constant SDL_ORIENTATION_LANDSCAPE
#2	constant SDL_ORIENTATION_LANDSCAPE_FLIPPED
#3	constant SDL_ORIENTATION_PORTRAIT
#4	constant SDL_ORIENTATION_PORTRAIT_FLIPPED
#0	constant SDL_FLASH_CANCEL
#1	constant SDL_FLASH_BRIEFLY
#2	constant SDL_FLASH_UNTIL_FOCUSED
#0	constant SDL_GL_RED_SIZE
#1	constant SDL_GL_GREEN_SIZE
#2	constant SDL_GL_BLUE_SIZE
#3	constant SDL_GL_ALPHA_SIZE
#4	constant SDL_GL_BUFFER_SIZE
#5	constant SDL_GL_DOUBLEBUFFER
#6	constant SDL_GL_DEPTH_SIZE
#7	constant SDL_GL_STENCIL_SIZE
#8	constant SDL_GL_ACCUM_RED_SIZE
#9	constant SDL_GL_ACCUM_GREEN_SIZE
#10	constant SDL_GL_ACCUM_BLUE_SIZE
#11	constant SDL_GL_ACCUM_ALPHA_SIZE
#12	constant SDL_GL_STEREO
#13	constant SDL_GL_MULTISAMPLEBUFFERS
#14	constant SDL_GL_MULTISAMPLESAMPLES
#15	constant SDL_GL_ACCELERATED_VISUAL
#16	constant SDL_GL_RETAINED_BACKING
#17	constant SDL_GL_CONTEXT_MAJOR_VERSION
#18	constant SDL_GL_CONTEXT_MINOR_VERSION
#19	constant SDL_GL_CONTEXT_EGL
#20	constant SDL_GL_CONTEXT_FLAGS
#21	constant SDL_GL_CONTEXT_PROFILE_MASK
#22	constant SDL_GL_SHARE_WITH_CURRENT_CONTEXT
#23	constant SDL_GL_FRAMEBUFFER_SRGB_CAPABLE
#24	constant SDL_GL_CONTEXT_RELEASE_BEHAVIOR
#25	constant SDL_GL_CONTEXT_RESET_NOTIFICATION
#26	constant SDL_GL_CONTEXT_NO_ERROR
#1	constant SDL_GL_CONTEXT_PROFILE_CORE
#2	constant SDL_GL_CONTEXT_PROFILE_COMPATIBILITY
#4	constant SDL_GL_CONTEXT_PROFILE_ES
#1	constant SDL_GL_CONTEXT_DEBUG_FLAG
#2	constant SDL_GL_CONTEXT_FORWARD_COMPATIBLE_FLAG
#4	constant SDL_GL_CONTEXT_ROBUST_ACCESS_FLAG
#8	constant SDL_GL_CONTEXT_RESET_ISOLATION_FLAG
#0	constant SDL_GL_CONTEXT_RELEASE_BEHAVIOR_NONE
#1	constant SDL_GL_CONTEXT_RELEASE_BEHAVIOR_FLUSH
#0	constant SDL_GL_CONTEXT_RESET_NO_NOTIFICATION
#1	constant SDL_GL_CONTEXT_RESET_LOSE_CONTEXT
#0	constant SDL_HITTEST_NORMAL
#1	constant SDL_HITTEST_DRAGGABLE
#2	constant SDL_HITTEST_RESIZE_TOPLEFT
#3	constant SDL_HITTEST_RESIZE_TOP
#4	constant SDL_HITTEST_RESIZE_TOPRIGHT
#5	constant SDL_HITTEST_RESIZE_RIGHT
#6	constant SDL_HITTEST_RESIZE_BOTTOMRIGHT
#7	constant SDL_HITTEST_RESIZE_BOTTOM
#8	constant SDL_HITTEST_RESIZE_BOTTOMLEFT
#9	constant SDL_HITTEST_RESIZE_LEFT

\ -------===< structs >===--------
\ SDL_AssertData
begin-structure SDL_AssertData
	drop 8 8 +field SDL_AssertData-condition
	drop 4 4 +field SDL_AssertData-trigger_count
	drop 16 8 +field SDL_AssertData-filename
	drop 32 8 +field SDL_AssertData-function
	drop 0 4 +field SDL_AssertData-always_ignore
	drop 40 8 +field SDL_AssertData-next
	drop 24 4 +field SDL_AssertData-linenum
drop 48 end-structure
\ SDL_atomic_t
begin-structure SDL_atomic_t
	drop 0 4 +field SDL_atomic_t-value
drop 4 end-structure
\ SDL_AudioSpec
begin-structure SDL_AudioSpec
	drop 0 4 +field SDL_AudioSpec-freq
	drop 6 1 +field SDL_AudioSpec-channels
	drop 7 1 +field SDL_AudioSpec-silence
	drop 10 2 +field SDL_AudioSpec-padding
	drop 8 2 +field SDL_AudioSpec-samples
	drop 12 4 +field SDL_AudioSpec-size
	drop 4 2 +field SDL_AudioSpec-format
	drop 16 8 +field SDL_AudioSpec-callback
	drop 24 8 +field SDL_AudioSpec-userdata
drop 32 end-structure
\ SDL_AudioCVT
begin-structure SDL_AudioCVT
	drop 124 4 +field SDL_AudioCVT-filter_index
	drop 8 8 +field SDL_AudioCVT-rate_incr
	drop 24 4 +field SDL_AudioCVT-len
	drop 28 4 +field SDL_AudioCVT-len_cvt
	drop 16 8 +field SDL_AudioCVT-buf
	drop 44 80 +field SDL_AudioCVT-filters
	drop 4 2 +field SDL_AudioCVT-src_format
	drop 6 2 +field SDL_AudioCVT-dst_format
	drop 32 4 +field SDL_AudioCVT-len_mult
	drop 0 4 +field SDL_AudioCVT-needed
	drop 36 8 +field SDL_AudioCVT-len_ratio
drop 128 end-structure
\ SDL_CommonEvent
begin-structure SDL_CommonEvent
	drop 0 4 +field SDL_CommonEvent-type
	drop 4 4 +field SDL_CommonEvent-timestamp
drop 8 end-structure
\ SDL_DisplayEvent
begin-structure SDL_DisplayEvent
	drop 8 4 +field SDL_DisplayEvent-display
	drop 0 4 +field SDL_DisplayEvent-type
	drop 13 1 +field SDL_DisplayEvent-padding1
	drop 16 4 +field SDL_DisplayEvent-data1
	drop 4 4 +field SDL_DisplayEvent-timestamp
	drop 14 1 +field SDL_DisplayEvent-padding2
	drop 12 1 +field SDL_DisplayEvent-event
	drop 15 1 +field SDL_DisplayEvent-padding3
drop 20 end-structure
\ SDL_WindowEvent
begin-structure SDL_WindowEvent
	drop 8 4 +field SDL_WindowEvent-windowID
	drop 0 4 +field SDL_WindowEvent-type
	drop 13 1 +field SDL_WindowEvent-padding1
	drop 16 4 +field SDL_WindowEvent-data1
	drop 4 4 +field SDL_WindowEvent-timestamp
	drop 14 1 +field SDL_WindowEvent-padding2
	drop 20 4 +field SDL_WindowEvent-data2
	drop 12 1 +field SDL_WindowEvent-event
	drop 15 1 +field SDL_WindowEvent-padding3
drop 24 end-structure
\ SDL_KeyboardEvent
begin-structure SDL_KeyboardEvent
	drop 8 4 +field SDL_KeyboardEvent-windowID
	drop 0 4 +field SDL_KeyboardEvent-type
	drop 4 4 +field SDL_KeyboardEvent-timestamp
	drop 12 1 +field SDL_KeyboardEvent-state
	drop 14 1 +field SDL_KeyboardEvent-padding2
	drop 13 1 +field SDL_KeyboardEvent-repeat
	drop 15 1 +field SDL_KeyboardEvent-padding3
	drop 16 16 +field SDL_KeyboardEvent-keysym
drop 32 end-structure
\ SDL_TextEditingEvent
begin-structure SDL_TextEditingEvent
	drop 8 4 +field SDL_TextEditingEvent-windowID
	drop 0 4 +field SDL_TextEditingEvent-type
	drop 12 32 +field SDL_TextEditingEvent-text
	drop 48 4 +field SDL_TextEditingEvent-length
	drop 4 4 +field SDL_TextEditingEvent-timestamp
	drop 44 4 +field SDL_TextEditingEvent-start
drop 52 end-structure
\ SDL_TextInputEvent
begin-structure SDL_TextInputEvent
	drop 8 4 +field SDL_TextInputEvent-windowID
	drop 0 4 +field SDL_TextInputEvent-type
	drop 12 32 +field SDL_TextInputEvent-text
	drop 4 4 +field SDL_TextInputEvent-timestamp
drop 44 end-structure
\ SDL_MouseMotionEvent
begin-structure SDL_MouseMotionEvent
	drop 32 4 +field SDL_MouseMotionEvent-yrel
	drop 20 4 +field SDL_MouseMotionEvent-x
	drop 12 4 +field SDL_MouseMotionEvent-which
	drop 24 4 +field SDL_MouseMotionEvent-y
	drop 8 4 +field SDL_MouseMotionEvent-windowID
	drop 0 4 +field SDL_MouseMotionEvent-type
	drop 4 4 +field SDL_MouseMotionEvent-timestamp
	drop 16 4 +field SDL_MouseMotionEvent-state
	drop 28 4 +field SDL_MouseMotionEvent-xrel
drop 36 end-structure
\ SDL_MouseButtonEvent
begin-structure SDL_MouseButtonEvent
	drop 20 4 +field SDL_MouseButtonEvent-x
	drop 12 4 +field SDL_MouseButtonEvent-which
	drop 24 4 +field SDL_MouseButtonEvent-y
	drop 8 4 +field SDL_MouseButtonEvent-windowID
	drop 16 1 +field SDL_MouseButtonEvent-button
	drop 0 4 +field SDL_MouseButtonEvent-type
	drop 18 1 +field SDL_MouseButtonEvent-clicks
	drop 19 1 +field SDL_MouseButtonEvent-padding1
	drop 4 4 +field SDL_MouseButtonEvent-timestamp
	drop 17 1 +field SDL_MouseButtonEvent-state
drop 28 end-structure
\ SDL_MouseWheelEvent
begin-structure SDL_MouseWheelEvent
	drop 16 4 +field SDL_MouseWheelEvent-x
	drop 12 4 +field SDL_MouseWheelEvent-which
	drop 20 4 +field SDL_MouseWheelEvent-y
	drop 28 4 +field SDL_MouseWheelEvent-preciseX
	drop 8 4 +field SDL_MouseWheelEvent-windowID
	drop 32 4 +field SDL_MouseWheelEvent-preciseY
	drop 0 4 +field SDL_MouseWheelEvent-type
	drop 4 4 +field SDL_MouseWheelEvent-timestamp
	drop 24 4 +field SDL_MouseWheelEvent-direction
drop 36 end-structure
\ SDL_JoyAxisEvent
begin-structure SDL_JoyAxisEvent
	drop 18 2 +field SDL_JoyAxisEvent-padding4
	drop 8 4 +field SDL_JoyAxisEvent-which
	drop 16 2 +field SDL_JoyAxisEvent-value
	drop 0 4 +field SDL_JoyAxisEvent-type
	drop 12 1 +field SDL_JoyAxisEvent-axis
	drop 13 1 +field SDL_JoyAxisEvent-padding1
	drop 4 4 +field SDL_JoyAxisEvent-timestamp
	drop 14 1 +field SDL_JoyAxisEvent-padding2
	drop 15 1 +field SDL_JoyAxisEvent-padding3
drop 20 end-structure
\ SDL_JoyBallEvent
begin-structure SDL_JoyBallEvent
	drop 18 2 +field SDL_JoyBallEvent-yrel
	drop 8 4 +field SDL_JoyBallEvent-which
	drop 0 4 +field SDL_JoyBallEvent-type
	drop 13 1 +field SDL_JoyBallEvent-padding1
	drop 4 4 +field SDL_JoyBallEvent-timestamp
	drop 14 1 +field SDL_JoyBallEvent-padding2
	drop 12 1 +field SDL_JoyBallEvent-ball
	drop 15 1 +field SDL_JoyBallEvent-padding3
	drop 16 2 +field SDL_JoyBallEvent-xrel
drop 20 end-structure
\ SDL_JoyHatEvent
begin-structure SDL_JoyHatEvent
	drop 8 4 +field SDL_JoyHatEvent-which
	drop 13 1 +field SDL_JoyHatEvent-value
	drop 0 4 +field SDL_JoyHatEvent-type
	drop 14 1 +field SDL_JoyHatEvent-padding1
	drop 4 4 +field SDL_JoyHatEvent-timestamp
	drop 12 1 +field SDL_JoyHatEvent-hat
	drop 15 1 +field SDL_JoyHatEvent-padding2
drop 16 end-structure
\ SDL_JoyButtonEvent
begin-structure SDL_JoyButtonEvent
	drop 8 4 +field SDL_JoyButtonEvent-which
	drop 12 1 +field SDL_JoyButtonEvent-button
	drop 0 4 +field SDL_JoyButtonEvent-type
	drop 14 1 +field SDL_JoyButtonEvent-padding1
	drop 4 4 +field SDL_JoyButtonEvent-timestamp
	drop 13 1 +field SDL_JoyButtonEvent-state
	drop 15 1 +field SDL_JoyButtonEvent-padding2
drop 16 end-structure
\ SDL_JoyDeviceEvent
begin-structure SDL_JoyDeviceEvent
	drop 8 4 +field SDL_JoyDeviceEvent-which
	drop 0 4 +field SDL_JoyDeviceEvent-type
	drop 4 4 +field SDL_JoyDeviceEvent-timestamp
drop 12 end-structure
\ SDL_ControllerAxisEvent
begin-structure SDL_ControllerAxisEvent
	drop 18 2 +field SDL_ControllerAxisEvent-padding4
	drop 8 4 +field SDL_ControllerAxisEvent-which
	drop 16 2 +field SDL_ControllerAxisEvent-value
	drop 0 4 +field SDL_ControllerAxisEvent-type
	drop 12 1 +field SDL_ControllerAxisEvent-axis
	drop 13 1 +field SDL_ControllerAxisEvent-padding1
	drop 4 4 +field SDL_ControllerAxisEvent-timestamp
	drop 14 1 +field SDL_ControllerAxisEvent-padding2
	drop 15 1 +field SDL_ControllerAxisEvent-padding3
drop 20 end-structure
\ SDL_ControllerButtonEvent
begin-structure SDL_ControllerButtonEvent
	drop 8 4 +field SDL_ControllerButtonEvent-which
	drop 12 1 +field SDL_ControllerButtonEvent-button
	drop 0 4 +field SDL_ControllerButtonEvent-type
	drop 14 1 +field SDL_ControllerButtonEvent-padding1
	drop 4 4 +field SDL_ControllerButtonEvent-timestamp
	drop 13 1 +field SDL_ControllerButtonEvent-state
	drop 15 1 +field SDL_ControllerButtonEvent-padding2
drop 16 end-structure
\ SDL_ControllerDeviceEvent
begin-structure SDL_ControllerDeviceEvent
	drop 8 4 +field SDL_ControllerDeviceEvent-which
	drop 0 4 +field SDL_ControllerDeviceEvent-type
	drop 4 4 +field SDL_ControllerDeviceEvent-timestamp
drop 12 end-structure
\ SDL_ControllerTouchpadEvent
begin-structure SDL_ControllerTouchpadEvent
	drop 16 4 +field SDL_ControllerTouchpadEvent-finger
	drop 12 4 +field SDL_ControllerTouchpadEvent-touchpad
	drop 20 4 +field SDL_ControllerTouchpadEvent-x
	drop 8 4 +field SDL_ControllerTouchpadEvent-which
	drop 24 4 +field SDL_ControllerTouchpadEvent-y
	drop 0 4 +field SDL_ControllerTouchpadEvent-type
	drop 4 4 +field SDL_ControllerTouchpadEvent-timestamp
	drop 28 4 +field SDL_ControllerTouchpadEvent-pressure
drop 32 end-structure
\ SDL_ControllerSensorEvent
begin-structure SDL_ControllerSensorEvent
	drop 16 12 +field SDL_ControllerSensorEvent-data
	drop 8 4 +field SDL_ControllerSensorEvent-which
	drop 0 4 +field SDL_ControllerSensorEvent-type
	drop 12 4 +field SDL_ControllerSensorEvent-sensor
	drop 4 4 +field SDL_ControllerSensorEvent-timestamp
drop 28 end-structure
\ SDL_AudioDeviceEvent
begin-structure SDL_AudioDeviceEvent
	drop 8 4 +field SDL_AudioDeviceEvent-which
	drop 0 4 +field SDL_AudioDeviceEvent-type
	drop 13 1 +field SDL_AudioDeviceEvent-padding1
	drop 4 4 +field SDL_AudioDeviceEvent-timestamp
	drop 14 1 +field SDL_AudioDeviceEvent-padding2
	drop 12 1 +field SDL_AudioDeviceEvent-iscapture
	drop 15 1 +field SDL_AudioDeviceEvent-padding3
drop 16 end-structure
\ SDL_TouchFingerEvent
begin-structure SDL_TouchFingerEvent
	drop 8 8 +field SDL_TouchFingerEvent-touchId
	drop 24 4 +field SDL_TouchFingerEvent-x
	drop 28 4 +field SDL_TouchFingerEvent-y
	drop 32 4 +field SDL_TouchFingerEvent-dx
	drop 36 4 +field SDL_TouchFingerEvent-dy
	drop 44 4 +field SDL_TouchFingerEvent-windowID
	drop 0 4 +field SDL_TouchFingerEvent-type
	drop 4 4 +field SDL_TouchFingerEvent-timestamp
	drop 40 4 +field SDL_TouchFingerEvent-pressure
	drop 16 8 +field SDL_TouchFingerEvent-fingerId
drop 48 end-structure
\ SDL_MultiGestureEvent
begin-structure SDL_MultiGestureEvent
	drop 8 8 +field SDL_MultiGestureEvent-touchId
	drop 16 4 +field SDL_MultiGestureEvent-dTheta
	drop 20 4 +field SDL_MultiGestureEvent-dDist
	drop 24 4 +field SDL_MultiGestureEvent-x
	drop 28 4 +field SDL_MultiGestureEvent-y
	drop 34 2 +field SDL_MultiGestureEvent-padding
	drop 0 4 +field SDL_MultiGestureEvent-type
	drop 4 4 +field SDL_MultiGestureEvent-timestamp
	drop 32 2 +field SDL_MultiGestureEvent-numFingers
drop 40 end-structure
\ SDL_DollarGestureEvent
begin-structure SDL_DollarGestureEvent
	drop 8 8 +field SDL_DollarGestureEvent-touchId
	drop 32 4 +field SDL_DollarGestureEvent-x
	drop 28 4 +field SDL_DollarGestureEvent-error
	drop 36 4 +field SDL_DollarGestureEvent-y
	drop 0 4 +field SDL_DollarGestureEvent-type
	drop 4 4 +field SDL_DollarGestureEvent-timestamp
	drop 16 8 +field SDL_DollarGestureEvent-gestureId
	drop 24 4 +field SDL_DollarGestureEvent-numFingers
drop 40 end-structure
\ SDL_DropEvent
begin-structure SDL_DropEvent
	drop 16 4 +field SDL_DropEvent-windowID
	drop 0 4 +field SDL_DropEvent-type
	drop 4 4 +field SDL_DropEvent-timestamp
	drop 8 8 +field SDL_DropEvent-file
drop 24 end-structure
\ SDL_SensorEvent
begin-structure SDL_SensorEvent
	drop 12 24 +field SDL_SensorEvent-data
	drop 8 4 +field SDL_SensorEvent-which
	drop 0 4 +field SDL_SensorEvent-type
	drop 4 4 +field SDL_SensorEvent-timestamp
drop 36 end-structure
\ SDL_QuitEvent
begin-structure SDL_QuitEvent
	drop 0 4 +field SDL_QuitEvent-type
	drop 4 4 +field SDL_QuitEvent-timestamp
drop 8 end-structure
\ SDL_OSEvent
begin-structure SDL_OSEvent
	drop 0 4 +field SDL_OSEvent-type
	drop 4 4 +field SDL_OSEvent-timestamp
drop 8 end-structure
\ SDL_UserEvent
begin-structure SDL_UserEvent
	drop 8 4 +field SDL_UserEvent-windowID
	drop 12 4 +field SDL_UserEvent-code
	drop 0 4 +field SDL_UserEvent-type
	drop 16 8 +field SDL_UserEvent-data1
	drop 4 4 +field SDL_UserEvent-timestamp
	drop 24 8 +field SDL_UserEvent-data2
drop 32 end-structure
\ SDL_SysWMEvent
begin-structure SDL_SysWMEvent
	drop 0 4 +field SDL_SysWMEvent-type
	drop 8 8 +field SDL_SysWMEvent-msg
	drop 4 4 +field SDL_SysWMEvent-timestamp
drop 16 end-structure
\ SDL_Event
begin-structure SDL_Event
	drop 0 16 +field SDL_Event-jhat
	drop 0 24 +field SDL_Event-window
	drop 0 12 +field SDL_Event-cdevice
	drop 0 16 +field SDL_Event-adevice
	drop 0 36 +field SDL_Event-sensor
	drop 0 20 +field SDL_Event-jball
	drop 0 20 +field SDL_Event-caxis
	drop 0 16 +field SDL_Event-jbutton
	drop 0 28 +field SDL_Event-button
	drop 0 28 +field SDL_Event-csensor
	drop 0 36 +field SDL_Event-wheel
	drop 0 36 +field SDL_Event-motion
	drop 0 40 +field SDL_Event-mgesture
	drop 0 40 +field SDL_Event-dgesture
	drop 0 24 +field SDL_Event-drop
	drop 0 8 +field SDL_Event-common
	drop 0 32 +field SDL_Event-key
	drop 0 52 +field SDL_Event-edit
	drop 0 20 +field SDL_Event-display
	drop 0 16 +field SDL_Event-cbutton
	drop 0 32 +field SDL_Event-ctouchpad
	drop 0 48 +field SDL_Event-tfinger
	drop 0 4 +field SDL_Event-type
	drop 0 20 +field SDL_Event-jaxis
	drop 0 12 +field SDL_Event-jdevice
	drop 0 16 +field SDL_Event-syswm
	drop 0 56 +field SDL_Event-padding
	drop 0 8 +field SDL_Event-quit
	drop 0 32 +field SDL_Event-user
	drop 0 44 +field SDL_Event-text
drop 56 end-structure
\ SDL_HapticDirection
begin-structure SDL_HapticDirection
	drop 0 1 +field SDL_HapticDirection-type
	drop 4 12 +field SDL_HapticDirection-dir
drop 16 end-structure
\ SDL_HapticConstant
begin-structure SDL_HapticConstant
	drop 30 2 +field SDL_HapticConstant-level
	drop 24 2 +field SDL_HapticConstant-delay
	drop 26 2 +field SDL_HapticConstant-button
	drop 28 2 +field SDL_HapticConstant-interval
	drop 32 2 +field SDL_HapticConstant-attack_length
	drop 36 2 +field SDL_HapticConstant-fade_length
	drop 0 2 +field SDL_HapticConstant-type
	drop 20 4 +field SDL_HapticConstant-length
	drop 34 2 +field SDL_HapticConstant-attack_level
	drop 38 2 +field SDL_HapticConstant-fade_level
	drop 4 16 +field SDL_HapticConstant-direction
drop 40 end-structure
\ SDL_HapticPeriodic
begin-structure SDL_HapticPeriodic
	drop 4 16 +field SDL_HapticPeriodic-direction
	drop 20 4 +field SDL_HapticPeriodic-length
	drop 44 2 +field SDL_HapticPeriodic-fade_level
	drop 40 2 +field SDL_HapticPeriodic-attack_level
	drop 28 2 +field SDL_HapticPeriodic-interval
	drop 26 2 +field SDL_HapticPeriodic-button
	drop 42 2 +field SDL_HapticPeriodic-fade_length
	drop 38 2 +field SDL_HapticPeriodic-attack_length
	drop 34 2 +field SDL_HapticPeriodic-offset
	drop 32 2 +field SDL_HapticPeriodic-magnitude
	drop 30 2 +field SDL_HapticPeriodic-period
	drop 0 2 +field SDL_HapticPeriodic-type
	drop 36 2 +field SDL_HapticPeriodic-phase
	drop 24 2 +field SDL_HapticPeriodic-delay
drop 48 end-structure
\ SDL_HapticCondition
begin-structure SDL_HapticCondition
	drop 30 6 +field SDL_HapticCondition-right_sat
	drop 42 6 +field SDL_HapticCondition-right_coeff
	drop 48 6 +field SDL_HapticCondition-left_coeff
	drop 24 2 +field SDL_HapticCondition-delay
	drop 54 6 +field SDL_HapticCondition-deadband
	drop 26 2 +field SDL_HapticCondition-button
	drop 28 2 +field SDL_HapticCondition-interval
	drop 36 6 +field SDL_HapticCondition-left_sat
	drop 0 2 +field SDL_HapticCondition-type
	drop 20 4 +field SDL_HapticCondition-length
	drop 60 6 +field SDL_HapticCondition-center
	drop 4 16 +field SDL_HapticCondition-direction
drop 68 end-structure
\ SDL_HapticRamp
begin-structure SDL_HapticRamp
	drop 32 2 +field SDL_HapticRamp-end
	drop 24 2 +field SDL_HapticRamp-delay
	drop 26 2 +field SDL_HapticRamp-button
	drop 28 2 +field SDL_HapticRamp-interval
	drop 34 2 +field SDL_HapticRamp-attack_length
	drop 38 2 +field SDL_HapticRamp-fade_length
	drop 0 2 +field SDL_HapticRamp-type
	drop 20 4 +field SDL_HapticRamp-length
	drop 30 2 +field SDL_HapticRamp-start
	drop 36 2 +field SDL_HapticRamp-attack_level
	drop 40 2 +field SDL_HapticRamp-fade_level
	drop 4 16 +field SDL_HapticRamp-direction
drop 44 end-structure
\ SDL_HapticLeftRight
begin-structure SDL_HapticLeftRight
	drop 0 2 +field SDL_HapticLeftRight-type
	drop 4 4 +field SDL_HapticLeftRight-length
	drop 8 2 +field SDL_HapticLeftRight-large_magnitude
	drop 10 2 +field SDL_HapticLeftRight-small_magnitude
drop 12 end-structure
\ SDL_HapticCustom
begin-structure SDL_HapticCustom
	drop 4 16 +field SDL_HapticCustom-direction
	drop 20 4 +field SDL_HapticCustom-length
	drop 54 2 +field SDL_HapticCustom-fade_level
	drop 50 2 +field SDL_HapticCustom-attack_level
	drop 28 2 +field SDL_HapticCustom-interval
	drop 26 2 +field SDL_HapticCustom-button
	drop 34 2 +field SDL_HapticCustom-samples
	drop 52 2 +field SDL_HapticCustom-fade_length
	drop 48 2 +field SDL_HapticCustom-attack_length
	drop 30 1 +field SDL_HapticCustom-channels
	drop 32 2 +field SDL_HapticCustom-period
	drop 0 2 +field SDL_HapticCustom-type
	drop 24 2 +field SDL_HapticCustom-delay
	drop 40 8 +field SDL_HapticCustom-data
drop 56 end-structure
\ SDL_HapticEffect
begin-structure SDL_HapticEffect
	drop 0 68 +field SDL_HapticEffect-condition
	drop 0 44 +field SDL_HapticEffect-ramp
	drop 0 40 +field SDL_HapticEffect-constant
	drop 0 12 +field SDL_HapticEffect-leftright
	drop 0 56 +field SDL_HapticEffect-custom
	drop 0 2 +field SDL_HapticEffect-type
	drop 0 48 +field SDL_HapticEffect-periodic
drop 72 end-structure
\ SDL_hid_device_info
begin-structure SDL_hid_device_info
	drop 64 4 +field SDL_hid_device_info-interface_protocol
	drop 56 4 +field SDL_hid_device_info-interface_class
	drop 52 4 +field SDL_hid_device_info-interface_number
	drop 24 2 +field SDL_hid_device_info-release_number
	drop 16 8 +field SDL_hid_device_info-serial_number
	drop 0 8 +field SDL_hid_device_info-path
	drop 40 8 +field SDL_hid_device_info-product_string
	drop 32 8 +field SDL_hid_device_info-manufacturer_string
	drop 60 4 +field SDL_hid_device_info-interface_subclass
	drop 50 2 +field SDL_hid_device_info-usage
	drop 72 8 +field SDL_hid_device_info-next
	drop 10 2 +field SDL_hid_device_info-product_id
	drop 48 2 +field SDL_hid_device_info-usage_page
	drop 8 2 +field SDL_hid_device_info-vendor_id
drop 80 end-structure
\ SDL_MessageBoxButtonData
begin-structure SDL_MessageBoxButtonData
	drop 4 4 +field SDL_MessageBoxButtonData-buttonid
	drop 8 8 +field SDL_MessageBoxButtonData-text
	drop 0 4 +field SDL_MessageBoxButtonData-flags
drop 16 end-structure
\ SDL_MessageBoxColor
begin-structure SDL_MessageBoxColor
	drop 2 1 +field SDL_MessageBoxColor-b
	drop 0 1 +field SDL_MessageBoxColor-r
	drop 1 1 +field SDL_MessageBoxColor-g
drop 3 end-structure
\ SDL_MessageBoxColorScheme
begin-structure SDL_MessageBoxColorScheme
	drop 0 15 +field SDL_MessageBoxColorScheme-colors
drop 15 end-structure
\ SDL_MessageBoxData
begin-structure SDL_MessageBoxData
	drop 32 4 +field SDL_MessageBoxData-numbuttons
	drop 40 8 +field SDL_MessageBoxData-buttons
	drop 8 8 +field SDL_MessageBoxData-window
	drop 48 8 +field SDL_MessageBoxData-colorScheme
	drop 16 8 +field SDL_MessageBoxData-title
	drop 24 8 +field SDL_MessageBoxData-message
	drop 0 4 +field SDL_MessageBoxData-flags
drop 56 end-structure
\ SDL_RendererInfo
begin-structure SDL_RendererInfo
	drop 0 8 +field SDL_RendererInfo-name
	drop 80 4 +field SDL_RendererInfo-max_texture_width
	drop 84 4 +field SDL_RendererInfo-max_texture_height
	drop 12 4 +field SDL_RendererInfo-num_texture_formats
	drop 16 64 +field SDL_RendererInfo-texture_formats
	drop 8 4 +field SDL_RendererInfo-flags
drop 88 end-structure
\ SDL_Vertex
begin-structure SDL_Vertex
	drop 8 4 +field SDL_Vertex-color
	drop 0 8 +field SDL_Vertex-position
	drop 12 8 +field SDL_Vertex-tex_coord
drop 20 end-structure
\ SDL_RWops
begin-structure SDL_RWops
	drop 24 8 +field SDL_RWops-write
	drop 8 8 +field SDL_RWops-seek
	drop 0 8 +field SDL_RWops-size
	drop 40 4 +field SDL_RWops-type
	drop 48 24 +field SDL_RWops-hidden
	drop 16 8 +field SDL_RWops-read
	drop 32 8 +field SDL_RWops-close
drop 72 end-structure
\ SDL_RWops_hidden
begin-structure SDL_RWops_hidden
	drop 0 16 +field SDL_RWops_hidden-unknown
	drop 0 24 +field SDL_RWops_hidden-mem
drop 24 end-structure
\ SDL_RWops_hidden_unknown
begin-structure SDL_RWops_hidden_unknown
	drop 0 8 +field SDL_RWops_hidden_unknown-data1
	drop 8 8 +field SDL_RWops_hidden_unknown-data2
drop 16 end-structure
\ SDL_RWops_hidden_mem
begin-structure SDL_RWops_hidden_mem
	drop 16 8 +field SDL_RWops_hidden_mem-stop
	drop 8 8 +field SDL_RWops_hidden_mem-here
	drop 0 8 +field SDL_RWops_hidden_mem-base
drop 24 end-structure
\ SDL_WindowShapeParams
begin-structure SDL_WindowShapeParams
	drop 0 4 +field SDL_WindowShapeParams-colorKey
	drop 0 1 +field SDL_WindowShapeParams-binarizationCutoff
drop 4 end-structure
\ SDL_WindowShapeMode
begin-structure SDL_WindowShapeMode
	drop 4 4 +field SDL_WindowShapeMode-parameters
	drop 0 4 +field SDL_WindowShapeMode-mode
drop 8 end-structure
\ SDL_version
begin-structure SDL_version
	drop 0 1 +field SDL_version-major
	drop 1 1 +field SDL_version-minor
	drop 2 1 +field SDL_version-patch
drop 3 end-structure
\ SDL_DisplayMode
begin-structure SDL_DisplayMode
	drop 4 4 +field SDL_DisplayMode-w
	drop 12 4 +field SDL_DisplayMode-refresh_rate
	drop 0 4 +field SDL_DisplayMode-format
	drop 8 4 +field SDL_DisplayMode-h
	drop 16 8 +field SDL_DisplayMode-driverdata
drop 24 end-structure
\ SDL_Locale
begin-structure SDL_Locale
	drop 8 8 +field SDL_Locale-country
	drop 0 8 +field SDL_Locale-language
drop 16 end-structure

\ --===< function pointers >===---
c-funptr SDL_RWops-size() {((struct SDL_RWops*)ptr)->size} a -- d	( context -- )
c-funptr SDL_RWops-seek() {((struct SDL_RWops*)ptr)->seek} a d n -- d	( context offset whence -- )
c-funptr SDL_RWops-read() {((struct SDL_RWops*)ptr)->read} a a u u -- u	( context ptr size maxnum -- )
c-funptr SDL_RWops-write() {((struct SDL_RWops*)ptr)->write} a a u u -- u	( context ptr size num -- )
c-funptr SDL_RWops-close() {((struct SDL_RWops*)ptr)->close} a -- n	( context -- )

\ ------===< callbacks >===-------
c-callback SDL_malloc_func: u -- a	( size -- )
c-callback SDL_calloc_func: u u -- a	( nmemb size -- )
c-callback SDL_realloc_func: a u -- a	( mem size -- )
c-callback SDL_free_func: a -- void	( mem -- )
c-callback SDL_AssertionHandler: a a -- n	( data userdata -- )
c-callback SDL_AudioCallback: a a n -- void	( userdata stream len -- )
c-callback SDL_AudioFilter: a u -- void	( cvt format -- )
c-callback SDL_EventFilter: a a -- n	( userdata event -- )
c-callback SDL_HintCallback: a s s s -- void	( userdata name oldValue newValue -- )
c-callback SDL_LogOutputFunction: a n n s -- void	( userdata category priority message -- )
c-callback SDL_ThreadFunction: a -- n	( data -- )
c-callback SDL_TimerCallback: u a -- u	( interval param -- )
c-callback SDL_HitTest: a a a -- n	( win area data -- )

\ ------===< functions >===-------
c-function SDL_malloc SDL_malloc u -- a	( size -- )
c-function SDL_calloc SDL_calloc u u -- a	( nmemb size -- )
c-function SDL_realloc SDL_realloc a u -- a	( mem size -- )
c-function SDL_free SDL_free a -- void	( mem -- )
c-function SDL_GetMemoryFunctions SDL_GetMemoryFunctions a a a a -- void	( malloc_func calloc_func realloc_func free_func -- )
c-function SDL_SetMemoryFunctions SDL_SetMemoryFunctions a a a a -- n	( malloc_func calloc_func realloc_func free_func -- )
c-function SDL_GetNumAllocations SDL_GetNumAllocations  -- n	( -- )
c-function SDL_getenv SDL_getenv s -- a	( name -- )
c-function SDL_setenv SDL_setenv s s n -- n	( name value overwrite -- )
c-function SDL_qsort SDL_qsort a u u a -- void	( base nmemb size compare -- )
c-function SDL_abs SDL_abs n -- n	( x -- )
c-function SDL_isalpha SDL_isalpha n -- n	( x -- )
c-function SDL_isalnum SDL_isalnum n -- n	( x -- )
c-function SDL_isblank SDL_isblank n -- n	( x -- )
c-function SDL_iscntrl SDL_iscntrl n -- n	( x -- )
c-function SDL_isdigit SDL_isdigit n -- n	( x -- )
c-function SDL_isxdigit SDL_isxdigit n -- n	( x -- )
c-function SDL_ispunct SDL_ispunct n -- n	( x -- )
c-function SDL_isspace SDL_isspace n -- n	( x -- )
c-function SDL_isupper SDL_isupper n -- n	( x -- )
c-function SDL_islower SDL_islower n -- n	( x -- )
c-function SDL_isprint SDL_isprint n -- n	( x -- )
c-function SDL_isgraph SDL_isgraph n -- n	( x -- )
c-function SDL_toupper SDL_toupper n -- n	( x -- )
c-function SDL_tolower SDL_tolower n -- n	( x -- )
c-function SDL_crc32 SDL_crc32 u a u -- u	( crc data len -- )
c-function SDL_memset SDL_memset a n u -- a	( dst c len -- )
c-function SDL_memset4 SDL_memset4 a u u -- void	( dst val dwords -- )
c-function SDL_memcpy SDL_memcpy a a u -- a	( dst src len -- )
c-function SDL_memmove SDL_memmove a a u -- a	( dst src len -- )
c-function SDL_memcmp SDL_memcmp a a u -- n	( s1 s2 len -- )
c-function SDL_wcslen SDL_wcslen ws -- u	( wstr -- )
c-function SDL_wcslcpy SDL_wcslcpy a ws u -- u	( dst src maxlen -- )
c-function SDL_wcslcat SDL_wcslcat a ws u -- u	( dst src maxlen -- )
c-function SDL_wcsdup SDL_wcsdup ws -- a	( wstr -- )
c-function SDL_wcsstr SDL_wcsstr ws ws -- a	( haystack needle -- )
c-function SDL_wcscmp SDL_wcscmp ws ws -- n	( str1 str2 -- )
c-function SDL_wcsncmp SDL_wcsncmp ws ws u -- n	( str1 str2 maxlen -- )
c-function SDL_wcscasecmp SDL_wcscasecmp ws ws -- n	( str1 str2 -- )
c-function SDL_wcsncasecmp SDL_wcsncasecmp ws ws u -- n	( str1 str2 len -- )
c-function SDL_strlen SDL_strlen s -- u	( str -- )
c-function SDL_strlcpy SDL_strlcpy a s u -- u	( dst src maxlen -- )
c-function SDL_utf8strlcpy SDL_utf8strlcpy a s u -- u	( dst src dst_bytes -- )
c-function SDL_strlcat SDL_strlcat a s u -- u	( dst src maxlen -- )
c-function SDL_strdup SDL_strdup s -- a	( str -- )
c-function SDL_strrev SDL_strrev a -- a	( str -- )
c-function SDL_strupr SDL_strupr a -- a	( str -- )
c-function SDL_strlwr SDL_strlwr a -- a	( str -- )
c-function SDL_strchr SDL_strchr s n -- a	( str c -- )
c-function SDL_strrchr SDL_strrchr s n -- a	( str c -- )
c-function SDL_strstr SDL_strstr s s -- a	( haystack needle -- )
c-function SDL_strtokr SDL_strtokr a s a -- a	( s1 s2 saveptr -- )
c-function SDL_utf8strlen SDL_utf8strlen s -- u	( str -- )
c-function SDL_itoa SDL_itoa n a n -- a	( value str radix -- )
c-function SDL_uitoa SDL_uitoa u a n -- a	( value str radix -- )
c-function SDL_ltoa SDL_ltoa n a n -- a	( value str radix -- )
c-function SDL_ultoa SDL_ultoa u a n -- a	( value str radix -- )
c-function SDL_lltoa SDL_lltoa d a n -- a	( value str radix -- )
c-function SDL_ulltoa SDL_ulltoa ud a n -- a	( value str radix -- )
c-function SDL_atoi SDL_atoi s -- n	( str -- )
c-function SDL_atof SDL_atof s -- r	( str -- )
c-function SDL_strtol SDL_strtol s a n -- n	( str endp base -- )
c-function SDL_strtoul SDL_strtoul s a n -- u	( str endp base -- )
c-function SDL_strtoll SDL_strtoll s a n -- d	( str endp base -- )
c-function SDL_strtoull SDL_strtoull s a n -- ud	( str endp base -- )
c-function SDL_strtod SDL_strtod s a -- r	( str endp -- )
c-function SDL_strcmp SDL_strcmp s s -- n	( str1 str2 -- )
c-function SDL_strncmp SDL_strncmp s s u -- n	( str1 str2 maxlen -- )
c-function SDL_strcasecmp SDL_strcasecmp s s -- n	( str1 str2 -- )
c-function SDL_strncasecmp SDL_strncasecmp s s u -- n	( str1 str2 len -- )
c-function SDL_sscanf SDL_sscanf s s ... -- n	( text fmt <noname> -- )
c-function SDL_vsscanf SDL_vsscanf s s a -- n	( text fmt ap -- )
c-function SDL_snprintf SDL_snprintf a u s ... -- n	( text maxlen fmt <noname> -- )
c-function SDL_vsnprintf SDL_vsnprintf a u s a -- n	( text maxlen fmt ap -- )
c-function SDL_asprintf SDL_asprintf a s ... -- n	( strp fmt <noname> -- )
c-function SDL_vasprintf SDL_vasprintf a s a -- n	( strp fmt ap -- )
c-function SDL_acos SDL_acos r -- r	( x -- )
c-function SDL_acosf SDL_acosf r -- r	( x -- )
c-function SDL_asin SDL_asin r -- r	( x -- )
c-function SDL_asinf SDL_asinf r -- r	( x -- )
c-function SDL_atan SDL_atan r -- r	( x -- )
c-function SDL_atanf SDL_atanf r -- r	( x -- )
c-function SDL_atan2 SDL_atan2 r r -- r	( y x -- )
c-function SDL_atan2f SDL_atan2f r r -- r	( y x -- )
c-function SDL_ceil SDL_ceil r -- r	( x -- )
c-function SDL_ceilf SDL_ceilf r -- r	( x -- )
c-function SDL_copysign SDL_copysign r r -- r	( x y -- )
c-function SDL_copysignf SDL_copysignf r r -- r	( x y -- )
c-function SDL_cos SDL_cos r -- r	( x -- )
c-function SDL_cosf SDL_cosf r -- r	( x -- )
c-function SDL_exp SDL_exp r -- r	( x -- )
c-function SDL_expf SDL_expf r -- r	( x -- )
c-function SDL_fabs SDL_fabs r -- r	( x -- )
c-function SDL_fabsf SDL_fabsf r -- r	( x -- )
c-function SDL_floor SDL_floor r -- r	( x -- )
c-function SDL_floorf SDL_floorf r -- r	( x -- )
c-function SDL_trunc SDL_trunc r -- r	( x -- )
c-function SDL_truncf SDL_truncf r -- r	( x -- )
c-function SDL_fmod SDL_fmod r r -- r	( x y -- )
c-function SDL_fmodf SDL_fmodf r r -- r	( x y -- )
c-function SDL_log SDL_log r -- r	( x -- )
c-function SDL_logf SDL_logf r -- r	( x -- )
c-function SDL_log10 SDL_log10 r -- r	( x -- )
c-function SDL_log10f SDL_log10f r -- r	( x -- )
c-function SDL_pow SDL_pow r r -- r	( x y -- )
c-function SDL_powf SDL_powf r r -- r	( x y -- )
c-function SDL_round SDL_round r -- r	( x -- )
c-function SDL_roundf SDL_roundf r -- r	( x -- )
c-function SDL_lround SDL_lround r -- n	( x -- )
c-function SDL_lroundf SDL_lroundf r -- n	( x -- )
c-function SDL_scalbn SDL_scalbn r n -- r	( x n -- )
c-function SDL_scalbnf SDL_scalbnf r n -- r	( x n -- )
c-function SDL_sin SDL_sin r -- r	( x -- )
c-function SDL_sinf SDL_sinf r -- r	( x -- )
c-function SDL_sqrt SDL_sqrt r -- r	( x -- )
c-function SDL_sqrtf SDL_sqrtf r -- r	( x -- )
c-function SDL_tan SDL_tan r -- r	( x -- )
c-function SDL_tanf SDL_tanf r -- r	( x -- )
c-function SDL_iconv_open SDL_iconv_open s s -- a	( tocode fromcode -- )
c-function SDL_iconv_close SDL_iconv_close a -- n	( cd -- )
c-function SDL_iconv SDL_iconv a a a a a -- u	( cd inbuf inbytesleft outbuf outbytesleft -- )
c-function SDL_iconv_string SDL_iconv_string s s s u -- a	( tocode fromcode inbuf inbytesleft -- )
c-function SDL_memcpy4 SDL_memcpy4 a a u -- a	( dst src dwords -- )
c-function SDL_ReportAssertion SDL_ReportAssertion a s s n -- n	( <noname> <noname> <noname> <noname> -- )
c-function SDL_SetAssertionHandler SDL_SetAssertionHandler a a -- void	( handler userdata -- )
c-function SDL_GetDefaultAssertionHandler SDL_GetDefaultAssertionHandler  -- a	( -- )
c-function SDL_GetAssertionHandler SDL_GetAssertionHandler a -- a	( puserdata -- )
c-function SDL_GetAssertionReport SDL_GetAssertionReport  -- a	( -- )
c-function SDL_ResetAssertionReport SDL_ResetAssertionReport  -- void	( -- )
c-function SDL_AtomicTryLock SDL_AtomicTryLock a -- n	( lock -- )
c-function SDL_AtomicLock SDL_AtomicLock a -- void	( lock -- )
c-function SDL_AtomicUnlock SDL_AtomicUnlock a -- void	( lock -- )
c-function SDL_MemoryBarrierReleaseFunction SDL_MemoryBarrierReleaseFunction  -- void	( -- )
c-function SDL_MemoryBarrierAcquireFunction SDL_MemoryBarrierAcquireFunction  -- void	( -- )
c-function SDL_AtomicCAS SDL_AtomicCAS a n n -- n	( a oldval newval -- )
c-function SDL_AtomicSet SDL_AtomicSet a n -- n	( a v -- )
c-function SDL_AtomicGet SDL_AtomicGet a -- n	( a -- )
c-function SDL_AtomicAdd SDL_AtomicAdd a n -- n	( a v -- )
c-function SDL_AtomicCASPtr SDL_AtomicCASPtr a a a -- n	( a oldval newval -- )
c-function SDL_AtomicSetPtr SDL_AtomicSetPtr a a -- a	( a v -- )
c-function SDL_AtomicGetPtr SDL_AtomicGetPtr a -- a	( a -- )
c-function SDL_GetNumAudioDrivers SDL_GetNumAudioDrivers  -- n	( -- )
c-function SDL_GetAudioDriver SDL_GetAudioDriver n -- s	( index -- )
c-function SDL_AudioInit SDL_AudioInit s -- n	( driver_name -- )
c-function SDL_AudioQuit SDL_AudioQuit  -- void	( -- )
c-function SDL_GetCurrentAudioDriver SDL_GetCurrentAudioDriver  -- s	( -- )
c-function SDL_OpenAudio SDL_OpenAudio a a -- n	( desired obtained -- )
c-function SDL_GetNumAudioDevices SDL_GetNumAudioDevices n -- n	( iscapture -- )
c-function SDL_GetAudioDeviceName SDL_GetAudioDeviceName n n -- s	( index iscapture -- )
c-function SDL_GetAudioDeviceSpec SDL_GetAudioDeviceSpec n n a -- n	( index iscapture spec -- )
c-function SDL_OpenAudioDevice SDL_OpenAudioDevice s n a a n -- u	( device iscapture desired obtained allowed_changes -- )
c-function SDL_GetAudioStatus SDL_GetAudioStatus  -- n	( -- )
c-function SDL_GetAudioDeviceStatus SDL_GetAudioDeviceStatus u -- n	( dev -- )
c-function SDL_PauseAudio SDL_PauseAudio n -- void	( pause_on -- )
c-function SDL_PauseAudioDevice SDL_PauseAudioDevice u n -- void	( dev pause_on -- )
c-function SDL_LoadWAV_RW SDL_LoadWAV_RW a n a a a -- a	( src freesrc spec audio_buf audio_len -- )
c-function SDL_FreeWAV SDL_FreeWAV a -- void	( audio_buf -- )
c-function SDL_BuildAudioCVT SDL_BuildAudioCVT a u u n u u n -- n	( cvt src_format src_channels src_rate dst_format dst_channels dst_rate -- )
c-function SDL_ConvertAudio SDL_ConvertAudio a -- n	( cvt -- )
c-function SDL_NewAudioStream SDL_NewAudioStream u u n u u n -- a	( src_format src_channels src_rate dst_format dst_channels dst_rate -- )
c-function SDL_AudioStreamPut SDL_AudioStreamPut a a n -- n	( stream buf len -- )
c-function SDL_AudioStreamGet SDL_AudioStreamGet a a n -- n	( stream buf len -- )
c-function SDL_AudioStreamAvailable SDL_AudioStreamAvailable a -- n	( stream -- )
c-function SDL_AudioStreamFlush SDL_AudioStreamFlush a -- n	( stream -- )
c-function SDL_AudioStreamClear SDL_AudioStreamClear a -- void	( stream -- )
c-function SDL_FreeAudioStream SDL_FreeAudioStream a -- void	( stream -- )
c-function SDL_MixAudio SDL_MixAudio a a u n -- void	( dst src len volume -- )
c-function SDL_MixAudioFormat SDL_MixAudioFormat a a u u n -- void	( dst src format len volume -- )
c-function SDL_QueueAudio SDL_QueueAudio u a u -- n	( dev data len -- )
c-function SDL_DequeueAudio SDL_DequeueAudio u a u -- u	( dev data len -- )
c-function SDL_GetQueuedAudioSize SDL_GetQueuedAudioSize u -- u	( dev -- )
c-function SDL_ClearQueuedAudio SDL_ClearQueuedAudio u -- void	( dev -- )
c-function SDL_LockAudio SDL_LockAudio  -- void	( -- )
c-function SDL_LockAudioDevice SDL_LockAudioDevice u -- void	( dev -- )
c-function SDL_UnlockAudio SDL_UnlockAudio  -- void	( -- )
c-function SDL_UnlockAudioDevice SDL_UnlockAudioDevice u -- void	( dev -- )
c-function SDL_CloseAudio SDL_CloseAudio  -- void	( -- )
c-function SDL_CloseAudioDevice SDL_CloseAudioDevice u -- void	( dev -- )
c-function SDL_SetClipboardText SDL_SetClipboardText s -- n	( text -- )
c-function SDL_GetClipboardText SDL_GetClipboardText  -- a	( -- )
c-function SDL_HasClipboardText SDL_HasClipboardText  -- n	( -- )
c-function SDL_GetCPUCount SDL_GetCPUCount  -- n	( -- )
c-function SDL_GetCPUCacheLineSize SDL_GetCPUCacheLineSize  -- n	( -- )
c-function SDL_HasRDTSC SDL_HasRDTSC  -- n	( -- )
c-function SDL_HasAltiVec SDL_HasAltiVec  -- n	( -- )
c-function SDL_HasMMX SDL_HasMMX  -- n	( -- )
c-function SDL_Has3DNow SDL_Has3DNow  -- n	( -- )
c-function SDL_HasSSE SDL_HasSSE  -- n	( -- )
c-function SDL_HasSSE2 SDL_HasSSE2  -- n	( -- )
c-function SDL_HasSSE3 SDL_HasSSE3  -- n	( -- )
c-function SDL_HasSSE41 SDL_HasSSE41  -- n	( -- )
c-function SDL_HasSSE42 SDL_HasSSE42  -- n	( -- )
c-function SDL_HasAVX SDL_HasAVX  -- n	( -- )
c-function SDL_HasAVX2 SDL_HasAVX2  -- n	( -- )
c-function SDL_HasAVX512F SDL_HasAVX512F  -- n	( -- )
c-function SDL_HasARMSIMD SDL_HasARMSIMD  -- n	( -- )
c-function SDL_HasNEON SDL_HasNEON  -- n	( -- )
c-function SDL_GetSystemRAM SDL_GetSystemRAM  -- n	( -- )
c-function SDL_SIMDGetAlignment SDL_SIMDGetAlignment  -- u	( -- )
c-function SDL_SIMDAlloc SDL_SIMDAlloc u -- a	( len -- )
c-function SDL_SIMDRealloc SDL_SIMDRealloc a u -- a	( mem len -- )
c-function SDL_SIMDFree SDL_SIMDFree a -- void	( ptr -- )
c-function SDL_Swap16 SDL_Swap16 u -- u	( x -- )
c-function SDL_Swap32 SDL_Swap32 u -- u	( x -- )
c-function SDL_Swap64 SDL_Swap64 ud -- ud	( x -- )
c-function SDL_SwapFloat SDL_SwapFloat r -- r	( x -- )
c-function SDL_SetError SDL_SetError s ... -- n	( fmt <noname> -- )
c-function SDL_GetError SDL_GetError  -- s	( -- )
c-function SDL_GetErrorMsg SDL_GetErrorMsg a n -- a	( errstr maxlen -- )
c-function SDL_ClearError SDL_ClearError  -- void	( -- )
c-function SDL_Error SDL_Error n -- n	( code -- )
c-function SDL_PumpEvents SDL_PumpEvents  -- void	( -- )
c-function SDL_PeepEvents SDL_PeepEvents a n n u u -- n	( events numevents action minType maxType -- )
c-function SDL_HasEvent SDL_HasEvent u -- n	( type -- )
c-function SDL_HasEvents SDL_HasEvents u u -- n	( minType maxType -- )
c-function SDL_FlushEvent SDL_FlushEvent u -- void	( type -- )
c-function SDL_FlushEvents SDL_FlushEvents u u -- void	( minType maxType -- )
c-function SDL_PollEvent SDL_PollEvent a -- n	( event -- )
c-function SDL_WaitEvent SDL_WaitEvent a -- n	( event -- )
c-function SDL_WaitEventTimeout SDL_WaitEventTimeout a n -- n	( event timeout -- )
c-function SDL_PushEvent SDL_PushEvent a -- n	( event -- )
c-function SDL_SetEventFilter SDL_SetEventFilter a a -- void	( filter userdata -- )
c-function SDL_GetEventFilter SDL_GetEventFilter a a -- n	( filter userdata -- )
c-function SDL_AddEventWatch SDL_AddEventWatch a a -- void	( filter userdata -- )
c-function SDL_DelEventWatch SDL_DelEventWatch a a -- void	( filter userdata -- )
c-function SDL_FilterEvents SDL_FilterEvents a a -- void	( filter userdata -- )
c-function SDL_EventState SDL_EventState u n -- u	( type state -- )
c-function SDL_RegisterEvents SDL_RegisterEvents n -- u	( numevents -- )
c-function SDL_GetBasePath SDL_GetBasePath  -- a	( -- )
c-function SDL_GetPrefPath SDL_GetPrefPath s s -- a	( org app -- )
c-function SDL_NumHaptics SDL_NumHaptics  -- n	( -- )
c-function SDL_HapticName SDL_HapticName n -- s	( device_index -- )
c-function SDL_HapticOpen SDL_HapticOpen n -- a	( device_index -- )
c-function SDL_HapticOpened SDL_HapticOpened n -- n	( device_index -- )
c-function SDL_HapticIndex SDL_HapticIndex a -- n	( haptic -- )
c-function SDL_MouseIsHaptic SDL_MouseIsHaptic  -- n	( -- )
c-function SDL_HapticOpenFromMouse SDL_HapticOpenFromMouse  -- a	( -- )
c-function SDL_JoystickIsHaptic SDL_JoystickIsHaptic a -- n	( joystick -- )
c-function SDL_HapticOpenFromJoystick SDL_HapticOpenFromJoystick a -- a	( joystick -- )
c-function SDL_HapticClose SDL_HapticClose a -- void	( haptic -- )
c-function SDL_HapticNumEffects SDL_HapticNumEffects a -- n	( haptic -- )
c-function SDL_HapticNumEffectsPlaying SDL_HapticNumEffectsPlaying a -- n	( haptic -- )
c-function SDL_HapticQuery SDL_HapticQuery a -- u	( haptic -- )
c-function SDL_HapticNumAxes SDL_HapticNumAxes a -- n	( haptic -- )
c-function SDL_HapticEffectSupported SDL_HapticEffectSupported a a -- n	( haptic effect -- )
c-function SDL_HapticNewEffect SDL_HapticNewEffect a a -- n	( haptic effect -- )
c-function SDL_HapticUpdateEffect SDL_HapticUpdateEffect a n a -- n	( haptic effect data -- )
c-function SDL_HapticRunEffect SDL_HapticRunEffect a n u -- n	( haptic effect iterations -- )
c-function SDL_HapticStopEffect SDL_HapticStopEffect a n -- n	( haptic effect -- )
c-function SDL_HapticDestroyEffect SDL_HapticDestroyEffect a n -- void	( haptic effect -- )
c-function SDL_HapticGetEffectStatus SDL_HapticGetEffectStatus a n -- n	( haptic effect -- )
c-function SDL_HapticSetGain SDL_HapticSetGain a n -- n	( haptic gain -- )
c-function SDL_HapticSetAutocenter SDL_HapticSetAutocenter a n -- n	( haptic autocenter -- )
c-function SDL_HapticPause SDL_HapticPause a -- n	( haptic -- )
c-function SDL_HapticUnpause SDL_HapticUnpause a -- n	( haptic -- )
c-function SDL_HapticStopAll SDL_HapticStopAll a -- n	( haptic -- )
c-function SDL_HapticRumbleSupported SDL_HapticRumbleSupported a -- n	( haptic -- )
c-function SDL_HapticRumbleInit SDL_HapticRumbleInit a -- n	( haptic -- )
c-function SDL_HapticRumblePlay SDL_HapticRumblePlay a r u -- n	( haptic strength length -- )
c-function SDL_HapticRumbleStop SDL_HapticRumbleStop a -- n	( haptic -- )
c-function SDL_hid_init SDL_hid_init  -- n	( -- )
c-function SDL_hid_exit SDL_hid_exit  -- n	( -- )
c-function SDL_hid_device_change_count SDL_hid_device_change_count  -- u	( -- )
c-function SDL_hid_enumerate SDL_hid_enumerate u u -- a	( vendor_id product_id -- )
c-function SDL_hid_free_enumeration SDL_hid_free_enumeration a -- void	( devs -- )
c-function SDL_hid_open SDL_hid_open u u ws -- a	( vendor_id product_id serial_number -- )
c-function SDL_hid_open_path SDL_hid_open_path s n -- a	( path bExclusive -- )
c-function SDL_hid_write SDL_hid_write a a u -- n	( dev data length -- )
c-function SDL_hid_read_timeout SDL_hid_read_timeout a a u n -- n	( dev data length milliseconds -- )
c-function SDL_hid_read SDL_hid_read a a u -- n	( dev data length -- )
c-function SDL_hid_set_nonblocking SDL_hid_set_nonblocking a n -- n	( dev nonblock -- )
c-function SDL_hid_send_feature_report SDL_hid_send_feature_report a a u -- n	( dev data length -- )
c-function SDL_hid_get_feature_report SDL_hid_get_feature_report a a u -- n	( dev data length -- )
c-function SDL_hid_close SDL_hid_close a -- void	( dev -- )
c-function SDL_hid_get_manufacturer_string SDL_hid_get_manufacturer_string a a u -- n	( dev string maxlen -- )
c-function SDL_hid_get_product_string SDL_hid_get_product_string a a u -- n	( dev string maxlen -- )
c-function SDL_hid_get_serial_number_string SDL_hid_get_serial_number_string a a u -- n	( dev string maxlen -- )
c-function SDL_hid_get_indexed_string SDL_hid_get_indexed_string a n a u -- n	( dev string_index string maxlen -- )
c-function SDL_hid_ble_scan SDL_hid_ble_scan n -- void	( active -- )
c-function SDL_SetHintWithPriority SDL_SetHintWithPriority s s n -- n	( name value priority -- )
c-function SDL_SetHint SDL_SetHint s s -- n	( name value -- )
c-function SDL_GetHint SDL_GetHint s -- s	( name -- )
c-function SDL_GetHintBoolean SDL_GetHintBoolean s n -- n	( name default_value -- )
c-function SDL_AddHintCallback SDL_AddHintCallback s a a -- void	( name callback userdata -- )
c-function SDL_DelHintCallback SDL_DelHintCallback s a a -- void	( name callback userdata -- )
c-function SDL_ClearHints SDL_ClearHints  -- void	( -- )
c-function SDL_LoadObject SDL_LoadObject s -- a	( sofile -- )
c-function SDL_LoadFunction SDL_LoadFunction a s -- a	( handle name -- )
c-function SDL_UnloadObject SDL_UnloadObject a -- void	( handle -- )
c-function SDL_LogSetAllPriority SDL_LogSetAllPriority n -- void	( priority -- )
c-function SDL_LogSetPriority SDL_LogSetPriority n n -- void	( category priority -- )
c-function SDL_LogGetPriority SDL_LogGetPriority n -- n	( category -- )
c-function SDL_LogResetPriorities SDL_LogResetPriorities  -- void	( -- )
c-function SDL_Log SDL_Log s ... -- void	( fmt <noname> -- )
c-function SDL_LogVerbose SDL_LogVerbose n s ... -- void	( category fmt <noname> -- )
c-function SDL_LogDebug SDL_LogDebug n s ... -- void	( category fmt <noname> -- )
c-function SDL_LogInfo SDL_LogInfo n s ... -- void	( category fmt <noname> -- )
c-function SDL_LogWarn SDL_LogWarn n s ... -- void	( category fmt <noname> -- )
c-function SDL_LogError SDL_LogError n s ... -- void	( category fmt <noname> -- )
c-function SDL_LogCritical SDL_LogCritical n s ... -- void	( category fmt <noname> -- )
c-function SDL_LogMessage SDL_LogMessage n n s ... -- void	( category priority fmt <noname> -- )
c-function SDL_LogMessageV SDL_LogMessageV n n s a -- void	( category priority fmt ap -- )
c-function SDL_LogGetOutputFunction SDL_LogGetOutputFunction a a -- void	( callback userdata -- )
c-function SDL_LogSetOutputFunction SDL_LogSetOutputFunction a a -- void	( callback userdata -- )
c-function SDL_ShowMessageBox SDL_ShowMessageBox a a -- n	( messageboxdata buttonid -- )
c-function SDL_ShowSimpleMessageBox SDL_ShowSimpleMessageBox u s s a -- n	( flags title message window -- )
c-function SDL_Metal_CreateView SDL_Metal_CreateView a -- a	( window -- )
c-function SDL_Metal_DestroyView SDL_Metal_DestroyView a -- void	( view -- )
c-function SDL_Metal_GetLayer SDL_Metal_GetLayer a -- a	( view -- )
c-function SDL_Metal_GetDrawableSize SDL_Metal_GetDrawableSize a a a -- void	( window w h -- )
c-function SDL_CreateMutex SDL_CreateMutex  -- a	( -- )
c-function SDL_LockMutex SDL_LockMutex a -- n	( mutex -- )
c-function SDL_TryLockMutex SDL_TryLockMutex a -- n	( mutex -- )
c-function SDL_UnlockMutex SDL_UnlockMutex a -- n	( mutex -- )
c-function SDL_DestroyMutex SDL_DestroyMutex a -- void	( mutex -- )
c-function SDL_CreateSemaphore SDL_CreateSemaphore u -- a	( initial_value -- )
c-function SDL_DestroySemaphore SDL_DestroySemaphore a -- void	( sem -- )
c-function SDL_SemWait SDL_SemWait a -- n	( sem -- )
c-function SDL_SemTryWait SDL_SemTryWait a -- n	( sem -- )
c-function SDL_SemWaitTimeout SDL_SemWaitTimeout a u -- n	( sem ms -- )
c-function SDL_SemPost SDL_SemPost a -- n	( sem -- )
c-function SDL_SemValue SDL_SemValue a -- u	( sem -- )
c-function SDL_CreateCond SDL_CreateCond  -- a	( -- )
c-function SDL_DestroyCond SDL_DestroyCond a -- void	( cond -- )
c-function SDL_CondSignal SDL_CondSignal a -- n	( cond -- )
c-function SDL_CondBroadcast SDL_CondBroadcast a -- n	( cond -- )
c-function SDL_CondWait SDL_CondWait a a -- n	( cond mutex -- )
c-function SDL_CondWaitTimeout SDL_CondWaitTimeout a a u -- n	( cond mutex ms -- )
c-function SDL_GetPowerInfo SDL_GetPowerInfo a a -- n	( secs pct -- )
c-function SDL_GetNumRenderDrivers SDL_GetNumRenderDrivers  -- n	( -- )
c-function SDL_GetRenderDriverInfo SDL_GetRenderDriverInfo n a -- n	( index info -- )
c-function SDL_CreateWindowAndRenderer SDL_CreateWindowAndRenderer n n u a a -- n	( width height window_flags window renderer -- )
c-function SDL_CreateRenderer SDL_CreateRenderer a n u -- a	( window index flags -- )
c-function SDL_CreateSoftwareRenderer SDL_CreateSoftwareRenderer a -- a	( surface -- )
c-function SDL_GetRenderer SDL_GetRenderer a -- a	( window -- )
c-function SDL_GetRendererInfo SDL_GetRendererInfo a a -- n	( renderer info -- )
c-function SDL_GetRendererOutputSize SDL_GetRendererOutputSize a a a -- n	( renderer w h -- )
c-function SDL_CreateTexture SDL_CreateTexture a u n n n -- a	( renderer format access w h -- )
c-function SDL_CreateTextureFromSurface SDL_CreateTextureFromSurface a a -- a	( renderer surface -- )
c-function SDL_QueryTexture SDL_QueryTexture a a a a a -- n	( texture format access w h -- )
c-function SDL_SetTextureColorMod SDL_SetTextureColorMod a u u u -- n	( texture r g b -- )
c-function SDL_GetTextureColorMod SDL_GetTextureColorMod a a a a -- n	( texture r g b -- )
c-function SDL_SetTextureAlphaMod SDL_SetTextureAlphaMod a u -- n	( texture alpha -- )
c-function SDL_GetTextureAlphaMod SDL_GetTextureAlphaMod a a -- n	( texture alpha -- )
c-function SDL_SetTextureBlendMode SDL_SetTextureBlendMode a u -- n	( texture blendMode -- )
c-function SDL_GetTextureBlendMode SDL_GetTextureBlendMode a a -- n	( texture blendMode -- )
c-function SDL_SetTextureScaleMode SDL_SetTextureScaleMode a n -- n	( texture scaleMode -- )
c-function SDL_GetTextureScaleMode SDL_GetTextureScaleMode a a -- n	( texture scaleMode -- )
c-function SDL_SetTextureUserData SDL_SetTextureUserData a a -- n	( texture userdata -- )
c-function SDL_GetTextureUserData SDL_GetTextureUserData a -- a	( texture -- )
c-function SDL_UpdateTexture SDL_UpdateTexture a a a n -- n	( texture rect pixels pitch -- )
c-function SDL_UpdateYUVTexture SDL_UpdateYUVTexture a a a n a n a n -- n	( texture rect Yplane Ypitch Uplane Upitch Vplane Vpitch -- )
c-function SDL_UpdateNVTexture SDL_UpdateNVTexture a a a n a n -- n	( texture rect Yplane Ypitch UVplane UVpitch -- )
c-function SDL_LockTexture SDL_LockTexture a a a a -- n	( texture rect pixels pitch -- )
c-function SDL_LockTextureToSurface SDL_LockTextureToSurface a a a -- n	( texture rect surface -- )
c-function SDL_UnlockTexture SDL_UnlockTexture a -- void	( texture -- )
c-function SDL_RenderTargetSupported SDL_RenderTargetSupported a -- n	( renderer -- )
c-function SDL_SetRenderTarget SDL_SetRenderTarget a a -- n	( renderer texture -- )
c-function SDL_GetRenderTarget SDL_GetRenderTarget a -- a	( renderer -- )
c-function SDL_RenderSetLogicalSize SDL_RenderSetLogicalSize a n n -- n	( renderer w h -- )
c-function SDL_RenderGetLogicalSize SDL_RenderGetLogicalSize a a a -- void	( renderer w h -- )
c-function SDL_RenderSetIntegerScale SDL_RenderSetIntegerScale a n -- n	( renderer enable -- )
c-function SDL_RenderGetIntegerScale SDL_RenderGetIntegerScale a -- n	( renderer -- )
c-function SDL_RenderSetViewport SDL_RenderSetViewport a a -- n	( renderer rect -- )
c-function SDL_RenderGetViewport SDL_RenderGetViewport a a -- void	( renderer rect -- )
c-function SDL_RenderSetClipRect SDL_RenderSetClipRect a a -- n	( renderer rect -- )
c-function SDL_RenderGetClipRect SDL_RenderGetClipRect a a -- void	( renderer rect -- )
c-function SDL_RenderIsClipEnabled SDL_RenderIsClipEnabled a -- n	( renderer -- )
c-function SDL_RenderSetScale SDL_RenderSetScale a r r -- n	( renderer scaleX scaleY -- )
c-function SDL_RenderGetScale SDL_RenderGetScale a a a -- void	( renderer scaleX scaleY -- )
c-function SDL_RenderWindowToLogical SDL_RenderWindowToLogical a n n a a -- void	( renderer windowX windowY logicalX logicalY -- )
c-function SDL_RenderLogicalToWindow SDL_RenderLogicalToWindow a r r a a -- void	( renderer logicalX logicalY windowX windowY -- )
c-function SDL_SetRenderDrawColor SDL_SetRenderDrawColor a u u u u -- n	( renderer r g b a -- )
c-function SDL_GetRenderDrawColor SDL_GetRenderDrawColor a a a a a -- n	( renderer r g b a -- )
c-function SDL_SetRenderDrawBlendMode SDL_SetRenderDrawBlendMode a u -- n	( renderer blendMode -- )
c-function SDL_GetRenderDrawBlendMode SDL_GetRenderDrawBlendMode a a -- n	( renderer blendMode -- )
c-function SDL_RenderClear SDL_RenderClear a -- n	( renderer -- )
c-function SDL_RenderDrawPoint SDL_RenderDrawPoint a n n -- n	( renderer x y -- )
c-function SDL_RenderDrawPoints SDL_RenderDrawPoints a a n -- n	( renderer points count -- )
c-function SDL_RenderDrawLine SDL_RenderDrawLine a n n n n -- n	( renderer x1 y1 x2 y2 -- )
c-function SDL_RenderDrawLines SDL_RenderDrawLines a a n -- n	( renderer points count -- )
c-function SDL_RenderDrawRect SDL_RenderDrawRect a a -- n	( renderer rect -- )
c-function SDL_RenderDrawRects SDL_RenderDrawRects a a n -- n	( renderer rects count -- )
c-function SDL_RenderFillRect SDL_RenderFillRect a a -- n	( renderer rect -- )
c-function SDL_RenderFillRects SDL_RenderFillRects a a n -- n	( renderer rects count -- )
c-function SDL_RenderCopy SDL_RenderCopy a a a a -- n	( renderer texture srcrect dstrect -- )
c-function SDL_RenderCopyEx SDL_RenderCopyEx a a a a r a n -- n	( renderer texture srcrect dstrect angle center flip -- )
c-function SDL_RenderDrawPointF SDL_RenderDrawPointF a r r -- n	( renderer x y -- )
c-function SDL_RenderDrawPointsF SDL_RenderDrawPointsF a a n -- n	( renderer points count -- )
c-function SDL_RenderDrawLineF SDL_RenderDrawLineF a r r r r -- n	( renderer x1 y1 x2 y2 -- )
c-function SDL_RenderDrawLinesF SDL_RenderDrawLinesF a a n -- n	( renderer points count -- )
c-function SDL_RenderDrawRectF SDL_RenderDrawRectF a a -- n	( renderer rect -- )
c-function SDL_RenderDrawRectsF SDL_RenderDrawRectsF a a n -- n	( renderer rects count -- )
c-function SDL_RenderFillRectF SDL_RenderFillRectF a a -- n	( renderer rect -- )
c-function SDL_RenderFillRectsF SDL_RenderFillRectsF a a n -- n	( renderer rects count -- )
c-function SDL_RenderCopyF SDL_RenderCopyF a a a a -- n	( renderer texture srcrect dstrect -- )
c-function SDL_RenderCopyExF SDL_RenderCopyExF a a a a r a n -- n	( renderer texture srcrect dstrect angle center flip -- )
c-function SDL_RenderGeometry SDL_RenderGeometry a a a n a n -- n	( renderer texture vertices num_vertices indices num_indices -- )
c-function SDL_RenderGeometryRaw SDL_RenderGeometryRaw a a a n a n a n n a n n -- n	( renderer texture xy xy_stride color color_stride uv uv_stride num_vertices indices num_indices size_indices -- )
c-function SDL_RenderReadPixels SDL_RenderReadPixels a a u a n -- n	( renderer rect format pixels pitch -- )
c-function SDL_RenderPresent SDL_RenderPresent a -- void	( renderer -- )
c-function SDL_DestroyTexture SDL_DestroyTexture a -- void	( texture -- )
c-function SDL_DestroyRenderer SDL_DestroyRenderer a -- void	( renderer -- )
c-function SDL_RenderFlush SDL_RenderFlush a -- n	( renderer -- )
c-function SDL_GL_BindTexture SDL_GL_BindTexture a a a -- n	( texture texw texh -- )
c-function SDL_GL_UnbindTexture SDL_GL_UnbindTexture a -- n	( texture -- )
c-function SDL_RenderGetMetalLayer SDL_RenderGetMetalLayer a -- a	( renderer -- )
c-function SDL_RenderGetMetalCommandEncoder SDL_RenderGetMetalCommandEncoder a -- a	( renderer -- )
c-function SDL_RenderSetVSync SDL_RenderSetVSync a n -- n	( renderer vsync -- )
c-function SDL_RWFromFile SDL_RWFromFile s s -- a	( file mode -- )
c-function SDL_RWFromFP SDL_RWFromFP a n -- a	( fp autoclose -- )
c-function SDL_RWFromMem SDL_RWFromMem a n -- a	( mem size -- )
c-function SDL_RWFromConstMem SDL_RWFromConstMem a n -- a	( mem size -- )
c-function SDL_AllocRW SDL_AllocRW  -- a	( -- )
c-function SDL_FreeRW SDL_FreeRW a -- void	( area -- )
c-function SDL_RWsize SDL_RWsize a -- d	( context -- )
c-function SDL_RWseek SDL_RWseek a d n -- d	( context offset whence -- )
c-function SDL_RWtell SDL_RWtell a -- d	( context -- )
c-function SDL_RWread SDL_RWread a a u u -- u	( context ptr size maxnum -- )
c-function SDL_RWwrite SDL_RWwrite a a u u -- u	( context ptr size num -- )
c-function SDL_RWclose SDL_RWclose a -- n	( context -- )
c-function SDL_LoadFile_RW SDL_LoadFile_RW a a n -- a	( src datasize freesrc -- )
c-function SDL_LoadFile SDL_LoadFile s a -- a	( file datasize -- )
c-function SDL_ReadU8 SDL_ReadU8 a -- u	( src -- )
c-function SDL_ReadLE16 SDL_ReadLE16 a -- u	( src -- )
c-function SDL_ReadBE16 SDL_ReadBE16 a -- u	( src -- )
c-function SDL_ReadLE32 SDL_ReadLE32 a -- u	( src -- )
c-function SDL_ReadBE32 SDL_ReadBE32 a -- u	( src -- )
c-function SDL_ReadLE64 SDL_ReadLE64 a -- ud	( src -- )
c-function SDL_ReadBE64 SDL_ReadBE64 a -- ud	( src -- )
c-function SDL_WriteU8 SDL_WriteU8 a u -- u	( dst value -- )
c-function SDL_WriteLE16 SDL_WriteLE16 a u -- u	( dst value -- )
c-function SDL_WriteBE16 SDL_WriteBE16 a u -- u	( dst value -- )
c-function SDL_WriteLE32 SDL_WriteLE32 a u -- u	( dst value -- )
c-function SDL_WriteBE32 SDL_WriteBE32 a u -- u	( dst value -- )
c-function SDL_WriteLE64 SDL_WriteLE64 a ud -- u	( dst value -- )
c-function SDL_WriteBE64 SDL_WriteBE64 a ud -- u	( dst value -- )
c-function SDL_LockSensors SDL_LockSensors  -- void	( -- )
c-function SDL_UnlockSensors SDL_UnlockSensors  -- void	( -- )
c-function SDL_NumSensors SDL_NumSensors  -- n	( -- )
c-function SDL_SensorGetDeviceName SDL_SensorGetDeviceName n -- s	( device_index -- )
c-function SDL_SensorGetDeviceType SDL_SensorGetDeviceType n -- n	( device_index -- )
c-function SDL_SensorGetDeviceNonPortableType SDL_SensorGetDeviceNonPortableType n -- n	( device_index -- )
c-function SDL_SensorGetDeviceInstanceID SDL_SensorGetDeviceInstanceID n -- n	( device_index -- )
c-function SDL_SensorOpen SDL_SensorOpen n -- a	( device_index -- )
c-function SDL_SensorFromInstanceID SDL_SensorFromInstanceID n -- a	( instance_id -- )
c-function SDL_SensorGetName SDL_SensorGetName a -- s	( sensor -- )
c-function SDL_SensorGetType SDL_SensorGetType a -- n	( sensor -- )
c-function SDL_SensorGetNonPortableType SDL_SensorGetNonPortableType a -- n	( sensor -- )
c-function SDL_SensorGetInstanceID SDL_SensorGetInstanceID a -- n	( sensor -- )
c-function SDL_SensorGetData SDL_SensorGetData a a n -- n	( sensor data num_values -- )
c-function SDL_SensorClose SDL_SensorClose a -- void	( sensor -- )
c-function SDL_SensorUpdate SDL_SensorUpdate  -- void	( -- )
c-function SDL_CreateShapedWindow SDL_CreateShapedWindow s u u u u u -- a	( title x y w h flags -- )
c-function SDL_IsShapedWindow SDL_IsShapedWindow a -- n	( window -- )
c-function SDL_SetWindowShape SDL_SetWindowShape a a a -- n	( window shape shape_mode -- )
c-function SDL_GetShapedWindowMode SDL_GetShapedWindowMode a a -- n	( window shape_mode -- )
c-function SDL_IsTablet SDL_IsTablet  -- n	( -- )
c-function SDL_OnApplicationWillTerminate SDL_OnApplicationWillTerminate  -- void	( -- )
c-function SDL_OnApplicationDidReceiveMemoryWarning SDL_OnApplicationDidReceiveMemoryWarning  -- void	( -- )
c-function SDL_OnApplicationWillResignActive SDL_OnApplicationWillResignActive  -- void	( -- )
c-function SDL_OnApplicationDidEnterBackground SDL_OnApplicationDidEnterBackground  -- void	( -- )
c-function SDL_OnApplicationWillEnterForeground SDL_OnApplicationWillEnterForeground  -- void	( -- )
c-function SDL_OnApplicationDidBecomeActive SDL_OnApplicationDidBecomeActive  -- void	( -- )
c-function SDL_CreateThread SDL_CreateThread a s a -- a	( fn name data -- )
c-function SDL_CreateThreadWithStackSize SDL_CreateThreadWithStackSize a s u a -- a	( fn name stacksize data -- )
c-function SDL_GetThreadName SDL_GetThreadName a -- s	( thread -- )
c-function SDL_ThreadID SDL_ThreadID  -- u	( -- )
c-function SDL_GetThreadID SDL_GetThreadID a -- u	( thread -- )
c-function SDL_SetThreadPriority SDL_SetThreadPriority n -- n	( priority -- )
c-function SDL_WaitThread SDL_WaitThread a a -- void	( thread status -- )
c-function SDL_DetachThread SDL_DetachThread a -- void	( thread -- )
c-function SDL_TLSCreate SDL_TLSCreate  -- u	( -- )
c-function SDL_TLSGet SDL_TLSGet u -- a	( id -- )
c-function SDL_TLSSet SDL_TLSSet u a a -- n	( id value destructor -- )
c-function SDL_TLSCleanup SDL_TLSCleanup  -- void	( -- )
c-function SDL_GetTicks SDL_GetTicks  -- u	( -- )
c-function SDL_GetTicks64 SDL_GetTicks64  -- ud	( -- )
c-function SDL_GetPerformanceCounter SDL_GetPerformanceCounter  -- ud	( -- )
c-function SDL_GetPerformanceFrequency SDL_GetPerformanceFrequency  -- ud	( -- )
c-function SDL_Delay SDL_Delay u -- void	( ms -- )
c-function SDL_AddTimer SDL_AddTimer u a a -- n	( interval callback param -- )
c-function SDL_RemoveTimer SDL_RemoveTimer n -- n	( id -- )
c-function SDL_GetVersion SDL_GetVersion a -- void	( ver -- )
c-function SDL_GetRevision SDL_GetRevision  -- s	( -- )
c-function SDL_GetRevisionNumber SDL_GetRevisionNumber  -- n	( -- )
c-function SDL_GetNumVideoDrivers SDL_GetNumVideoDrivers  -- n	( -- )
c-function SDL_GetVideoDriver SDL_GetVideoDriver n -- s	( index -- )
c-function SDL_VideoInit SDL_VideoInit s -- n	( driver_name -- )
c-function SDL_VideoQuit SDL_VideoQuit  -- void	( -- )
c-function SDL_GetCurrentVideoDriver SDL_GetCurrentVideoDriver  -- s	( -- )
c-function SDL_GetNumVideoDisplays SDL_GetNumVideoDisplays  -- n	( -- )
c-function SDL_GetDisplayName SDL_GetDisplayName n -- s	( displayIndex -- )
c-function SDL_GetDisplayBounds SDL_GetDisplayBounds n a -- n	( displayIndex rect -- )
c-function SDL_GetDisplayUsableBounds SDL_GetDisplayUsableBounds n a -- n	( displayIndex rect -- )
c-function SDL_GetDisplayDPI SDL_GetDisplayDPI n a a a -- n	( displayIndex ddpi hdpi vdpi -- )
c-function SDL_GetDisplayOrientation SDL_GetDisplayOrientation n -- n	( displayIndex -- )
c-function SDL_GetNumDisplayModes SDL_GetNumDisplayModes n -- n	( displayIndex -- )
c-function SDL_GetDisplayMode SDL_GetDisplayMode n n a -- n	( displayIndex modeIndex mode -- )
c-function SDL_GetDesktopDisplayMode SDL_GetDesktopDisplayMode n a -- n	( displayIndex mode -- )
c-function SDL_GetCurrentDisplayMode SDL_GetCurrentDisplayMode n a -- n	( displayIndex mode -- )
c-function SDL_GetClosestDisplayMode SDL_GetClosestDisplayMode n a a -- a	( displayIndex mode closest -- )
c-function SDL_GetWindowDisplayIndex SDL_GetWindowDisplayIndex a -- n	( window -- )
c-function SDL_SetWindowDisplayMode SDL_SetWindowDisplayMode a a -- n	( window mode -- )
c-function SDL_GetWindowDisplayMode SDL_GetWindowDisplayMode a a -- n	( window mode -- )
c-function SDL_GetWindowICCProfile SDL_GetWindowICCProfile a a -- a	( window size -- )
c-function SDL_GetWindowPixelFormat SDL_GetWindowPixelFormat a -- u	( window -- )
c-function SDL_CreateWindow SDL_CreateWindow s n n n n u -- a	( title x y w h flags -- )
c-function SDL_CreateWindowFrom SDL_CreateWindowFrom a -- a	( data -- )
c-function SDL_GetWindowID SDL_GetWindowID a -- u	( window -- )
c-function SDL_GetWindowFromID SDL_GetWindowFromID u -- a	( id -- )
c-function SDL_GetWindowFlags SDL_GetWindowFlags a -- u	( window -- )
c-function SDL_SetWindowTitle SDL_SetWindowTitle a s -- void	( window title -- )
c-function SDL_GetWindowTitle SDL_GetWindowTitle a -- s	( window -- )
c-function SDL_SetWindowIcon SDL_SetWindowIcon a a -- void	( window icon -- )
c-function SDL_SetWindowData SDL_SetWindowData a s a -- a	( window name userdata -- )
c-function SDL_GetWindowData SDL_GetWindowData a s -- a	( window name -- )
c-function SDL_SetWindowPosition SDL_SetWindowPosition a n n -- void	( window x y -- )
c-function SDL_GetWindowPosition SDL_GetWindowPosition a a a -- void	( window x y -- )
c-function SDL_SetWindowSize SDL_SetWindowSize a n n -- void	( window w h -- )
c-function SDL_GetWindowSize SDL_GetWindowSize a a a -- void	( window w h -- )
c-function SDL_GetWindowBordersSize SDL_GetWindowBordersSize a a a a a -- n	( window top left bottom right -- )
c-function SDL_SetWindowMinimumSize SDL_SetWindowMinimumSize a n n -- void	( window min_w min_h -- )
c-function SDL_GetWindowMinimumSize SDL_GetWindowMinimumSize a a a -- void	( window w h -- )
c-function SDL_SetWindowMaximumSize SDL_SetWindowMaximumSize a n n -- void	( window max_w max_h -- )
c-function SDL_GetWindowMaximumSize SDL_GetWindowMaximumSize a a a -- void	( window w h -- )
c-function SDL_SetWindowBordered SDL_SetWindowBordered a n -- void	( window bordered -- )
c-function SDL_SetWindowResizable SDL_SetWindowResizable a n -- void	( window resizable -- )
c-function SDL_SetWindowAlwaysOnTop SDL_SetWindowAlwaysOnTop a n -- void	( window on_top -- )
c-function SDL_ShowWindow SDL_ShowWindow a -- void	( window -- )
c-function SDL_HideWindow SDL_HideWindow a -- void	( window -- )
c-function SDL_RaiseWindow SDL_RaiseWindow a -- void	( window -- )
c-function SDL_MaximizeWindow SDL_MaximizeWindow a -- void	( window -- )
c-function SDL_MinimizeWindow SDL_MinimizeWindow a -- void	( window -- )
c-function SDL_RestoreWindow SDL_RestoreWindow a -- void	( window -- )
c-function SDL_SetWindowFullscreen SDL_SetWindowFullscreen a u -- n	( window flags -- )
c-function SDL_GetWindowSurface SDL_GetWindowSurface a -- a	( window -- )
c-function SDL_UpdateWindowSurface SDL_UpdateWindowSurface a -- n	( window -- )
c-function SDL_UpdateWindowSurfaceRects SDL_UpdateWindowSurfaceRects a a n -- n	( window rects numrects -- )
c-function SDL_SetWindowGrab SDL_SetWindowGrab a n -- void	( window grabbed -- )
c-function SDL_SetWindowKeyboardGrab SDL_SetWindowKeyboardGrab a n -- void	( window grabbed -- )
c-function SDL_SetWindowMouseGrab SDL_SetWindowMouseGrab a n -- void	( window grabbed -- )
c-function SDL_GetWindowGrab SDL_GetWindowGrab a -- n	( window -- )
c-function SDL_GetWindowKeyboardGrab SDL_GetWindowKeyboardGrab a -- n	( window -- )
c-function SDL_GetWindowMouseGrab SDL_GetWindowMouseGrab a -- n	( window -- )
c-function SDL_GetGrabbedWindow SDL_GetGrabbedWindow  -- a	( -- )
c-function SDL_SetWindowMouseRect SDL_SetWindowMouseRect a a -- n	( window rect -- )
c-function SDL_GetWindowMouseRect SDL_GetWindowMouseRect a -- a	( window -- )
c-function SDL_SetWindowBrightness SDL_SetWindowBrightness a r -- n	( window brightness -- )
c-function SDL_GetWindowBrightness SDL_GetWindowBrightness a -- r	( window -- )
c-function SDL_SetWindowOpacity SDL_SetWindowOpacity a r -- n	( window opacity -- )
c-function SDL_GetWindowOpacity SDL_GetWindowOpacity a a -- n	( window out_opacity -- )
c-function SDL_SetWindowModalFor SDL_SetWindowModalFor a a -- n	( modal_window parent_window -- )
c-function SDL_SetWindowInputFocus SDL_SetWindowInputFocus a -- n	( window -- )
c-function SDL_SetWindowGammaRamp SDL_SetWindowGammaRamp a a a a -- n	( window red green blue -- )
c-function SDL_GetWindowGammaRamp SDL_GetWindowGammaRamp a a a a -- n	( window red green blue -- )
c-function SDL_SetWindowHitTest SDL_SetWindowHitTest a a a -- n	( window callback callback_data -- )
c-function SDL_FlashWindow SDL_FlashWindow a n -- n	( window operation -- )
c-function SDL_DestroyWindow SDL_DestroyWindow a -- void	( window -- )
c-function SDL_IsScreenSaverEnabled SDL_IsScreenSaverEnabled  -- n	( -- )
c-function SDL_EnableScreenSaver SDL_EnableScreenSaver  -- void	( -- )
c-function SDL_DisableScreenSaver SDL_DisableScreenSaver  -- void	( -- )
c-function SDL_GL_LoadLibrary SDL_GL_LoadLibrary s -- n	( path -- )
c-function SDL_GL_GetProcAddress SDL_GL_GetProcAddress s -- a	( proc -- )
c-function SDL_GL_UnloadLibrary SDL_GL_UnloadLibrary  -- void	( -- )
c-function SDL_GL_ExtensionSupported SDL_GL_ExtensionSupported s -- n	( extension -- )
c-function SDL_GL_ResetAttributes SDL_GL_ResetAttributes  -- void	( -- )
c-function SDL_GL_SetAttribute SDL_GL_SetAttribute n n -- n	( attr value -- )
c-function SDL_GL_GetAttribute SDL_GL_GetAttribute n a -- n	( attr value -- )
c-function SDL_GL_CreateContext SDL_GL_CreateContext a -- a	( window -- )
c-function SDL_GL_MakeCurrent SDL_GL_MakeCurrent a a -- n	( window context -- )
c-function SDL_GL_GetCurrentWindow SDL_GL_GetCurrentWindow  -- a	( -- )
c-function SDL_GL_GetCurrentContext SDL_GL_GetCurrentContext  -- a	( -- )
c-function SDL_GL_GetDrawableSize SDL_GL_GetDrawableSize a a a -- void	( window w h -- )
c-function SDL_GL_SetSwapInterval SDL_GL_SetSwapInterval n -- n	( interval -- )
c-function SDL_GL_GetSwapInterval SDL_GL_GetSwapInterval  -- n	( -- )
c-function SDL_GL_SwapWindow SDL_GL_SwapWindow a -- void	( window -- )
c-function SDL_GL_DeleteContext SDL_GL_DeleteContext a -- void	( context -- )
c-function SDL_GetPreferredLocales SDL_GetPreferredLocales  -- a	( -- )
c-function SDL_OpenURL SDL_OpenURL s -- n	( url -- )

\ ----===< postfix >===-----
end-c-library
previous set-current
