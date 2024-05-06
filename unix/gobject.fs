\ This file has been generated using SWIG and fsi,
\ and is already platform dependent, search for the corresponding
\ fsi-file to compile it where no one has compiled it before ;)
\ Forth systems have their own own dynamic loader and don't need addional C-Code.
\ That's why this file will just print normal forth-code once compiled
\ and can be used directly with include or require.
\ As all comments are stripped during the compilation, please
\ insert the copyright notice of the original file here.

\ ----===< prefix >===-----
c-library gobject
s" gobject-2.0" add-lib
s" a 0" vararg$ $!
\c #define _GLIB_HAVE_BUILTIN_OVERFLOW_CHECKS 1
\c #include <glib.h>
\c #include <glib-object.h>

\ ----===< int constants >===-----
#1234	constant G_LITTLE_ENDIAN
#4321	constant G_BIG_ENDIAN
#3412	constant G_PDP_ENDIAN
#127	constant G_IEEE754_FLOAT_BIAS
#1023	constant G_IEEE754_DOUBLE_BIAS
#-100	constant G_PRIORITY_HIGH
#0	constant G_PRIORITY_DEFAULT
#100	constant G_PRIORITY_HIGH_IDLE
#200	constant G_PRIORITY_DEFAULT_IDLE
#300	constant G_PRIORITY_LOW
#2	constant G_TYPE_FUNDAMENTAL_SHIFT
#22	constant G_TYPE_RESERVED_GLIB_FIRST
#31	constant G_TYPE_RESERVED_GLIB_LAST
#32	constant G_TYPE_RESERVED_BSE_FIRST
#48	constant G_TYPE_RESERVED_BSE_LAST
#49	constant G_TYPE_RESERVED_USER_FIRST
#511	constant G_SIGNAL_FLAGS_MASK
#63	constant G_SIGNAL_MATCH_MASK

\ ---===< float constants >===----
2.718282e0	fconstant G_E
0.693147e0	fconstant G_LN2
2.302585e0	fconstant G_LN10
3.141593e0	fconstant G_PI
1.570796e0	fconstant G_PI_2
0.785398e0	fconstant G_PI_4
1.414214e0	fconstant G_SQRT2
0.301030e0	fconstant G_LOG_2_BASE_10

\ --------===< enums >===---------
#0	constant G_THREAD_ERROR_AGAIN
#0	constant G_ONCE_STATUS_NOTCALLED
#1	constant G_ONCE_STATUS_PROGRESS
#2	constant G_ONCE_STATUS_READY
#1	constant G_IO_IN
#4	constant G_IO_OUT
#2	constant G_IO_PRI
#8	constant G_IO_ERR
#16	constant G_IO_HUP
#32	constant G_IO_NVAL
#0	constant G_MAIN_CONTEXT_FLAGS_NONE
#1	constant G_MAIN_CONTEXT_FLAGS_OWNERLESS_POLLING
#0	constant G_TYPE_DEBUG_NONE
#1	constant G_TYPE_DEBUG_OBJECTS
#2	constant G_TYPE_DEBUG_SIGNALS
#4	constant G_TYPE_DEBUG_INSTANCE_COUNT
#7	constant G_TYPE_DEBUG_MASK
#1	constant G_TYPE_FLAG_CLASSED
#2	constant G_TYPE_FLAG_INSTANTIATABLE
#4	constant G_TYPE_FLAG_DERIVABLE
#8	constant G_TYPE_FLAG_DEEP_DERIVABLE
#16	constant G_TYPE_FLAG_ABSTRACT
#32	constant G_TYPE_FLAG_VALUE_ABSTRACT
#64	constant G_TYPE_FLAG_FINAL
#1	constant G_SIGNAL_RUN_FIRST
#2	constant G_SIGNAL_RUN_LAST
#4	constant G_SIGNAL_RUN_CLEANUP
#8	constant G_SIGNAL_NO_RECURSE
#16	constant G_SIGNAL_DETAILED
#32	constant G_SIGNAL_ACTION
#64	constant G_SIGNAL_NO_HOOKS
#128	constant G_SIGNAL_MUST_COLLECT
#256	constant G_SIGNAL_DEPRECATED
#131072	constant G_SIGNAL_ACCUMULATOR_FIRST_RUN
#1	constant G_CONNECT_AFTER
#2	constant G_CONNECT_SWAPPED
#1	constant G_SIGNAL_MATCH_ID
#2	constant G_SIGNAL_MATCH_DETAIL
#4	constant G_SIGNAL_MATCH_CLOSURE
#8	constant G_SIGNAL_MATCH_FUNC
#16	constant G_SIGNAL_MATCH_DATA
#32	constant G_SIGNAL_MATCH_UNBLOCKED

\ -------===< structs >===--------
\ _GTimeVal
begin-structure _GTimeVal
	drop 8 8 +field _GTimeVal-tv_usec
	drop 0 8 +field _GTimeVal-tv_sec
drop 16 end-structure
\ _GMutex
begin-structure _GMutex
	drop 0 8 +field _GMutex-p
	drop 0 8 +field _GMutex-i
drop 8 end-structure
\ _GRWLock
begin-structure _GRWLock
	drop 0 8 +field _GRWLock-p
	drop 8 8 +field _GRWLock-i
drop 16 end-structure
\ _GCond
begin-structure _GCond
	drop 0 8 +field _GCond-p
	drop 8 8 +field _GCond-i
drop 16 end-structure
\ _GRecMutex
begin-structure _GRecMutex
	drop 0 8 +field _GRecMutex-p
	drop 8 8 +field _GRecMutex-i
drop 16 end-structure
\ _GPrivate
begin-structure _GPrivate
	drop 0 8 +field _GPrivate-p
	drop 16 16 +field _GPrivate-future
	drop 8 8 +field _GPrivate-notify
drop 32 end-structure
\ _GOnce
begin-structure _GOnce
	drop 0 4 +field _GOnce-status
	drop 8 8 +field _GOnce-retval
drop 16 end-structure
\ _GSource
begin-structure _GSource
	drop 40 4 +field _GSource-priority
	drop 8 8 +field _GSource-callback_funcs
	drop 16 8 +field _GSource-source_funcs
	drop 24 4 +field _GSource-ref_count
	drop 64 8 +field _GSource-prev
	drop 80 8 +field _GSource-name
	drop 56 8 +field _GSource-poll_fds
	drop 88 8 +field _GSource-priv
	drop 0 8 +field _GSource-callback_data
	drop 48 4 +field _GSource-source_id
	drop 32 8 +field _GSource-context
	drop 44 4 +field _GSource-flags
	drop 72 8 +field _GSource-next
drop 96 end-structure
\ _GSourceCallbackFuncs
begin-structure _GSourceCallbackFuncs
	drop 8 8 +field _GSourceCallbackFuncs-unref
	drop 16 8 +field _GSourceCallbackFuncs-get
	drop 0 8 +field _GSourceCallbackFuncs-ref
drop 24 end-structure
\ _GSourceFuncs
begin-structure _GSourceFuncs
	drop 24 8 +field _GSourceFuncs-finalize
	drop 8 8 +field _GSourceFuncs-check
	drop 0 8 +field _GSourceFuncs-prepare
	drop 40 8 +field _GSourceFuncs-closure_marshal
	drop 32 8 +field _GSourceFuncs-closure_callback
	drop 16 8 +field _GSourceFuncs-dispatch
drop 48 end-structure
\ _GTypeClass
begin-structure _GTypeClass
	drop 0 8 +field _GTypeClass-g_type
drop 8 end-structure
\ _GTypeInstance
begin-structure _GTypeInstance
	drop 0 8 +field _GTypeInstance-g_class
drop 8 end-structure
\ _GTypeInterface
begin-structure _GTypeInterface
	drop 0 8 +field _GTypeInterface-g_type
	drop 8 8 +field _GTypeInterface-g_instance_type
drop 16 end-structure
\ _GTypeQuery
begin-structure _GTypeQuery
	drop 8 8 +field _GTypeQuery-type_name
	drop 16 4 +field _GTypeQuery-class_size
	drop 20 4 +field _GTypeQuery-instance_size
	drop 0 8 +field _GTypeQuery-type
drop 24 end-structure
\ _GTypeInfo
begin-structure _GTypeInfo
	drop 16 8 +field _GTypeInfo-base_finalize
	drop 32 8 +field _GTypeInfo-class_finalize
	drop 64 8 +field _GTypeInfo-value_table
	drop 50 2 +field _GTypeInfo-n_preallocs
	drop 0 2 +field _GTypeInfo-class_size
	drop 48 2 +field _GTypeInfo-instance_size
	drop 8 8 +field _GTypeInfo-base_init
	drop 24 8 +field _GTypeInfo-class_init
	drop 56 8 +field _GTypeInfo-instance_init
	drop 40 8 +field _GTypeInfo-class_data
drop 72 end-structure
\ _GTypeFundamentalInfo
begin-structure _GTypeFundamentalInfo
	drop 0 4 +field _GTypeFundamentalInfo-type_flags
drop 4 end-structure
\ _GInterfaceInfo
begin-structure _GInterfaceInfo
	drop 8 8 +field _GInterfaceInfo-interface_finalize
	drop 0 8 +field _GInterfaceInfo-interface_init
	drop 16 8 +field _GInterfaceInfo-interface_data
drop 24 end-structure
\ _GTypeValueTable
begin-structure _GTypeValueTable
	drop 8 8 +field _GTypeValueTable-value_free
	drop 56 8 +field _GTypeValueTable-lcopy_value
	drop 24 8 +field _GTypeValueTable-value_peek_pointer
	drop 40 8 +field _GTypeValueTable-collect_value
	drop 32 8 +field _GTypeValueTable-collect_format
	drop 48 8 +field _GTypeValueTable-lcopy_format
	drop 0 8 +field _GTypeValueTable-value_init
	drop 16 8 +field _GTypeValueTable-value_copy
drop 64 end-structure
\ _GObject
begin-structure _GObject
	drop 0 8 +field _GObject-g_type_instance
	drop 8 4 +field _GObject-ref_count
	drop 16 8 +field _GObject-qdata
drop 24 end-structure
\ _GObjectClass
begin-structure _GObjectClass
	drop 24 8 +field _GObjectClass-set_property
	drop 32 8 +field _GObjectClass-get_property
	drop 48 8 +field _GObjectClass-finalize
	drop 16 8 +field _GObjectClass-constructor
	drop 40 8 +field _GObjectClass-dispose
	drop 88 48 +field _GObjectClass-pdummy
	drop 8 8 +field _GObjectClass-construct_properties
	drop 72 8 +field _GObjectClass-constructed
	drop 0 8 +field _GObjectClass-g_type_class
	drop 64 8 +field _GObjectClass-notify
	drop 80 8 +field _GObjectClass-flags
	drop 56 8 +field _GObjectClass-dispatch_properties_changed
drop 136 end-structure
\ _GObjectConstructParam
begin-structure _GObjectConstructParam
	drop 0 8 +field _GObjectConstructParam-pspec
	drop 8 8 +field _GObjectConstructParam-value
drop 16 end-structure
\ GWeakRef
begin-structure GWeakRef
	drop 0 8 +field GWeakRef-priv
drop 8 end-structure
\ GWeakRef_priv
begin-structure GWeakRef_priv
	drop 0 8 +field GWeakRef_priv-p
drop 8 end-structure
\ _GSignalInvocationHint
begin-structure _GSignalInvocationHint
	drop 0 4 +field _GSignalInvocationHint-signal_id
	drop 4 4 +field _GSignalInvocationHint-detail
	drop 8 4 +field _GSignalInvocationHint-run_type
drop 12 end-structure
\ _GSignalQuery
begin-structure _GSignalQuery
	drop 32 8 +field _GSignalQuery-return_type
	drop 0 4 +field _GSignalQuery-signal_id
	drop 48 8 +field _GSignalQuery-param_types
	drop 16 8 +field _GSignalQuery-itype
	drop 24 4 +field _GSignalQuery-signal_flags
	drop 40 4 +field _GSignalQuery-n_params
	drop 8 8 +field _GSignalQuery-signal_name
drop 56 end-structure

\ --===< function pointers >===---
c-funptr _GSourceCallbackFuncs-ref() {((struct _GSourceCallbackFuncs*)ptr)->ref} a -- void	( cb_data -- )
c-funptr _GSourceCallbackFuncs-unref() {((struct _GSourceCallbackFuncs*)ptr)->unref} a -- void	( cb_data -- )
c-funptr _GSourceCallbackFuncs-get() {((struct _GSourceCallbackFuncs*)ptr)->get} a a a a -- void	( cb_data source func data -- )
c-funptr _GSourceFuncs-prepare() {((struct _GSourceFuncs*)ptr)->prepare} a a -- n	( source timeout_ -- )
c-funptr _GSourceFuncs-check() {((struct _GSourceFuncs*)ptr)->check} a -- n	( source -- )
c-funptr _GSourceFuncs-dispatch() {((struct _GSourceFuncs*)ptr)->dispatch} a a a -- n	( source callback user_data -- )
c-funptr _GSourceFuncs-finalize() {((struct _GSourceFuncs*)ptr)->finalize} a -- void	( source -- )
c-funptr _GTypeValueTable-value_init() {((struct _GTypeValueTable*)ptr)->value_init} a -- void	( value -- )
c-funptr _GTypeValueTable-value_free() {((struct _GTypeValueTable*)ptr)->value_free} a -- void	( value -- )
c-funptr _GTypeValueTable-value_copy() {((struct _GTypeValueTable*)ptr)->value_copy} a a -- void	( src_value dest_value -- )
c-funptr _GTypeValueTable-value_peek_pointer() {((struct _GTypeValueTable*)ptr)->value_peek_pointer} a -- a	( value -- )
c-funptr _GTypeValueTable-collect_value() {((struct _GTypeValueTable*)ptr)->collect_value} a u a u -- a	( value n_collect_values collect_values collect_flags -- )
c-funptr _GTypeValueTable-lcopy_value() {((struct _GTypeValueTable*)ptr)->lcopy_value} a u a u -- a	( value n_collect_values collect_values collect_flags -- )
c-funptr _GObjectClass-constructor() {((struct _GObjectClass*)ptr)->constructor} n u a -- a	( type n_construct_properties construct_properties -- )
c-funptr _GObjectClass-set_property() {((struct _GObjectClass*)ptr)->set_property} a u a a -- void	( object property_id value pspec -- )
c-funptr _GObjectClass-get_property() {((struct _GObjectClass*)ptr)->get_property} a u a a -- void	( object property_id value pspec -- )
c-funptr _GObjectClass-dispose() {((struct _GObjectClass*)ptr)->dispose} a -- void	( object -- )
c-funptr _GObjectClass-finalize() {((struct _GObjectClass*)ptr)->finalize} a -- void	( object -- )
c-funptr _GObjectClass-dispatch_properties_changed() {((struct _GObjectClass*)ptr)->dispatch_properties_changed} a u a -- void	( object n_pspecs pspecs -- )
c-funptr _GObjectClass-notify() {((struct _GObjectClass*)ptr)->notify} a a -- void	( object pspec -- )
c-funptr _GObjectClass-constructed() {((struct _GObjectClass*)ptr)->constructed} a -- void	( object -- )

\ ------===< callbacks >===-------
c-callback GCompareFunc: a a -- n	( a b -- )
c-callback GCompareDataFunc: a a a -- n	( a b user_data -- )
c-callback GEqualFunc: a a -- n	( a b -- )
c-callback GDestroyNotify: a -- void	( data -- )
c-callback GFunc: a a -- void	( data user_data -- )
c-callback GHashFunc: a -- u	( key -- )
c-callback GHFunc: a a a -- void	( key value user_data -- )
c-callback GCopyFunc: a a -- a	( src data -- )
c-callback GFreeFunc: a -- void	( data -- )
c-callback GTranslateFunc: s a -- s	( str data -- )
c-callback GThreadFunc: a -- a	( data -- )
c-callback GSourceFunc: a -- n	( user_data -- )
c-callback GChildWatchFunc: n n a -- void	( pid wait_status user_data -- )
c-callback GSourceDisposeFunc: a -- void	( source -- )
c-callback GSourceDummyMarshal:  -- void	( <noname> -- )
c-callback GClearHandleFunc: u -- void	( handle_id -- )
c-callback GBaseInitFunc: a -- void	( g_class -- )
c-callback GBaseFinalizeFunc: a -- void	( g_class -- )
c-callback GClassInitFunc: a a -- void	( g_class class_data -- )
c-callback GClassFinalizeFunc: a a -- void	( g_class class_data -- )
c-callback GInstanceInitFunc: a a -- void	( instance g_class -- )
c-callback GInterfaceInitFunc: a a -- void	( g_iface iface_data -- )
c-callback GInterfaceFinalizeFunc: a a -- void	( g_iface iface_data -- )
c-callback GTypeClassCacheFunc: a a -- n	( cache_data g_class -- )
c-callback GTypeInterfaceCheckFunc: a a -- void	( check_data g_iface -- )
c-callback GObjectGetPropertyFunc: a u a a -- void	( object property_id value pspec -- )
c-callback GObjectSetPropertyFunc: a u a a -- void	( object property_id value pspec -- )
c-callback GObjectFinalizeFunc: a -- void	( object -- )
c-callback GWeakNotify: a a -- void	( data where_the_object_was -- )
c-callback GToggleNotify: a a n -- void	( data object is_last_ref -- )
c-callback GSignalEmissionHook: a u a a -- n	( ihint n_param_values param_values data -- )
c-callback GSignalAccumulator: a a a a -- n	( ihint return_accu handler_return data -- )

\ ------===< functions >===-------
\ c-function _GLIB_CHECKED_ADD_UINT _GLIB_CHECKED_ADD_UINT a u u -- n	( dest a b -- )
\ c-function _GLIB_CHECKED_MUL_UINT _GLIB_CHECKED_MUL_UINT a u u -- n	( dest a b -- )
\ c-function _GLIB_CHECKED_ADD_UINT64 _GLIB_CHECKED_ADD_UINT64 a n n -- n	( dest a b -- )
\ c-function _GLIB_CHECKED_MUL_UINT64 _GLIB_CHECKED_MUL_UINT64 a n n -- n	( dest a b -- )
\ c-function _GLIB_CHECKED_ADD_SIZE _GLIB_CHECKED_ADD_SIZE a n n -- n	( dest a b -- )
\ c-function _GLIB_CHECKED_MUL_SIZE _GLIB_CHECKED_MUL_SIZE a n n -- n	( dest a b -- )
c-function g_quark_try_string g_quark_try_string s -- n	( string -- )
c-function g_quark_from_static_string g_quark_from_static_string s -- n	( string -- )
c-function g_quark_from_string g_quark_from_string s -- n	( string -- )
c-function g_quark_to_string g_quark_to_string n -- s	( quark -- )
c-function g_intern_string g_intern_string s -- s	( string -- )
c-function g_intern_static_string g_intern_static_string s -- s	( string -- )
c-function g_thread_error_quark g_thread_error_quark  -- n	( -- )
c-function g_thread_ref g_thread_ref a -- a	( thread -- )
c-function g_thread_unref g_thread_unref a -- void	( thread -- )
c-function g_thread_new g_thread_new s a a -- a	( name func data -- )
c-function g_thread_try_new g_thread_try_new s a a a -- a	( name func data error -- )
c-function g_thread_self g_thread_self  -- a	( -- )
c-function g_thread_exit g_thread_exit a -- void	( retval -- )
c-function g_thread_join g_thread_join a -- a	( thread -- )
c-function g_thread_yield g_thread_yield  -- void	( -- )
c-function g_mutex_init g_mutex_init a -- void	( mutex -- )
c-function g_mutex_clear g_mutex_clear a -- void	( mutex -- )
c-function g_mutex_lock g_mutex_lock a -- void	( mutex -- )
c-function g_mutex_trylock g_mutex_trylock a -- n	( mutex -- )
c-function g_mutex_unlock g_mutex_unlock a -- void	( mutex -- )
c-function g_rw_lock_init g_rw_lock_init a -- void	( rw_lock -- )
c-function g_rw_lock_clear g_rw_lock_clear a -- void	( rw_lock -- )
c-function g_rw_lock_writer_lock g_rw_lock_writer_lock a -- void	( rw_lock -- )
c-function g_rw_lock_writer_trylock g_rw_lock_writer_trylock a -- n	( rw_lock -- )
c-function g_rw_lock_writer_unlock g_rw_lock_writer_unlock a -- void	( rw_lock -- )
c-function g_rw_lock_reader_lock g_rw_lock_reader_lock a -- void	( rw_lock -- )
c-function g_rw_lock_reader_trylock g_rw_lock_reader_trylock a -- n	( rw_lock -- )
c-function g_rw_lock_reader_unlock g_rw_lock_reader_unlock a -- void	( rw_lock -- )
c-function g_rec_mutex_init g_rec_mutex_init a -- void	( rec_mutex -- )
c-function g_rec_mutex_clear g_rec_mutex_clear a -- void	( rec_mutex -- )
c-function g_rec_mutex_lock g_rec_mutex_lock a -- void	( rec_mutex -- )
c-function g_rec_mutex_trylock g_rec_mutex_trylock a -- n	( rec_mutex -- )
c-function g_rec_mutex_unlock g_rec_mutex_unlock a -- void	( rec_mutex -- )
c-function g_cond_init g_cond_init a -- void	( cond -- )
c-function g_cond_clear g_cond_clear a -- void	( cond -- )
c-function g_cond_wait g_cond_wait a a -- void	( cond mutex -- )
c-function g_cond_signal g_cond_signal a -- void	( cond -- )
c-function g_cond_broadcast g_cond_broadcast a -- void	( cond -- )
c-function g_cond_wait_until g_cond_wait_until a a n -- n	( cond mutex end_time -- )
c-function g_private_get g_private_get a -- a	( key -- )
c-function g_private_set g_private_set a a -- void	( key value -- )
c-function g_private_replace g_private_replace a a -- void	( key value -- )
c-function g_once_impl g_once_impl a a a -- a	( once func arg -- )
\ c-function g_once_init_enter g_once_init_enter a -- n	( location -- )
\ c-function g_once_init_leave g_once_init_leave a n -- void	( location result -- )
c-function g_get_num_processors g_get_num_processors  -- u	( -- )
c-function g_mutex_locker_new g_mutex_locker_new a -- a	( mutex -- )
c-function g_mutex_locker_free g_mutex_locker_free a -- void	( locker -- )
c-function g_rec_mutex_locker_new g_rec_mutex_locker_new a -- a	( rec_mutex -- )
c-function g_rec_mutex_locker_free g_rec_mutex_locker_free a -- void	( locker -- )
c-function g_rw_lock_writer_locker_new g_rw_lock_writer_locker_new a -- a	( rw_lock -- )
c-function g_rw_lock_writer_locker_free g_rw_lock_writer_locker_free a -- void	( locker -- )
c-function g_rw_lock_reader_locker_new g_rw_lock_reader_locker_new a -- a	( rw_lock -- )
c-function g_rw_lock_reader_locker_free g_rw_lock_reader_locker_free a -- void	( locker -- )
c-function g_main_context_new g_main_context_new  -- a	( -- )
c-function g_main_context_new_with_flags g_main_context_new_with_flags n -- a	( flags -- )
c-function g_main_context_ref g_main_context_ref a -- a	( context -- )
c-function g_main_context_unref g_main_context_unref a -- void	( context -- )
c-function g_main_context_default g_main_context_default  -- a	( -- )
c-function g_main_context_iteration g_main_context_iteration a n -- n	( context may_block -- )
c-function g_main_context_pending g_main_context_pending a -- n	( context -- )
c-function g_main_context_find_source_by_id g_main_context_find_source_by_id a u -- a	( context source_id -- )
c-function g_main_context_find_source_by_user_data g_main_context_find_source_by_user_data a a -- a	( context user_data -- )
c-function g_main_context_find_source_by_funcs_user_data g_main_context_find_source_by_funcs_user_data a a a -- a	( context funcs user_data -- )
c-function g_main_context_wakeup g_main_context_wakeup a -- void	( context -- )
c-function g_main_context_acquire g_main_context_acquire a -- n	( context -- )
c-function g_main_context_release g_main_context_release a -- void	( context -- )
c-function g_main_context_is_owner g_main_context_is_owner a -- n	( context -- )
\ c-function g_main_context_wait g_main_context_wait a a a -- n	( context cond mutex -- )
c-function g_main_context_prepare g_main_context_prepare a a -- n	( context priority -- )
c-function g_main_context_query g_main_context_query a n a a n -- n	( context max_priority timeout_ fds n_fds -- )
c-function g_main_context_check g_main_context_check a n a n -- n	( context max_priority fds n_fds -- )
c-function g_main_context_dispatch g_main_context_dispatch a -- void	( context -- )
c-function g_main_context_set_poll_func g_main_context_set_poll_func a a -- void	( context func -- )
c-function g_main_context_get_poll_func g_main_context_get_poll_func a -- a	( context -- )
c-function g_main_context_add_poll g_main_context_add_poll a a n -- void	( context fd priority -- )
c-function g_main_context_remove_poll g_main_context_remove_poll a a -- void	( context fd -- )
c-function g_main_depth g_main_depth  -- n	( -- )
c-function g_main_current_source g_main_current_source  -- a	( -- )
c-function g_main_context_push_thread_default g_main_context_push_thread_default a -- void	( context -- )
c-function g_main_context_pop_thread_default g_main_context_pop_thread_default a -- void	( context -- )
c-function g_main_context_get_thread_default g_main_context_get_thread_default  -- a	( -- )
c-function g_main_context_ref_thread_default g_main_context_ref_thread_default  -- a	( -- )
c-function g_main_context_pusher_new g_main_context_pusher_new a -- a	( main_context -- )
c-function g_main_context_pusher_free g_main_context_pusher_free a -- void	( pusher -- )
c-function g_main_loop_new g_main_loop_new a n -- a	( context is_running -- )
c-function g_main_loop_run g_main_loop_run a -- void	( loop -- )
c-function g_main_loop_quit g_main_loop_quit a -- void	( loop -- )
c-function g_main_loop_ref g_main_loop_ref a -- a	( loop -- )
c-function g_main_loop_unref g_main_loop_unref a -- void	( loop -- )
c-function g_main_loop_is_running g_main_loop_is_running a -- n	( loop -- )
c-function g_main_loop_get_context g_main_loop_get_context a -- a	( loop -- )
c-function g_source_new g_source_new a u -- a	( source_funcs struct_size -- )
c-function g_source_set_dispose_function g_source_set_dispose_function a a -- void	( source dispose -- )
c-function g_source_ref g_source_ref a -- a	( source -- )
c-function g_source_unref g_source_unref a -- void	( source -- )
c-function g_source_attach g_source_attach a a -- u	( source context -- )
c-function g_source_destroy g_source_destroy a -- void	( source -- )
c-function g_source_set_priority g_source_set_priority a n -- void	( source priority -- )
c-function g_source_get_priority g_source_get_priority a -- n	( source -- )
c-function g_source_set_can_recurse g_source_set_can_recurse a n -- void	( source can_recurse -- )
c-function g_source_get_can_recurse g_source_get_can_recurse a -- n	( source -- )
c-function g_source_get_id g_source_get_id a -- u	( source -- )
c-function g_source_get_context g_source_get_context a -- a	( source -- )
c-function g_source_set_callback g_source_set_callback a a a a -- void	( source func data notify -- )
c-function g_source_set_funcs g_source_set_funcs a a -- void	( source funcs -- )
c-function g_source_is_destroyed g_source_is_destroyed a -- n	( source -- )
c-function g_source_set_name g_source_set_name a s -- void	( source name -- )
c-function g_source_set_static_name g_source_set_static_name a s -- void	( source name -- )
c-function g_source_get_name g_source_get_name a -- s	( source -- )
c-function g_source_set_name_by_id g_source_set_name_by_id u s -- void	( tag name -- )
c-function g_source_set_ready_time g_source_set_ready_time a n -- void	( source ready_time -- )
c-function g_source_get_ready_time g_source_get_ready_time a -- n	( source -- )
c-function g_source_set_callback_indirect g_source_set_callback_indirect a a a -- void	( source callback_data callback_funcs -- )
c-function g_source_add_poll g_source_add_poll a a -- void	( source fd -- )
c-function g_source_remove_poll g_source_remove_poll a a -- void	( source fd -- )
c-function g_source_add_child_source g_source_add_child_source a a -- void	( source child_source -- )
c-function g_source_remove_child_source g_source_remove_child_source a a -- void	( source child_source -- )
\ c-function g_source_get_current_time g_source_get_current_time a a -- void	( source timeval -- )
c-function g_source_get_time g_source_get_time a -- n	( source -- )
c-function g_idle_source_new g_idle_source_new  -- a	( -- )
c-function g_child_watch_source_new g_child_watch_source_new n -- a	( pid -- )
c-function g_timeout_source_new g_timeout_source_new u -- a	( interval -- )
c-function g_timeout_source_new_seconds g_timeout_source_new_seconds u -- a	( interval -- )
c-function g_get_current_time g_get_current_time a -- void	( result -- )
c-function g_get_monotonic_time g_get_monotonic_time  -- n	( -- )
c-function g_get_real_time g_get_real_time  -- n	( -- )
c-function g_source_remove g_source_remove u -- n	( tag -- )
c-function g_source_remove_by_user_data g_source_remove_by_user_data a -- n	( user_data -- )
c-function g_source_remove_by_funcs_user_data g_source_remove_by_funcs_user_data a a -- n	( funcs user_data -- )
\ c-function g_clear_handle_id g_clear_handle_id a a -- void	( tag_ptr clear_func -- )
c-function g_timeout_add_full g_timeout_add_full n u a a a -- u	( priority interval function data notify -- )
c-function g_timeout_add g_timeout_add u a a -- u	( interval function data -- )
c-function g_timeout_add_seconds_full g_timeout_add_seconds_full n u a a a -- u	( priority interval function data notify -- )
c-function g_timeout_add_seconds g_timeout_add_seconds u a a -- u	( interval function data -- )
c-function g_child_watch_add_full g_child_watch_add_full n n a a a -- u	( priority pid function data notify -- )
c-function g_child_watch_add g_child_watch_add n a a -- u	( pid function data -- )
c-function g_idle_add g_idle_add a a -- u	( function data -- )
c-function g_idle_add_full g_idle_add_full n a a a -- u	( priority function data notify -- )
c-function g_idle_remove_by_data g_idle_remove_by_data a -- n	( data -- )
c-function g_main_context_invoke_full g_main_context_invoke_full a n a a a -- void	( context priority function data notify -- )
c-function g_main_context_invoke g_main_context_invoke a a a -- void	( context function data -- )
c-function g_steal_fd g_steal_fd a -- n	( fd_ptr -- )
c-function g_type_init g_type_init  -- void	( -- )
c-function g_type_init_with_debug_flags g_type_init_with_debug_flags n -- void	( debug_flags -- )
c-function g_type_name g_type_name n -- s	( type -- )
c-function g_type_qname g_type_qname n -- n	( type -- )
c-function g_type_from_name g_type_from_name s -- n	( name -- )
c-function g_type_parent g_type_parent n -- n	( type -- )
c-function g_type_depth g_type_depth n -- u	( type -- )
c-function g_type_next_base g_type_next_base n n -- n	( leaf_type root_type -- )
c-function g_type_is_a g_type_is_a n n -- n	( type is_a_type -- )
c-function g_type_class_ref g_type_class_ref n -- a	( type -- )
c-function g_type_class_peek g_type_class_peek n -- a	( type -- )
c-function g_type_class_peek_static g_type_class_peek_static n -- a	( type -- )
c-function g_type_class_unref g_type_class_unref a -- void	( g_class -- )
c-function g_type_class_peek_parent g_type_class_peek_parent a -- a	( g_class -- )
c-function g_type_interface_peek g_type_interface_peek a n -- a	( instance_class iface_type -- )
c-function g_type_interface_peek_parent g_type_interface_peek_parent a -- a	( g_iface -- )
c-function g_type_default_interface_ref g_type_default_interface_ref n -- a	( g_type -- )
c-function g_type_default_interface_peek g_type_default_interface_peek n -- a	( g_type -- )
c-function g_type_default_interface_unref g_type_default_interface_unref a -- void	( g_iface -- )
c-function g_type_children g_type_children n a -- a	( type n_children -- )
c-function g_type_interfaces g_type_interfaces n a -- a	( type n_interfaces -- )
c-function g_type_set_qdata g_type_set_qdata n n a -- void	( type quark data -- )
c-function g_type_get_qdata g_type_get_qdata n n -- a	( type quark -- )
c-function g_type_query g_type_query n a -- void	( type query -- )
c-function g_type_get_instance_count g_type_get_instance_count n -- n	( type -- )
c-function g_type_register_static g_type_register_static n s a n -- n	( parent_type type_name info flags -- )
c-function g_type_register_static_simple g_type_register_static_simple n s u a u a n -- n	( parent_type type_name class_size class_init instance_size instance_init flags -- )
c-function g_type_register_dynamic g_type_register_dynamic n s a n -- n	( parent_type type_name plugin flags -- )
c-function g_type_register_fundamental g_type_register_fundamental n s a a n -- n	( type_id type_name info finfo flags -- )
c-function g_type_add_interface_static g_type_add_interface_static n n a -- void	( instance_type interface_type info -- )
c-function g_type_add_interface_dynamic g_type_add_interface_dynamic n n a -- void	( instance_type interface_type plugin -- )
c-function g_type_interface_add_prerequisite g_type_interface_add_prerequisite n n -- void	( interface_type prerequisite_type -- )
c-function g_type_interface_prerequisites g_type_interface_prerequisites n a -- a	( interface_type n_prerequisites -- )
c-function g_type_interface_instantiatable_prerequisite g_type_interface_instantiatable_prerequisite n -- n	( interface_type -- )
c-function g_type_class_add_private g_type_class_add_private a n -- void	( g_class private_size -- )
c-function g_type_add_instance_private g_type_add_instance_private n n -- n	( class_type private_size -- )
c-function g_type_instance_get_private g_type_instance_get_private a n -- a	( instance private_type -- )
c-function g_type_class_adjust_private_offset g_type_class_adjust_private_offset a a -- void	( g_class private_size_or_offset -- )
c-function g_type_add_class_private g_type_add_class_private n n -- void	( class_type private_size -- )
c-function g_type_class_get_private g_type_class_get_private a n -- a	( klass private_type -- )
c-function g_type_class_get_instance_private_offset g_type_class_get_instance_private_offset a -- n	( g_class -- )
c-function g_type_ensure g_type_ensure n -- void	( type -- )
c-function g_type_get_type_registration_serial g_type_get_type_registration_serial  -- u	( -- )
c-function g_type_get_plugin g_type_get_plugin n -- a	( type -- )
c-function g_type_interface_get_plugin g_type_interface_get_plugin n n -- a	( instance_type interface_type -- )
c-function g_type_fundamental_next g_type_fundamental_next  -- n	( -- )
c-function g_type_fundamental g_type_fundamental n -- n	( type_id -- )
c-function g_type_create_instance g_type_create_instance n -- a	( type -- )
c-function g_type_free_instance g_type_free_instance a -- void	( instance -- )
c-function g_type_add_class_cache_func g_type_add_class_cache_func a a -- void	( cache_data cache_func -- )
c-function g_type_remove_class_cache_func g_type_remove_class_cache_func a a -- void	( cache_data cache_func -- )
c-function g_type_class_unref_uncached g_type_class_unref_uncached a -- void	( g_class -- )
c-function g_type_add_interface_check g_type_add_interface_check a a -- void	( check_data check_func -- )
c-function g_type_remove_interface_check g_type_remove_interface_check a a -- void	( check_data check_func -- )
c-function g_type_value_table_peek g_type_value_table_peek n -- a	( type -- )
c-function g_type_check_instance g_type_check_instance a -- n	( instance -- )
c-function g_type_check_instance_cast g_type_check_instance_cast a n -- a	( instance iface_type -- )
c-function g_type_check_instance_is_a g_type_check_instance_is_a a n -- n	( instance iface_type -- )
c-function g_type_check_instance_is_fundamentally_a g_type_check_instance_is_fundamentally_a a n -- n	( instance fundamental_type -- )
c-function g_type_check_class_cast g_type_check_class_cast a n -- a	( g_class is_a_type -- )
c-function g_type_check_class_is_a g_type_check_class_is_a a n -- n	( g_class is_a_type -- )
c-function g_type_check_is_value_type g_type_check_is_value_type n -- n	( type -- )
c-function g_type_check_value g_type_check_value a -- n	( value -- )
c-function g_type_check_value_holds g_type_check_value_holds a n -- n	( value type -- )
c-function g_type_test_flags g_type_test_flags n u -- n	( type flags -- )
c-function g_type_name_from_instance g_type_name_from_instance a -- s	( instance -- )
c-function g_type_name_from_class g_type_name_from_class a -- s	( g_class -- )
c-function g_initially_unowned_get_type g_initially_unowned_get_type  -- n	( -- )
c-function g_object_class_install_property g_object_class_install_property a u a -- void	( oclass property_id pspec -- )
c-function g_object_class_find_property g_object_class_find_property a s -- a	( oclass property_name -- )
c-function g_object_class_list_properties g_object_class_list_properties a a -- a	( oclass n_properties -- )
c-function g_object_class_override_property g_object_class_override_property a u s -- void	( oclass property_id name -- )
c-function g_object_class_install_properties g_object_class_install_properties a u a -- void	( oclass n_pspecs pspecs -- )
c-function g_object_interface_install_property g_object_interface_install_property a a -- void	( g_iface pspec -- )
c-function g_object_interface_find_property g_object_interface_find_property a s -- a	( g_iface property_name -- )
c-function g_object_interface_list_properties g_object_interface_list_properties a a -- a	( g_iface n_properties_p -- )
c-function g_object_get_type g_object_get_type  -- n	( -- )
c-function g_object_new g_object_new n s ... -- a	( object_type first_property_name <noname> -- )
c-function g_object_new_with_properties g_object_new_with_properties n u a a -- a	( object_type n_properties names values -- )
\ c-function g_object_newv g_object_newv n u a -- a	( object_type n_parameters parameters -- )
\ c-function g_object_new_valist g_object_new_valist n s n -- a	( object_type first_property_name var_args -- )
c-function g_object_set g_object_set a s ... -- void	( object first_property_name <noname> -- )
c-function g_object_get g_object_get a s ... -- void	( object first_property_name <noname> -- )
c-function g_object_connect g_object_connect a s ... -- a	( object signal_spec <noname> -- )
c-function g_object_disconnect g_object_disconnect a s ... -- void	( object signal_spec <noname> -- )
c-function g_object_setv g_object_setv a u a a -- void	( object n_properties names values -- )
\ c-function g_object_set_valist g_object_set_valist a s n -- void	( object first_property_name var_args -- )
c-function g_object_getv g_object_getv a u a a -- void	( object n_properties names values -- )
\ c-function g_object_get_valist g_object_get_valist a s n -- void	( object first_property_name var_args -- )
c-function g_object_set_property g_object_set_property a s a -- void	( object property_name value -- )
c-function g_object_get_property g_object_get_property a s a -- void	( object property_name value -- )
c-function g_object_freeze_notify g_object_freeze_notify a -- void	( object -- )
c-function g_object_notify g_object_notify a s -- void	( object property_name -- )
c-function g_object_notify_by_pspec g_object_notify_by_pspec a a -- void	( object pspec -- )
c-function g_object_thaw_notify g_object_thaw_notify a -- void	( object -- )
c-function g_object_is_floating g_object_is_floating a -- n	( object -- )
c-function g_object_ref_sink g_object_ref_sink a -- a	( object -- )
c-function g_object_take_ref g_object_take_ref a -- a	( object -- )
c-function g_object_ref g_object_ref a -- a	( object -- )
c-function g_object_unref g_object_unref a -- void	( object -- )
c-function g_object_weak_ref g_object_weak_ref a a a -- void	( object notify data -- )
c-function g_object_weak_unref g_object_weak_unref a a a -- void	( object notify data -- )
c-function g_object_add_weak_pointer g_object_add_weak_pointer a a -- void	( object weak_pointer_location -- )
c-function g_object_remove_weak_pointer g_object_remove_weak_pointer a a -- void	( object weak_pointer_location -- )
c-function g_object_add_toggle_ref g_object_add_toggle_ref a a a -- void	( object notify data -- )
c-function g_object_remove_toggle_ref g_object_remove_toggle_ref a a a -- void	( object notify data -- )
c-function g_object_get_qdata g_object_get_qdata a n -- a	( object quark -- )
c-function g_object_set_qdata g_object_set_qdata a n a -- void	( object quark data -- )
c-function g_object_set_qdata_full g_object_set_qdata_full a n a a -- void	( object quark data destroy -- )
c-function g_object_steal_qdata g_object_steal_qdata a n -- a	( object quark -- )
c-function g_object_dup_qdata g_object_dup_qdata a n a a -- a	( object quark dup_func user_data -- )
c-function g_object_replace_qdata g_object_replace_qdata a n a a a a -- n	( object quark oldval newval destroy old_destroy -- )
c-function g_object_get_data g_object_get_data a s -- a	( object key -- )
c-function g_object_set_data g_object_set_data a s a -- void	( object key data -- )
c-function g_object_set_data_full g_object_set_data_full a s a a -- void	( object key data destroy -- )
c-function g_object_steal_data g_object_steal_data a s -- a	( object key -- )
c-function g_object_dup_data g_object_dup_data a s a a -- a	( object key dup_func user_data -- )
c-function g_object_replace_data g_object_replace_data a s a a a a -- n	( object key oldval newval destroy old_destroy -- )
c-function g_object_watch_closure g_object_watch_closure a a -- void	( object closure -- )
c-function g_cclosure_new_object g_cclosure_new_object a a -- a	( callback_func object -- )
c-function g_cclosure_new_object_swap g_cclosure_new_object_swap a a -- a	( callback_func object -- )
c-function g_closure_new_object g_closure_new_object u a -- a	( sizeof_closure object -- )
c-function g_value_set_object g_value_set_object a a -- void	( value v_object -- )
c-function g_value_get_object g_value_get_object a -- a	( value -- )
c-function g_value_dup_object g_value_dup_object a -- a	( value -- )
c-function g_signal_connect_object g_signal_connect_object a s a a n -- u	( instance detailed_signal c_handler gobject connect_flags -- )
c-function g_object_force_floating g_object_force_floating a -- void	( object -- )
c-function g_object_run_dispose g_object_run_dispose a -- void	( object -- )
c-function g_value_take_object g_value_take_object a a -- void	( value v_object -- )
\ c-function g_value_set_object_take_ownership g_value_set_object_take_ownership a a -- void	( value v_object -- )
\ c-function g_object_compat_control g_object_compat_control n a -- n	( what data -- )
\ c-function g_clear_object g_clear_object a -- void	( object_ptr -- )
\ c-function g_set_object g_set_object a a -- n	( object_ptr new_object -- )
c-function g_assert_finalize_object g_assert_finalize_object a -- void	( object -- )
\ c-function g_clear_weak_pointer g_clear_weak_pointer a -- void	( weak_pointer_location -- )
\ c-function g_set_weak_pointer g_set_weak_pointer a a -- n	( weak_pointer_location new_object -- )
c-function g_weak_ref_init g_weak_ref_init a a -- void	( weak_ref object -- )
c-function g_weak_ref_clear g_weak_ref_clear a -- void	( weak_ref -- )
c-function g_weak_ref_get g_weak_ref_get a -- a	( weak_ref -- )
c-function g_weak_ref_set g_weak_ref_set a a -- void	( weak_ref object -- )
c-function g_signal_newv g_signal_newv s n n a a a a n u a -- u	( signal_name itype signal_flags class_closure accumulator accu_data c_marshaller return_type n_params param_types -- )
\ c-function g_signal_new_valist g_signal_new_valist s n n a a a a n u n -- u	( signal_name itype signal_flags class_closure accumulator accu_data c_marshaller return_type n_params args -- )
c-function g_signal_new g_signal_new s n n u a a a n u ... -- u	( signal_name itype signal_flags class_offset accumulator accu_data c_marshaller return_type n_params <noname> -- )
c-function g_signal_new_class_handler g_signal_new_class_handler s n n a a a a n u ... -- u	( signal_name itype signal_flags class_handler accumulator accu_data c_marshaller return_type n_params <noname> -- )
c-function g_signal_set_va_marshaller g_signal_set_va_marshaller u n a -- void	( signal_id instance_type va_marshaller -- )
c-function g_signal_emitv g_signal_emitv a u n a -- void	( instance_and_params signal_id detail return_value -- )
\ c-function g_signal_emit_valist g_signal_emit_valist a u n n -- void	( instance signal_id detail var_args -- )
c-function g_signal_emit g_signal_emit a u n ... -- void	( instance signal_id detail <noname> -- )
c-function g_signal_emit_by_name g_signal_emit_by_name a s ... -- void	( instance detailed_signal <noname> -- )
c-function g_signal_lookup g_signal_lookup s n -- u	( name itype -- )
c-function g_signal_name g_signal_name u -- s	( signal_id -- )
c-function g_signal_query g_signal_query u a -- void	( signal_id query -- )
c-function g_signal_list_ids g_signal_list_ids n a -- a	( itype n_ids -- )
c-function g_signal_is_valid_name g_signal_is_valid_name s -- n	( name -- )
c-function g_signal_parse_name g_signal_parse_name s n a a n -- n	( detailed_signal itype signal_id_p detail_p force_detail_quark -- )
c-function g_signal_get_invocation_hint g_signal_get_invocation_hint a -- a	( instance -- )
c-function g_signal_stop_emission g_signal_stop_emission a u n -- void	( instance signal_id detail -- )
c-function g_signal_stop_emission_by_name g_signal_stop_emission_by_name a s -- void	( instance detailed_signal -- )
c-function g_signal_add_emission_hook g_signal_add_emission_hook u n a a a -- u	( signal_id detail hook_func hook_data data_destroy -- )
c-function g_signal_remove_emission_hook g_signal_remove_emission_hook u u -- void	( signal_id hook_id -- )
c-function g_signal_has_handler_pending g_signal_has_handler_pending a u n n -- n	( instance signal_id detail may_be_blocked -- )
c-function g_signal_connect_closure_by_id g_signal_connect_closure_by_id a u n a n -- u	( instance signal_id detail closure after -- )
c-function g_signal_connect_closure g_signal_connect_closure a s a n -- u	( instance detailed_signal closure after -- )
c-function g_signal_connect_data g_signal_connect_data a s a a a n -- u	( instance detailed_signal c_handler data destroy_data connect_flags -- )
c-function g_signal_handler_block g_signal_handler_block a u -- void	( instance handler_id -- )
c-function g_signal_handler_unblock g_signal_handler_unblock a u -- void	( instance handler_id -- )
c-function g_signal_handler_disconnect g_signal_handler_disconnect a u -- void	( instance handler_id -- )
c-function g_signal_handler_is_connected g_signal_handler_is_connected a u -- n	( instance handler_id -- )
c-function g_signal_handler_find g_signal_handler_find a n u n a a a -- u	( instance mask signal_id detail closure func data -- )
c-function g_signal_handlers_block_matched g_signal_handlers_block_matched a n u n a a a -- u	( instance mask signal_id detail closure func data -- )
c-function g_signal_handlers_unblock_matched g_signal_handlers_unblock_matched a n u n a a a -- u	( instance mask signal_id detail closure func data -- )
c-function g_signal_handlers_disconnect_matched g_signal_handlers_disconnect_matched a n u n a a a -- u	( instance mask signal_id detail closure func data -- )
c-function g_clear_signal_handler g_clear_signal_handler a{(gulong*)} a -- void	( handler_id_ptr instance -- )
c-function g_signal_override_class_closure g_signal_override_class_closure u n a -- void	( signal_id instance_type class_closure -- )
c-function g_signal_override_class_handler g_signal_override_class_handler s n a -- void	( signal_name instance_type class_handler -- )
c-function g_signal_chain_from_overridden g_signal_chain_from_overridden a a -- void	( instance_and_params return_value -- )
c-function g_signal_chain_from_overridden_handler g_signal_chain_from_overridden_handler a ... -- void	( instance <noname> -- )
c-function g_signal_accumulator_true_handled g_signal_accumulator_true_handled a a a a -- n	( ihint return_accu handler_return dummy -- )
c-function g_signal_accumulator_first_wins g_signal_accumulator_first_wins a a a a -- n	( ihint return_accu handler_return dummy -- )
c-function g_signal_handlers_destroy g_signal_handlers_destroy a -- void	( instance -- )
c-function _g_signals_destroy _g_signals_destroy n -- void	( itype -- )

\ ----===< postfix >===-----
end-c-library
