\ This file has been generated using SWIG and fsi,
\ and is already platform dependent, search for the corresponding
\ fsi-file to compile it where no one has compiled it before ;)
\ Forth systems have their own own dynamic loader and don't need addional C-Code.
\ That's why this file will just print normal forth-code once compiled
\ and can be used directly with include or require.
\ As all comments are stripped during the compilation, please
\ insert the copyright notice of the original file here.

\ ----===< prefix >===-----
cs-vocabulary pulse

get-current also pulse definitions

c-library pulse
s" pulse" add-lib
s" ((struct pa_:x.spx[arg0]" ptr-declare $+[]!
\c #include <pulse/pulseaudio.h>

\ ----===< int constants >===-----
#32	constant PA_CHANNELS_MAX
#384000	constant PA_RATE_MAX
#32	constant PA_SAMPLE_SPEC_SNPRINT_MAX
#11	constant PA_BYTES_SNPRINT_MAX
#256	constant PA_FORMAT_INFO_SNPRINT_MAX
#12	constant PA_API_VERSION
#35	constant PA_PROTOCOL_VERSION
#15	constant PA_MAJOR
#99	constant PA_MINOR
#0	constant PA_MICRO
#336	constant PA_CHANNEL_MAP_SNPRINT_MAX
#320	constant PA_CVOLUME_SNPRINT_MAX
#448	constant PA_SW_CVOLUME_SNPRINT_DB_MAX
#1984	constant PA_CVOLUME_SNPRINT_VERBOSE_MAX
#10	constant PA_VOLUME_SNPRINT_MAX
#11	constant PA_SW_VOLUME_SNPRINT_DB_MAX
#35	constant PA_VOLUME_SNPRINT_VERBOSE_MAX

\ --------===< enums >===---------
#0	constant PA_IO_EVENT_NULL
#1	constant PA_IO_EVENT_INPUT
#2	constant PA_IO_EVENT_OUTPUT
#4	constant PA_IO_EVENT_HANGUP
#8	constant PA_IO_EVENT_ERROR
#0	constant PA_SAMPLE_U8
#1	constant PA_SAMPLE_ALAW
#2	constant PA_SAMPLE_ULAW
#3	constant PA_SAMPLE_S16LE
#4	constant PA_SAMPLE_S16BE
#5	constant PA_SAMPLE_FLOAT32LE
#6	constant PA_SAMPLE_FLOAT32BE
#7	constant PA_SAMPLE_S32LE
#8	constant PA_SAMPLE_S32BE
#9	constant PA_SAMPLE_S24LE
#10	constant PA_SAMPLE_S24BE
#11	constant PA_SAMPLE_S24_32LE
#12	constant PA_SAMPLE_S24_32BE
#13	constant PA_SAMPLE_MAX
#-1	constant PA_SAMPLE_INVALID
#0	constant PA_ENCODING_ANY
#1	constant PA_ENCODING_PCM
#2	constant PA_ENCODING_AC3_IEC61937
#3	constant PA_ENCODING_EAC3_IEC61937
#4	constant PA_ENCODING_MPEG_IEC61937
#5	constant PA_ENCODING_DTS_IEC61937
#6	constant PA_ENCODING_MPEG2_AAC_IEC61937
#7	constant PA_ENCODING_TRUEHD_IEC61937
#8	constant PA_ENCODING_DTSHD_IEC61937
#9	constant PA_ENCODING_MAX
#-1	constant PA_ENCODING_INVALID
#0	constant PA_PROP_TYPE_INT
#1	constant PA_PROP_TYPE_INT_RANGE
#2	constant PA_PROP_TYPE_INT_ARRAY
#3	constant PA_PROP_TYPE_STRING
#4	constant PA_PROP_TYPE_STRING_ARRAY
#-1	constant PA_PROP_TYPE_INVALID
#0	constant PA_CONTEXT_UNCONNECTED
#1	constant PA_CONTEXT_CONNECTING
#2	constant PA_CONTEXT_AUTHORIZING
#3	constant PA_CONTEXT_SETTING_NAME
#4	constant PA_CONTEXT_READY
#5	constant PA_CONTEXT_FAILED
#6	constant PA_CONTEXT_TERMINATED
#0	constant PA_STREAM_UNCONNECTED
#1	constant PA_STREAM_CREATING
#2	constant PA_STREAM_READY
#3	constant PA_STREAM_FAILED
#4	constant PA_STREAM_TERMINATED
#0	constant PA_OPERATION_RUNNING
#1	constant PA_OPERATION_DONE
#2	constant PA_OPERATION_CANCELLED
#0	constant PA_CONTEXT_NOFLAGS
#1	constant PA_CONTEXT_NOAUTOSPAWN
#2	constant PA_CONTEXT_NOFAIL
#1	constant PA_DIRECTION_OUTPUT
#2	constant PA_DIRECTION_INPUT
#0	constant PA_DEVICE_TYPE_SINK
#1	constant PA_DEVICE_TYPE_SOURCE
#0	constant PA_STREAM_NODIRECTION
#1	constant PA_STREAM_PLAYBACK
#2	constant PA_STREAM_RECORD
#3	constant PA_STREAM_UPLOAD
#0	constant PA_STREAM_NOFLAGS
#1	constant PA_STREAM_START_CORKED
#2	constant PA_STREAM_INTERPOLATE_TIMING
#4	constant PA_STREAM_NOT_MONOTONIC
#8	constant PA_STREAM_AUTO_TIMING_UPDATE
#16	constant PA_STREAM_NO_REMAP_CHANNELS
#32	constant PA_STREAM_NO_REMIX_CHANNELS
#64	constant PA_STREAM_FIX_FORMAT
#128	constant PA_STREAM_FIX_RATE
#256	constant PA_STREAM_FIX_CHANNELS
#512	constant PA_STREAM_DONT_MOVE
#1024	constant PA_STREAM_VARIABLE_RATE
#2048	constant PA_STREAM_PEAK_DETECT
#4096	constant PA_STREAM_START_MUTED
#8192	constant PA_STREAM_ADJUST_LATENCY
#16384	constant PA_STREAM_EARLY_REQUESTS
#32768	constant PA_STREAM_DONT_INHIBIT_AUTO_SUSPEND
#65536	constant PA_STREAM_START_UNMUTED
#131072	constant PA_STREAM_FAIL_ON_SUSPEND
#262144	constant PA_STREAM_RELATIVE_VOLUME
#524288	constant PA_STREAM_PASSTHROUGH
#0	constant PA_OK
#1	constant PA_ERR_ACCESS
#2	constant PA_ERR_COMMAND
#3	constant PA_ERR_INVALID
#4	constant PA_ERR_EXIST
#5	constant PA_ERR_NOENTITY
#6	constant PA_ERR_CONNECTIONREFUSED
#7	constant PA_ERR_PROTOCOL
#8	constant PA_ERR_TIMEOUT
#9	constant PA_ERR_AUTHKEY
#10	constant PA_ERR_INTERNAL
#11	constant PA_ERR_CONNECTIONTERMINATED
#12	constant PA_ERR_KILLED
#13	constant PA_ERR_INVALIDSERVER
#14	constant PA_ERR_MODINITFAILED
#15	constant PA_ERR_BADSTATE
#16	constant PA_ERR_NODATA
#17	constant PA_ERR_VERSION
#18	constant PA_ERR_TOOLARGE
#19	constant PA_ERR_NOTSUPPORTED
#20	constant PA_ERR_UNKNOWN
#21	constant PA_ERR_NOEXTENSION
#22	constant PA_ERR_OBSOLETE
#23	constant PA_ERR_NOTIMPLEMENTED
#24	constant PA_ERR_FORKED
#25	constant PA_ERR_IO
#26	constant PA_ERR_BUSY
#27	constant PA_ERR_MAX
#0	constant PA_SUBSCRIPTION_MASK_NULL
#1	constant PA_SUBSCRIPTION_MASK_SINK
#2	constant PA_SUBSCRIPTION_MASK_SOURCE
#4	constant PA_SUBSCRIPTION_MASK_SINK_INPUT
#8	constant PA_SUBSCRIPTION_MASK_SOURCE_OUTPUT
#16	constant PA_SUBSCRIPTION_MASK_MODULE
#32	constant PA_SUBSCRIPTION_MASK_CLIENT
#64	constant PA_SUBSCRIPTION_MASK_SAMPLE_CACHE
#128	constant PA_SUBSCRIPTION_MASK_SERVER
#256	constant PA_SUBSCRIPTION_MASK_AUTOLOAD
#512	constant PA_SUBSCRIPTION_MASK_CARD
#767	constant PA_SUBSCRIPTION_MASK_ALL
#0	constant PA_SUBSCRIPTION_EVENT_SINK
#1	constant PA_SUBSCRIPTION_EVENT_SOURCE
#2	constant PA_SUBSCRIPTION_EVENT_SINK_INPUT
#3	constant PA_SUBSCRIPTION_EVENT_SOURCE_OUTPUT
#4	constant PA_SUBSCRIPTION_EVENT_MODULE
#5	constant PA_SUBSCRIPTION_EVENT_CLIENT
#6	constant PA_SUBSCRIPTION_EVENT_SAMPLE_CACHE
#7	constant PA_SUBSCRIPTION_EVENT_SERVER
#8	constant PA_SUBSCRIPTION_EVENT_AUTOLOAD
#9	constant PA_SUBSCRIPTION_EVENT_CARD
#15	constant PA_SUBSCRIPTION_EVENT_FACILITY_MASK
#0	constant PA_SUBSCRIPTION_EVENT_NEW
#16	constant PA_SUBSCRIPTION_EVENT_CHANGE
#32	constant PA_SUBSCRIPTION_EVENT_REMOVE
#48	constant PA_SUBSCRIPTION_EVENT_TYPE_MASK
#0	constant PA_SEEK_RELATIVE
#1	constant PA_SEEK_ABSOLUTE
#2	constant PA_SEEK_RELATIVE_ON_READ
#3	constant PA_SEEK_RELATIVE_END
#0	constant PA_SINK_NOFLAGS
#1	constant PA_SINK_HW_VOLUME_CTRL
#2	constant PA_SINK_LATENCY
#4	constant PA_SINK_HARDWARE
#8	constant PA_SINK_NETWORK
#16	constant PA_SINK_HW_MUTE_CTRL
#32	constant PA_SINK_DECIBEL_VOLUME
#64	constant PA_SINK_FLAT_VOLUME
#128	constant PA_SINK_DYNAMIC_LATENCY
#256	constant PA_SINK_SET_FORMATS
#-1	constant PA_SINK_INVALID_STATE
#0	constant PA_SINK_RUNNING
#1	constant PA_SINK_IDLE
#2	constant PA_SINK_SUSPENDED
#-2	constant PA_SINK_INIT
#-3	constant PA_SINK_UNLINKED
#0	constant PA_SOURCE_NOFLAGS
#1	constant PA_SOURCE_HW_VOLUME_CTRL
#2	constant PA_SOURCE_LATENCY
#4	constant PA_SOURCE_HARDWARE
#8	constant PA_SOURCE_NETWORK
#16	constant PA_SOURCE_HW_MUTE_CTRL
#32	constant PA_SOURCE_DECIBEL_VOLUME
#64	constant PA_SOURCE_DYNAMIC_LATENCY
#128	constant PA_SOURCE_FLAT_VOLUME
#-1	constant PA_SOURCE_INVALID_STATE
#0	constant PA_SOURCE_RUNNING
#1	constant PA_SOURCE_IDLE
#2	constant PA_SOURCE_SUSPENDED
#-2	constant PA_SOURCE_INIT
#-3	constant PA_SOURCE_UNLINKED
#0	constant PA_PORT_AVAILABLE_UNKNOWN
#1	constant PA_PORT_AVAILABLE_NO
#2	constant PA_PORT_AVAILABLE_YES
#0	constant PA_DEVICE_PORT_TYPE_UNKNOWN
#1	constant PA_DEVICE_PORT_TYPE_AUX
#2	constant PA_DEVICE_PORT_TYPE_SPEAKER
#3	constant PA_DEVICE_PORT_TYPE_HEADPHONES
#4	constant PA_DEVICE_PORT_TYPE_LINE
#5	constant PA_DEVICE_PORT_TYPE_MIC
#6	constant PA_DEVICE_PORT_TYPE_HEADSET
#7	constant PA_DEVICE_PORT_TYPE_HANDSET
#8	constant PA_DEVICE_PORT_TYPE_EARPIECE
#9	constant PA_DEVICE_PORT_TYPE_SPDIF
#10	constant PA_DEVICE_PORT_TYPE_HDMI
#11	constant PA_DEVICE_PORT_TYPE_TV
#12	constant PA_DEVICE_PORT_TYPE_RADIO
#13	constant PA_DEVICE_PORT_TYPE_VIDEO
#14	constant PA_DEVICE_PORT_TYPE_USB
#15	constant PA_DEVICE_PORT_TYPE_BLUETOOTH
#16	constant PA_DEVICE_PORT_TYPE_PORTABLE
#17	constant PA_DEVICE_PORT_TYPE_HANDSFREE
#18	constant PA_DEVICE_PORT_TYPE_CAR
#19	constant PA_DEVICE_PORT_TYPE_HIFI
#20	constant PA_DEVICE_PORT_TYPE_PHONE
#21	constant PA_DEVICE_PORT_TYPE_NETWORK
#22	constant PA_DEVICE_PORT_TYPE_ANALOG
#0	constant PA_AUTOLOAD_SINK
#1	constant PA_AUTOLOAD_SOURCE
#-1	constant PA_CHANNEL_POSITION_INVALID
#0	constant PA_CHANNEL_POSITION_MONO
#1	constant PA_CHANNEL_POSITION_FRONT_LEFT
#2	constant PA_CHANNEL_POSITION_FRONT_RIGHT
#3	constant PA_CHANNEL_POSITION_FRONT_CENTER
#1	constant PA_CHANNEL_POSITION_LEFT
#2	constant PA_CHANNEL_POSITION_RIGHT
#3	constant PA_CHANNEL_POSITION_CENTER
#4	constant PA_CHANNEL_POSITION_REAR_CENTER
#5	constant PA_CHANNEL_POSITION_REAR_LEFT
#6	constant PA_CHANNEL_POSITION_REAR_RIGHT
#7	constant PA_CHANNEL_POSITION_LFE
#7	constant PA_CHANNEL_POSITION_SUBWOOFER
#8	constant PA_CHANNEL_POSITION_FRONT_LEFT_OF_CENTER
#9	constant PA_CHANNEL_POSITION_FRONT_RIGHT_OF_CENTER
#10	constant PA_CHANNEL_POSITION_SIDE_LEFT
#11	constant PA_CHANNEL_POSITION_SIDE_RIGHT
#12	constant PA_CHANNEL_POSITION_AUX0
#13	constant PA_CHANNEL_POSITION_AUX1
#14	constant PA_CHANNEL_POSITION_AUX2
#15	constant PA_CHANNEL_POSITION_AUX3
#16	constant PA_CHANNEL_POSITION_AUX4
#17	constant PA_CHANNEL_POSITION_AUX5
#18	constant PA_CHANNEL_POSITION_AUX6
#19	constant PA_CHANNEL_POSITION_AUX7
#20	constant PA_CHANNEL_POSITION_AUX8
#21	constant PA_CHANNEL_POSITION_AUX9
#22	constant PA_CHANNEL_POSITION_AUX10
#23	constant PA_CHANNEL_POSITION_AUX11
#24	constant PA_CHANNEL_POSITION_AUX12
#25	constant PA_CHANNEL_POSITION_AUX13
#26	constant PA_CHANNEL_POSITION_AUX14
#27	constant PA_CHANNEL_POSITION_AUX15
#28	constant PA_CHANNEL_POSITION_AUX16
#29	constant PA_CHANNEL_POSITION_AUX17
#30	constant PA_CHANNEL_POSITION_AUX18
#31	constant PA_CHANNEL_POSITION_AUX19
#32	constant PA_CHANNEL_POSITION_AUX20
#33	constant PA_CHANNEL_POSITION_AUX21
#34	constant PA_CHANNEL_POSITION_AUX22
#35	constant PA_CHANNEL_POSITION_AUX23
#36	constant PA_CHANNEL_POSITION_AUX24
#37	constant PA_CHANNEL_POSITION_AUX25
#38	constant PA_CHANNEL_POSITION_AUX26
#39	constant PA_CHANNEL_POSITION_AUX27
#40	constant PA_CHANNEL_POSITION_AUX28
#41	constant PA_CHANNEL_POSITION_AUX29
#42	constant PA_CHANNEL_POSITION_AUX30
#43	constant PA_CHANNEL_POSITION_AUX31
#44	constant PA_CHANNEL_POSITION_TOP_CENTER
#45	constant PA_CHANNEL_POSITION_TOP_FRONT_LEFT
#46	constant PA_CHANNEL_POSITION_TOP_FRONT_RIGHT
#47	constant PA_CHANNEL_POSITION_TOP_FRONT_CENTER
#48	constant PA_CHANNEL_POSITION_TOP_REAR_LEFT
#49	constant PA_CHANNEL_POSITION_TOP_REAR_RIGHT
#50	constant PA_CHANNEL_POSITION_TOP_REAR_CENTER
#51	constant PA_CHANNEL_POSITION_MAX
#0	constant PA_CHANNEL_MAP_AIFF
#1	constant PA_CHANNEL_MAP_ALSA
#2	constant PA_CHANNEL_MAP_AUX
#3	constant PA_CHANNEL_MAP_WAVEEX
#4	constant PA_CHANNEL_MAP_OSS
#5	constant PA_CHANNEL_MAP_DEF_MAX
#0	constant PA_CHANNEL_MAP_DEFAULT
#0	constant PA_UPDATE_SET
#1	constant PA_UPDATE_MERGE
#2	constant PA_UPDATE_REPLACE

\ -------===< structs >===--------
\ pa_mainloop_api
begin-structure pa_mainloop_api
	drop 24 8 +field pa_mainloop_api-io_free
	drop 48 8 +field pa_mainloop_api-time_restart
	drop 88 8 +field pa_mainloop_api-defer_free
	drop 8 8 +field pa_mainloop_api-io_new
	drop 0 8 +field pa_mainloop_api-userdata
	drop 80 8 +field pa_mainloop_api-defer_enable
	drop 16 8 +field pa_mainloop_api-io_enable
	drop 104 8 +field pa_mainloop_api-quit
	drop 96 8 +field pa_mainloop_api-defer_set_destroy
	drop 64 8 +field pa_mainloop_api-time_set_destroy
	drop 40 8 +field pa_mainloop_api-time_new
	drop 32 8 +field pa_mainloop_api-io_set_destroy
	drop 56 8 +field pa_mainloop_api-time_free
	drop 72 8 +field pa_mainloop_api-defer_new
drop 112 end-structure
\ pa_sample_spec
begin-structure pa_sample_spec
	drop 8 1 +field pa_sample_spec-channels
	drop 0 4 +field pa_sample_spec-format
	drop 4 4 +field pa_sample_spec-rate
drop 12 end-structure
\ pa_format_info
begin-structure pa_format_info
	drop 0 4 +field pa_format_info-encoding
	drop 8 8 +field pa_format_info-plist
drop 16 end-structure
\ pa_buffer_attr
begin-structure pa_buffer_attr
	drop 12 4 +field pa_buffer_attr-minreq
	drop 0 4 +field pa_buffer_attr-maxlength
	drop 4 4 +field pa_buffer_attr-tlength
	drop 8 4 +field pa_buffer_attr-prebuf
	drop 16 4 +field pa_buffer_attr-fragsize
drop 20 end-structure
\ pa_timing_info
begin-structure pa_timing_info
	drop 24 8 +field pa_timing_info-sink_usec
	drop 72 8 +field pa_timing_info-read_index
	drop 80 8 +field pa_timing_info-configured_sink_usec
	drop 32 8 +field pa_timing_info-source_usec
	drop 88 8 +field pa_timing_info-configured_source_usec
	drop 16 4 +field pa_timing_info-synchronized_clocks
	drop 96 8 +field pa_timing_info-since_underrun
	drop 40 8 +field pa_timing_info-transport_usec
	drop 0 16 +field pa_timing_info-timestamp
	drop 52 4 +field pa_timing_info-write_index_corrupt
	drop 64 4 +field pa_timing_info-read_index_corrupt
	drop 48 4 +field pa_timing_info-playing
	drop 56 8 +field pa_timing_info-write_index
drop 104 end-structure
\ pa_spawn_api
begin-structure pa_spawn_api
	drop 8 8 +field pa_spawn_api-postfork
	drop 16 8 +field pa_spawn_api-atfork
	drop 0 8 +field pa_spawn_api-prefork
drop 24 end-structure
\ pa_sink_port_info
begin-structure pa_sink_port_info
	drop 16 4 +field pa_sink_port_info-priority
	drop 0 8 +field pa_sink_port_info-name
	drop 20 4 +field pa_sink_port_info-available
	drop 8 8 +field pa_sink_port_info-description
	drop 24 8 +field pa_sink_port_info-availability_group
	drop 32 4 +field pa_sink_port_info-type
drop 40 end-structure
\ pa_sink_info
begin-structure pa_sink_info
	drop 36 132 +field pa_sink_info-channel_map
	drop 344 8 +field pa_sink_info-proplist
	drop 384 8 +field pa_sink_info-ports
	drop 312 8 +field pa_sink_info-monitor_source_name
	drop 0 8 +field pa_sink_info-name
	drop 400 1 +field pa_sink_info-n_formats
	drop 408 8 +field pa_sink_info-formats
	drop 304 4 +field pa_sink_info-mute
	drop 392 8 +field pa_sink_info-active_port
	drop 336 4 +field pa_sink_info-flags
	drop 172 132 +field pa_sink_info-volume
	drop 328 8 +field pa_sink_info-driver
	drop 168 4 +field pa_sink_info-owner_module
	drop 372 4 +field pa_sink_info-card
	drop 16 8 +field pa_sink_info-description
	drop 308 4 +field pa_sink_info-monitor_source
	drop 8 4 +field pa_sink_info-index
	drop 364 4 +field pa_sink_info-state
	drop 376 4 +field pa_sink_info-n_ports
	drop 320 8 +field pa_sink_info-latency
	drop 352 8 +field pa_sink_info-configured_latency
	drop 360 4 +field pa_sink_info-base_volume
	drop 368 4 +field pa_sink_info-n_volume_steps
	drop 24 12 +field pa_sink_info-sample_spec
drop 416 end-structure
\ pa_source_port_info
begin-structure pa_source_port_info
	drop 16 4 +field pa_source_port_info-priority
	drop 0 8 +field pa_source_port_info-name
	drop 20 4 +field pa_source_port_info-available
	drop 8 8 +field pa_source_port_info-description
	drop 24 8 +field pa_source_port_info-availability_group
	drop 32 4 +field pa_source_port_info-type
drop 40 end-structure
\ pa_source_info
begin-structure pa_source_info
	drop 308 4 +field pa_source_info-monitor_of_sink
	drop 36 132 +field pa_source_info-channel_map
	drop 344 8 +field pa_source_info-proplist
	drop 384 8 +field pa_source_info-ports
	drop 0 8 +field pa_source_info-name
	drop 400 1 +field pa_source_info-n_formats
	drop 408 8 +field pa_source_info-formats
	drop 304 4 +field pa_source_info-mute
	drop 392 8 +field pa_source_info-active_port
	drop 336 4 +field pa_source_info-flags
	drop 312 8 +field pa_source_info-monitor_of_sink_name
	drop 172 132 +field pa_source_info-volume
	drop 328 8 +field pa_source_info-driver
	drop 168 4 +field pa_source_info-owner_module
	drop 372 4 +field pa_source_info-card
	drop 16 8 +field pa_source_info-description
	drop 8 4 +field pa_source_info-index
	drop 364 4 +field pa_source_info-state
	drop 376 4 +field pa_source_info-n_ports
	drop 320 8 +field pa_source_info-latency
	drop 352 8 +field pa_source_info-configured_latency
	drop 360 4 +field pa_source_info-base_volume
	drop 368 4 +field pa_source_info-n_volume_steps
	drop 24 12 +field pa_source_info-sample_spec
drop 416 end-structure
\ pa_server_info
begin-structure pa_server_info
	drop 8 8 +field pa_server_info-host_name
	drop 32 12 +field pa_server_info-sample_spec
	drop 16 8 +field pa_server_info-server_version
	drop 64 4 +field pa_server_info-cookie
	drop 68 132 +field pa_server_info-channel_map
	drop 0 8 +field pa_server_info-user_name
	drop 24 8 +field pa_server_info-server_name
	drop 48 8 +field pa_server_info-default_sink_name
	drop 56 8 +field pa_server_info-default_source_name
drop 200 end-structure
\ pa_module_info
begin-structure pa_module_info
	drop 24 4 +field pa_module_info-n_used
	drop 0 4 +field pa_module_info-index
	drop 8 8 +field pa_module_info-name
	drop 32 8 +field pa_module_info-proplist
	drop 28 4 +field pa_module_info-auto_unload
	drop 16 8 +field pa_module_info-argument
drop 40 end-structure
\ pa_client_info
begin-structure pa_client_info
	drop 16 4 +field pa_client_info-owner_module
	drop 0 4 +field pa_client_info-index
	drop 8 8 +field pa_client_info-name
	drop 24 8 +field pa_client_info-driver
	drop 32 8 +field pa_client_info-proplist
drop 40 end-structure
\ pa_card_profile_info
begin-structure pa_card_profile_info
	drop 24 4 +field pa_card_profile_info-priority
	drop 0 8 +field pa_card_profile_info-name
	drop 8 8 +field pa_card_profile_info-description
	drop 16 4 +field pa_card_profile_info-n_sinks
	drop 20 4 +field pa_card_profile_info-n_sources
drop 32 end-structure
\ pa_card_profile_info2
begin-structure pa_card_profile_info2
	drop 24 4 +field pa_card_profile_info2-priority
	drop 0 8 +field pa_card_profile_info2-name
	drop 28 4 +field pa_card_profile_info2-available
	drop 8 8 +field pa_card_profile_info2-description
	drop 16 4 +field pa_card_profile_info2-n_sinks
	drop 20 4 +field pa_card_profile_info2-n_sources
drop 32 end-structure
\ pa_card_port_info
begin-structure pa_card_port_info
	drop 16 4 +field pa_card_port_info-priority
	drop 0 8 +field pa_card_port_info-name
	drop 40 8 +field pa_card_port_info-proplist
	drop 20 4 +field pa_card_port_info-available
	drop 48 8 +field pa_card_port_info-latency_offset
	drop 8 8 +field pa_card_port_info-description
	drop 64 8 +field pa_card_port_info-availability_group
	drop 72 4 +field pa_card_port_info-type
	drop 28 4 +field pa_card_port_info-n_profiles
	drop 32 8 +field pa_card_port_info-profiles
	drop 24 4 +field pa_card_port_info-direction
	drop 56 8 +field pa_card_port_info-profiles2
drop 80 end-structure
\ pa_card_info
begin-structure pa_card_info
	drop 16 4 +field pa_card_info-owner_module
	drop 64 4 +field pa_card_info-n_ports
	drop 0 4 +field pa_card_info-index
	drop 8 8 +field pa_card_info-name
	drop 24 8 +field pa_card_info-driver
	drop 56 8 +field pa_card_info-proplist
	drop 72 8 +field pa_card_info-ports
	drop 48 8 +field pa_card_info-active_profile
	drop 88 8 +field pa_card_info-active_profile2
	drop 32 4 +field pa_card_info-n_profiles
	drop 40 8 +field pa_card_info-profiles
	drop 80 8 +field pa_card_info-profiles2
drop 96 end-structure
\ pa_sink_input_info
begin-structure pa_sink_input_info
	drop 20 4 +field pa_sink_input_info-client
	drop 40 132 +field pa_sink_input_info-channel_map
	drop 344 8 +field pa_sink_input_info-proplist
	drop 352 4 +field pa_sink_input_info-corked
	drop 8 8 +field pa_sink_input_info-name
	drop 320 8 +field pa_sink_input_info-resample_method
	drop 368 8 +field pa_sink_input_info-format
	drop 312 8 +field pa_sink_input_info-sink_usec
	drop 304 8 +field pa_sink_input_info-buffer_usec
	drop 336 4 +field pa_sink_input_info-mute
	drop 172 132 +field pa_sink_input_info-volume
	drop 360 4 +field pa_sink_input_info-volume_writable
	drop 328 8 +field pa_sink_input_info-driver
	drop 16 4 +field pa_sink_input_info-owner_module
	drop 0 4 +field pa_sink_input_info-index
	drop 356 4 +field pa_sink_input_info-has_volume
	drop 24 4 +field pa_sink_input_info-sink
	drop 28 12 +field pa_sink_input_info-sample_spec
drop 376 end-structure
\ pa_source_output_info
begin-structure pa_source_output_info
	drop 20 4 +field pa_source_output_info-client
	drop 40 132 +field pa_source_output_info-channel_map
	drop 216 4 +field pa_source_output_info-corked
	drop 208 8 +field pa_source_output_info-proplist
	drop 8 8 +field pa_source_output_info-name
	drop 192 8 +field pa_source_output_info-resample_method
	drop 368 8 +field pa_source_output_info-format
	drop 176 8 +field pa_source_output_info-buffer_usec
	drop 24 4 +field pa_source_output_info-source
	drop 352 4 +field pa_source_output_info-mute
	drop 220 132 +field pa_source_output_info-volume
	drop 360 4 +field pa_source_output_info-volume_writable
	drop 200 8 +field pa_source_output_info-driver
	drop 16 4 +field pa_source_output_info-owner_module
	drop 0 4 +field pa_source_output_info-index
	drop 356 4 +field pa_source_output_info-has_volume
	drop 184 8 +field pa_source_output_info-source_usec
	drop 28 12 +field pa_source_output_info-sample_spec
drop 376 end-structure
\ pa_stat_info
begin-structure pa_stat_info
	drop 8 4 +field pa_stat_info-memblock_allocated
	drop 12 4 +field pa_stat_info-memblock_allocated_size
	drop 4 4 +field pa_stat_info-memblock_total_size
	drop 16 4 +field pa_stat_info-scache_size
	drop 0 4 +field pa_stat_info-memblock_total
drop 20 end-structure
\ pa_sample_info
begin-structure pa_sample_info
	drop 0 4 +field pa_sample_info-index
	drop 8 8 +field pa_sample_info-name
	drop 148 12 +field pa_sample_info-sample_spec
	drop 308 4 +field pa_sample_info-lazy
	drop 320 8 +field pa_sample_info-proplist
	drop 296 8 +field pa_sample_info-duration
	drop 312 8 +field pa_sample_info-filename
	drop 16 132 +field pa_sample_info-volume
	drop 160 132 +field pa_sample_info-channel_map
	drop 304 4 +field pa_sample_info-bytes
drop 328 end-structure
\ pa_autoload_info
begin-structure pa_autoload_info
	drop 0 4 +field pa_autoload_info-index
	drop 8 8 +field pa_autoload_info-name
	drop 24 8 +field pa_autoload_info-module
	drop 16 4 +field pa_autoload_info-type
	drop 32 8 +field pa_autoload_info-argument
drop 40 end-structure
\ pa_channel_map
begin-structure pa_channel_map
	drop 0 1 +field pa_channel_map-channels
	drop 4 128 +field pa_channel_map-map
drop 132 end-structure
\ pa_cvolume
begin-structure pa_cvolume
	drop 0 1 +field pa_cvolume-channels
	drop 4 128 +field pa_cvolume-values
drop 132 end-structure

\ --===< function pointers >===---
c-funptr pa_mainloop_api-io_new() {((struct pa_mainloop_api*)ptr)->io_new} a n n a a -- a	( a fd events cb userdata -- )
c-funptr pa_mainloop_api-io_enable() {((struct pa_mainloop_api*)ptr)->io_enable} a n -- void	( e events -- )
c-funptr pa_mainloop_api-io_free() {((struct pa_mainloop_api*)ptr)->io_free} a -- void	( e -- )
c-funptr pa_mainloop_api-io_set_destroy() {((struct pa_mainloop_api*)ptr)->io_set_destroy} a a -- void	( e cb -- )
c-funptr pa_mainloop_api-time_new() {((struct pa_mainloop_api*)ptr)->time_new} a a a a -- a	( a tv cb userdata -- )
c-funptr pa_mainloop_api-time_restart() {((struct pa_mainloop_api*)ptr)->time_restart} a a -- void	( e tv -- )
c-funptr pa_mainloop_api-time_free() {((struct pa_mainloop_api*)ptr)->time_free} a -- void	( e -- )
c-funptr pa_mainloop_api-time_set_destroy() {((struct pa_mainloop_api*)ptr)->time_set_destroy} a a -- void	( e cb -- )
c-funptr pa_mainloop_api-defer_new() {((struct pa_mainloop_api*)ptr)->defer_new} a a a -- a	( a cb userdata -- )
c-funptr pa_mainloop_api-defer_enable() {((struct pa_mainloop_api*)ptr)->defer_enable} a n -- void	( e b -- )
c-funptr pa_mainloop_api-defer_free() {((struct pa_mainloop_api*)ptr)->defer_free} a -- void	( e -- )
c-funptr pa_mainloop_api-defer_set_destroy() {((struct pa_mainloop_api*)ptr)->defer_set_destroy} a a -- void	( e cb -- )
c-funptr pa_mainloop_api-quit() {((struct pa_mainloop_api*)ptr)->quit} a n -- void	( a retval -- )
c-funptr pa_spawn_api-prefork() {((struct pa_spawn_api*)ptr)->prefork}  -- void	( <noname> -- )
c-funptr pa_spawn_api-postfork() {((struct pa_spawn_api*)ptr)->postfork}  -- void	( <noname> -- )
c-funptr pa_spawn_api-atfork() {((struct pa_spawn_api*)ptr)->atfork}  -- void	( <noname> -- )

\ ------===< callbacks >===-------
c-callback pa_io_event_cb_t: a a n n a -- void	( ea e fd events userdata -- )
c-callback pa_io_event_destroy_cb_t: a a a -- void	( a e userdata -- )
c-callback pa_time_event_cb_t: a a a a -- void	( a e tv userdata -- )
c-callback pa_time_event_destroy_cb_t: a a a -- void	( a e userdata -- )
c-callback pa_defer_event_cb_t: a a a -- void	( a e userdata -- )
c-callback pa_defer_event_destroy_cb_t: a a a -- void	( a e userdata -- )
c-callback pa_free_cb_t: a -- void	( p -- )
c-callback pa_context_notify_cb_t: a a -- void	( c userdata -- )
c-callback pa_context_success_cb_t: a n a -- void	( c success userdata -- )
c-callback pa_context_event_cb_t: a s a a -- void	( c name p userdata -- )
c-callback pa_stream_success_cb_t: a n a -- void	( s success userdata -- )
c-callback pa_stream_request_cb_t: a n a -- void	( p nbytes userdata -- )
c-callback pa_stream_notify_cb_t: a a -- void	( p userdata -- )
c-callback pa_stream_event_cb_t: a s a a -- void	( p name pl userdata -- )
c-callback pa_sink_info_cb_t: a a n a -- void	( c i eol userdata -- )
c-callback pa_source_info_cb_t: a a n a -- void	( c i eol userdata -- )
c-callback pa_server_info_cb_t: a a a -- void	( c i userdata -- )
c-callback pa_module_info_cb_t: a a n a -- void	( c i eol userdata -- )
c-callback pa_context_index_cb_t: a n a -- void	( c idx userdata -- )
c-callback pa_context_string_cb_t: a n a a -- void	( c success response userdata -- )
c-callback pa_client_info_cb_t: a a n a -- void	( c i eol userdata -- )
c-callback pa_card_info_cb_t: a a n a -- void	( c i eol userdata -- )
c-callback pa_sink_input_info_cb_t: a a n a -- void	( c i eol userdata -- )
c-callback pa_source_output_info_cb_t: a a n a -- void	( c i eol userdata -- )
c-callback pa_stat_info_cb_t: a a a -- void	( c i userdata -- )
c-callback pa_sample_info_cb_t: a a n a -- void	( c i eol userdata -- )
c-callback pa_autoload_info_cb_t: a a n a -- void	( c i eol userdata -- )
c-callback pa_context_subscribe_cb_t: a n n a -- void	( c t idx userdata -- )
c-callback pa_context_play_sample_cb_t: a n a -- void	( c idx userdata -- )
c-callback pa_operation_notify_cb_t: a a -- void	( o userdata -- )
c-callback pa_poll_func: a u n a -- n	( ufds nfds timeout userdata -- )
c-callback pa_signal_cb_t: a a n a -- void	( api e sig userdata -- )
c-callback pa_signal_destroy_cb_t: a a a -- void	( api e userdata -- )

\ ------===< functions >===-------
c-function pa_direction_valid pa_direction_valid n -- n	( direction -- )
c-function pa_direction_to_string pa_direction_to_string n -- s	( direction -- )
c-function pa_mainloop_api_once pa_mainloop_api_once a a a -- void	( m callback userdata -- )
c-function pa_bytes_per_second pa_bytes_per_second a -- n	( spec -- )
c-function pa_frame_size pa_frame_size a -- n	( spec -- )
c-function pa_sample_size pa_sample_size a -- n	( spec -- )
c-function pa_sample_size_of_format pa_sample_size_of_format n -- n	( f -- )
c-function pa_bytes_to_usec pa_bytes_to_usec n a -- n	( length spec -- )
c-function pa_usec_to_bytes pa_usec_to_bytes n a -- n	( t spec -- )
c-function pa_sample_spec_init pa_sample_spec_init a -- a	( spec -- )
c-function pa_sample_format_valid pa_sample_format_valid u -- n	( format -- )
c-function pa_sample_rate_valid pa_sample_rate_valid n -- n	( rate -- )
c-function pa_channels_valid pa_channels_valid n -- n	( channels -- )
c-function pa_sample_spec_valid pa_sample_spec_valid a -- n	( spec -- )
c-function pa_sample_spec_equal pa_sample_spec_equal a a -- n	( a b -- )
c-function pa_sample_format_to_string pa_sample_format_to_string n -- s	( f -- )
c-function pa_parse_sample_format pa_parse_sample_format s -- n	( format -- )
c-function pa_sample_spec_snprint pa_sample_spec_snprint a n a -- a	( s l spec -- )
c-function pa_bytes_snprint pa_bytes_snprint a n u -- a	( s l v -- )
c-function pa_sample_format_is_le pa_sample_format_is_le n -- n	( f -- )
c-function pa_sample_format_is_be pa_sample_format_is_be n -- n	( f -- )
c-function pa_encoding_to_string pa_encoding_to_string n -- s	( e -- )
c-function pa_encoding_from_string pa_encoding_from_string s -- n	( encoding -- )
c-function pa_format_info_new pa_format_info_new  -- a	( -- )
c-function pa_format_info_copy pa_format_info_copy a -- a	( src -- )
c-function pa_format_info_free pa_format_info_free a -- void	( f -- )
c-function pa_format_info_valid pa_format_info_valid a -- n	( f -- )
c-function pa_format_info_is_pcm pa_format_info_is_pcm a -- n	( f -- )
c-function pa_format_info_is_compatible pa_format_info_is_compatible a a -- n	( first second -- )
c-function pa_format_info_snprint pa_format_info_snprint a n a -- a	( s l f -- )
c-function pa_format_info_from_string pa_format_info_from_string s -- a	( str -- )
c-function pa_format_info_from_sample_spec pa_format_info_from_sample_spec a a -- a	( ss map -- )
c-function pa_format_info_to_sample_spec pa_format_info_to_sample_spec a a a -- n	( f ss map -- )
c-function pa_format_info_get_prop_type pa_format_info_get_prop_type a s -- n	( f key -- )
c-function pa_format_info_get_prop_int pa_format_info_get_prop_int a s a -- n	( f key v -- )
c-function pa_format_info_get_prop_int_range pa_format_info_get_prop_int_range a s a a -- n	( f key min max -- )
c-function pa_format_info_get_prop_int_array pa_format_info_get_prop_int_array a s a a -- n	( f key values n_values -- )
c-function pa_format_info_get_prop_string pa_format_info_get_prop_string a s a -- n	( f key v -- )
c-function pa_format_info_get_prop_string_array pa_format_info_get_prop_string_array a s a a -- n	( f key values n_values -- )
c-function pa_format_info_free_string_array pa_format_info_free_string_array a n -- void	( values n_values -- )
c-function pa_format_info_get_sample_format pa_format_info_get_sample_format a a -- n	( f sf -- )
c-function pa_format_info_get_rate pa_format_info_get_rate a a -- n	( f rate -- )
c-function pa_format_info_get_channels pa_format_info_get_channels a a -- n	( f channels -- )
c-function pa_format_info_get_channel_map pa_format_info_get_channel_map a a -- n	( f map -- )
c-function pa_format_info_set_prop_int pa_format_info_set_prop_int a s n -- void	( f key value -- )
c-function pa_format_info_set_prop_int_array pa_format_info_set_prop_int_array a s a n -- void	( f key values n_values -- )
c-function pa_format_info_set_prop_int_range pa_format_info_set_prop_int_range a s n n -- void	( f key min max -- )
c-function pa_format_info_set_prop_string pa_format_info_set_prop_string a s s -- void	( f key value -- )
c-function pa_format_info_set_prop_string_array pa_format_info_set_prop_string_array a s a n -- void	( f key values n_values -- )
c-function pa_format_info_set_sample_format pa_format_info_set_sample_format a n -- void	( f sf -- )
c-function pa_format_info_set_rate pa_format_info_set_rate a n -- void	( f rate -- )
c-function pa_format_info_set_channels pa_format_info_set_channels a n -- void	( f channels -- )
c-function pa_format_info_set_channel_map pa_format_info_set_channel_map a a -- void	( f map -- )
c-function PA_CONTEXT_IS_GOOD PA_CONTEXT_IS_GOOD n -- n	( x -- )
c-function PA_STREAM_IS_GOOD PA_STREAM_IS_GOOD n -- n	( x -- )
c-function PA_SINK_IS_OPENED PA_SINK_IS_OPENED n -- n	( x -- )
c-function PA_SINK_IS_RUNNING PA_SINK_IS_RUNNING n -- n	( x -- )
c-function PA_SOURCE_IS_OPENED PA_SOURCE_IS_OPENED n -- n	( x -- )
c-function PA_SOURCE_IS_RUNNING PA_SOURCE_IS_RUNNING n -- n	( x -- )
c-function pa_context_new pa_context_new a s -- a	( mainloop name -- )
c-function pa_context_new_with_proplist pa_context_new_with_proplist a s a -- a	( mainloop name proplist -- )
c-function pa_context_unref pa_context_unref a -- void	( c -- )
c-function pa_context_ref pa_context_ref a -- a	( c -- )
c-function pa_context_set_state_callback pa_context_set_state_callback a a a -- void	( c cb userdata -- )
c-function pa_context_set_event_callback pa_context_set_event_callback a a a -- void	( p cb userdata -- )
c-function pa_context_errno pa_context_errno a -- n	( c -- )
c-function pa_context_is_pending pa_context_is_pending a -- n	( c -- )
c-function pa_context_get_state pa_context_get_state a -- n	( c -- )
c-function pa_context_connect pa_context_connect a s n a -- n	( c server flags api -- )
c-function pa_context_disconnect pa_context_disconnect a -- void	( c -- )
c-function pa_context_drain pa_context_drain a a a -- a	( c cb userdata -- )
c-function pa_context_exit_daemon pa_context_exit_daemon a a a -- a	( c cb userdata -- )
c-function pa_context_set_default_sink pa_context_set_default_sink a s a a -- a	( c name cb userdata -- )
c-function pa_context_set_default_source pa_context_set_default_source a s a a -- a	( c name cb userdata -- )
c-function pa_context_is_local pa_context_is_local a -- n	( c -- )
c-function pa_context_set_name pa_context_set_name a s a a -- a	( c name cb userdata -- )
c-function pa_context_get_server pa_context_get_server a -- s	( c -- )
c-function pa_context_get_protocol_version pa_context_get_protocol_version a -- n	( c -- )
c-function pa_context_get_server_protocol_version pa_context_get_server_protocol_version a -- n	( c -- )
c-function pa_context_proplist_update pa_context_proplist_update a n a a a -- a	( c mode p cb userdata -- )
c-function pa_context_proplist_remove pa_context_proplist_remove a a a a -- a	( c keys cb userdata -- )
c-function pa_context_get_index pa_context_get_index a -- n	( s -- )
c-function pa_context_rttime_new pa_context_rttime_new a n a a -- a	( c usec cb userdata -- )
c-function pa_context_rttime_restart pa_context_rttime_restart a a n -- void	( c e usec -- )
c-function pa_context_get_tile_size pa_context_get_tile_size a a -- n	( c ss -- )
c-function pa_context_load_cookie_from_file pa_context_load_cookie_from_file a s -- n	( c cookie_file_path -- )
c-function pa_stream_new pa_stream_new a s a a -- a	( c name ss map -- )
c-function pa_stream_new_with_proplist pa_stream_new_with_proplist a s a a a -- a	( c name ss map p -- )
c-function pa_stream_new_extended pa_stream_new_extended a s a u a -- a	( c name formats n_formats p -- )
c-function pa_stream_unref pa_stream_unref a -- void	( s -- )
c-function pa_stream_ref pa_stream_ref a -- a	( s -- )
c-function pa_stream_get_state pa_stream_get_state a -- n	( p -- )
c-function pa_stream_get_context pa_stream_get_context a -- a	( p -- )
c-function pa_stream_get_index pa_stream_get_index a -- n	( s -- )
c-function pa_stream_get_device_index pa_stream_get_device_index a -- n	( s -- )
c-function pa_stream_get_device_name pa_stream_get_device_name a -- s	( s -- )
c-function pa_stream_is_suspended pa_stream_is_suspended a -- n	( s -- )
c-function pa_stream_is_corked pa_stream_is_corked a -- n	( s -- )
c-function pa_stream_connect_playback pa_stream_connect_playback a s a n a a -- n	( s dev attr flags volume sync_stream -- )
c-function pa_stream_connect_record pa_stream_connect_record a s a n -- n	( s dev attr flags -- )
c-function pa_stream_disconnect pa_stream_disconnect a -- n	( s -- )
c-function pa_stream_begin_write pa_stream_begin_write a a a -- n	( p data nbytes -- )
c-function pa_stream_cancel_write pa_stream_cancel_write a -- n	( p -- )
c-function pa_stream_write pa_stream_write a a n a d n -- n	( p data nbytes free_cb offset seek -- )
c-function pa_stream_write_ext_free pa_stream_write_ext_free a a n a a d n -- n	( p data nbytes free_cb free_cb_data offset seek -- )
c-function pa_stream_peek pa_stream_peek a a a -- n	( p data nbytes -- )
c-function pa_stream_drop pa_stream_drop a -- n	( p -- )
c-function pa_stream_writable_size pa_stream_writable_size a -- n	( p -- )
c-function pa_stream_readable_size pa_stream_readable_size a -- n	( p -- )
c-function pa_stream_drain pa_stream_drain a a a -- a	( s cb userdata -- )
c-function pa_stream_update_timing_info pa_stream_update_timing_info a a a -- a	( p cb userdata -- )
c-function pa_stream_set_state_callback pa_stream_set_state_callback a a a -- void	( s cb userdata -- )
c-function pa_stream_set_write_callback pa_stream_set_write_callback a a a -- void	( p cb userdata -- )
c-function pa_stream_set_read_callback pa_stream_set_read_callback a a a -- void	( p cb userdata -- )
c-function pa_stream_set_overflow_callback pa_stream_set_overflow_callback a a a -- void	( p cb userdata -- )
c-function pa_stream_get_underflow_index pa_stream_get_underflow_index a -- d	( p -- )
c-function pa_stream_set_underflow_callback pa_stream_set_underflow_callback a a a -- void	( p cb userdata -- )
c-function pa_stream_set_started_callback pa_stream_set_started_callback a a a -- void	( p cb userdata -- )
c-function pa_stream_set_latency_update_callback pa_stream_set_latency_update_callback a a a -- void	( p cb userdata -- )
c-function pa_stream_set_moved_callback pa_stream_set_moved_callback a a a -- void	( p cb userdata -- )
c-function pa_stream_set_suspended_callback pa_stream_set_suspended_callback a a a -- void	( p cb userdata -- )
c-function pa_stream_set_event_callback pa_stream_set_event_callback a a a -- void	( p cb userdata -- )
c-function pa_stream_set_buffer_attr_callback pa_stream_set_buffer_attr_callback a a a -- void	( p cb userdata -- )
c-function pa_stream_cork pa_stream_cork a n a a -- a	( s b cb userdata -- )
c-function pa_stream_flush pa_stream_flush a a a -- a	( s cb userdata -- )
c-function pa_stream_prebuf pa_stream_prebuf a a a -- a	( s cb userdata -- )
c-function pa_stream_trigger pa_stream_trigger a a a -- a	( s cb userdata -- )
c-function pa_stream_set_name pa_stream_set_name a s a a -- a	( s name cb userdata -- )
c-function pa_stream_get_time pa_stream_get_time a a -- n	( s r_usec -- )
c-function pa_stream_get_latency pa_stream_get_latency a a a -- n	( s r_usec negative -- )
c-function pa_stream_get_timing_info pa_stream_get_timing_info a -- a	( s -- )
c-function pa_stream_get_sample_spec pa_stream_get_sample_spec a -- a	( s -- )
c-function pa_stream_get_channel_map pa_stream_get_channel_map a -- a	( s -- )
c-function pa_stream_get_format_info pa_stream_get_format_info a -- a	( s -- )
c-function pa_stream_get_buffer_attr pa_stream_get_buffer_attr a -- a	( s -- )
c-function pa_stream_set_buffer_attr pa_stream_set_buffer_attr a a a a -- a	( s attr cb userdata -- )
c-function pa_stream_update_sample_rate pa_stream_update_sample_rate a n a a -- a	( s rate cb userdata -- )
c-function pa_stream_proplist_update pa_stream_proplist_update a n a a a -- a	( s mode p cb userdata -- )
c-function pa_stream_proplist_remove pa_stream_proplist_remove a a a a -- a	( s keys cb userdata -- )
c-function pa_stream_set_monitor_stream pa_stream_set_monitor_stream a n -- n	( s sink_input_idx -- )
c-function pa_stream_get_monitor_stream pa_stream_get_monitor_stream a -- n	( s -- )
c-function pa_context_get_sink_info_by_name pa_context_get_sink_info_by_name a s a a -- a	( c name cb userdata -- )
c-function pa_context_get_sink_info_by_index pa_context_get_sink_info_by_index a n a a -- a	( c idx cb userdata -- )
c-function pa_context_get_sink_info_list pa_context_get_sink_info_list a a a -- a	( c cb userdata -- )
c-function pa_context_set_sink_volume_by_index pa_context_set_sink_volume_by_index a n a a a -- a	( c idx volume cb userdata -- )
c-function pa_context_set_sink_volume_by_name pa_context_set_sink_volume_by_name a s a a a -- a	( c name volume cb userdata -- )
c-function pa_context_set_sink_mute_by_index pa_context_set_sink_mute_by_index a n n a a -- a	( c idx mute cb userdata -- )
c-function pa_context_set_sink_mute_by_name pa_context_set_sink_mute_by_name a s n a a -- a	( c name mute cb userdata -- )
c-function pa_context_suspend_sink_by_name pa_context_suspend_sink_by_name a s n a a -- a	( c sink_name suspend cb userdata -- )
c-function pa_context_suspend_sink_by_index pa_context_suspend_sink_by_index a n n a a -- a	( c idx suspend cb userdata -- )
c-function pa_context_set_sink_port_by_index pa_context_set_sink_port_by_index a n s a a -- a	( c idx port cb userdata -- )
c-function pa_context_set_sink_port_by_name pa_context_set_sink_port_by_name a s s a a -- a	( c name port cb userdata -- )
c-function pa_context_get_source_info_by_name pa_context_get_source_info_by_name a s a a -- a	( c name cb userdata -- )
c-function pa_context_get_source_info_by_index pa_context_get_source_info_by_index a n a a -- a	( c idx cb userdata -- )
c-function pa_context_get_source_info_list pa_context_get_source_info_list a a a -- a	( c cb userdata -- )
c-function pa_context_set_source_volume_by_index pa_context_set_source_volume_by_index a n a a a -- a	( c idx volume cb userdata -- )
c-function pa_context_set_source_volume_by_name pa_context_set_source_volume_by_name a s a a a -- a	( c name volume cb userdata -- )
c-function pa_context_set_source_mute_by_index pa_context_set_source_mute_by_index a n n a a -- a	( c idx mute cb userdata -- )
c-function pa_context_set_source_mute_by_name pa_context_set_source_mute_by_name a s n a a -- a	( c name mute cb userdata -- )
c-function pa_context_suspend_source_by_name pa_context_suspend_source_by_name a s n a a -- a	( c source_name suspend cb userdata -- )
c-function pa_context_suspend_source_by_index pa_context_suspend_source_by_index a n n a a -- a	( c idx suspend cb userdata -- )
c-function pa_context_set_source_port_by_index pa_context_set_source_port_by_index a n s a a -- a	( c idx port cb userdata -- )
c-function pa_context_set_source_port_by_name pa_context_set_source_port_by_name a s s a a -- a	( c name port cb userdata -- )
c-function pa_context_get_server_info pa_context_get_server_info a a a -- a	( c cb userdata -- )
c-function pa_context_get_module_info pa_context_get_module_info a n a a -- a	( c idx cb userdata -- )
c-function pa_context_get_module_info_list pa_context_get_module_info_list a a a -- a	( c cb userdata -- )
c-function pa_context_load_module pa_context_load_module a s s a a -- a	( c name argument cb userdata -- )
c-function pa_context_unload_module pa_context_unload_module a n a a -- a	( c idx cb userdata -- )
c-function pa_context_send_message_to_object pa_context_send_message_to_object a s s s a a -- a	( c recipient_name message message_parameters cb userdata -- )
c-function pa_context_get_client_info pa_context_get_client_info a n a a -- a	( c idx cb userdata -- )
c-function pa_context_get_client_info_list pa_context_get_client_info_list a a a -- a	( c cb userdata -- )
c-function pa_context_kill_client pa_context_kill_client a n a a -- a	( c idx cb userdata -- )
c-function pa_context_get_card_info_by_index pa_context_get_card_info_by_index a n a a -- a	( c idx cb userdata -- )
c-function pa_context_get_card_info_by_name pa_context_get_card_info_by_name a s a a -- a	( c name cb userdata -- )
c-function pa_context_get_card_info_list pa_context_get_card_info_list a a a -- a	( c cb userdata -- )
c-function pa_context_set_card_profile_by_index pa_context_set_card_profile_by_index a n s a a -- a	( c idx profile cb userdata -- )
c-function pa_context_set_card_profile_by_name pa_context_set_card_profile_by_name a s s a a -- a	( c name profile cb userdata -- )
c-function pa_context_set_port_latency_offset pa_context_set_port_latency_offset a s s d a a -- a	( c card_name port_name offset cb userdata -- )
c-function pa_context_get_sink_input_info pa_context_get_sink_input_info a n a a -- a	( c idx cb userdata -- )
c-function pa_context_get_sink_input_info_list pa_context_get_sink_input_info_list a a a -- a	( c cb userdata -- )
c-function pa_context_move_sink_input_by_name pa_context_move_sink_input_by_name a n s a a -- a	( c idx sink_name cb userdata -- )
c-function pa_context_move_sink_input_by_index pa_context_move_sink_input_by_index a n n a a -- a	( c idx sink_idx cb userdata -- )
c-function pa_context_set_sink_input_volume pa_context_set_sink_input_volume a n a a a -- a	( c idx volume cb userdata -- )
c-function pa_context_set_sink_input_mute pa_context_set_sink_input_mute a n n a a -- a	( c idx mute cb userdata -- )
c-function pa_context_kill_sink_input pa_context_kill_sink_input a n a a -- a	( c idx cb userdata -- )
c-function pa_context_get_source_output_info pa_context_get_source_output_info a n a a -- a	( c idx cb userdata -- )
c-function pa_context_get_source_output_info_list pa_context_get_source_output_info_list a a a -- a	( c cb userdata -- )
c-function pa_context_move_source_output_by_name pa_context_move_source_output_by_name a n s a a -- a	( c idx source_name cb userdata -- )
c-function pa_context_move_source_output_by_index pa_context_move_source_output_by_index a n n a a -- a	( c idx source_idx cb userdata -- )
c-function pa_context_set_source_output_volume pa_context_set_source_output_volume a n a a a -- a	( c idx volume cb userdata -- )
c-function pa_context_set_source_output_mute pa_context_set_source_output_mute a n n a a -- a	( c idx mute cb userdata -- )
c-function pa_context_kill_source_output pa_context_kill_source_output a n a a -- a	( c idx cb userdata -- )
c-function pa_context_stat pa_context_stat a a a -- a	( c cb userdata -- )
c-function pa_context_get_sample_info_by_name pa_context_get_sample_info_by_name a s a a -- a	( c name cb userdata -- )
c-function pa_context_get_sample_info_by_index pa_context_get_sample_info_by_index a n a a -- a	( c idx cb userdata -- )
c-function pa_context_get_sample_info_list pa_context_get_sample_info_list a a a -- a	( c cb userdata -- )
\ c-function pa_context_get_autoload_info_by_name pa_context_get_autoload_info_by_name a s n a a -- a	( c name type cb userdata -- )
\ c-function pa_context_get_autoload_info_by_index pa_context_get_autoload_info_by_index a n a a -- a	( c idx cb userdata -- )
\ c-function pa_context_get_autoload_info_list pa_context_get_autoload_info_list a a a -- a	( c cb userdata -- )
\ c-function pa_context_add_autoload pa_context_add_autoload a s n s s a a -- a	( c name type module argument <noname> userdata -- )
\ c-function pa_context_remove_autoload_by_name pa_context_remove_autoload_by_name a s n a a -- a	( c name type cb userdata -- )
\ c-function pa_context_remove_autoload_by_index pa_context_remove_autoload_by_index a n a a -- a	( c idx cb userdata -- )
c-function pa_context_subscribe pa_context_subscribe a n a a -- a	( c m cb userdata -- )
c-function pa_context_set_subscribe_callback pa_context_set_subscribe_callback a a a -- void	( c cb userdata -- )
c-function pa_stream_connect_upload pa_stream_connect_upload a n -- n	( s length -- )
c-function pa_stream_finish_upload pa_stream_finish_upload a -- n	( s -- )
c-function pa_context_remove_sample pa_context_remove_sample a s a a -- a	( c name cb userdata -- )
c-function pa_context_play_sample pa_context_play_sample a s s n a a -- a	( c name dev volume cb userdata -- )
c-function pa_context_play_sample_with_proplist pa_context_play_sample_with_proplist a s s n a a a -- a	( c name dev volume proplist cb userdata -- )
c-function pa_get_library_version pa_get_library_version  -- s	( -- )
c-function pa_strerror pa_strerror n -- s	( error -- )
c-function pa_operation_ref pa_operation_ref a -- a	( o -- )
c-function pa_operation_unref pa_operation_unref a -- void	( o -- )
c-function pa_operation_cancel pa_operation_cancel a -- void	( o -- )
c-function pa_operation_get_state pa_operation_get_state a -- n	( o -- )
c-function pa_operation_set_state_callback pa_operation_set_state_callback a a a -- void	( o cb userdata -- )
c-function pa_channel_map_init pa_channel_map_init a -- a	( m -- )
c-function pa_channel_map_init_mono pa_channel_map_init_mono a -- a	( m -- )
c-function pa_channel_map_init_stereo pa_channel_map_init_stereo a -- a	( m -- )
c-function pa_channel_map_init_auto pa_channel_map_init_auto a u n -- a	( m channels def -- )
c-function pa_channel_map_init_extend pa_channel_map_init_extend a u n -- a	( m channels def -- )
c-function pa_channel_position_to_string pa_channel_position_to_string n -- s	( pos -- )
c-function pa_channel_position_from_string pa_channel_position_from_string s -- n	( s -- )
c-function pa_channel_position_to_pretty_string pa_channel_position_to_pretty_string n -- s	( pos -- )
c-function pa_channel_map_snprint pa_channel_map_snprint a n a -- a	( s l map -- )
c-function pa_channel_map_parse pa_channel_map_parse a s -- a	( map s -- )
c-function pa_channel_map_equal pa_channel_map_equal a a -- n	( a b -- )
c-function pa_channel_map_valid pa_channel_map_valid a -- n	( map -- )
c-function pa_channel_map_compatible pa_channel_map_compatible a a -- n	( map ss -- )
c-function pa_channel_map_superset pa_channel_map_superset a a -- n	( a b -- )
c-function pa_channel_map_can_balance pa_channel_map_can_balance a -- n	( map -- )
c-function pa_channel_map_can_fade pa_channel_map_can_fade a -- n	( map -- )
c-function pa_channel_map_can_lfe_balance pa_channel_map_can_lfe_balance a -- n	( map -- )
c-function pa_channel_map_to_name pa_channel_map_to_name a -- s	( map -- )
c-function pa_channel_map_to_pretty_name pa_channel_map_to_pretty_name a -- s	( map -- )
c-function pa_channel_map_has_position pa_channel_map_has_position a n -- n	( map p -- )
c-function pa_channel_map_mask pa_channel_map_mask a -- n	( map -- )
c-function pa_cvolume_equal pa_cvolume_equal a a -- n	( a b -- )
c-function pa_cvolume_init pa_cvolume_init a -- a	( a -- )
c-function pa_cvolume_set pa_cvolume_set a u n -- a	( a channels v -- )
c-function pa_cvolume_snprint pa_cvolume_snprint a n a -- a	( s l c -- )
c-function pa_sw_cvolume_snprint_dB pa_sw_cvolume_snprint_dB a n a -- a	( s l c -- )
c-function pa_cvolume_snprint_verbose pa_cvolume_snprint_verbose a n a a n -- a	( s l c map print_dB -- )
c-function pa_volume_snprint pa_volume_snprint a n n -- a	( s l v -- )
c-function pa_sw_volume_snprint_dB pa_sw_volume_snprint_dB a n n -- a	( s l v -- )
c-function pa_volume_snprint_verbose pa_volume_snprint_verbose a n n n -- a	( s l v print_dB -- )
c-function pa_cvolume_avg pa_cvolume_avg a -- n	( a -- )
c-function pa_cvolume_avg_mask pa_cvolume_avg_mask a a n -- n	( a cm mask -- )
c-function pa_cvolume_max pa_cvolume_max a -- n	( a -- )
c-function pa_cvolume_max_mask pa_cvolume_max_mask a a n -- n	( a cm mask -- )
c-function pa_cvolume_min pa_cvolume_min a -- n	( a -- )
c-function pa_cvolume_min_mask pa_cvolume_min_mask a a n -- n	( a cm mask -- )
c-function pa_cvolume_valid pa_cvolume_valid a -- n	( v -- )
c-function pa_cvolume_channels_equal_to pa_cvolume_channels_equal_to a n -- n	( a v -- )
c-function pa_sw_volume_multiply pa_sw_volume_multiply n n -- n	( a b -- )
c-function pa_sw_cvolume_multiply pa_sw_cvolume_multiply a a a -- a	( dest a b -- )
c-function pa_sw_cvolume_multiply_scalar pa_sw_cvolume_multiply_scalar a a n -- a	( dest a b -- )
c-function pa_sw_volume_divide pa_sw_volume_divide n n -- n	( a b -- )
c-function pa_sw_cvolume_divide pa_sw_cvolume_divide a a a -- a	( dest a b -- )
c-function pa_sw_cvolume_divide_scalar pa_sw_cvolume_divide_scalar a a n -- a	( dest a b -- )
c-function pa_sw_volume_from_dB pa_sw_volume_from_dB r -- n	( f -- )
c-function pa_sw_volume_to_dB pa_sw_volume_to_dB n -- r	( v -- )
c-function pa_sw_volume_from_linear pa_sw_volume_from_linear r -- n	( v -- )
c-function pa_sw_volume_to_linear pa_sw_volume_to_linear n -- r	( v -- )
c-function pa_cvolume_remap pa_cvolume_remap a a a -- a	( v from to -- )
c-function pa_cvolume_compatible pa_cvolume_compatible a a -- n	( v ss -- )
c-function pa_cvolume_compatible_with_channel_map pa_cvolume_compatible_with_channel_map a a -- n	( v cm -- )
c-function pa_cvolume_get_balance pa_cvolume_get_balance a a -- r	( v map -- )
c-function pa_cvolume_set_balance pa_cvolume_set_balance a a r -- a	( v map new_balance -- )
c-function pa_cvolume_get_fade pa_cvolume_get_fade a a -- r	( v map -- )
c-function pa_cvolume_set_fade pa_cvolume_set_fade a a r -- a	( v map new_fade -- )
c-function pa_cvolume_get_lfe_balance pa_cvolume_get_lfe_balance a a -- r	( v map -- )
c-function pa_cvolume_set_lfe_balance pa_cvolume_set_lfe_balance a a r -- a	( v map new_balance -- )
c-function pa_cvolume_scale pa_cvolume_scale a n -- a	( v max -- )
c-function pa_cvolume_scale_mask pa_cvolume_scale_mask a n a n -- a	( v max cm mask -- )
c-function pa_cvolume_set_position pa_cvolume_set_position a a n n -- a	( cv map t v -- )
c-function pa_cvolume_get_position pa_cvolume_get_position a a n -- n	( cv map t -- )
c-function pa_cvolume_merge pa_cvolume_merge a a a -- a	( dest a b -- )
c-function pa_cvolume_inc_clamp pa_cvolume_inc_clamp a n n -- a	( v inc limit -- )
c-function pa_cvolume_inc pa_cvolume_inc a n -- a	( v inc -- )
c-function pa_cvolume_dec pa_cvolume_dec a n -- a	( v dec -- )
c-function pa_xmalloc pa_xmalloc n -- a	( l -- )
c-function pa_xmalloc0 pa_xmalloc0 n -- a	( l -- )
c-function pa_xrealloc pa_xrealloc a n -- a	( ptr size -- )
c-function pa_xfree pa_xfree a -- void	( p -- )
c-function pa_xstrdup pa_xstrdup s -- a	( s -- )
c-function pa_xstrndup pa_xstrndup s n -- a	( s l -- )
c-function pa_xmemdup pa_xmemdup a n -- a	( p l -- )
c-function _pa_xnew_internal _pa_xnew_internal n n -- a	( n k -- )
c-function _pa_xnew0_internal _pa_xnew0_internal n n -- a	( n k -- )
c-function _pa_xnewdup_internal _pa_xnewdup_internal a n n -- a	( p n k -- )
c-function _pa_xrenew_internal _pa_xrenew_internal a n n -- a	( p n k -- )
c-function pa_utf8_valid pa_utf8_valid s -- a	( str -- )
c-function pa_ascii_valid pa_ascii_valid s -- a	( str -- )
c-function pa_utf8_filter pa_utf8_filter s -- a	( str -- )
c-function pa_ascii_filter pa_ascii_filter s -- a	( str -- )
c-function pa_utf8_to_locale pa_utf8_to_locale s -- a	( str -- )
c-function pa_locale_to_utf8 pa_locale_to_utf8 s -- a	( str -- )
c-function pa_threaded_mainloop_new pa_threaded_mainloop_new  -- a	( -- )
c-function pa_threaded_mainloop_free pa_threaded_mainloop_free a -- void	( m -- )
c-function pa_threaded_mainloop_start pa_threaded_mainloop_start a -- n	( m -- )
c-function pa_threaded_mainloop_stop pa_threaded_mainloop_stop a -- void	( m -- )
c-function pa_threaded_mainloop_lock pa_threaded_mainloop_lock a -- void	( m -- )
c-function pa_threaded_mainloop_unlock pa_threaded_mainloop_unlock a -- void	( m -- )
c-function pa_threaded_mainloop_wait pa_threaded_mainloop_wait a -- void	( m -- )
c-function pa_threaded_mainloop_signal pa_threaded_mainloop_signal a n -- void	( m wait_for_accept -- )
c-function pa_threaded_mainloop_accept pa_threaded_mainloop_accept a -- void	( m -- )
c-function pa_threaded_mainloop_get_retval pa_threaded_mainloop_get_retval a -- n	( m -- )
c-function pa_threaded_mainloop_get_api pa_threaded_mainloop_get_api a -- a	( m -- )
c-function pa_threaded_mainloop_in_thread pa_threaded_mainloop_in_thread a -- n	( m -- )
c-function pa_threaded_mainloop_set_name pa_threaded_mainloop_set_name a s -- void	( m name -- )
c-function pa_threaded_mainloop_once_unlocked pa_threaded_mainloop_once_unlocked a a a -- void	( m callback userdata -- )
c-function pa_mainloop_new pa_mainloop_new  -- a	( -- )
c-function pa_mainloop_free pa_mainloop_free a -- void	( m -- )
c-function pa_mainloop_prepare pa_mainloop_prepare a n -- n	( m timeout -- )
c-function pa_mainloop_poll pa_mainloop_poll a -- n	( m -- )
c-function pa_mainloop_dispatch pa_mainloop_dispatch a -- n	( m -- )
c-function pa_mainloop_get_retval pa_mainloop_get_retval a -- n	( m -- )
c-function pa_mainloop_iterate pa_mainloop_iterate a n a -- n	( m block retval -- )
c-function pa_mainloop_run pa_mainloop_run a a -- n	( m retval -- )
c-function pa_mainloop_get_api pa_mainloop_get_api a -- a	( m -- )
c-function pa_mainloop_quit pa_mainloop_quit a n -- void	( m retval -- )
c-function pa_mainloop_wakeup pa_mainloop_wakeup a -- void	( m -- )
c-function pa_mainloop_set_poll_func pa_mainloop_set_poll_func a a a -- void	( m poll_func userdata -- )
c-function pa_signal_init pa_signal_init a -- n	( api -- )
c-function pa_signal_done pa_signal_done  -- void	( -- )
c-function pa_signal_new pa_signal_new n a a -- a	( sig callback userdata -- )
c-function pa_signal_free pa_signal_free a -- void	( e -- )
c-function pa_signal_set_destroy pa_signal_set_destroy a a -- void	( e callback -- )
c-function pa_get_user_name pa_get_user_name a n -- a	( s l -- )
c-function pa_get_host_name pa_get_host_name a n -- a	( s l -- )
c-function pa_get_fqdn pa_get_fqdn a n -- a	( s l -- )
c-function pa_get_home_dir pa_get_home_dir a n -- a	( s l -- )
c-function pa_get_binary_name pa_get_binary_name a n -- a	( s l -- )
c-function pa_path_get_filename pa_path_get_filename s -- a	( p -- )
c-function pa_msleep pa_msleep u -- n	( t -- )
c-function pa_thread_make_realtime pa_thread_make_realtime n -- n	( rtprio -- )
c-function pa_gettimeofday pa_gettimeofday a -- a	( tv -- )
c-function pa_timeval_diff pa_timeval_diff a a -- n	( a b -- )
c-function pa_timeval_cmp pa_timeval_cmp a a -- n	( a b -- )
c-function pa_timeval_age pa_timeval_age a -- n	( tv -- )
c-function pa_timeval_add pa_timeval_add a n -- a	( tv v -- )
c-function pa_timeval_sub pa_timeval_sub a n -- a	( tv v -- )
c-function pa_timeval_store pa_timeval_store a n -- a	( tv v -- )
c-function pa_timeval_load pa_timeval_load a -- n	( tv -- )
c-function pa_proplist_new pa_proplist_new  -- a	( -- )
c-function pa_proplist_free pa_proplist_free a -- void	( p -- )
c-function pa_proplist_key_valid pa_proplist_key_valid s -- n	( key -- )
c-function pa_proplist_sets pa_proplist_sets a s s -- n	( p key value -- )
c-function pa_proplist_setp pa_proplist_setp a s -- n	( p pair -- )
\ c-function pa_proplist_setf pa_proplist_setf a s s ... -- n	( p key format <noname> -- )
c-function pa_proplist_set pa_proplist_set a s a n -- n	( p key data nbytes -- )
c-function pa_proplist_gets pa_proplist_gets a s -- s	( p key -- )
c-function pa_proplist_get pa_proplist_get a s a a -- n	( p key data nbytes -- )
c-function pa_proplist_update pa_proplist_update a n a -- void	( p mode other -- )
c-function pa_proplist_unset pa_proplist_unset a s -- n	( p key -- )
c-function pa_proplist_unset_many pa_proplist_unset_many a a -- n	( p keys -- )
c-function pa_proplist_iterate pa_proplist_iterate a a -- s	( p state -- )
c-function pa_proplist_to_string pa_proplist_to_string a -- a	( p -- )
c-function pa_proplist_to_string_sep pa_proplist_to_string_sep a s -- a	( p sep -- )
c-function pa_proplist_from_string pa_proplist_from_string s -- a	( str -- )
c-function pa_proplist_contains pa_proplist_contains a s -- n	( p key -- )
c-function pa_proplist_clear pa_proplist_clear a -- void	( p -- )
c-function pa_proplist_copy pa_proplist_copy a -- a	( p -- )
c-function pa_proplist_size pa_proplist_size a -- u	( p -- )
c-function pa_proplist_isempty pa_proplist_isempty a -- n	( p -- )
c-function pa_proplist_equal pa_proplist_equal a a -- n	( a b -- )
c-function pa_rtclock_now pa_rtclock_now  -- n	( -- )

\ ----===< postfix >===-----
end-c-library
previous set-current
