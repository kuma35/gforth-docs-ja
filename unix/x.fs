\ This file has been generated using SWIG and fsi,
\ and is already platform dependent, search for the corresponding
\ fsi-file to compile it where no one has compiled it before ;)
\ Forth systems have their own own dynamic loader and don't need addional C-Code.
\ That's why this file will just print normal forth-code once compiled
\ and can be used directly with include or require.
\ As all comments are stripped during the compilation, please
\ insert the copyright notice of the original file here.

\ ----===< prefix >===-----
cs-vocabulary X11

get-current also X11 definitions

c-library x
s" a a 0" vararg$ $!
s" X11 -lXext" add-lib
\c #include <X11/X.h>
\c #include <X11/Xlib.h>
\c #include <X11/Xutil.h>
\c #include <X11/keysym.h>
\c #include <X11/XF86keysym.h>
\c #include <X11/extensions/sync.h>
\c #define _EVDEVK(x) x

\ ----===< int constants >===-----
#11	constant X_PROTOCOL
#0	constant X_PROTOCOL_REVISION
#0	constant None
#1	constant ParentRelative
#0	constant CopyFromParent
#0	constant PointerWindow
#1	constant InputFocus
#1	constant PointerRoot
#0	constant AnyPropertyType
#0	constant AnyKey
#0	constant AnyButton
#0	constant AllTemporary
#0	constant CurrentTime
#0	constant NoSymbol
#0	constant NoEventMask
#1	constant KeyPressMask
#2	constant KeyReleaseMask
#4	constant ButtonPressMask
#8	constant ButtonReleaseMask
#16	constant EnterWindowMask
#32	constant LeaveWindowMask
#64	constant PointerMotionMask
#128	constant PointerMotionHintMask
#256	constant Button1MotionMask
#512	constant Button2MotionMask
#1024	constant Button3MotionMask
#2048	constant Button4MotionMask
#4096	constant Button5MotionMask
#8192	constant ButtonMotionMask
#16384	constant KeymapStateMask
#32768	constant ExposureMask
#65536	constant VisibilityChangeMask
#131072	constant StructureNotifyMask
#262144	constant ResizeRedirectMask
#524288	constant SubstructureNotifyMask
#1048576	constant SubstructureRedirectMask
#2097152	constant FocusChangeMask
#4194304	constant PropertyChangeMask
#8388608	constant ColormapChangeMask
#16777216	constant OwnerGrabButtonMask
#2	constant KeyPress
#3	constant KeyRelease
#4	constant ButtonPress
#5	constant ButtonRelease
#6	constant MotionNotify
#7	constant EnterNotify
#8	constant LeaveNotify
#9	constant FocusIn
#10	constant FocusOut
#11	constant KeymapNotify
#12	constant Expose
#13	constant GraphicsExpose
#14	constant NoExpose
#15	constant VisibilityNotify
#16	constant CreateNotify
#17	constant DestroyNotify
#18	constant UnmapNotify
#19	constant MapNotify
#20	constant MapRequest
#21	constant ReparentNotify
#22	constant ConfigureNotify
#23	constant ConfigureRequest
#24	constant GravityNotify
#25	constant ResizeRequest
#26	constant CirculateNotify
#27	constant CirculateRequest
#28	constant PropertyNotify
#29	constant SelectionClear
#30	constant SelectionRequest
#31	constant SelectionNotify
#32	constant ColormapNotify
#33	constant ClientMessage
#34	constant MappingNotify
#35	constant GenericEvent
#36	constant LASTEvent
#1	constant ShiftMask
#2	constant LockMask
#4	constant ControlMask
#8	constant Mod1Mask
#16	constant Mod2Mask
#32	constant Mod3Mask
#64	constant Mod4Mask
#128	constant Mod5Mask
#0	constant ShiftMapIndex
#1	constant LockMapIndex
#2	constant ControlMapIndex
#3	constant Mod1MapIndex
#4	constant Mod2MapIndex
#5	constant Mod3MapIndex
#6	constant Mod4MapIndex
#7	constant Mod5MapIndex
#256	constant Button1Mask
#512	constant Button2Mask
#1024	constant Button3Mask
#2048	constant Button4Mask
#4096	constant Button5Mask
#32768	constant AnyModifier
#1	constant Button1
#2	constant Button2
#3	constant Button3
#4	constant Button4
#5	constant Button5
#0	constant NotifyNormal
#1	constant NotifyGrab
#2	constant NotifyUngrab
#3	constant NotifyWhileGrabbed
#1	constant NotifyHint
#0	constant NotifyAncestor
#1	constant NotifyVirtual
#2	constant NotifyInferior
#3	constant NotifyNonlinear
#4	constant NotifyNonlinearVirtual
#5	constant NotifyPointer
#6	constant NotifyPointerRoot
#7	constant NotifyDetailNone
#0	constant VisibilityUnobscured
#1	constant VisibilityPartiallyObscured
#2	constant VisibilityFullyObscured
#0	constant PlaceOnTop
#1	constant PlaceOnBottom
#0	constant FamilyInternet
#1	constant FamilyDECnet
#2	constant FamilyChaos
#6	constant FamilyInternet6
#5	constant FamilyServerInterpreted
#0	constant PropertyNewValue
#1	constant PropertyDelete
#0	constant ColormapUninstalled
#1	constant ColormapInstalled
#0	constant GrabModeSync
#1	constant GrabModeAsync
#0	constant GrabSuccess
#1	constant AlreadyGrabbed
#2	constant GrabInvalidTime
#3	constant GrabNotViewable
#4	constant GrabFrozen
#0	constant AsyncPointer
#1	constant SyncPointer
#2	constant ReplayPointer
#3	constant AsyncKeyboard
#4	constant SyncKeyboard
#5	constant ReplayKeyboard
#6	constant AsyncBoth
#7	constant SyncBoth
#2	constant RevertToParent
#0	constant Success
#1	constant BadRequest
#2	constant BadValue
#3	constant BadWindow
#4	constant BadPixmap
#5	constant BadAtom
#6	constant BadCursor
#7	constant BadFont
#8	constant BadMatch
#9	constant BadDrawable
#10	constant BadAccess
#11	constant BadAlloc
#12	constant BadColor
#13	constant BadGC
#14	constant BadIDChoice
#15	constant BadName
#16	constant BadLength
#17	constant BadImplementation
#128	constant FirstExtensionError
#255	constant LastExtensionError
#1	constant InputOutput
#2	constant InputOnly
#1	constant CWBackPixmap
#2	constant CWBackPixel
#4	constant CWBorderPixmap
#8	constant CWBorderPixel
#16	constant CWBitGravity
#32	constant CWWinGravity
#64	constant CWBackingStore
#128	constant CWBackingPlanes
#256	constant CWBackingPixel
#512	constant CWOverrideRedirect
#1024	constant CWSaveUnder
#2048	constant CWEventMask
#4096	constant CWDontPropagate
#8192	constant CWColormap
#16384	constant CWCursor
#1	constant CWX
#2	constant CWY
#4	constant CWWidth
#8	constant CWHeight
#16	constant CWBorderWidth
#32	constant CWSibling
#64	constant CWStackMode
#0	constant ForgetGravity
#1	constant NorthWestGravity
#2	constant NorthGravity
#3	constant NorthEastGravity
#4	constant WestGravity
#5	constant CenterGravity
#6	constant EastGravity
#7	constant SouthWestGravity
#8	constant SouthGravity
#9	constant SouthEastGravity
#10	constant StaticGravity
#0	constant UnmapGravity
#0	constant NotUseful
#1	constant WhenMapped
#2	constant Always
#0	constant IsUnmapped
#1	constant IsUnviewable
#2	constant IsViewable
#0	constant SetModeInsert
#1	constant SetModeDelete
#0	constant DestroyAll
#1	constant RetainPermanent
#2	constant RetainTemporary
#0	constant Above
#1	constant Below
#2	constant TopIf
#3	constant BottomIf
#4	constant Opposite
#0	constant RaiseLowest
#1	constant LowerHighest
#0	constant PropModeReplace
#1	constant PropModePrepend
#2	constant PropModeAppend
#0	constant GXclear
#1	constant GXand
#2	constant GXandReverse
#3	constant GXcopy
#4	constant GXandInverted
#5	constant GXnoop
#6	constant GXxor
#7	constant GXor
#8	constant GXnor
#9	constant GXequiv
#10	constant GXinvert
#11	constant GXorReverse
#12	constant GXcopyInverted
#13	constant GXorInverted
#14	constant GXnand
#15	constant GXset
#0	constant LineSolid
#1	constant LineOnOffDash
#2	constant LineDoubleDash
#0	constant CapNotLast
#1	constant CapButt
#2	constant CapRound
#3	constant CapProjecting
#0	constant JoinMiter
#1	constant JoinRound
#2	constant JoinBevel
#0	constant FillSolid
#1	constant FillTiled
#2	constant FillStippled
#3	constant FillOpaqueStippled
#0	constant EvenOddRule
#1	constant WindingRule
#0	constant ClipByChildren
#1	constant IncludeInferiors
#0	constant Unsorted
#1	constant YSorted
#2	constant YXSorted
#3	constant YXBanded
#0	constant CoordModeOrigin
#1	constant CoordModePrevious
#0	constant Complex
#1	constant Nonconvex
#2	constant Convex
#0	constant ArcChord
#1	constant ArcPieSlice
#1	constant GCFunction
#2	constant GCPlaneMask
#4	constant GCForeground
#8	constant GCBackground
#16	constant GCLineWidth
#32	constant GCLineStyle
#64	constant GCCapStyle
#128	constant GCJoinStyle
#256	constant GCFillStyle
#512	constant GCFillRule
#1024	constant GCTile
#2048	constant GCStipple
#4096	constant GCTileStipXOrigin
#8192	constant GCTileStipYOrigin
#16384	constant GCFont
#32768	constant GCSubwindowMode
#65536	constant GCGraphicsExposures
#131072	constant GCClipXOrigin
#262144	constant GCClipYOrigin
#524288	constant GCClipMask
#1048576	constant GCDashOffset
#2097152	constant GCDashList
#4194304	constant GCArcMode
#22	constant GCLastBit
#0	constant FontLeftToRight
#1	constant FontRightToLeft
#255	constant FontChange
#0	constant XYBitmap
#1	constant XYPixmap
#2	constant ZPixmap
#0	constant AllocNone
#1	constant AllocAll
#1	constant DoRed
#2	constant DoGreen
#4	constant DoBlue
#0	constant CursorShape
#1	constant TileShape
#2	constant StippleShape
#0	constant AutoRepeatModeOff
#1	constant AutoRepeatModeOn
#2	constant AutoRepeatModeDefault
#0	constant LedModeOff
#1	constant LedModeOn
#1	constant KBKeyClickPercent
#2	constant KBBellPercent
#4	constant KBBellPitch
#8	constant KBBellDuration
#16	constant KBLed
#32	constant KBLedMode
#64	constant KBKey
#128	constant KBAutoRepeatMode
#0	constant MappingSuccess
#1	constant MappingBusy
#2	constant MappingFailed
#0	constant MappingModifier
#1	constant MappingKeyboard
#2	constant MappingPointer
#0	constant DontPreferBlanking
#1	constant PreferBlanking
#2	constant DefaultBlanking
#0	constant DisableScreenSaver
#0	constant DisableScreenInterval
#0	constant DontAllowExposures
#1	constant AllowExposures
#2	constant DefaultExposures
#0	constant ScreenSaverReset
#1	constant ScreenSaverActive
#0	constant HostInsert
#1	constant HostDelete
#1	constant EnableAccess
#0	constant DisableAccess
#0	constant StaticGray
#1	constant GrayScale
#2	constant StaticColor
#3	constant PseudoColor
#4	constant TrueColor
#5	constant DirectColor
#0	constant LSBFirst
#1	constant MSBFirst
#6	constant XlibSpecificationRelease
#1	constant X_HAVE_UTF8_STRING
#1	constant True
#0	constant False
#0	constant QueuedAlready
#1	constant QueuedAfterReading
#2	constant QueuedAfterFlush
#1	constant XIMPreeditArea
#2	constant XIMPreeditCallbacks
#4	constant XIMPreeditPosition
#8	constant XIMPreeditNothing
#16	constant XIMPreeditNone
#256	constant XIMStatusArea
#512	constant XIMStatusCallbacks
#1024	constant XIMStatusNothing
#2048	constant XIMStatusNone
#-1	constant XBufferOverflow
#1	constant XLookupNone
#2	constant XLookupChars
#3	constant XLookupKeySym
#4	constant XLookupBoth
#1	constant XIMReverse
#2	constant XIMUnderline
#4	constant XIMHighlight
#32	constant XIMPrimary
#64	constant XIMSecondary
#128	constant XIMTertiary
#256	constant XIMVisibleToForward
#512	constant XIMVisibleToBackword
#1024	constant XIMVisibleToCenter
#0	constant XIMPreeditUnKnown
#1	constant XIMPreeditEnable
#2	constant XIMPreeditDisable
#1	constant XIMInitialState
#2	constant XIMPreserveState
#1	constant XIMStringConversionLeftEdge
#2	constant XIMStringConversionRightEdge
#4	constant XIMStringConversionTopEdge
#8	constant XIMStringConversionBottomEdge
#16	constant XIMStringConversionConcealed
#32	constant XIMStringConversionWrapped
#1	constant XIMStringConversionBuffer
#2	constant XIMStringConversionLine
#3	constant XIMStringConversionWord
#4	constant XIMStringConversionChar
#1	constant XIMStringConversionSubstitution
#2	constant XIMStringConversionRetrieval
#1	constant XIMHotKeyStateON
#2	constant XIMHotKeyStateOFF
#0	constant NoValue
#1	constant XValue
#2	constant YValue
#4	constant WidthValue
#8	constant HeightValue
#15	constant AllValues
#16	constant XNegative
#32	constant YNegative
#1	constant USPosition
#2	constant USSize
#4	constant PPosition
#8	constant PSize
#16	constant PMinSize
#32	constant PMaxSize
#64	constant PResizeInc
#128	constant PAspect
#256	constant PBaseSize
#512	constant PWinGravity
#252	constant PAllHints
#1	constant InputHint
#2	constant StateHint
#4	constant IconPixmapHint
#8	constant IconWindowHint
#16	constant IconPositionHint
#32	constant IconMaskHint
#64	constant WindowGroupHint
#127	constant AllHints
#256	constant XUrgencyHint
#0	constant WithdrawnState
#1	constant NormalState
#3	constant IconicState
#0	constant DontCareState
#2	constant ZoomState
#4	constant InactiveState
#-1	constant XNoMemory
#-2	constant XLocaleNotSupported
#-3	constant XConverterNotFound
#0	constant RectangleOut
#1	constant RectangleIn
#2	constant RectanglePart
#0	constant VisualNoMask
#1	constant VisualIDMask
#2	constant VisualScreenMask
#4	constant VisualDepthMask
#8	constant VisualClassMask
#16	constant VisualRedMaskMask
#32	constant VisualGreenMaskMask
#64	constant VisualBlueMaskMask
#128	constant VisualColormapSizeMask
#256	constant VisualBitsPerRGBMask
#511	constant VisualAllMask
#0	constant BitmapSuccess
#1	constant BitmapOpenFailed
#2	constant BitmapFileInvalid
#3	constant BitmapNoMemory
#0	constant XCSUCCESS
#1	constant XCNOMEM
#2	constant XCNOENT
#16777215	constant XK_VoidSymbol
#65288	constant XK_BackSpace
#65289	constant XK_Tab
#65290	constant XK_Linefeed
#65291	constant XK_Clear
#65293	constant XK_Return
#65299	constant XK_Pause
#65300	constant XK_Scroll_Lock
#65301	constant XK_Sys_Req
#65307	constant XK_Escape
#65535	constant XK_Delete
#65312	constant XK_Multi_key
#65335	constant XK_Codeinput
#65340	constant XK_SingleCandidate
#65341	constant XK_MultipleCandidate
#65342	constant XK_PreviousCandidate
#65313	constant XK_Kanji
#65314	constant XK_Muhenkan
#65315	constant XK_Henkan_Mode
#65315	constant XK_Henkan
#65316	constant XK_Romaji
#65317	constant XK_Hiragana
#65318	constant XK_Katakana
#65319	constant XK_Hiragana_Katakana
#65320	constant XK_Zenkaku
#65321	constant XK_Hankaku
#65322	constant XK_Zenkaku_Hankaku
#65323	constant XK_Touroku
#65324	constant XK_Massyo
#65325	constant XK_Kana_Lock
#65326	constant XK_Kana_Shift
#65327	constant XK_Eisu_Shift
#65328	constant XK_Eisu_toggle
#65335	constant XK_Kanji_Bangou
#65341	constant XK_Zen_Koho
#65342	constant XK_Mae_Koho
#65360	constant XK_Home
#65361	constant XK_Left
#65362	constant XK_Up
#65363	constant XK_Right
#65364	constant XK_Down
#65365	constant XK_Prior
#65365	constant XK_Page_Up
#65366	constant XK_Next
#65366	constant XK_Page_Down
#65367	constant XK_End
#65368	constant XK_Begin
#65376	constant XK_Select
#65377	constant XK_Print
#65378	constant XK_Execute
#65379	constant XK_Insert
#65381	constant XK_Undo
#65382	constant XK_Redo
#65383	constant XK_Menu
#65384	constant XK_Find
#65385	constant XK_Cancel
#65386	constant XK_Help
#65387	constant XK_Break
#65406	constant XK_Mode_switch
#65406	constant XK_script_switch
#65407	constant XK_Num_Lock
#65408	constant XK_KP_Space
#65417	constant XK_KP_Tab
#65421	constant XK_KP_Enter
#65425	constant XK_KP_F1
#65426	constant XK_KP_F2
#65427	constant XK_KP_F3
#65428	constant XK_KP_F4
#65429	constant XK_KP_Home
#65430	constant XK_KP_Left
#65431	constant XK_KP_Up
#65432	constant XK_KP_Right
#65433	constant XK_KP_Down
#65434	constant XK_KP_Prior
#65434	constant XK_KP_Page_Up
#65435	constant XK_KP_Next
#65435	constant XK_KP_Page_Down
#65436	constant XK_KP_End
#65437	constant XK_KP_Begin
#65438	constant XK_KP_Insert
#65439	constant XK_KP_Delete
#65469	constant XK_KP_Equal
#65450	constant XK_KP_Multiply
#65451	constant XK_KP_Add
#65452	constant XK_KP_Separator
#65453	constant XK_KP_Subtract
#65454	constant XK_KP_Decimal
#65455	constant XK_KP_Divide
#65456	constant XK_KP_0
#65457	constant XK_KP_1
#65458	constant XK_KP_2
#65459	constant XK_KP_3
#65460	constant XK_KP_4
#65461	constant XK_KP_5
#65462	constant XK_KP_6
#65463	constant XK_KP_7
#65464	constant XK_KP_8
#65465	constant XK_KP_9
#65470	constant XK_F1
#65471	constant XK_F2
#65472	constant XK_F3
#65473	constant XK_F4
#65474	constant XK_F5
#65475	constant XK_F6
#65476	constant XK_F7
#65477	constant XK_F8
#65478	constant XK_F9
#65479	constant XK_F10
#65480	constant XK_F11
#65480	constant XK_L1
#65481	constant XK_F12
#65481	constant XK_L2
#65482	constant XK_F13
#65482	constant XK_L3
#65483	constant XK_F14
#65483	constant XK_L4
#65484	constant XK_F15
#65484	constant XK_L5
#65485	constant XK_F16
#65485	constant XK_L6
#65486	constant XK_F17
#65486	constant XK_L7
#65487	constant XK_F18
#65487	constant XK_L8
#65488	constant XK_F19
#65488	constant XK_L9
#65489	constant XK_F20
#65489	constant XK_L10
#65490	constant XK_F21
#65490	constant XK_R1
#65491	constant XK_F22
#65491	constant XK_R2
#65492	constant XK_F23
#65492	constant XK_R3
#65493	constant XK_F24
#65493	constant XK_R4
#65494	constant XK_F25
#65494	constant XK_R5
#65495	constant XK_F26
#65495	constant XK_R6
#65496	constant XK_F27
#65496	constant XK_R7
#65497	constant XK_F28
#65497	constant XK_R8
#65498	constant XK_F29
#65498	constant XK_R9
#65499	constant XK_F30
#65499	constant XK_R10
#65500	constant XK_F31
#65500	constant XK_R11
#65501	constant XK_F32
#65501	constant XK_R12
#65502	constant XK_F33
#65502	constant XK_R13
#65503	constant XK_F34
#65503	constant XK_R14
#65504	constant XK_F35
#65504	constant XK_R15
#65505	constant XK_Shift_L
#65506	constant XK_Shift_R
#65507	constant XK_Control_L
#65508	constant XK_Control_R
#65509	constant XK_Caps_Lock
#65510	constant XK_Shift_Lock
#65511	constant XK_Meta_L
#65512	constant XK_Meta_R
#65513	constant XK_Alt_L
#65514	constant XK_Alt_R
#65515	constant XK_Super_L
#65516	constant XK_Super_R
#65517	constant XK_Hyper_L
#65518	constant XK_Hyper_R
#269025025	constant XF86XK_ModeLock
#269025026	constant XF86XK_MonBrightnessUp
#269025027	constant XF86XK_MonBrightnessDown
#269025028	constant XF86XK_KbdLightOnOff
#269025029	constant XF86XK_KbdBrightnessUp
#269025030	constant XF86XK_KbdBrightnessDown
#269025031	constant XF86XK_MonBrightnessCycle
#269025040	constant XF86XK_Standby
#269025041	constant XF86XK_AudioLowerVolume
#269025042	constant XF86XK_AudioMute
#269025043	constant XF86XK_AudioRaiseVolume
#269025044	constant XF86XK_AudioPlay
#269025045	constant XF86XK_AudioStop
#269025046	constant XF86XK_AudioPrev
#269025047	constant XF86XK_AudioNext
#269025048	constant XF86XK_HomePage
#269025049	constant XF86XK_Mail
#269025050	constant XF86XK_Start
#269025051	constant XF86XK_Search
#269025052	constant XF86XK_AudioRecord
#269025053	constant XF86XK_Calculator
#269025054	constant XF86XK_Memo
#269025055	constant XF86XK_ToDoList
#269025056	constant XF86XK_Calendar
#269025057	constant XF86XK_PowerDown
#269025058	constant XF86XK_ContrastAdjust
#269025059	constant XF86XK_RockerUp
#269025060	constant XF86XK_RockerDown
#269025061	constant XF86XK_RockerEnter
#269025062	constant XF86XK_Back
#269025063	constant XF86XK_Forward
#269025064	constant XF86XK_Stop
#269025065	constant XF86XK_Refresh
#269025066	constant XF86XK_PowerOff
#269025067	constant XF86XK_WakeUp
#269025068	constant XF86XK_Eject
#269025069	constant XF86XK_ScreenSaver
#269025070	constant XF86XK_WWW
#269025071	constant XF86XK_Sleep
#269025072	constant XF86XK_Favorites
#269025073	constant XF86XK_AudioPause
#269025074	constant XF86XK_AudioMedia
#269025075	constant XF86XK_MyComputer
#269025076	constant XF86XK_VendorHome
#269025077	constant XF86XK_LightBulb
#269025078	constant XF86XK_Shop
#269025079	constant XF86XK_History
#269025080	constant XF86XK_OpenURL
#269025081	constant XF86XK_AddFavorite
#269025082	constant XF86XK_HotLinks
#269025083	constant XF86XK_BrightnessAdjust
#269025084	constant XF86XK_Finance
#269025085	constant XF86XK_Community
#269025086	constant XF86XK_AudioRewind
#269025087	constant XF86XK_BackForward
#269025088	constant XF86XK_Launch0
#269025089	constant XF86XK_Launch1
#269025090	constant XF86XK_Launch2
#269025091	constant XF86XK_Launch3
#269025092	constant XF86XK_Launch4
#269025093	constant XF86XK_Launch5
#269025094	constant XF86XK_Launch6
#269025095	constant XF86XK_Launch7
#269025096	constant XF86XK_Launch8
#269025097	constant XF86XK_Launch9
#269025098	constant XF86XK_LaunchA
#269025099	constant XF86XK_LaunchB
#269025100	constant XF86XK_LaunchC
#269025101	constant XF86XK_LaunchD
#269025102	constant XF86XK_LaunchE
#269025103	constant XF86XK_LaunchF
#269025104	constant XF86XK_ApplicationLeft
#269025105	constant XF86XK_ApplicationRight
#269025106	constant XF86XK_Book
#269025107	constant XF86XK_CD
#269025108	constant XF86XK_Calculater
#269025109	constant XF86XK_Clear
#269025110	constant XF86XK_Close
#269025111	constant XF86XK_Copy
#269025112	constant XF86XK_Cut
#269025113	constant XF86XK_Display
#269025114	constant XF86XK_DOS
#269025115	constant XF86XK_Documents
#269025116	constant XF86XK_Excel
#269025117	constant XF86XK_Explorer
#269025118	constant XF86XK_Game
#269025119	constant XF86XK_Go
#269025120	constant XF86XK_iTouch
#269025121	constant XF86XK_LogOff
#269025122	constant XF86XK_Market
#269025123	constant XF86XK_Meeting
#269025125	constant XF86XK_MenuKB
#269025126	constant XF86XK_MenuPB
#269025127	constant XF86XK_MySites
#269025128	constant XF86XK_New
#269025129	constant XF86XK_News
#269025130	constant XF86XK_OfficeHome
#269025131	constant XF86XK_Open
#269025132	constant XF86XK_Option
#269025133	constant XF86XK_Paste
#269025134	constant XF86XK_Phone
#269025136	constant XF86XK_Q
#269025138	constant XF86XK_Reply
#269025139	constant XF86XK_Reload
#269025140	constant XF86XK_RotateWindows
#269025141	constant XF86XK_RotationPB
#269025142	constant XF86XK_RotationKB
#269025143	constant XF86XK_Save
#269025144	constant XF86XK_ScrollUp
#269025145	constant XF86XK_ScrollDown
#269025146	constant XF86XK_ScrollClick
#269025147	constant XF86XK_Send
#269025148	constant XF86XK_Spell
#269025149	constant XF86XK_SplitScreen
#269025150	constant XF86XK_Support
#269025151	constant XF86XK_TaskPane
#269025152	constant XF86XK_Terminal
#269025153	constant XF86XK_Tools
#269025154	constant XF86XK_Travel
#269025156	constant XF86XK_UserPB
#269025157	constant XF86XK_User1KB
#269025158	constant XF86XK_User2KB
#269025159	constant XF86XK_Video
#269025160	constant XF86XK_WheelButton
#269025161	constant XF86XK_Word
#269025162	constant XF86XK_Xfer
#269025163	constant XF86XK_ZoomIn
#269025164	constant XF86XK_ZoomOut
#269025165	constant XF86XK_Away
#269025166	constant XF86XK_Messenger
#269025167	constant XF86XK_WebCam
#269025168	constant XF86XK_MailForward
#269025169	constant XF86XK_Pictures
#269025170	constant XF86XK_Music
#269025171	constant XF86XK_Battery
#269025172	constant XF86XK_Bluetooth
#269025173	constant XF86XK_WLAN
#269025174	constant XF86XK_UWB
#269025175	constant XF86XK_AudioForward
#269025176	constant XF86XK_AudioRepeat
#269025177	constant XF86XK_AudioRandomPlay
#269025178	constant XF86XK_Subtitle
#269025179	constant XF86XK_AudioCycleTrack
#269025180	constant XF86XK_CycleAngle
#269025181	constant XF86XK_FrameBack
#269025182	constant XF86XK_FrameForward
#269025183	constant XF86XK_Time
#269025184	constant XF86XK_Select
#269025185	constant XF86XK_View
#269025186	constant XF86XK_TopMenu
#269025187	constant XF86XK_Red
#269025188	constant XF86XK_Green
#269025189	constant XF86XK_Yellow
#269025190	constant XF86XK_Blue
#269025191	constant XF86XK_Suspend
#269025192	constant XF86XK_Hibernate
#269025193	constant XF86XK_TouchpadToggle
#269025200	constant XF86XK_TouchpadOn
#269025201	constant XF86XK_TouchpadOff
#269025202	constant XF86XK_AudioMicMute
#269025203	constant XF86XK_Keyboard
#269025204	constant XF86XK_WWAN
#269025205	constant XF86XK_RFKill
#269025206	constant XF86XK_AudioPreset
#269025207	constant XF86XK_RotationLockToggle
#269025208	constant XF86XK_FullScreen
#269024769	constant XF86XK_Switch_VT_1
#269024770	constant XF86XK_Switch_VT_2
#269024771	constant XF86XK_Switch_VT_3
#269024772	constant XF86XK_Switch_VT_4
#269024773	constant XF86XK_Switch_VT_5
#269024774	constant XF86XK_Switch_VT_6
#269024775	constant XF86XK_Switch_VT_7
#269024776	constant XF86XK_Switch_VT_8
#269024777	constant XF86XK_Switch_VT_9
#269024778	constant XF86XK_Switch_VT_10
#269024779	constant XF86XK_Switch_VT_11
#269024780	constant XF86XK_Switch_VT_12
#269024800	constant XF86XK_Ungrab
#269024801	constant XF86XK_ClearGrab
#269024802	constant XF86XK_Next_VMode
#269024803	constant XF86XK_Prev_VMode
#269024804	constant XF86XK_LogWindowTree
#269024805	constant XF86XK_LogGrabInfo
#244	constant XF86XK_BrightnessAuto
#245	constant XF86XK_DisplayOff
#358	constant XF86XK_Info
#375	constant XF86XK_AspectRatio
#389	constant XF86XK_DVD
#392	constant XF86XK_Audio
#402	constant XF86XK_ChannelUp
#403	constant XF86XK_ChannelDown
#411	constant XF86XK_Break
#416	constant XF86XK_VideoPhone
#420	constant XF86XK_ZoomReset
#422	constant XF86XK_Editor
#424	constant XF86XK_GraphicsEditor
#425	constant XF86XK_Presentation
#426	constant XF86XK_Database
#428	constant XF86XK_Voicemail
#429	constant XF86XK_Addressbook
#431	constant XF86XK_DisplayToggle
#432	constant XF86XK_SpellCheck
#438	constant XF86XK_ContextMenu
#439	constant XF86XK_MediaRepeat
#440	constant XF86XK_10ChannelsUp
#441	constant XF86XK_10ChannelsDown
#442	constant XF86XK_Images
#444	constant XF86XK_NotificationCenter
#445	constant XF86XK_PickupPhone
#446	constant XF86XK_HangupPhone
#464	constant XF86XK_Fn
#465	constant XF86XK_Fn_Esc
#485	constant XF86XK_FnRightShift
#512	constant XF86XK_Numeric0
#513	constant XF86XK_Numeric1
#514	constant XF86XK_Numeric2
#515	constant XF86XK_Numeric3
#516	constant XF86XK_Numeric4
#517	constant XF86XK_Numeric5
#518	constant XF86XK_Numeric6
#519	constant XF86XK_Numeric7
#520	constant XF86XK_Numeric8
#521	constant XF86XK_Numeric9
#522	constant XF86XK_NumericStar
#523	constant XF86XK_NumericPound
#524	constant XF86XK_NumericA
#525	constant XF86XK_NumericB
#526	constant XF86XK_NumericC
#527	constant XF86XK_NumericD
#528	constant XF86XK_CameraFocus
#529	constant XF86XK_WPSButton
#533	constant XF86XK_CameraZoomIn
#534	constant XF86XK_CameraZoomOut
#535	constant XF86XK_CameraUp
#536	constant XF86XK_CameraDown
#537	constant XF86XK_CameraLeft
#538	constant XF86XK_CameraRight
#539	constant XF86XK_AttendantOn
#540	constant XF86XK_AttendantOff
#541	constant XF86XK_AttendantToggle
#542	constant XF86XK_LightsToggle
#560	constant XF86XK_ALSToggle
#576	constant XF86XK_Buttonconfig
#577	constant XF86XK_Taskmanager
#578	constant XF86XK_Journal
#579	constant XF86XK_ControlPanel
#580	constant XF86XK_AppSelect
#581	constant XF86XK_Screensaver
#582	constant XF86XK_VoiceCommand
#583	constant XF86XK_Assistant
#592	constant XF86XK_BrightnessMin
#593	constant XF86XK_BrightnessMax
#608	constant XF86XK_KbdInputAssistPrev
#609	constant XF86XK_KbdInputAssistNext
#610	constant XF86XK_KbdInputAssistPrevgroup
#611	constant XF86XK_KbdInputAssistNextgroup
#612	constant XF86XK_KbdInputAssistAccept
#613	constant XF86XK_KbdInputAssistCancel
#614	constant XF86XK_RightUp
#615	constant XF86XK_RightDown
#616	constant XF86XK_LeftUp
#617	constant XF86XK_LeftDown
#618	constant XF86XK_RootMenu
#619	constant XF86XK_MediaTopMenu
#620	constant XF86XK_Numeric11
#621	constant XF86XK_Numeric12
#622	constant XF86XK_AudioDesc
#623	constant XF86XK_3DMode
#624	constant XF86XK_NextFavorite
#625	constant XF86XK_StopRecord
#626	constant XF86XK_PauseRecord
#627	constant XF86XK_VOD
#628	constant XF86XK_Unmute
#629	constant XF86XK_FastReverse
#630	constant XF86XK_SlowReverse
#631	constant XF86XK_Data
#632	constant XF86XK_OnScreenKeyboard
#633	constant XF86XK_PrivacyScreenToggle
#634	constant XF86XK_SelectiveScreenshot
#656	constant XF86XK_Macro1
#657	constant XF86XK_Macro2
#658	constant XF86XK_Macro3
#659	constant XF86XK_Macro4
#660	constant XF86XK_Macro5
#661	constant XF86XK_Macro6
#662	constant XF86XK_Macro7
#663	constant XF86XK_Macro8
#664	constant XF86XK_Macro9
#665	constant XF86XK_Macro10
#666	constant XF86XK_Macro11
#667	constant XF86XK_Macro12
#668	constant XF86XK_Macro13
#669	constant XF86XK_Macro14
#670	constant XF86XK_Macro15
#671	constant XF86XK_Macro16
#672	constant XF86XK_Macro17
#673	constant XF86XK_Macro18
#674	constant XF86XK_Macro19
#675	constant XF86XK_Macro20
#676	constant XF86XK_Macro21
#677	constant XF86XK_Macro22
#678	constant XF86XK_Macro23
#679	constant XF86XK_Macro24
#680	constant XF86XK_Macro25
#681	constant XF86XK_Macro26
#682	constant XF86XK_Macro27
#683	constant XF86XK_Macro28
#684	constant XF86XK_Macro29
#685	constant XF86XK_Macro30
#688	constant XF86XK_MacroRecordStart
#689	constant XF86XK_MacroRecordStop
#690	constant XF86XK_MacroPresetCycle
#691	constant XF86XK_MacroPreset1
#692	constant XF86XK_MacroPreset2
#693	constant XF86XK_MacroPreset3
#696	constant XF86XK_KbdLcdMenu1
#697	constant XF86XK_KbdLcdMenu2
#698	constant XF86XK_KbdLcdMenu3
#699	constant XF86XK_KbdLcdMenu4
#700	constant XF86XK_KbdLcdMenu5

\ --------===< enums >===---------
#0	constant XOMOrientation_LTR_TTB
#1	constant XOMOrientation_RTL_TTB
#2	constant XOMOrientation_TTB_LTR
#3	constant XOMOrientation_TTB_RTL
#4	constant XOMOrientation_Context
#0	constant XIMForwardChar
#1	constant XIMBackwardChar
#2	constant XIMForwardWord
#3	constant XIMBackwardWord
#4	constant XIMCaretUp
#5	constant XIMCaretDown
#6	constant XIMNextLine
#7	constant XIMPreviousLine
#8	constant XIMLineStart
#9	constant XIMLineEnd
#10	constant XIMAbsolutePosition
#11	constant XIMDontChange
#0	constant XIMIsInvisible
#1	constant XIMIsPrimary
#2	constant XIMIsSecondary
#0	constant XIMTextType
#1	constant XIMBitmapType
#0	constant XStringStyle
#1	constant XCompoundTextStyle
#2	constant XTextStyle
#3	constant XStdICCTextStyle
#4	constant XUTF8StringStyle

\ -------===< structs >===--------
\ XExtData
begin-structure XExtData
drop 32 end-structure
\ XExtCodes
begin-structure XExtCodes
	drop 0 4 +field XExtCodes-extension
	drop 12 4 +field XExtCodes-first_error
	drop 4 4 +field XExtCodes-major_opcode
	drop 8 4 +field XExtCodes-first_event
drop 16 end-structure
\ XPixmapFormatValues
begin-structure XPixmapFormatValues
	drop 8 4 +field XPixmapFormatValues-scanline_pad
	drop 4 4 +field XPixmapFormatValues-bits_per_pixel
	drop 0 4 +field XPixmapFormatValues-depth
drop 12 end-structure
\ XGCValues
begin-structure XGCValues
	drop 48 4 +field XGCValues-fill_style
	drop 44 4 +field XGCValues-join_style
	drop 40 4 +field XGCValues-cap_style
	drop 80 4 +field XGCValues-ts_x_origin
	drop 84 4 +field XGCValues-ts_y_origin
	drop 88 8 +field XGCValues-font
	drop 104 4 +field XGCValues-clip_x_origin
	drop 108 4 +field XGCValues-clip_y_origin
	drop 72 8 +field XGCValues-stipple
	drop 8 8 +field XGCValues-plane_mask
	drop 96 4 +field XGCValues-subwindow_mode
	drop 36 4 +field XGCValues-line_style
	drop 64 8 +field XGCValues-tile
	drop 24 8 +field XGCValues-background
	drop 16 8 +field XGCValues-foreground
	drop 0 4 +field XGCValues-function
	drop 100 4 +field XGCValues-graphics_exposures
	drop 32 4 +field XGCValues-line_width
	drop 56 4 +field XGCValues-arc_mode
	drop 112 8 +field XGCValues-clip_mask
	drop 52 4 +field XGCValues-fill_rule
	drop 120 4 +field XGCValues-dash_offset
	drop 124 1 +field XGCValues-dashes
drop 128 end-structure
\ Visual
begin-structure Visual
	drop 40 8 +field Visual-blue_mask
	drop 0 8 +field Visual-ext_data
	drop 8 8 +field Visual-visualid
	drop 32 8 +field Visual-green_mask
	drop 24 8 +field Visual-red_mask
	drop 48 4 +field Visual-bits_per_rgb
	drop 52 4 +field Visual-map_entries
	drop 16 4 +field Visual-class
drop 56 end-structure
\ Depth
begin-structure Depth
	drop 4 4 +field Depth-nvisuals
	drop 8 8 +field Depth-visuals
	drop 0 4 +field Depth-depth
drop 16 end-structure
\ Screen
begin-structure Screen
	drop 56 4 +field Screen-root_depth
	drop 116 4 +field Screen-save_unders
	drop 120 8 +field Screen-root_input_mask
	drop 28 4 +field Screen-height
	drop 108 4 +field Screen-min_maps
	drop 112 4 +field Screen-backing_store
	drop 80 8 +field Screen-cmap
	drop 16 8 +field Screen-root
	drop 0 8 +field Screen-ext_data
	drop 104 4 +field Screen-max_maps
	drop 36 4 +field Screen-mheight
	drop 48 8 +field Screen-depths
	drop 40 4 +field Screen-ndepths
	drop 8 8 +field Screen-display
	drop 24 4 +field Screen-width
	drop 72 8 +field Screen-default_gc
	drop 88 8 +field Screen-white_pixel
	drop 96 8 +field Screen-black_pixel
	drop 64 8 +field Screen-root_visual
	drop 32 4 +field Screen-mwidth
drop 128 end-structure
\ ScreenFormat
begin-structure ScreenFormat
	drop 16 4 +field ScreenFormat-scanline_pad
	drop 0 8 +field ScreenFormat-ext_data
	drop 12 4 +field ScreenFormat-bits_per_pixel
	drop 8 4 +field ScreenFormat-depth
drop 24 end-structure
\ XSetWindowAttributes
begin-structure XSetWindowAttributes
	drop 96 8 +field XSetWindowAttributes-colormap
	drop 16 8 +field XSetWindowAttributes-border_pixmap
	drop 0 8 +field XSetWindowAttributes-background_pixmap
	drop 80 8 +field XSetWindowAttributes-do_not_propagate_mask
	drop 36 4 +field XSetWindowAttributes-win_gravity
	drop 32 4 +field XSetWindowAttributes-bit_gravity
	drop 40 4 +field XSetWindowAttributes-backing_store
	drop 104 8 +field XSetWindowAttributes-cursor
	drop 24 8 +field XSetWindowAttributes-border_pixel
	drop 8 8 +field XSetWindowAttributes-background_pixel
	drop 64 4 +field XSetWindowAttributes-save_under
	drop 88 4 +field XSetWindowAttributes-override_redirect
	drop 56 8 +field XSetWindowAttributes-backing_pixel
	drop 48 8 +field XSetWindowAttributes-backing_planes
	drop 72 8 +field XSetWindowAttributes-event_mask
drop 112 end-structure
\ XWindowAttributes
begin-structure XWindowAttributes
	drop 0 4 +field XWindowAttributes-x
	drop 48 4 +field XWindowAttributes-win_gravity
	drop 44 4 +field XWindowAttributes-bit_gravity
	drop 80 8 +field XWindowAttributes-colormap
	drop 112 8 +field XWindowAttributes-do_not_propagate_mask
	drop 4 4 +field XWindowAttributes-y
	drop 12 4 +field XWindowAttributes-height
	drop 52 4 +field XWindowAttributes-backing_store
	drop 16 4 +field XWindowAttributes-border_width
	drop 32 8 +field XWindowAttributes-root
	drop 88 4 +field XWindowAttributes-map_installed
	drop 40 4 +field XWindowAttributes-class
	drop 20 4 +field XWindowAttributes-depth
	drop 92 4 +field XWindowAttributes-map_state
	drop 24 8 +field XWindowAttributes-visual
	drop 8 4 +field XWindowAttributes-width
	drop 64 8 +field XWindowAttributes-backing_pixel
	drop 72 4 +field XWindowAttributes-save_under
	drop 120 4 +field XWindowAttributes-override_redirect
	drop 56 8 +field XWindowAttributes-backing_planes
	drop 96 8 +field XWindowAttributes-all_event_masks
	drop 104 8 +field XWindowAttributes-your_event_mask
	drop 128 8 +field XWindowAttributes-screen
drop 136 end-structure
\ XHostAddress
begin-structure XHostAddress
	drop 4 4 +field XHostAddress-length
	drop 8 8 +field XHostAddress-address
	drop 0 4 +field XHostAddress-family
drop 16 end-structure
\ XServerInterpretedAddress
begin-structure XServerInterpretedAddress
	drop 0 4 +field XServerInterpretedAddress-typelength
	drop 4 4 +field XServerInterpretedAddress-valuelength
	drop 16 8 +field XServerInterpretedAddress-value
	drop 8 8 +field XServerInterpretedAddress-type
drop 24 end-structure
\ XImage
begin-structure XImage
drop 136 end-structure
\ funcs
begin-structure funcs
	drop 0 8 +field funcs-create_image
	drop 8 8 +field funcs-destroy_image
	drop 16 8 +field funcs-get_pixel
	drop 24 8 +field funcs-put_pixel
	drop 40 8 +field funcs-add_pixel
	drop 32 8 +field funcs-sub_image
drop 48 end-structure
\ XWindowChanges
begin-structure XWindowChanges
	drop 0 4 +field XWindowChanges-x
	drop 4 4 +field XWindowChanges-y
	drop 32 4 +field XWindowChanges-stack_mode
	drop 12 4 +field XWindowChanges-height
	drop 16 4 +field XWindowChanges-border_width
	drop 24 8 +field XWindowChanges-sibling
	drop 8 4 +field XWindowChanges-width
drop 40 end-structure
\ XColor
begin-structure XColor
	drop 12 2 +field XColor-blue
	drop 0 8 +field XColor-pixel
	drop 10 2 +field XColor-green
	drop 8 2 +field XColor-red
	drop 14 1 +field XColor-flags
	drop 15 1 +field XColor-pad
drop 16 end-structure
\ XSegment
begin-structure XSegment
	drop 2 2 +field XSegment-y1
	drop 6 2 +field XSegment-y2
	drop 0 2 +field XSegment-x1
	drop 4 2 +field XSegment-x2
drop 8 end-structure
\ XPoint
begin-structure XPoint
	drop 0 2 +field XPoint-x
	drop 2 2 +field XPoint-y
drop 4 end-structure
\ XRectangle
begin-structure XRectangle
	drop 0 2 +field XRectangle-x
	drop 2 2 +field XRectangle-y
	drop 6 2 +field XRectangle-height
	drop 4 2 +field XRectangle-width
drop 8 end-structure
\ XArc
begin-structure XArc
	drop 0 2 +field XArc-x
	drop 2 2 +field XArc-y
	drop 6 2 +field XArc-height
	drop 8 2 +field XArc-angle1
	drop 4 2 +field XArc-width
	drop 10 2 +field XArc-angle2
drop 12 end-structure
\ XKeyboardControl
begin-structure XKeyboardControl
	drop 0 4 +field XKeyboardControl-key_click_percent
	drop 4 4 +field XKeyboardControl-bell_percent
	drop 12 4 +field XKeyboardControl-bell_duration
	drop 20 4 +field XKeyboardControl-led_mode
	drop 8 4 +field XKeyboardControl-bell_pitch
	drop 24 4 +field XKeyboardControl-key
	drop 16 4 +field XKeyboardControl-led
	drop 28 4 +field XKeyboardControl-auto_repeat_mode
drop 32 end-structure
\ XKeyboardState
begin-structure XKeyboardState
	drop 0 4 +field XKeyboardState-key_click_percent
	drop 4 4 +field XKeyboardState-bell_percent
	drop 12 4 +field XKeyboardState-bell_duration
	drop 8 4 +field XKeyboardState-bell_pitch
	drop 28 32 +field XKeyboardState-auto_repeats
	drop 16 8 +field XKeyboardState-led_mask
	drop 24 4 +field XKeyboardState-global_auto_repeat
drop 64 end-structure
\ XTimeCoord
begin-structure XTimeCoord
	drop 8 2 +field XTimeCoord-x
	drop 0 8 +field XTimeCoord-time
	drop 10 2 +field XTimeCoord-y
drop 16 end-structure
\ XModifierKeymap
begin-structure XModifierKeymap
	drop 8 8 +field XModifierKeymap-modifiermap
	drop 0 4 +field XModifierKeymap-max_keypermod
drop 16 end-structure
\ XKeyEvent
begin-structure XKeyEvent
	drop 48 8 +field XKeyEvent-subwindow
	drop 32 8 +field XKeyEvent-window
	drop 8 8 +field XKeyEvent-serial
	drop 64 4 +field XKeyEvent-x
	drop 68 4 +field XKeyEvent-y
	drop 88 4 +field XKeyEvent-same_screen
	drop 84 4 +field XKeyEvent-keycode
	drop 72 4 +field XKeyEvent-x_root
	drop 56 8 +field XKeyEvent-time
	drop 40 8 +field XKeyEvent-root
	drop 76 4 +field XKeyEvent-y_root
	drop 24 8 +field XKeyEvent-display
	drop 0 4 +field XKeyEvent-type
	drop 80 4 +field XKeyEvent-state
	drop 16 4 +field XKeyEvent-send_event
drop 96 end-structure
\ XButtonEvent
begin-structure XButtonEvent
	drop 48 8 +field XButtonEvent-subwindow
	drop 32 8 +field XButtonEvent-window
	drop 8 8 +field XButtonEvent-serial
	drop 64 4 +field XButtonEvent-x
	drop 68 4 +field XButtonEvent-y
	drop 88 4 +field XButtonEvent-same_screen
	drop 84 4 +field XButtonEvent-button
	drop 72 4 +field XButtonEvent-x_root
	drop 56 8 +field XButtonEvent-time
	drop 40 8 +field XButtonEvent-root
	drop 76 4 +field XButtonEvent-y_root
	drop 24 8 +field XButtonEvent-display
	drop 0 4 +field XButtonEvent-type
	drop 80 4 +field XButtonEvent-state
	drop 16 4 +field XButtonEvent-send_event
drop 96 end-structure
\ XMotionEvent
begin-structure XMotionEvent
	drop 48 8 +field XMotionEvent-subwindow
	drop 32 8 +field XMotionEvent-window
	drop 8 8 +field XMotionEvent-serial
	drop 64 4 +field XMotionEvent-x
	drop 68 4 +field XMotionEvent-y
	drop 88 4 +field XMotionEvent-same_screen
	drop 72 4 +field XMotionEvent-x_root
	drop 56 8 +field XMotionEvent-time
	drop 40 8 +field XMotionEvent-root
	drop 84 1 +field XMotionEvent-is_hint
	drop 76 4 +field XMotionEvent-y_root
	drop 24 8 +field XMotionEvent-display
	drop 0 4 +field XMotionEvent-type
	drop 80 4 +field XMotionEvent-state
	drop 16 4 +field XMotionEvent-send_event
drop 96 end-structure
\ XCrossingEvent
begin-structure XCrossingEvent
	drop 80 4 +field XCrossingEvent-mode
	drop 48 8 +field XCrossingEvent-subwindow
	drop 32 8 +field XCrossingEvent-window
	drop 8 8 +field XCrossingEvent-serial
	drop 64 4 +field XCrossingEvent-x
	drop 92 4 +field XCrossingEvent-focus
	drop 68 4 +field XCrossingEvent-y
	drop 88 4 +field XCrossingEvent-same_screen
	drop 72 4 +field XCrossingEvent-x_root
	drop 56 8 +field XCrossingEvent-time
	drop 40 8 +field XCrossingEvent-root
	drop 76 4 +field XCrossingEvent-y_root
	drop 24 8 +field XCrossingEvent-display
	drop 84 4 +field XCrossingEvent-detail
	drop 0 4 +field XCrossingEvent-type
	drop 96 4 +field XCrossingEvent-state
	drop 16 4 +field XCrossingEvent-send_event
drop 104 end-structure
\ XFocusChangeEvent
begin-structure XFocusChangeEvent
	drop 24 8 +field XFocusChangeEvent-display
	drop 8 8 +field XFocusChangeEvent-serial
	drop 32 8 +field XFocusChangeEvent-window
	drop 0 4 +field XFocusChangeEvent-type
	drop 16 4 +field XFocusChangeEvent-send_event
	drop 44 4 +field XFocusChangeEvent-detail
	drop 40 4 +field XFocusChangeEvent-mode
drop 48 end-structure
\ XKeymapEvent
begin-structure XKeymapEvent
	drop 24 8 +field XKeymapEvent-display
	drop 40 32 +field XKeymapEvent-key_vector
	drop 8 8 +field XKeymapEvent-serial
	drop 32 8 +field XKeymapEvent-window
	drop 0 4 +field XKeymapEvent-type
	drop 16 4 +field XKeymapEvent-send_event
drop 72 end-structure
\ XExposeEvent
begin-structure XExposeEvent
	drop 24 8 +field XExposeEvent-display
	drop 40 4 +field XExposeEvent-x
	drop 44 4 +field XExposeEvent-y
	drop 56 4 +field XExposeEvent-count
	drop 8 8 +field XExposeEvent-serial
	drop 32 8 +field XExposeEvent-window
	drop 0 4 +field XExposeEvent-type
	drop 52 4 +field XExposeEvent-height
	drop 16 4 +field XExposeEvent-send_event
	drop 48 4 +field XExposeEvent-width
drop 64 end-structure
\ XGraphicsExposeEvent
begin-structure XGraphicsExposeEvent
	drop 24 8 +field XGraphicsExposeEvent-display
	drop 40 4 +field XGraphicsExposeEvent-x
	drop 44 4 +field XGraphicsExposeEvent-y
	drop 56 4 +field XGraphicsExposeEvent-count
	drop 8 8 +field XGraphicsExposeEvent-serial
	drop 32 8 +field XGraphicsExposeEvent-drawable
	drop 0 4 +field XGraphicsExposeEvent-type
	drop 52 4 +field XGraphicsExposeEvent-height
	drop 16 4 +field XGraphicsExposeEvent-send_event
	drop 48 4 +field XGraphicsExposeEvent-width
	drop 60 4 +field XGraphicsExposeEvent-major_code
	drop 64 4 +field XGraphicsExposeEvent-minor_code
drop 72 end-structure
\ XNoExposeEvent
begin-structure XNoExposeEvent
	drop 24 8 +field XNoExposeEvent-display
	drop 8 8 +field XNoExposeEvent-serial
	drop 32 8 +field XNoExposeEvent-drawable
	drop 0 4 +field XNoExposeEvent-type
	drop 16 4 +field XNoExposeEvent-send_event
	drop 40 4 +field XNoExposeEvent-major_code
	drop 44 4 +field XNoExposeEvent-minor_code
drop 48 end-structure
\ XVisibilityEvent
begin-structure XVisibilityEvent
	drop 24 8 +field XVisibilityEvent-display
	drop 8 8 +field XVisibilityEvent-serial
	drop 32 8 +field XVisibilityEvent-window
	drop 0 4 +field XVisibilityEvent-type
	drop 16 4 +field XVisibilityEvent-send_event
	drop 40 4 +field XVisibilityEvent-state
drop 48 end-structure
\ XCreateWindowEvent
begin-structure XCreateWindowEvent
	drop 24 8 +field XCreateWindowEvent-display
	drop 48 4 +field XCreateWindowEvent-x
	drop 52 4 +field XCreateWindowEvent-y
	drop 8 8 +field XCreateWindowEvent-serial
	drop 40 8 +field XCreateWindowEvent-window
	drop 68 4 +field XCreateWindowEvent-override_redirect
	drop 0 4 +field XCreateWindowEvent-type
	drop 60 4 +field XCreateWindowEvent-height
	drop 64 4 +field XCreateWindowEvent-border_width
	drop 16 4 +field XCreateWindowEvent-send_event
	drop 32 8 +field XCreateWindowEvent-parent
	drop 56 4 +field XCreateWindowEvent-width
drop 72 end-structure
\ XDestroyWindowEvent
begin-structure XDestroyWindowEvent
	drop 24 8 +field XDestroyWindowEvent-display
	drop 8 8 +field XDestroyWindowEvent-serial
	drop 40 8 +field XDestroyWindowEvent-window
	drop 0 4 +field XDestroyWindowEvent-type
	drop 16 4 +field XDestroyWindowEvent-send_event
	drop 32 8 +field XDestroyWindowEvent-event
drop 48 end-structure
\ XUnmapEvent
begin-structure XUnmapEvent
	drop 24 8 +field XUnmapEvent-display
	drop 8 8 +field XUnmapEvent-serial
	drop 40 8 +field XUnmapEvent-window
	drop 0 4 +field XUnmapEvent-type
	drop 48 4 +field XUnmapEvent-from_configure
	drop 16 4 +field XUnmapEvent-send_event
	drop 32 8 +field XUnmapEvent-event
drop 56 end-structure
\ XMapEvent
begin-structure XMapEvent
	drop 24 8 +field XMapEvent-display
	drop 8 8 +field XMapEvent-serial
	drop 40 8 +field XMapEvent-window
	drop 48 4 +field XMapEvent-override_redirect
	drop 0 4 +field XMapEvent-type
	drop 16 4 +field XMapEvent-send_event
	drop 32 8 +field XMapEvent-event
drop 56 end-structure
\ XMapRequestEvent
begin-structure XMapRequestEvent
	drop 24 8 +field XMapRequestEvent-display
	drop 8 8 +field XMapRequestEvent-serial
	drop 40 8 +field XMapRequestEvent-window
	drop 0 4 +field XMapRequestEvent-type
	drop 16 4 +field XMapRequestEvent-send_event
	drop 32 8 +field XMapRequestEvent-parent
drop 48 end-structure
\ XReparentEvent
begin-structure XReparentEvent
	drop 24 8 +field XReparentEvent-display
	drop 56 4 +field XReparentEvent-x
	drop 60 4 +field XReparentEvent-y
	drop 8 8 +field XReparentEvent-serial
	drop 40 8 +field XReparentEvent-window
	drop 64 4 +field XReparentEvent-override_redirect
	drop 0 4 +field XReparentEvent-type
	drop 16 4 +field XReparentEvent-send_event
	drop 48 8 +field XReparentEvent-parent
	drop 32 8 +field XReparentEvent-event
drop 72 end-structure
\ XConfigureEvent
begin-structure XConfigureEvent
	drop 24 8 +field XConfigureEvent-display
	drop 72 8 +field XConfigureEvent-above
	drop 48 4 +field XConfigureEvent-x
	drop 52 4 +field XConfigureEvent-y
	drop 8 8 +field XConfigureEvent-serial
	drop 40 8 +field XConfigureEvent-window
	drop 80 4 +field XConfigureEvent-override_redirect
	drop 0 4 +field XConfigureEvent-type
	drop 60 4 +field XConfigureEvent-height
	drop 64 4 +field XConfigureEvent-border_width
	drop 16 4 +field XConfigureEvent-send_event
	drop 56 4 +field XConfigureEvent-width
	drop 32 8 +field XConfigureEvent-event
drop 88 end-structure
\ XGravityEvent
begin-structure XGravityEvent
	drop 24 8 +field XGravityEvent-display
	drop 48 4 +field XGravityEvent-x
	drop 52 4 +field XGravityEvent-y
	drop 8 8 +field XGravityEvent-serial
	drop 40 8 +field XGravityEvent-window
	drop 0 4 +field XGravityEvent-type
	drop 16 4 +field XGravityEvent-send_event
	drop 32 8 +field XGravityEvent-event
drop 56 end-structure
\ XResizeRequestEvent
begin-structure XResizeRequestEvent
	drop 24 8 +field XResizeRequestEvent-display
	drop 8 8 +field XResizeRequestEvent-serial
	drop 32 8 +field XResizeRequestEvent-window
	drop 0 4 +field XResizeRequestEvent-type
	drop 44 4 +field XResizeRequestEvent-height
	drop 16 4 +field XResizeRequestEvent-send_event
	drop 40 4 +field XResizeRequestEvent-width
drop 48 end-structure
\ XConfigureRequestEvent
begin-structure XConfigureRequestEvent
	drop 40 8 +field XConfigureRequestEvent-window
	drop 8 8 +field XConfigureRequestEvent-serial
	drop 48 4 +field XConfigureRequestEvent-x
	drop 52 4 +field XConfigureRequestEvent-y
	drop 60 4 +field XConfigureRequestEvent-height
	drop 64 4 +field XConfigureRequestEvent-border_width
	drop 88 8 +field XConfigureRequestEvent-value_mask
	drop 72 8 +field XConfigureRequestEvent-above
	drop 24 8 +field XConfigureRequestEvent-display
	drop 80 4 +field XConfigureRequestEvent-detail
	drop 56 4 +field XConfigureRequestEvent-width
	drop 0 4 +field XConfigureRequestEvent-type
	drop 16 4 +field XConfigureRequestEvent-send_event
	drop 32 8 +field XConfigureRequestEvent-parent
drop 96 end-structure
\ XCirculateEvent
begin-structure XCirculateEvent
	drop 24 8 +field XCirculateEvent-display
	drop 48 4 +field XCirculateEvent-place
	drop 8 8 +field XCirculateEvent-serial
	drop 40 8 +field XCirculateEvent-window
	drop 0 4 +field XCirculateEvent-type
	drop 16 4 +field XCirculateEvent-send_event
	drop 32 8 +field XCirculateEvent-event
drop 56 end-structure
\ XCirculateRequestEvent
begin-structure XCirculateRequestEvent
	drop 24 8 +field XCirculateRequestEvent-display
	drop 48 4 +field XCirculateRequestEvent-place
	drop 8 8 +field XCirculateRequestEvent-serial
	drop 40 8 +field XCirculateRequestEvent-window
	drop 0 4 +field XCirculateRequestEvent-type
	drop 16 4 +field XCirculateRequestEvent-send_event
	drop 32 8 +field XCirculateRequestEvent-parent
drop 56 end-structure
\ XPropertyEvent
begin-structure XPropertyEvent
	drop 24 8 +field XPropertyEvent-display
	drop 40 8 +field XPropertyEvent-atom
	drop 48 8 +field XPropertyEvent-time
	drop 8 8 +field XPropertyEvent-serial
	drop 32 8 +field XPropertyEvent-window
	drop 0 4 +field XPropertyEvent-type
	drop 16 4 +field XPropertyEvent-send_event
	drop 56 4 +field XPropertyEvent-state
drop 64 end-structure
\ XSelectionClearEvent
begin-structure XSelectionClearEvent
	drop 24 8 +field XSelectionClearEvent-display
	drop 48 8 +field XSelectionClearEvent-time
	drop 8 8 +field XSelectionClearEvent-serial
	drop 32 8 +field XSelectionClearEvent-window
	drop 0 4 +field XSelectionClearEvent-type
	drop 16 4 +field XSelectionClearEvent-send_event
	drop 40 8 +field XSelectionClearEvent-selection
drop 56 end-structure
\ XSelectionRequestEvent
begin-structure XSelectionRequestEvent
	drop 24 8 +field XSelectionRequestEvent-display
	drop 40 8 +field XSelectionRequestEvent-requestor
	drop 64 8 +field XSelectionRequestEvent-property
	drop 56 8 +field XSelectionRequestEvent-target
	drop 72 8 +field XSelectionRequestEvent-time
	drop 8 8 +field XSelectionRequestEvent-serial
	drop 0 4 +field XSelectionRequestEvent-type
	drop 16 4 +field XSelectionRequestEvent-send_event
	drop 32 8 +field XSelectionRequestEvent-owner
	drop 48 8 +field XSelectionRequestEvent-selection
drop 80 end-structure
\ XSelectionEvent
begin-structure XSelectionEvent
	drop 24 8 +field XSelectionEvent-display
	drop 32 8 +field XSelectionEvent-requestor
	drop 56 8 +field XSelectionEvent-property
	drop 48 8 +field XSelectionEvent-target
	drop 64 8 +field XSelectionEvent-time
	drop 8 8 +field XSelectionEvent-serial
	drop 0 4 +field XSelectionEvent-type
	drop 16 4 +field XSelectionEvent-send_event
	drop 40 8 +field XSelectionEvent-selection
drop 72 end-structure
\ XColormapEvent
begin-structure XColormapEvent
	drop 24 8 +field XColormapEvent-display
	drop 48 4 +field XColormapEvent-new
	drop 8 8 +field XColormapEvent-serial
	drop 32 8 +field XColormapEvent-window
	drop 0 4 +field XColormapEvent-type
	drop 16 4 +field XColormapEvent-send_event
	drop 40 8 +field XColormapEvent-colormap
	drop 52 4 +field XColormapEvent-state
drop 56 end-structure
\ XClientMessageEvent
begin-structure XClientMessageEvent
	drop 24 8 +field XClientMessageEvent-display
	drop 56 40 +field XClientMessageEvent-data
	drop 40 8 +field XClientMessageEvent-message_type
	drop 8 8 +field XClientMessageEvent-serial
	drop 32 8 +field XClientMessageEvent-window
	drop 0 4 +field XClientMessageEvent-type
	drop 16 4 +field XClientMessageEvent-send_event
	drop 48 4 +field XClientMessageEvent-format
drop 96 end-structure
\ XClientMessageEvent_data
begin-structure XClientMessageEvent_data
	drop 0 20 +field XClientMessageEvent_data-b
	drop 0 20 +field XClientMessageEvent_data-s
	drop 0 40 +field XClientMessageEvent_data-l
drop 40 end-structure
\ XMappingEvent
begin-structure XMappingEvent
	drop 24 8 +field XMappingEvent-display
	drop 40 4 +field XMappingEvent-request
	drop 44 4 +field XMappingEvent-first_keycode
	drop 48 4 +field XMappingEvent-count
	drop 8 8 +field XMappingEvent-serial
	drop 32 8 +field XMappingEvent-window
	drop 0 4 +field XMappingEvent-type
	drop 16 4 +field XMappingEvent-send_event
drop 56 end-structure
\ XErrorEvent
begin-structure XErrorEvent
	drop 8 8 +field XErrorEvent-display
	drop 16 8 +field XErrorEvent-resourceid
	drop 24 8 +field XErrorEvent-serial
	drop 33 1 +field XErrorEvent-request_code
	drop 0 4 +field XErrorEvent-type
	drop 32 1 +field XErrorEvent-error_code
	drop 34 1 +field XErrorEvent-minor_code
drop 40 end-structure
\ XAnyEvent
begin-structure XAnyEvent
	drop 24 8 +field XAnyEvent-display
	drop 8 8 +field XAnyEvent-serial
	drop 32 8 +field XAnyEvent-window
	drop 0 4 +field XAnyEvent-type
	drop 16 4 +field XAnyEvent-send_event
drop 40 end-structure
\ XGenericEvent
begin-structure XGenericEvent
	drop 24 8 +field XGenericEvent-display
	drop 32 4 +field XGenericEvent-extension
	drop 8 8 +field XGenericEvent-serial
	drop 0 4 +field XGenericEvent-type
	drop 36 4 +field XGenericEvent-evtype
	drop 16 4 +field XGenericEvent-send_event
drop 40 end-structure
\ XGenericEventCookie
begin-structure XGenericEventCookie
	drop 24 8 +field XGenericEventCookie-display
	drop 32 4 +field XGenericEventCookie-extension
	drop 48 8 +field XGenericEventCookie-data
	drop 40 4 +field XGenericEventCookie-cookie
	drop 8 8 +field XGenericEventCookie-serial
	drop 0 4 +field XGenericEventCookie-type
	drop 36 4 +field XGenericEventCookie-evtype
	drop 16 4 +field XGenericEventCookie-send_event
drop 56 end-structure
\ XEvent
begin-structure XEvent
drop 192 end-structure
\ XCharStruct
begin-structure XCharStruct
	drop 6 2 +field XCharStruct-ascent
	drop 4 2 +field XCharStruct-width
	drop 8 2 +field XCharStruct-descent
	drop 10 2 +field XCharStruct-attributes
	drop 0 2 +field XCharStruct-lbearing
	drop 2 2 +field XCharStruct-rbearing
drop 12 end-structure
\ XFontProp
begin-structure XFontProp
	drop 0 8 +field XFontProp-name
	drop 8 8 +field XFontProp-card32
drop 16 end-structure
\ XFontStruct
begin-structure XFontStruct
	drop 16 4 +field XFontStruct-direction
	drop 88 4 +field XFontStruct-ascent
	drop 32 4 +field XFontStruct-max_byte1
	drop 28 4 +field XFontStruct-min_byte1
	drop 24 4 +field XFontStruct-max_char_or_byte2
	drop 20 4 +field XFontStruct-min_char_or_byte2
	drop 0 8 +field XFontStruct-ext_data
	drop 36 4 +field XFontStruct-all_chars_exist
	drop 68 12 +field XFontStruct-max_bounds
	drop 56 12 +field XFontStruct-min_bounds
	drop 8 8 +field XFontStruct-fid
	drop 48 8 +field XFontStruct-properties
	drop 44 4 +field XFontStruct-n_properties
	drop 92 4 +field XFontStruct-descent
	drop 40 4 +field XFontStruct-default_char
	drop 80 8 +field XFontStruct-per_char
drop 96 end-structure
\ XTextItem
begin-structure XTextItem
	drop 12 4 +field XTextItem-delta
	drop 0 8 +field XTextItem-chars
	drop 16 8 +field XTextItem-font
	drop 8 4 +field XTextItem-nchars
drop 24 end-structure
\ XChar2b
begin-structure XChar2b
	drop 0 1 +field XChar2b-byte1
	drop 1 1 +field XChar2b-byte2
drop 2 end-structure
\ XTextItem16
begin-structure XTextItem16
	drop 12 4 +field XTextItem16-delta
	drop 0 8 +field XTextItem16-chars
	drop 16 8 +field XTextItem16-font
	drop 8 4 +field XTextItem16-nchars
drop 24 end-structure
\ XEDataObject
begin-structure XEDataObject
	drop 0 8 +field XEDataObject-display
	drop 0 8 +field XEDataObject-gc
	drop 0 8 +field XEDataObject-visual
	drop 0 8 +field XEDataObject-pixmap_format
	drop 0 8 +field XEDataObject-screen
	drop 0 8 +field XEDataObject-font
drop 8 end-structure
\ XFontSetExtents
begin-structure XFontSetExtents
	drop 0 8 +field XFontSetExtents-max_ink_extent
	drop 8 8 +field XFontSetExtents-max_logical_extent
drop 16 end-structure
\ XmbTextItem
begin-structure XmbTextItem
	drop 16 8 +field XmbTextItem-font_set
	drop 12 4 +field XmbTextItem-delta
	drop 0 8 +field XmbTextItem-chars
	drop 8 4 +field XmbTextItem-nchars
drop 24 end-structure
\ XwcTextItem
begin-structure XwcTextItem
	drop 16 8 +field XwcTextItem-font_set
	drop 12 4 +field XwcTextItem-delta
	drop 0 8 +field XwcTextItem-chars
	drop 8 4 +field XwcTextItem-nchars
drop 24 end-structure
\ XOMCharSetList
begin-structure XOMCharSetList
	drop 0 4 +field XOMCharSetList-charset_count
	drop 8 8 +field XOMCharSetList-charset_list
drop 16 end-structure
\ XOMOrientation
begin-structure XOMOrientation
	drop 0 4 +field XOMOrientation-num_orientation
	drop 8 8 +field XOMOrientation-orientation
drop 16 end-structure
\ XOMFontInfo
begin-structure XOMFontInfo
	drop 16 8 +field XOMFontInfo-font_name_list
	drop 0 4 +field XOMFontInfo-num_font
	drop 8 8 +field XOMFontInfo-font_struct_list
drop 24 end-structure
\ XIMStyles
begin-structure XIMStyles
	drop 0 2 +field XIMStyles-count_styles
	drop 8 8 +field XIMStyles-supported_styles
drop 16 end-structure
\ XIMCallback
begin-structure XIMCallback
	drop 0 8 +field XIMCallback-client_data
	drop 8 8 +field XIMCallback-callback
drop 16 end-structure
\ XICCallback
begin-structure XICCallback
	drop 0 8 +field XICCallback-client_data
	drop 8 8 +field XICCallback-callback
drop 16 end-structure
\ XIMText
begin-structure XIMText
drop 32 end-structure
\ _XIMText_string
begin-structure _XIMText_string
	drop 0 8 +field _XIMText_string-multi_byte
	drop 0 8 +field _XIMText_string-wide_char
drop 8 end-structure
\ XIMPreeditStateNotifyCallbackStruct
begin-structure XIMPreeditStateNotifyCallbackStruct
drop 8 end-structure
\ XIMStringConversionText
begin-structure XIMStringConversionText
drop 32 end-structure
\ _XIMStringConversionText_string
begin-structure _XIMStringConversionText_string
	drop 0 8 +field _XIMStringConversionText_string-wcs
	drop 0 8 +field _XIMStringConversionText_string-mbs
drop 8 end-structure
\ XIMStringConversionCallbackStruct
begin-structure XIMStringConversionCallbackStruct
drop 24 end-structure
\ XIMPreeditDrawCallbackStruct
begin-structure XIMPreeditDrawCallbackStruct
drop 24 end-structure
\ XIMPreeditCaretCallbackStruct
begin-structure XIMPreeditCaretCallbackStruct
drop 12 end-structure
\ XIMStatusDrawCallbackStruct
begin-structure XIMStatusDrawCallbackStruct
drop 16 end-structure
\ _XIMStatusDrawCallbackStruct_data
begin-structure _XIMStatusDrawCallbackStruct_data
	drop 0 8 +field _XIMStatusDrawCallbackStruct_data-text
	drop 0 8 +field _XIMStatusDrawCallbackStruct_data-bitmap
drop 8 end-structure
\ XIMHotKeyTrigger
begin-structure XIMHotKeyTrigger
drop 16 end-structure
\ XIMHotKeyTriggers
begin-structure XIMHotKeyTriggers
drop 16 end-structure
\ XIMValuesList
begin-structure XIMValuesList
	drop 0 2 +field XIMValuesList-count_values
	drop 8 8 +field XIMValuesList-supported_values
drop 16 end-structure
\ XSizeHints
begin-structure XSizeHints
	drop 44 4 +field XSizeHints-height_inc
	drop 8 4 +field XSizeHints-x
	drop 72 4 +field XSizeHints-win_gravity
	drop 12 4 +field XSizeHints-y
	drop 20 4 +field XSizeHints-height
	drop 32 4 +field XSizeHints-max_width
	drop 24 4 +field XSizeHints-min_width
	drop 36 4 +field XSizeHints-max_height
	drop 28 4 +field XSizeHints-min_height
	drop 68 4 +field XSizeHints-base_height
	drop 64 4 +field XSizeHints-base_width
	drop 16 4 +field XSizeHints-width
	drop 56 8 +field XSizeHints-max_aspect
	drop 48 8 +field XSizeHints-min_aspect
	drop 0 8 +field XSizeHints-flags
	drop 40 4 +field XSizeHints-width_inc
drop 80 end-structure
\ XSizeHints_min_aspect
begin-structure XSizeHints_min_aspect
	drop 0 4 +field XSizeHints_min_aspect-x
	drop 4 4 +field XSizeHints_min_aspect-y
drop 8 end-structure
\ XWMHints
begin-structure XWMHints
	drop 32 4 +field XWMHints-icon_x
	drop 8 4 +field XWMHints-input
	drop 36 4 +field XWMHints-icon_y
	drop 16 8 +field XWMHints-icon_pixmap
	drop 24 8 +field XWMHints-icon_window
	drop 48 8 +field XWMHints-window_group
	drop 12 4 +field XWMHints-initial_state
	drop 40 8 +field XWMHints-icon_mask
	drop 0 8 +field XWMHints-flags
drop 56 end-structure
\ XTextProperty
begin-structure XTextProperty
	drop 8 8 +field XTextProperty-encoding
	drop 24 8 +field XTextProperty-nitems
	drop 0 8 +field XTextProperty-value
	drop 16 4 +field XTextProperty-format
drop 32 end-structure
\ XIconSize
begin-structure XIconSize
	drop 20 4 +field XIconSize-height_inc
	drop 4 4 +field XIconSize-min_height
	drop 12 4 +field XIconSize-max_height
	drop 0 4 +field XIconSize-min_width
	drop 8 4 +field XIconSize-max_width
	drop 16 4 +field XIconSize-width_inc
drop 24 end-structure
\ XClassHint
begin-structure XClassHint
	drop 8 8 +field XClassHint-res_class
	drop 0 8 +field XClassHint-res_name
drop 16 end-structure
\ XComposeStatus
begin-structure XComposeStatus
drop 16 end-structure
\ XVisualInfo
begin-structure XVisualInfo
	drop 48 8 +field XVisualInfo-blue_mask
	drop 0 8 +field XVisualInfo-visual
	drop 8 8 +field XVisualInfo-visualid
	drop 56 4 +field XVisualInfo-colormap_size
	drop 40 8 +field XVisualInfo-green_mask
	drop 16 4 +field XVisualInfo-screen
	drop 20 4 +field XVisualInfo-depth
	drop 32 8 +field XVisualInfo-red_mask
	drop 60 4 +field XVisualInfo-bits_per_rgb
	drop 24 4 +field XVisualInfo-class
drop 64 end-structure
\ XStandardColormap
begin-structure XStandardColormap
	drop 8 8 +field XStandardColormap-red_max
	drop 48 8 +field XStandardColormap-blue_mult
	drop 40 8 +field XStandardColormap-blue_max
	drop 56 8 +field XStandardColormap-base_pixel
	drop 64 8 +field XStandardColormap-visualid
	drop 24 8 +field XStandardColormap-green_max
	drop 32 8 +field XStandardColormap-green_mult
	drop 0 8 +field XStandardColormap-colormap
	drop 16 8 +field XStandardColormap-red_mult
	drop 72 8 +field XStandardColormap-killid
drop 80 end-structure
\ XSyncSystemCounter
begin-structure XSyncSystemCounter
drop 24 end-structure
\ XSyncTrigger
begin-structure XSyncTrigger
	drop 0 8 +field XSyncTrigger-counter
	drop 8 4 +field XSyncTrigger-value_type
	drop 12 8 +field XSyncTrigger-wait_value
	drop 20 4 +field XSyncTrigger-test_type
drop 24 end-structure
\ XSyncWaitCondition
begin-structure XSyncWaitCondition
	drop 0 24 +field XSyncWaitCondition-trigger
	drop 24 8 +field XSyncWaitCondition-event_threshold
drop 32 end-structure
\ XSyncAlarmAttributes
begin-structure XSyncAlarmAttributes
	drop 0 24 +field XSyncAlarmAttributes-trigger
	drop 24 8 +field XSyncAlarmAttributes-delta
	drop 32 4 +field XSyncAlarmAttributes-events
	drop 36 4 +field XSyncAlarmAttributes-state
drop 40 end-structure
\ XSyncCounterNotifyEvent
begin-structure XSyncCounterNotifyEvent
	drop 24 8 +field XSyncCounterNotifyEvent-display
	drop 32 8 +field XSyncCounterNotifyEvent-counter
	drop 40 8 +field XSyncCounterNotifyEvent-wait_value
	drop 48 8 +field XSyncCounterNotifyEvent-counter_value
	drop 56 8 +field XSyncCounterNotifyEvent-time
	drop 64 4 +field XSyncCounterNotifyEvent-count
	drop 68 4 +field XSyncCounterNotifyEvent-destroyed
	drop 8 8 +field XSyncCounterNotifyEvent-serial
	drop 0 4 +field XSyncCounterNotifyEvent-type
	drop 16 4 +field XSyncCounterNotifyEvent-send_event
drop 72 end-structure
\ XSyncAlarmNotifyEvent
begin-structure XSyncAlarmNotifyEvent
	drop 24 8 +field XSyncAlarmNotifyEvent-display
	drop 48 8 +field XSyncAlarmNotifyEvent-alarm_value
	drop 32 8 +field XSyncAlarmNotifyEvent-alarm
	drop 40 8 +field XSyncAlarmNotifyEvent-counter_value
	drop 56 8 +field XSyncAlarmNotifyEvent-time
	drop 8 8 +field XSyncAlarmNotifyEvent-serial
	drop 0 4 +field XSyncAlarmNotifyEvent-type
	drop 16 4 +field XSyncAlarmNotifyEvent-send_event
	drop 64 4 +field XSyncAlarmNotifyEvent-state
drop 72 end-structure
\ XSyncAlarmError
begin-structure XSyncAlarmError
	drop 8 8 +field XSyncAlarmError-display
	drop 16 8 +field XSyncAlarmError-alarm
	drop 24 8 +field XSyncAlarmError-serial
	drop 33 1 +field XSyncAlarmError-request_code
	drop 0 4 +field XSyncAlarmError-type
	drop 32 1 +field XSyncAlarmError-error_code
	drop 34 1 +field XSyncAlarmError-minor_code
drop 40 end-structure
\ XSyncCounterError
begin-structure XSyncCounterError
	drop 8 8 +field XSyncCounterError-display
	drop 16 8 +field XSyncCounterError-counter
	drop 24 8 +field XSyncCounterError-serial
	drop 33 1 +field XSyncCounterError-request_code
	drop 0 4 +field XSyncCounterError-type
	drop 32 1 +field XSyncCounterError-error_code
	drop 34 1 +field XSyncCounterError-minor_code
drop 40 end-structure

\ --===< function pointers >===---
c-funptr _XExtData-free_private() {((struct _XExtData*)ptr)->free_private} a -- n	( extension -- )
c-funptr funcs-create_image() {((struct funcs*)ptr)->create_image} a a u n n a u u n n -- a	( <noname> <noname> <noname> <noname> <noname> <noname> <noname> <noname> <noname> <noname> -- )
c-funptr funcs-destroy_image() {((struct funcs*)ptr)->destroy_image} a -- n	( <noname> -- )
c-funptr funcs-get_pixel() {((struct funcs*)ptr)->get_pixel} a n n -- u	( <noname> <noname> <noname> -- )
c-funptr funcs-put_pixel() {((struct funcs*)ptr)->put_pixel} a n n u -- n	( <noname> <noname> <noname> <noname> -- )
c-funptr funcs-sub_image() {((struct funcs*)ptr)->sub_image} a n n u u -- a	( <noname> <noname> <noname> <noname> <noname> -- )
c-funptr funcs-add_pixel() {((struct funcs*)ptr)->add_pixel} a n -- n	( <noname> <noname> -- )

\ ------===< callbacks >===-------
c-callback XIMProc: a a a -- void	( <noname> <noname> <noname> -- )
c-callback XICProc: a a a -- n	( <noname> <noname> <noname> -- )
c-callback XIDProc: a a a -- void	( <noname> <noname> <noname> -- )
c-callback XErrorHandler: a a -- n	( <noname> <noname> -- )
c-callback XIOErrorHandler: a -- n	( <noname> -- )
c-callback XIOErrorExitHandler: a a -- void	( <noname> <noname> -- )
c-callback XConnectionWatchProc: a a n n a -- void	( <noname> <noname> <noname> <noname> <noname> -- )

\ ------===< functions >===-------
c-function _Xmblen _Xmblen a n -- n	( str len -- )
c-function XLoadQueryFont XLoadQueryFont a s -- a	( <noname> <noname> -- )
c-function XQueryFont XQueryFont a u -- a	( <noname> <noname> -- )
c-function XGetMotionEvents XGetMotionEvents a u u u a -- a	( <noname> <noname> <noname> <noname> <noname> -- )
c-function XDeleteModifiermapEntry XDeleteModifiermapEntry a u n -- a	( <noname> <noname> <noname> -- )
c-function XGetModifierMapping XGetModifierMapping a -- a	( <noname> -- )
c-function XInsertModifiermapEntry XInsertModifiermapEntry a u n -- a	( <noname> <noname> <noname> -- )
c-function XNewModifiermap XNewModifiermap n -- a	( <noname> -- )
c-function XCreateImage XCreateImage a a u n n a u u n n -- a	( <noname> <noname> <noname> <noname> <noname> <noname> <noname> <noname> <noname> <noname> -- )
c-function XInitImage XInitImage a -- n	( <noname> -- )
c-function XGetImage XGetImage a u n n u u u n -- a	( <noname> <noname> <noname> <noname> <noname> <noname> <noname> <noname> -- )
c-function XGetSubImage XGetSubImage a u n n u u u n a n n -- a	( <noname> <noname> <noname> <noname> <noname> <noname> <noname> <noname> <noname> <noname> <noname> -- )
c-function XOpenDisplay XOpenDisplay s -- a	( <noname> -- )
c-function XrmInitialize XrmInitialize  -- void	( -- )
c-function XFetchBytes XFetchBytes a a -- a	( <noname> <noname> -- )
c-function XFetchBuffer XFetchBuffer a a n -- a	( <noname> <noname> <noname> -- )
c-function XGetAtomName XGetAtomName a u -- a	( <noname> <noname> -- )
c-function XGetAtomNames XGetAtomNames a a n a -- n	( <noname> <noname> <noname> <noname> -- )
c-function XGetDefault XGetDefault a s s -- a	( <noname> <noname> <noname> -- )
c-function XDisplayName XDisplayName s -- a	( <noname> -- )
c-function XKeysymToString XKeysymToString u -- a	( <noname> -- )
c-function XSynchronize XSynchronize a n -- a	( <noname> <noname> -- )
c-function XSetAfterFunction XSetAfterFunction a a -- a	( <noname> <noname> -- )
c-function XInternAtom XInternAtom a s n -- u	( <noname> <noname> <noname> -- )
c-function XInternAtoms XInternAtoms a a n n a -- n	( <noname> <noname> <noname> <noname> <noname> -- )
c-function XCopyColormapAndFree XCopyColormapAndFree a u -- u	( <noname> <noname> -- )
c-function XCreateColormap XCreateColormap a u a n -- u	( <noname> <noname> <noname> <noname> -- )
c-function XCreatePixmapCursor XCreatePixmapCursor a u u a a u u -- u	( <noname> <noname> <noname> <noname> <noname> <noname> <noname> -- )
c-function XCreateGlyphCursor XCreateGlyphCursor a u u u u a a -- u	( <noname> <noname> <noname> <noname> <noname> <noname> <noname> -- )
c-function XCreateFontCursor XCreateFontCursor a u -- u	( <noname> <noname> -- )
c-function XLoadFont XLoadFont a s -- u	( <noname> <noname> -- )
c-function XCreateGC XCreateGC a u u a -- a	( <noname> <noname> <noname> <noname> -- )
c-function XGContextFromGC XGContextFromGC a -- u	( <noname> -- )
c-function XFlushGC XFlushGC a a -- void	( <noname> <noname> -- )
c-function XCreatePixmap XCreatePixmap a u u u u -- u	( <noname> <noname> <noname> <noname> <noname> -- )
c-function XCreateBitmapFromData XCreateBitmapFromData a u a u u -- u	( <noname> <noname> <noname> <noname> <noname> -- )
c-function XCreatePixmapFromBitmapData XCreatePixmapFromBitmapData a u a u u u u u -- u	( <noname> <noname> <noname> <noname> <noname> <noname> <noname> <noname> -- )
c-function XCreateSimpleWindow XCreateSimpleWindow a u n n u u u u u -- u	( <noname> <noname> <noname> <noname> <noname> <noname> <noname> <noname> <noname> -- )
c-function XGetSelectionOwner XGetSelectionOwner a u -- u	( <noname> <noname> -- )
c-function XCreateWindow XCreateWindow a u n n u u u n u a u a -- u	( <noname> <noname> <noname> <noname> <noname> <noname> <noname> <noname> <noname> <noname> <noname> <noname> -- )
c-function XListInstalledColormaps XListInstalledColormaps a u a -- a	( <noname> <noname> <noname> -- )
c-function XListFonts XListFonts a s n a -- a	( <noname> <noname> <noname> <noname> -- )
c-function XListFontsWithInfo XListFontsWithInfo a s n a a -- a	( <noname> <noname> <noname> <noname> <noname> -- )
c-function XGetFontPath XGetFontPath a a -- a	( <noname> <noname> -- )
c-function XListExtensions XListExtensions a a -- a	( <noname> <noname> -- )
c-function XListProperties XListProperties a u a -- a	( <noname> <noname> <noname> -- )
c-function XListHosts XListHosts a a a -- a	( <noname> <noname> <noname> -- )
c-function XKeycodeToKeysym XKeycodeToKeysym a u n -- u	( <noname> <noname> <noname> -- )
c-function XLookupKeysym XLookupKeysym a n -- u	( <noname> <noname> -- )
c-function XGetKeyboardMapping XGetKeyboardMapping a u n a -- a	( <noname> <noname> <noname> <noname> -- )
c-function XStringToKeysym XStringToKeysym s -- u	( <noname> -- )
c-function XMaxRequestSize XMaxRequestSize a -- n	( <noname> -- )
c-function XExtendedMaxRequestSize XExtendedMaxRequestSize a -- n	( <noname> -- )
c-function XResourceManagerString XResourceManagerString a -- a	( <noname> -- )
c-function XScreenResourceString XScreenResourceString a -- a	( <noname> -- )
c-function XDisplayMotionBufferSize XDisplayMotionBufferSize a -- u	( <noname> -- )
c-function XVisualIDFromVisual XVisualIDFromVisual a -- u	( <noname> -- )
c-function XInitThreads XInitThreads  -- n	( -- )
c-function XLockDisplay XLockDisplay a -- void	( <noname> -- )
c-function XUnlockDisplay XUnlockDisplay a -- void	( <noname> -- )
c-function XInitExtension XInitExtension a s -- a	( <noname> <noname> -- )
c-function XAddExtension XAddExtension a -- a	( <noname> -- )
c-function XFindOnExtensionList XFindOnExtensionList a n -- a	( <noname> <noname> -- )
c-function XEHeadOfExtensionList XEHeadOfExtensionList a{*(XEDataObject*)} -- a	( <noname> -- )
c-function XRootWindow XRootWindow a n -- u	( <noname> <noname> -- )
c-function XDefaultRootWindow XDefaultRootWindow a -- u	( <noname> -- )
c-function XRootWindowOfScreen XRootWindowOfScreen a -- u	( <noname> -- )
c-function XDefaultVisual XDefaultVisual a n -- a	( <noname> <noname> -- )
c-function XDefaultVisualOfScreen XDefaultVisualOfScreen a -- a	( <noname> -- )
c-function XDefaultGC XDefaultGC a n -- a	( <noname> <noname> -- )
c-function XDefaultGCOfScreen XDefaultGCOfScreen a -- a	( <noname> -- )
c-function XBlackPixel XBlackPixel a n -- u	( <noname> <noname> -- )
c-function XWhitePixel XWhitePixel a n -- u	( <noname> <noname> -- )
c-function XAllPlanes XAllPlanes  -- u	( -- )
c-function XBlackPixelOfScreen XBlackPixelOfScreen a -- u	( <noname> -- )
c-function XWhitePixelOfScreen XWhitePixelOfScreen a -- u	( <noname> -- )
c-function XNextRequest XNextRequest a -- u	( <noname> -- )
c-function XLastKnownRequestProcessed XLastKnownRequestProcessed a -- u	( <noname> -- )
c-function XServerVendor XServerVendor a -- a	( <noname> -- )
c-function XDisplayString XDisplayString a -- a	( <noname> -- )
c-function XDefaultColormap XDefaultColormap a n -- u	( <noname> <noname> -- )
c-function XDefaultColormapOfScreen XDefaultColormapOfScreen a -- u	( <noname> -- )
c-function XDisplayOfScreen XDisplayOfScreen a -- a	( <noname> -- )
c-function XScreenOfDisplay XScreenOfDisplay a n -- a	( <noname> <noname> -- )
c-function XDefaultScreenOfDisplay XDefaultScreenOfDisplay a -- a	( <noname> -- )
c-function XEventMaskOfScreen XEventMaskOfScreen a -- n	( <noname> -- )
c-function XScreenNumberOfScreen XScreenNumberOfScreen a -- n	( <noname> -- )
c-function XSetErrorHandler XSetErrorHandler a -- a	( <noname> -- )
c-function XSetIOErrorHandler XSetIOErrorHandler a -- a	( <noname> -- )
c-function XSetIOErrorExitHandler XSetIOErrorExitHandler a a a -- void	( <noname> <noname> <noname> -- )
c-function XListPixmapFormats XListPixmapFormats a a -- a	( <noname> <noname> -- )
c-function XListDepths XListDepths a n a -- a	( <noname> <noname> <noname> -- )
c-function XReconfigureWMWindow XReconfigureWMWindow a u n u a -- n	( <noname> <noname> <noname> <noname> <noname> -- )
c-function XGetWMProtocols XGetWMProtocols a u a a -- n	( <noname> <noname> <noname> <noname> -- )
c-function XSetWMProtocols XSetWMProtocols a u a n -- n	( <noname> <noname> <noname> <noname> -- )
c-function XIconifyWindow XIconifyWindow a u n -- n	( <noname> <noname> <noname> -- )
c-function XWithdrawWindow XWithdrawWindow a u n -- n	( <noname> <noname> <noname> -- )
c-function XGetCommand XGetCommand a u a a -- n	( <noname> <noname> <noname> <noname> -- )
c-function XGetWMColormapWindows XGetWMColormapWindows a u a a -- n	( <noname> <noname> <noname> <noname> -- )
c-function XSetWMColormapWindows XSetWMColormapWindows a u a n -- n	( <noname> <noname> <noname> <noname> -- )
c-function XFreeStringList XFreeStringList a -- void	( <noname> -- )
c-function XSetTransientForHint XSetTransientForHint a u u -- n	( <noname> <noname> <noname> -- )
c-function XActivateScreenSaver XActivateScreenSaver a -- n	( <noname> -- )
c-function XAddHost XAddHost a a -- n	( <noname> <noname> -- )
c-function XAddHosts XAddHosts a a n -- n	( <noname> <noname> <noname> -- )
c-function XAddToExtensionList XAddToExtensionList a a -- n	( <noname> <noname> -- )
c-function XAddToSaveSet XAddToSaveSet a u -- n	( <noname> <noname> -- )
c-function XAllocColor XAllocColor a u a -- n	( <noname> <noname> <noname> -- )
c-function XAllocColorCells XAllocColorCells a u n a u a u -- n	( <noname> <noname> <noname> <noname> <noname> <noname> <noname> -- )
c-function XAllocColorPlanes XAllocColorPlanes a u n a n n n n a a a -- n	( <noname> <noname> <noname> <noname> <noname> <noname> <noname> <noname> <noname> <noname> <noname> -- )
c-function XAllocNamedColor XAllocNamedColor a u s a a -- n	( <noname> <noname> <noname> <noname> <noname> -- )
c-function XAllowEvents XAllowEvents a n u -- n	( <noname> <noname> <noname> -- )
c-function XAutoRepeatOff XAutoRepeatOff a -- n	( <noname> -- )
c-function XAutoRepeatOn XAutoRepeatOn a -- n	( <noname> -- )
c-function XBell XBell a n -- n	( <noname> <noname> -- )
c-function XBitmapBitOrder XBitmapBitOrder a -- n	( <noname> -- )
c-function XBitmapPad XBitmapPad a -- n	( <noname> -- )
c-function XBitmapUnit XBitmapUnit a -- n	( <noname> -- )
c-function XCellsOfScreen XCellsOfScreen a -- n	( <noname> -- )
c-function XChangeActivePointerGrab XChangeActivePointerGrab a u u u -- n	( <noname> <noname> <noname> <noname> -- )
c-function XChangeGC XChangeGC a a u a -- n	( <noname> <noname> <noname> <noname> -- )
c-function XChangeKeyboardControl XChangeKeyboardControl a u a -- n	( <noname> <noname> <noname> -- )
c-function XChangeKeyboardMapping XChangeKeyboardMapping a n n a n -- n	( <noname> <noname> <noname> <noname> <noname> -- )
c-function XChangePointerControl XChangePointerControl a n n n n n -- n	( <noname> <noname> <noname> <noname> <noname> <noname> -- )
c-function XChangeProperty XChangeProperty a u u u n n a n -- n	( <noname> <noname> <noname> <noname> <noname> <noname> <noname> <noname> -- )
c-function XChangeSaveSet XChangeSaveSet a u n -- n	( <noname> <noname> <noname> -- )
c-function XChangeWindowAttributes XChangeWindowAttributes a u u a -- n	( <noname> <noname> <noname> <noname> -- )
c-function XCheckIfEvent XCheckIfEvent a a a a -- n	( <noname> <noname> <noname> <noname> -- )
c-function XCheckMaskEvent XCheckMaskEvent a n a -- n	( <noname> <noname> <noname> -- )
c-function XCheckTypedEvent XCheckTypedEvent a n a -- n	( <noname> <noname> <noname> -- )
c-function XCheckTypedWindowEvent XCheckTypedWindowEvent a u n a -- n	( <noname> <noname> <noname> <noname> -- )
c-function XCheckWindowEvent XCheckWindowEvent a u n a -- n	( <noname> <noname> <noname> <noname> -- )
c-function XCirculateSubwindows XCirculateSubwindows a u n -- n	( <noname> <noname> <noname> -- )
c-function XCirculateSubwindowsDown XCirculateSubwindowsDown a u -- n	( <noname> <noname> -- )
c-function XCirculateSubwindowsUp XCirculateSubwindowsUp a u -- n	( <noname> <noname> -- )
c-function XClearArea XClearArea a u n n u u n -- n	( <noname> <noname> <noname> <noname> <noname> <noname> <noname> -- )
c-function XClearWindow XClearWindow a u -- n	( <noname> <noname> -- )
c-function XCloseDisplay XCloseDisplay a -- n	( <noname> -- )
c-function XConfigureWindow XConfigureWindow a u u a -- n	( <noname> <noname> <noname> <noname> -- )
c-function XConnectionNumber XConnectionNumber a -- n	( <noname> -- )
c-function XConvertSelection XConvertSelection a u u u u u -- n	( <noname> <noname> <noname> <noname> <noname> <noname> -- )
c-function XCopyArea XCopyArea a u u a n n u u n n -- n	( <noname> <noname> <noname> <noname> <noname> <noname> <noname> <noname> <noname> <noname> -- )
c-function XCopyGC XCopyGC a a u a -- n	( <noname> <noname> <noname> <noname> -- )
c-function XCopyPlane XCopyPlane a u u a n n u u n n u -- n	( <noname> <noname> <noname> <noname> <noname> <noname> <noname> <noname> <noname> <noname> <noname> -- )
c-function XDefaultDepth XDefaultDepth a n -- n	( <noname> <noname> -- )
c-function XDefaultDepthOfScreen XDefaultDepthOfScreen a -- n	( <noname> -- )
c-function XDefaultScreen XDefaultScreen a -- n	( <noname> -- )
c-function XDefineCursor XDefineCursor a u u -- n	( <noname> <noname> <noname> -- )
c-function XDeleteProperty XDeleteProperty a u u -- n	( <noname> <noname> <noname> -- )
c-function XDestroyWindow XDestroyWindow a u -- n	( <noname> <noname> -- )
c-function XDestroySubwindows XDestroySubwindows a u -- n	( <noname> <noname> -- )
c-function XDoesBackingStore XDoesBackingStore a -- n	( <noname> -- )
c-function XDoesSaveUnders XDoesSaveUnders a -- n	( <noname> -- )
c-function XDisableAccessControl XDisableAccessControl a -- n	( <noname> -- )
c-function XDisplayCells XDisplayCells a n -- n	( <noname> <noname> -- )
c-function XDisplayHeight XDisplayHeight a n -- n	( <noname> <noname> -- )
c-function XDisplayHeightMM XDisplayHeightMM a n -- n	( <noname> <noname> -- )
c-function XDisplayKeycodes XDisplayKeycodes a a a -- n	( <noname> <noname> <noname> -- )
c-function XDisplayPlanes XDisplayPlanes a n -- n	( <noname> <noname> -- )
c-function XDisplayWidth XDisplayWidth a n -- n	( <noname> <noname> -- )
c-function XDisplayWidthMM XDisplayWidthMM a n -- n	( <noname> <noname> -- )
c-function XDrawArc XDrawArc a u a n n u u n n -- n	( <noname> <noname> <noname> <noname> <noname> <noname> <noname> <noname> <noname> -- )
c-function XDrawArcs XDrawArcs a u a a n -- n	( <noname> <noname> <noname> <noname> <noname> -- )
c-function XDrawImageString XDrawImageString a u a n n a n -- n	( <noname> <noname> <noname> <noname> <noname> <noname> <noname> -- )
c-function XDrawImageString16 XDrawImageString16 a u a n n a n -- n	( <noname> <noname> <noname> <noname> <noname> <noname> <noname> -- )
c-function XDrawLine XDrawLine a u a n n n n -- n	( <noname> <noname> <noname> <noname> <noname> <noname> <noname> -- )
c-function XDrawLines XDrawLines a u a a n n -- n	( <noname> <noname> <noname> <noname> <noname> <noname> -- )
c-function XDrawPoint XDrawPoint a u a n n -- n	( <noname> <noname> <noname> <noname> <noname> -- )
c-function XDrawPoints XDrawPoints a u a a n n -- n	( <noname> <noname> <noname> <noname> <noname> <noname> -- )
c-function XDrawRectangle XDrawRectangle a u a n n u u -- n	( <noname> <noname> <noname> <noname> <noname> <noname> <noname> -- )
c-function XDrawRectangles XDrawRectangles a u a a n -- n	( <noname> <noname> <noname> <noname> <noname> -- )
c-function XDrawSegments XDrawSegments a u a a n -- n	( <noname> <noname> <noname> <noname> <noname> -- )
c-function XDrawString XDrawString a u a n n a n -- n	( <noname> <noname> <noname> <noname> <noname> <noname> <noname> -- )
c-function XDrawString16 XDrawString16 a u a n n a n -- n	( <noname> <noname> <noname> <noname> <noname> <noname> <noname> -- )
c-function XDrawText XDrawText a u a n n a n -- n	( <noname> <noname> <noname> <noname> <noname> <noname> <noname> -- )
c-function XDrawText16 XDrawText16 a u a n n a n -- n	( <noname> <noname> <noname> <noname> <noname> <noname> <noname> -- )
c-function XEnableAccessControl XEnableAccessControl a -- n	( <noname> -- )
c-function XEventsQueued XEventsQueued a n -- n	( <noname> <noname> -- )
c-function XFetchName XFetchName a u a -- n	( <noname> <noname> <noname> -- )
c-function XFillArc XFillArc a u a n n u u n n -- n	( <noname> <noname> <noname> <noname> <noname> <noname> <noname> <noname> <noname> -- )
c-function XFillArcs XFillArcs a u a a n -- n	( <noname> <noname> <noname> <noname> <noname> -- )
c-function XFillPolygon XFillPolygon a u a a n n n -- n	( <noname> <noname> <noname> <noname> <noname> <noname> <noname> -- )
c-function XFillRectangle XFillRectangle a u a n n u u -- n	( <noname> <noname> <noname> <noname> <noname> <noname> <noname> -- )
c-function XFillRectangles XFillRectangles a u a a n -- n	( <noname> <noname> <noname> <noname> <noname> -- )
c-function XFlush XFlush a -- n	( <noname> -- )
c-function XForceScreenSaver XForceScreenSaver a n -- n	( <noname> <noname> -- )
c-function XFree XFree a -- n	( <noname> -- )
c-function XFreeColormap XFreeColormap a u -- n	( <noname> <noname> -- )
c-function XFreeColors XFreeColors a u a n u -- n	( <noname> <noname> <noname> <noname> <noname> -- )
c-function XFreeCursor XFreeCursor a u -- n	( <noname> <noname> -- )
c-function XFreeExtensionList XFreeExtensionList a -- n	( <noname> -- )
c-function XFreeFont XFreeFont a a -- n	( <noname> <noname> -- )
c-function XFreeFontInfo XFreeFontInfo a a n -- n	( <noname> <noname> <noname> -- )
c-function XFreeFontNames XFreeFontNames a -- n	( <noname> -- )
c-function XFreeFontPath XFreeFontPath a -- n	( <noname> -- )
c-function XFreeGC XFreeGC a a -- n	( <noname> <noname> -- )
c-function XFreeModifiermap XFreeModifiermap a -- n	( <noname> -- )
c-function XFreePixmap XFreePixmap a u -- n	( <noname> <noname> -- )
c-function XGeometry XGeometry a n s s u u u n n a a a a -- n	( <noname> <noname> <noname> <noname> <noname> <noname> <noname> <noname> <noname> <noname> <noname> <noname> <noname> -- )
c-function XGetErrorDatabaseText XGetErrorDatabaseText a s s s a n -- n	( <noname> <noname> <noname> <noname> <noname> <noname> -- )
c-function XGetErrorText XGetErrorText a n a n -- n	( <noname> <noname> <noname> <noname> -- )
c-function XGetFontProperty XGetFontProperty a u a -- n	( <noname> <noname> <noname> -- )
c-function XGetGCValues XGetGCValues a a u a -- n	( <noname> <noname> <noname> <noname> -- )
c-function XGetGeometry XGetGeometry a u a a a a a a a -- n	( <noname> <noname> <noname> <noname> <noname> <noname> <noname> <noname> <noname> -- )
c-function XGetIconName XGetIconName a u a -- n	( <noname> <noname> <noname> -- )
c-function XGetInputFocus XGetInputFocus a a a -- n	( <noname> <noname> <noname> -- )
c-function XGetKeyboardControl XGetKeyboardControl a a -- n	( <noname> <noname> -- )
c-function XGetPointerControl XGetPointerControl a a a a -- n	( <noname> <noname> <noname> <noname> -- )
c-function XGetPointerMapping XGetPointerMapping a a n -- n	( <noname> <noname> <noname> -- )
c-function XGetScreenSaver XGetScreenSaver a a a a a -- n	( <noname> <noname> <noname> <noname> <noname> -- )
c-function XGetTransientForHint XGetTransientForHint a u a -- n	( <noname> <noname> <noname> -- )
c-function XGetWindowProperty XGetWindowProperty a u u n n n u a a a a a -- n	( <noname> <noname> <noname> <noname> <noname> <noname> <noname> <noname> <noname> <noname> <noname> <noname> -- )
c-function XGetWindowAttributes XGetWindowAttributes a u a -- n	( <noname> <noname> <noname> -- )
c-function XGrabButton XGrabButton a u u u n u n n u u -- n	( <noname> <noname> <noname> <noname> <noname> <noname> <noname> <noname> <noname> <noname> -- )
c-function XGrabKey XGrabKey a n u u n n n -- n	( <noname> <noname> <noname> <noname> <noname> <noname> <noname> -- )
c-function XGrabKeyboard XGrabKeyboard a u n n n u -- n	( <noname> <noname> <noname> <noname> <noname> <noname> -- )
c-function XGrabPointer XGrabPointer a u n u n n u u u -- n	( <noname> <noname> <noname> <noname> <noname> <noname> <noname> <noname> <noname> -- )
c-function XGrabServer XGrabServer a -- n	( <noname> -- )
c-function XHeightMMOfScreen XHeightMMOfScreen a -- n	( <noname> -- )
c-function XHeightOfScreen XHeightOfScreen a -- n	( <noname> -- )
c-function XIfEvent XIfEvent a a a a -- n	( <noname> <noname> <noname> <noname> -- )
c-function XImageByteOrder XImageByteOrder a -- n	( <noname> -- )
c-function XInstallColormap XInstallColormap a u -- n	( <noname> <noname> -- )
c-function XKeysymToKeycode XKeysymToKeycode a u -- u	( <noname> <noname> -- )
c-function XKillClient XKillClient a u -- n	( <noname> <noname> -- )
c-function XLookupColor XLookupColor a u s a a -- n	( <noname> <noname> <noname> <noname> <noname> -- )
c-function XLowerWindow XLowerWindow a u -- n	( <noname> <noname> -- )
c-function XMapRaised XMapRaised a u -- n	( <noname> <noname> -- )
c-function XMapSubwindows XMapSubwindows a u -- n	( <noname> <noname> -- )
c-function XMapWindow XMapWindow a u -- n	( <noname> <noname> -- )
c-function XMaskEvent XMaskEvent a n a -- n	( <noname> <noname> <noname> -- )
c-function XMaxCmapsOfScreen XMaxCmapsOfScreen a -- n	( <noname> -- )
c-function XMinCmapsOfScreen XMinCmapsOfScreen a -- n	( <noname> -- )
c-function XMoveResizeWindow XMoveResizeWindow a u n n u u -- n	( <noname> <noname> <noname> <noname> <noname> <noname> -- )
c-function XMoveWindow XMoveWindow a u n n -- n	( <noname> <noname> <noname> <noname> -- )
c-function XNextEvent XNextEvent a a -- n	( <noname> <noname> -- )
c-function XNoOp XNoOp a -- n	( <noname> -- )
c-function XParseColor XParseColor a u s a -- n	( <noname> <noname> <noname> <noname> -- )
c-function XParseGeometry XParseGeometry s a a a a -- n	( <noname> <noname> <noname> <noname> <noname> -- )
c-function XPeekEvent XPeekEvent a a -- n	( <noname> <noname> -- )
c-function XPeekIfEvent XPeekIfEvent a a a a -- n	( <noname> <noname> <noname> <noname> -- )
c-function XPending XPending a -- n	( <noname> -- )
c-function XPlanesOfScreen XPlanesOfScreen a -- n	( <noname> -- )
c-function XProtocolRevision XProtocolRevision a -- n	( <noname> -- )
c-function XProtocolVersion XProtocolVersion a -- n	( <noname> -- )
c-function XPutBackEvent XPutBackEvent a a -- n	( <noname> <noname> -- )
c-function XPutImage XPutImage a u a a n n n n u u -- n	( <noname> <noname> <noname> <noname> <noname> <noname> <noname> <noname> <noname> <noname> -- )
c-function XQLength XQLength a -- n	( <noname> -- )
c-function XQueryBestCursor XQueryBestCursor a u u u a a -- n	( <noname> <noname> <noname> <noname> <noname> <noname> -- )
c-function XQueryBestSize XQueryBestSize a n u u u a a -- n	( <noname> <noname> <noname> <noname> <noname> <noname> <noname> -- )
c-function XQueryBestStipple XQueryBestStipple a u u u a a -- n	( <noname> <noname> <noname> <noname> <noname> <noname> -- )
c-function XQueryBestTile XQueryBestTile a u u u a a -- n	( <noname> <noname> <noname> <noname> <noname> <noname> -- )
c-function XQueryColor XQueryColor a u a -- n	( <noname> <noname> <noname> -- )
c-function XQueryColors XQueryColors a u a n -- n	( <noname> <noname> <noname> <noname> -- )
c-function XQueryExtension XQueryExtension a s a a a -- n	( <noname> <noname> <noname> <noname> <noname> -- )
c-function XQueryKeymap XQueryKeymap a a -- n	( <noname> <noname> -- )
c-function XQueryPointer XQueryPointer a u a a a a a a a -- n	( <noname> <noname> <noname> <noname> <noname> <noname> <noname> <noname> <noname> -- )
c-function XQueryTextExtents XQueryTextExtents a u a n a a a a -- n	( <noname> <noname> <noname> <noname> <noname> <noname> <noname> <noname> -- )
c-function XQueryTextExtents16 XQueryTextExtents16 a u a n a a a a -- n	( <noname> <noname> <noname> <noname> <noname> <noname> <noname> <noname> -- )
c-function XQueryTree XQueryTree a u a a a a -- n	( <noname> <noname> <noname> <noname> <noname> <noname> -- )
c-function XRaiseWindow XRaiseWindow a u -- n	( <noname> <noname> -- )
c-function XReadBitmapFile XReadBitmapFile a u s a a a a a -- n	( <noname> <noname> <noname> <noname> <noname> <noname> <noname> <noname> -- )
c-function XReadBitmapFileData XReadBitmapFileData s a a a a a -- n	( <noname> <noname> <noname> <noname> <noname> <noname> -- )
c-function XRebindKeysym XRebindKeysym a u a n a n -- n	( <noname> <noname> <noname> <noname> <noname> <noname> -- )
c-function XRecolorCursor XRecolorCursor a u a a -- n	( <noname> <noname> <noname> <noname> -- )
c-function XRefreshKeyboardMapping XRefreshKeyboardMapping a -- n	( <noname> -- )
c-function XRemoveFromSaveSet XRemoveFromSaveSet a u -- n	( <noname> <noname> -- )
c-function XRemoveHost XRemoveHost a a -- n	( <noname> <noname> -- )
c-function XRemoveHosts XRemoveHosts a a n -- n	( <noname> <noname> <noname> -- )
c-function XReparentWindow XReparentWindow a u u n n -- n	( <noname> <noname> <noname> <noname> <noname> -- )
c-function XResetScreenSaver XResetScreenSaver a -- n	( <noname> -- )
c-function XResizeWindow XResizeWindow a u u u -- n	( <noname> <noname> <noname> <noname> -- )
c-function XRestackWindows XRestackWindows a a n -- n	( <noname> <noname> <noname> -- )
c-function XRotateBuffers XRotateBuffers a n -- n	( <noname> <noname> -- )
c-function XRotateWindowProperties XRotateWindowProperties a u a n n -- n	( <noname> <noname> <noname> <noname> <noname> -- )
c-function XScreenCount XScreenCount a -- n	( <noname> -- )
c-function XSelectInput XSelectInput a u n -- n	( <noname> <noname> <noname> -- )
c-function XSendEvent XSendEvent a u n n a -- n	( <noname> <noname> <noname> <noname> <noname> -- )
c-function XSetAccessControl XSetAccessControl a n -- n	( <noname> <noname> -- )
c-function XSetArcMode XSetArcMode a a n -- n	( <noname> <noname> <noname> -- )
c-function XSetBackground XSetBackground a a u -- n	( <noname> <noname> <noname> -- )
c-function XSetClipMask XSetClipMask a a u -- n	( <noname> <noname> <noname> -- )
c-function XSetClipOrigin XSetClipOrigin a a n n -- n	( <noname> <noname> <noname> <noname> -- )
c-function XSetClipRectangles XSetClipRectangles a a n n a n n -- n	( <noname> <noname> <noname> <noname> <noname> <noname> <noname> -- )
c-function XSetCloseDownMode XSetCloseDownMode a n -- n	( <noname> <noname> -- )
c-function XSetCommand XSetCommand a u a n -- n	( <noname> <noname> <noname> <noname> -- )
c-function XSetDashes XSetDashes a a n a n -- n	( <noname> <noname> <noname> <noname> <noname> -- )
c-function XSetFillRule XSetFillRule a a n -- n	( <noname> <noname> <noname> -- )
c-function XSetFillStyle XSetFillStyle a a n -- n	( <noname> <noname> <noname> -- )
c-function XSetFont XSetFont a a u -- n	( <noname> <noname> <noname> -- )
c-function XSetFontPath XSetFontPath a a n -- n	( <noname> <noname> <noname> -- )
c-function XSetForeground XSetForeground a a u -- n	( <noname> <noname> <noname> -- )
c-function XSetFunction XSetFunction a a n -- n	( <noname> <noname> <noname> -- )
c-function XSetGraphicsExposures XSetGraphicsExposures a a n -- n	( <noname> <noname> <noname> -- )
c-function XSetIconName XSetIconName a u s -- n	( <noname> <noname> <noname> -- )
c-function XSetInputFocus XSetInputFocus a u n u -- n	( <noname> <noname> <noname> <noname> -- )
c-function XSetLineAttributes XSetLineAttributes a a u n n n -- n	( <noname> <noname> <noname> <noname> <noname> <noname> -- )
c-function XSetModifierMapping XSetModifierMapping a a -- n	( <noname> <noname> -- )
c-function XSetPlaneMask XSetPlaneMask a a u -- n	( <noname> <noname> <noname> -- )
c-function XSetPointerMapping XSetPointerMapping a a n -- n	( <noname> <noname> <noname> -- )
c-function XSetScreenSaver XSetScreenSaver a n n n n -- n	( <noname> <noname> <noname> <noname> <noname> -- )
c-function XSetSelectionOwner XSetSelectionOwner a u u u -- n	( <noname> <noname> <noname> <noname> -- )
c-function XSetState XSetState a a u u n u -- n	( <noname> <noname> <noname> <noname> <noname> <noname> -- )
c-function XSetStipple XSetStipple a a u -- n	( <noname> <noname> <noname> -- )
c-function XSetSubwindowMode XSetSubwindowMode a a n -- n	( <noname> <noname> <noname> -- )
c-function XSetTSOrigin XSetTSOrigin a a n n -- n	( <noname> <noname> <noname> <noname> -- )
c-function XSetTile XSetTile a a u -- n	( <noname> <noname> <noname> -- )
c-function XSetWindowBackground XSetWindowBackground a u u -- n	( <noname> <noname> <noname> -- )
c-function XSetWindowBackgroundPixmap XSetWindowBackgroundPixmap a u u -- n	( <noname> <noname> <noname> -- )
c-function XSetWindowBorder XSetWindowBorder a u u -- n	( <noname> <noname> <noname> -- )
c-function XSetWindowBorderPixmap XSetWindowBorderPixmap a u u -- n	( <noname> <noname> <noname> -- )
c-function XSetWindowBorderWidth XSetWindowBorderWidth a u u -- n	( <noname> <noname> <noname> -- )
c-function XSetWindowColormap XSetWindowColormap a u u -- n	( <noname> <noname> <noname> -- )
c-function XStoreBuffer XStoreBuffer a a n n -- n	( <noname> <noname> <noname> <noname> -- )
c-function XStoreBytes XStoreBytes a a n -- n	( <noname> <noname> <noname> -- )
c-function XStoreColor XStoreColor a u a -- n	( <noname> <noname> <noname> -- )
c-function XStoreColors XStoreColors a u a n -- n	( <noname> <noname> <noname> <noname> -- )
c-function XStoreName XStoreName a u s -- n	( <noname> <noname> <noname> -- )
c-function XStoreNamedColor XStoreNamedColor a u s u n -- n	( <noname> <noname> <noname> <noname> <noname> -- )
c-function XSync XSync a n -- n	( <noname> <noname> -- )
c-function XTextExtents XTextExtents a a n a a a a -- n	( <noname> <noname> <noname> <noname> <noname> <noname> <noname> -- )
c-function XTextExtents16 XTextExtents16 a a n a a a a -- n	( <noname> <noname> <noname> <noname> <noname> <noname> <noname> -- )
c-function XTextWidth XTextWidth a a n -- n	( <noname> <noname> <noname> -- )
c-function XTextWidth16 XTextWidth16 a a n -- n	( <noname> <noname> <noname> -- )
c-function XTranslateCoordinates XTranslateCoordinates a u u n n a a a -- n	( <noname> <noname> <noname> <noname> <noname> <noname> <noname> <noname> -- )
c-function XUndefineCursor XUndefineCursor a u -- n	( <noname> <noname> -- )
c-function XUngrabButton XUngrabButton a u u u -- n	( <noname> <noname> <noname> <noname> -- )
c-function XUngrabKey XUngrabKey a n u u -- n	( <noname> <noname> <noname> <noname> -- )
c-function XUngrabKeyboard XUngrabKeyboard a u -- n	( <noname> <noname> -- )
c-function XUngrabPointer XUngrabPointer a u -- n	( <noname> <noname> -- )
c-function XUngrabServer XUngrabServer a -- n	( <noname> -- )
c-function XUninstallColormap XUninstallColormap a u -- n	( <noname> <noname> -- )
c-function XUnloadFont XUnloadFont a u -- n	( <noname> <noname> -- )
c-function XUnmapSubwindows XUnmapSubwindows a u -- n	( <noname> <noname> -- )
c-function XUnmapWindow XUnmapWindow a u -- n	( <noname> <noname> -- )
c-function XVendorRelease XVendorRelease a -- n	( <noname> -- )
c-function XWarpPointer XWarpPointer a u u n n u u n n -- n	( <noname> <noname> <noname> <noname> <noname> <noname> <noname> <noname> <noname> -- )
c-function XWidthMMOfScreen XWidthMMOfScreen a -- n	( <noname> -- )
c-function XWidthOfScreen XWidthOfScreen a -- n	( <noname> -- )
c-function XWindowEvent XWindowEvent a u n a -- n	( <noname> <noname> <noname> <noname> -- )
c-function XWriteBitmapFile XWriteBitmapFile a a u u u n n -- n	( <noname> <noname> <noname> <noname> <noname> <noname> <noname> -- )
c-function XSupportsLocale XSupportsLocale  -- n	( -- )
c-function XSetLocaleModifiers XSetLocaleModifiers s -- a	( <noname> -- )
c-function XOpenOM XOpenOM a a s s -- a	( <noname> <noname> <noname> <noname> -- )
c-function XCloseOM XCloseOM a -- n	( <noname> -- )
c-function XSetOMValues XSetOMValues a ... -- a	( <noname> <noname> -- )
c-function XSetOMValues_2 XSetOMValues a a a ... -- a	( <noname> <noname> -- )
c-function XSetOMValues_3 XSetOMValues a a a a a ... -- a	( <noname> <noname> -- )
c-function XGetOMValues XGetOMValues a ... -- a	( <noname> <noname> -- )
c-function XGetOMValues_2 XGetOMValues a a a ... -- a	( <noname> <noname> -- )
c-function XGetOMValues_3 XGetOMValues a a a a a ... -- a	( <noname> <noname> -- )
c-function XDisplayOfOM XDisplayOfOM a -- a	( <noname> -- )
c-function XLocaleOfOM XLocaleOfOM a -- a	( <noname> -- )
c-function XCreateOC XCreateOC a ... -- a	( <noname> <noname> -- )
c-function XCreateOC_2 XCreateOC a a a ... -- a	( <noname> <noname> -- )
c-function XCreateOC_3 XCreateOC a a a a a ... -- a	( <noname> <noname> -- )
c-function XDestroyOC XDestroyOC a -- void	( <noname> -- )
c-function XOMOfOC XOMOfOC a -- a	( <noname> -- )
c-function XSetOCValues XSetOCValues a ... -- a	( <noname> <noname> -- )
c-function XSetOCValues_2 XSetOCValues a a a ... -- a	( <noname> <noname> -- )
c-function XSetOCValues_3 XSetOCValues a a a a a ... -- a	( <noname> <noname> -- )
c-function XGetOCValues XGetOCValues a ... -- a	( <noname> <noname> -- )
c-function XGetOCValues_2 XGetOCValues a a a ... -- a	( <noname> <noname> -- )
c-function XGetOCValues_3 XGetOCValues a a a a a ... -- a	( <noname> <noname> -- )
c-function XCreateFontSet XCreateFontSet a s a a a -- a	( <noname> <noname> <noname> <noname> <noname> -- )
c-function XFreeFontSet XFreeFontSet a a -- void	( <noname> <noname> -- )
c-function XFontsOfFontSet XFontsOfFontSet a a a -- n	( <noname> <noname> <noname> -- )
c-function XBaseFontNameListOfFontSet XBaseFontNameListOfFontSet a -- a	( <noname> -- )
c-function XLocaleOfFontSet XLocaleOfFontSet a -- a	( <noname> -- )
c-function XContextDependentDrawing XContextDependentDrawing a -- n	( <noname> -- )
c-function XDirectionalDependentDrawing XDirectionalDependentDrawing a -- n	( <noname> -- )
c-function XContextualDrawing XContextualDrawing a -- n	( <noname> -- )
c-function XExtentsOfFontSet XExtentsOfFontSet a -- a	( <noname> -- )
c-function XmbTextEscapement XmbTextEscapement a a n -- n	( <noname> <noname> <noname> -- )
c-function XwcTextEscapement XwcTextEscapement a a n -- n	( <noname> <noname> <noname> -- )
c-function Xutf8TextEscapement Xutf8TextEscapement a a n -- n	( <noname> <noname> <noname> -- )
c-function XmbTextExtents XmbTextExtents a a n a a -- n	( <noname> <noname> <noname> <noname> <noname> -- )
c-function XwcTextExtents XwcTextExtents a a n a a -- n	( <noname> <noname> <noname> <noname> <noname> -- )
c-function Xutf8TextExtents Xutf8TextExtents a a n a a -- n	( <noname> <noname> <noname> <noname> <noname> -- )
c-function XmbTextPerCharExtents XmbTextPerCharExtents a a n a a n a a a -- n	( <noname> <noname> <noname> <noname> <noname> <noname> <noname> <noname> <noname> -- )
c-function XwcTextPerCharExtents XwcTextPerCharExtents a a n a a n a a a -- n	( <noname> <noname> <noname> <noname> <noname> <noname> <noname> <noname> <noname> -- )
c-function Xutf8TextPerCharExtents Xutf8TextPerCharExtents a a n a a n a a a -- n	( <noname> <noname> <noname> <noname> <noname> <noname> <noname> <noname> <noname> -- )
c-function XmbDrawText XmbDrawText a u a n n a n -- void	( <noname> <noname> <noname> <noname> <noname> <noname> <noname> -- )
c-function XwcDrawText XwcDrawText a u a n n a n -- void	( <noname> <noname> <noname> <noname> <noname> <noname> <noname> -- )
c-function Xutf8DrawText Xutf8DrawText a u a n n a n -- void	( <noname> <noname> <noname> <noname> <noname> <noname> <noname> -- )
c-function XmbDrawString XmbDrawString a u a a n n a n -- void	( <noname> <noname> <noname> <noname> <noname> <noname> <noname> <noname> -- )
c-function XwcDrawString XwcDrawString a u a a n n a n -- void	( <noname> <noname> <noname> <noname> <noname> <noname> <noname> <noname> -- )
c-function Xutf8DrawString Xutf8DrawString a u a a n n a n -- void	( <noname> <noname> <noname> <noname> <noname> <noname> <noname> <noname> -- )
c-function XmbDrawImageString XmbDrawImageString a u a a n n a n -- void	( <noname> <noname> <noname> <noname> <noname> <noname> <noname> <noname> -- )
c-function XwcDrawImageString XwcDrawImageString a u a a n n a n -- void	( <noname> <noname> <noname> <noname> <noname> <noname> <noname> <noname> -- )
c-function Xutf8DrawImageString Xutf8DrawImageString a u a a n n a n -- void	( <noname> <noname> <noname> <noname> <noname> <noname> <noname> <noname> -- )
c-function XOpenIM XOpenIM a a a a -- a	( <noname> <noname> <noname> <noname> -- )
c-function XCloseIM XCloseIM a -- n	( <noname> -- )
c-function XGetIMValues XGetIMValues a ... -- a	( <noname> <noname> -- )
c-function XGetIMValues_2 XGetIMValues a a a ... -- a	( <noname> <noname> -- )
c-function XGetIMValues_3 XGetIMValues a a a a a ... -- a	( <noname> <noname> -- )
c-function XSetIMValues XSetIMValues a ... -- a	( <noname> <noname> -- )
c-function XSetIMValues_2 XSetIMValues a a a ... -- a	( <noname> <noname> -- )
c-function XSetIMValues_3 XSetIMValues a a a a a ... -- a	( <noname> <noname> -- )
c-function XDisplayOfIM XDisplayOfIM a -- a	( <noname> -- )
c-function XLocaleOfIM XLocaleOfIM a -- a	( <noname> -- )
c-function XCreateIC XCreateIC a ... -- a	( <noname> <noname> -- )
c-function XCreateIC_2 XCreateIC a a a ... -- a	( <noname> <noname> -- )
c-function XCreateIC_3 XCreateIC a a a a a ... -- a	( <noname> <noname> -- )
c-function XDestroyIC XDestroyIC a -- void	( <noname> -- )
c-function XSetICFocus XSetICFocus a -- void	( <noname> -- )
c-function XUnsetICFocus XUnsetICFocus a -- void	( <noname> -- )
c-function XwcResetIC XwcResetIC a -- a	( <noname> -- )
c-function XmbResetIC XmbResetIC a -- a	( <noname> -- )
c-function Xutf8ResetIC Xutf8ResetIC a -- a	( <noname> -- )
c-function XSetICValues XSetICValues a ... -- a	( <noname> <noname> -- )
c-function XSetICValues_2 XSetICValues a a a ... -- a	( <noname> <noname> -- )
c-function XSetICValues_3 XSetICValues a a a a a ... -- a	( <noname> <noname> -- )
c-function XGetICValues XGetICValues a ... -- a	( <noname> <noname> -- )
c-function XGetICValues_2 XGetICValues a a a ... -- a	( <noname> <noname> -- )
c-function XGetICValues_3 XGetICValues a a a a a ... -- a	( <noname> <noname> -- )
c-function XIMOfIC XIMOfIC a -- a	( <noname> -- )
c-function XFilterEvent XFilterEvent a u -- n	( <noname> <noname> -- )
c-function XmbLookupString XmbLookupString a a a n a a -- n	( <noname> <noname> <noname> <noname> <noname> <noname> -- )
c-function XwcLookupString XwcLookupString a a a n a a -- n	( <noname> <noname> <noname> <noname> <noname> <noname> -- )
c-function Xutf8LookupString Xutf8LookupString a a a n a a -- n	( <noname> <noname> <noname> <noname> <noname> <noname> -- )
c-function XVaCreateNestedList XVaCreateNestedList n ... -- a	( <noname> <noname> -- )
c-function XVaCreateNestedList_2 XVaCreateNestedList n a a ... -- a	( <noname> <noname> -- )
c-function XVaCreateNestedList_3 XVaCreateNestedList n a a a a ... -- a	( <noname> <noname> -- )
c-function XRegisterIMInstantiateCallback XRegisterIMInstantiateCallback a a a a a a -- n	( <noname> <noname> <noname> <noname> <noname> <noname> -- )
c-function XUnregisterIMInstantiateCallback XUnregisterIMInstantiateCallback a a a a a a -- n	( <noname> <noname> <noname> <noname> <noname> <noname> -- )
c-function XInternalConnectionNumbers XInternalConnectionNumbers a a a -- n	( <noname> <noname> <noname> -- )
c-function XProcessInternalConnection XProcessInternalConnection a n -- void	( <noname> <noname> -- )
c-function XAddConnectionWatch XAddConnectionWatch a a a -- n	( <noname> <noname> <noname> -- )
c-function XRemoveConnectionWatch XRemoveConnectionWatch a a a -- void	( <noname> <noname> <noname> -- )
c-function XSetAuthorization XSetAuthorization a n a n -- void	( <noname> <noname> <noname> <noname> -- )
c-function _Xmbtowc _Xmbtowc a a n -- n	( <noname> <noname> <noname> -- )
c-function _Xwctomb _Xwctomb a n -- n	( <noname> <noname> -- )
c-function XGetEventData XGetEventData a a -- n	( <noname> <noname> -- )
c-function XFreeEventData XFreeEventData a a -- void	( <noname> <noname> -- )
c-function XAllocClassHint XAllocClassHint  -- a	( -- )
c-function XAllocIconSize XAllocIconSize  -- a	( -- )
c-function XAllocSizeHints XAllocSizeHints  -- a	( -- )
c-function XAllocStandardColormap XAllocStandardColormap  -- a	( -- )
c-function XAllocWMHints XAllocWMHints  -- a	( -- )
c-function XClipBox XClipBox a a -- n	( <noname> <noname> -- )
c-function XCreateRegion XCreateRegion  -- a	( -- )
c-function XDefaultString XDefaultString  -- s	( -- )
c-function XDeleteContext XDeleteContext a u n -- n	( <noname> <noname> <noname> -- )
c-function XDestroyRegion XDestroyRegion a -- n	( <noname> -- )
c-function XEmptyRegion XEmptyRegion a -- n	( <noname> -- )
c-function XEqualRegion XEqualRegion a a -- n	( <noname> <noname> -- )
c-function XFindContext XFindContext a u n a -- n	( <noname> <noname> <noname> <noname> -- )
c-function XGetClassHint XGetClassHint a u a -- n	( <noname> <noname> <noname> -- )
c-function XGetIconSizes XGetIconSizes a u a a -- n	( <noname> <noname> <noname> <noname> -- )
c-function XGetNormalHints XGetNormalHints a u a -- n	( <noname> <noname> <noname> -- )
c-function XGetRGBColormaps XGetRGBColormaps a u a a u -- n	( <noname> <noname> <noname> <noname> <noname> -- )
c-function XGetSizeHints XGetSizeHints a u a u -- n	( <noname> <noname> <noname> <noname> -- )
c-function XGetStandardColormap XGetStandardColormap a u a u -- n	( <noname> <noname> <noname> <noname> -- )
c-function XGetTextProperty XGetTextProperty a u a u -- n	( <noname> <noname> <noname> <noname> -- )
c-function XGetVisualInfo XGetVisualInfo a n a a -- a	( <noname> <noname> <noname> <noname> -- )
c-function XGetWMClientMachine XGetWMClientMachine a u a -- n	( <noname> <noname> <noname> -- )
c-function XGetWMHints XGetWMHints a u -- a	( <noname> <noname> -- )
c-function XGetWMIconName XGetWMIconName a u a -- n	( <noname> <noname> <noname> -- )
c-function XGetWMName XGetWMName a u a -- n	( <noname> <noname> <noname> -- )
c-function XGetWMNormalHints XGetWMNormalHints a u a a -- n	( <noname> <noname> <noname> <noname> -- )
c-function XGetWMSizeHints XGetWMSizeHints a u a a u -- n	( <noname> <noname> <noname> <noname> <noname> -- )
c-function XGetZoomHints XGetZoomHints a u a -- n	( <noname> <noname> <noname> -- )
c-function XIntersectRegion XIntersectRegion a a a -- n	( <noname> <noname> <noname> -- )
c-function XConvertCase XConvertCase u a a -- void	( <noname> <noname> <noname> -- )
c-function XLookupString XLookupString a a n a a -- n	( <noname> <noname> <noname> <noname> <noname> -- )
c-function XMatchVisualInfo XMatchVisualInfo a n n n a -- n	( <noname> <noname> <noname> <noname> <noname> -- )
c-function XOffsetRegion XOffsetRegion a n n -- n	( <noname> <noname> <noname> -- )
c-function XPointInRegion XPointInRegion a n n -- n	( <noname> <noname> <noname> -- )
c-function XPolygonRegion XPolygonRegion a n n -- a	( <noname> <noname> <noname> -- )
c-function XRectInRegion XRectInRegion a n n u u -- n	( <noname> <noname> <noname> <noname> <noname> -- )
c-function XSaveContext XSaveContext a u n s -- n	( <noname> <noname> <noname> <noname> -- )
c-function XSetClassHint XSetClassHint a u a -- n	( <noname> <noname> <noname> -- )
c-function XSetIconSizes XSetIconSizes a u a n -- n	( <noname> <noname> <noname> <noname> -- )
c-function XSetNormalHints XSetNormalHints a u a -- n	( <noname> <noname> <noname> -- )
c-function XSetRGBColormaps XSetRGBColormaps a u a n u -- void	( <noname> <noname> <noname> <noname> <noname> -- )
c-function XSetSizeHints XSetSizeHints a u a u -- n	( <noname> <noname> <noname> <noname> -- )
c-function XSetStandardProperties XSetStandardProperties a u s a u a n a -- n	( <noname> <noname> <noname> <noname> <noname> <noname> <noname> <noname> -- )
c-function XSetTextProperty XSetTextProperty a u a u -- void	( <noname> <noname> <noname> <noname> -- )
c-function XSetWMClientMachine XSetWMClientMachine a u a -- void	( <noname> <noname> <noname> -- )
c-function XSetWMHints XSetWMHints a u a -- n	( <noname> <noname> <noname> -- )
c-function XSetWMIconName XSetWMIconName a u a -- void	( <noname> <noname> <noname> -- )
c-function XSetWMName XSetWMName a u a -- void	( <noname> <noname> <noname> -- )
c-function XSetWMNormalHints XSetWMNormalHints a u a -- void	( <noname> <noname> <noname> -- )
c-function XSetWMProperties XSetWMProperties a u a a a n a a a -- void	( <noname> <noname> <noname> <noname> <noname> <noname> <noname> <noname> <noname> -- )
c-function XmbSetWMProperties XmbSetWMProperties a u s s a n a a a -- void	( <noname> <noname> <noname> <noname> <noname> <noname> <noname> <noname> <noname> -- )
c-function Xutf8SetWMProperties Xutf8SetWMProperties a u s s a n a a a -- void	( <noname> <noname> <noname> <noname> <noname> <noname> <noname> <noname> <noname> -- )
c-function XSetWMSizeHints XSetWMSizeHints a u a u -- void	( <noname> <noname> <noname> <noname> -- )
c-function XSetRegion XSetRegion a a a -- n	( <noname> <noname> <noname> -- )
c-function XSetStandardColormap XSetStandardColormap a u a u -- void	( <noname> <noname> <noname> <noname> -- )
c-function XSetZoomHints XSetZoomHints a u a -- n	( <noname> <noname> <noname> -- )
c-function XShrinkRegion XShrinkRegion a n n -- n	( <noname> <noname> <noname> -- )
c-function XStringListToTextProperty XStringListToTextProperty a n a -- n	( <noname> <noname> <noname> -- )
c-function XSubtractRegion XSubtractRegion a a a -- n	( <noname> <noname> <noname> -- )
c-function XmbTextListToTextProperty XmbTextListToTextProperty a a n n a -- n	( display list count style text_prop_return -- )
c-function XwcTextListToTextProperty XwcTextListToTextProperty a a n n a -- n	( display list count style text_prop_return -- )
c-function Xutf8TextListToTextProperty Xutf8TextListToTextProperty a a n n a -- n	( display list count style text_prop_return -- )
c-function XwcFreeStringList XwcFreeStringList a -- void	( list -- )
c-function XTextPropertyToStringList XTextPropertyToStringList a a a -- n	( <noname> <noname> <noname> -- )
c-function XmbTextPropertyToTextList XmbTextPropertyToTextList a a a a -- n	( display text_prop list_return count_return -- )
c-function XwcTextPropertyToTextList XwcTextPropertyToTextList a a a a -- n	( display text_prop list_return count_return -- )
c-function Xutf8TextPropertyToTextList Xutf8TextPropertyToTextList a a a a -- n	( display text_prop list_return count_return -- )
c-function XUnionRectWithRegion XUnionRectWithRegion a a a -- n	( <noname> <noname> <noname> -- )
c-function XUnionRegion XUnionRegion a a a -- n	( <noname> <noname> <noname> -- )
c-function XWMGeometry XWMGeometry a n s a u a a a a a a -- n	( <noname> <noname> <noname> <noname> <noname> <noname> <noname> <noname> <noname> <noname> <noname> -- )
c-function XXorRegion XXorRegion a a a -- n	( <noname> <noname> <noname> -- )
c-function XSyncIntToValue XSyncIntToValue a n -- void	( <noname> <noname> -- )
c-function XSyncIntsToValue XSyncIntsToValue a u n -- void	( <noname> <noname> <noname> -- )
c-function XSyncValueGreaterThan XSyncValueGreaterThan a{*(XSyncValue*)} a{*(XSyncValue*)} -- n	( <noname> <noname> -- )
c-function XSyncValueLessThan XSyncValueLessThan a{*(XSyncValue*)} a{*(XSyncValue*)} -- n	( <noname> <noname> -- )
c-function XSyncValueGreaterOrEqual XSyncValueGreaterOrEqual a{*(XSyncValue*)} a{*(XSyncValue*)} -- n	( <noname> <noname> -- )
c-function XSyncValueLessOrEqual XSyncValueLessOrEqual a{*(XSyncValue*)} a{*(XSyncValue*)} -- n	( <noname> <noname> -- )
c-function XSyncValueEqual XSyncValueEqual a{*(XSyncValue*)} a{*(XSyncValue*)} -- n	( <noname> <noname> -- )
c-function XSyncValueIsNegative XSyncValueIsNegative a{*(XSyncValue*)} -- n	( <noname> -- )
c-function XSyncValueIsZero XSyncValueIsZero a{*(XSyncValue*)} -- n	( <noname> -- )
c-function XSyncValueIsPositive XSyncValueIsPositive a{*(XSyncValue*)} -- n	( <noname> -- )
c-function XSyncValueLow32 XSyncValueLow32 a{*(XSyncValue*)} -- u	( <noname> -- )
c-function XSyncValueHigh32 XSyncValueHigh32 a{*(XSyncValue*)} -- n	( <noname> -- )
c-function XSyncValueAdd XSyncValueAdd a a{*(XSyncValue*)} a{*(XSyncValue*)} a -- void	( <noname> <noname> <noname> <noname> -- )
c-function XSyncValueSubtract XSyncValueSubtract a a{*(XSyncValue*)} a{*(XSyncValue*)} a -- void	( <noname> <noname> <noname> <noname> -- )
c-function XSyncMaxValue XSyncMaxValue a -- void	( <noname> -- )
c-function XSyncMinValue XSyncMinValue a -- void	( <noname> -- )
c-function XSyncQueryExtension XSyncQueryExtension a a a -- n	( <noname> <noname> <noname> -- )
c-function XSyncInitialize XSyncInitialize a a a -- n	( <noname> <noname> <noname> -- )
c-function XSyncListSystemCounters XSyncListSystemCounters a a -- a	( <noname> <noname> -- )
c-function XSyncFreeSystemCounterList XSyncFreeSystemCounterList a -- void	( <noname> -- )
c-function XSyncCreateCounter XSyncCreateCounter a a{*(XSyncValue*)} -- u	( <noname> <noname> -- )
c-function XSyncSetCounter XSyncSetCounter a u a{*(XSyncValue*)} -- n	( <noname> <noname> <noname> -- )
c-function XSyncChangeCounter XSyncChangeCounter a u a{*(XSyncValue*)} -- n	( <noname> <noname> <noname> -- )
c-function XSyncDestroyCounter XSyncDestroyCounter a u -- n	( <noname> <noname> -- )
c-function XSyncQueryCounter XSyncQueryCounter a u a -- n	( <noname> <noname> <noname> -- )
c-function XSyncAwait XSyncAwait a a n -- n	( <noname> <noname> <noname> -- )
c-function XSyncCreateAlarm XSyncCreateAlarm a u a -- u	( <noname> <noname> <noname> -- )
c-function XSyncDestroyAlarm XSyncDestroyAlarm a u -- n	( <noname> <noname> -- )
c-function XSyncQueryAlarm XSyncQueryAlarm a u a -- n	( <noname> <noname> <noname> -- )
c-function XSyncChangeAlarm XSyncChangeAlarm a u u a -- n	( <noname> <noname> <noname> <noname> -- )
c-function XSyncSetPriority XSyncSetPriority a u n -- n	( <noname> <noname> <noname> -- )
c-function XSyncGetPriority XSyncGetPriority a u a -- n	( <noname> <noname> <noname> -- )
c-function XSyncCreateFence XSyncCreateFence a u n -- u	( <noname> <noname> <noname> -- )
c-function XSyncTriggerFence XSyncTriggerFence a u -- n	( <noname> <noname> -- )
c-function XSyncResetFence XSyncResetFence a u -- n	( <noname> <noname> -- )
c-function XSyncDestroyFence XSyncDestroyFence a u -- n	( <noname> <noname> -- )
c-function XSyncQueryFence XSyncQueryFence a u a -- n	( <noname> <noname> <noname> -- )
c-function XSyncAwaitFence XSyncAwaitFence a a n -- n	( <noname> <noname> <noname> -- )

\ ----===< postfix >===-----
end-c-library
previous set-current
