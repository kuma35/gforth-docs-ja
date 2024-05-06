\ This file has been generated using SWIG and fsi,
\ and is already platform dependent, search for the corresponding
\ fsi-file to compile it where no one has compiled it before ;)
\ Forth systems have their own own dynamic loader and don't need addional C-Code.
\ That's why this file will just print normal forth-code once compiled
\ and can be used directly with include or require.
\ As all comments are stripped during the compilation, please
\ insert the copyright notice of the original file here.

\ ----===< prefix >===-----
cs-vocabulary opus

get-current also opus definitions

c-library opus
s" n" vararg$ $!
s" opus" add-lib
\c #include <opus/opus.h>
\c #ifdef __gnu_linux__
\c #undef stderr
\c extern struct _IO_FILE *stderr;
\c #endif

\ ----===< int constants >===-----
#0	constant OPUS_OK
#-1	constant OPUS_BAD_ARG
#-2	constant OPUS_BUFFER_TOO_SMALL
#-3	constant OPUS_INTERNAL_ERROR
#-4	constant OPUS_INVALID_PACKET
#-5	constant OPUS_UNIMPLEMENTED
#-6	constant OPUS_INVALID_STATE
#-7	constant OPUS_ALLOC_FAIL
#4000	constant OPUS_SET_APPLICATION_REQUEST
#4001	constant OPUS_GET_APPLICATION_REQUEST
#4002	constant OPUS_SET_BITRATE_REQUEST
#4003	constant OPUS_GET_BITRATE_REQUEST
#4004	constant OPUS_SET_MAX_BANDWIDTH_REQUEST
#4005	constant OPUS_GET_MAX_BANDWIDTH_REQUEST
#4006	constant OPUS_SET_VBR_REQUEST
#4007	constant OPUS_GET_VBR_REQUEST
#4008	constant OPUS_SET_BANDWIDTH_REQUEST
#4009	constant OPUS_GET_BANDWIDTH_REQUEST
#4010	constant OPUS_SET_COMPLEXITY_REQUEST
#4011	constant OPUS_GET_COMPLEXITY_REQUEST
#4012	constant OPUS_SET_INBAND_FEC_REQUEST
#4013	constant OPUS_GET_INBAND_FEC_REQUEST
#4014	constant OPUS_SET_PACKET_LOSS_PERC_REQUEST
#4015	constant OPUS_GET_PACKET_LOSS_PERC_REQUEST
#4016	constant OPUS_SET_DTX_REQUEST
#4017	constant OPUS_GET_DTX_REQUEST
#4020	constant OPUS_SET_VBR_CONSTRAINT_REQUEST
#4021	constant OPUS_GET_VBR_CONSTRAINT_REQUEST
#4022	constant OPUS_SET_FORCE_CHANNELS_REQUEST
#4023	constant OPUS_GET_FORCE_CHANNELS_REQUEST
#4024	constant OPUS_SET_SIGNAL_REQUEST
#4025	constant OPUS_GET_SIGNAL_REQUEST
#4027	constant OPUS_GET_LOOKAHEAD_REQUEST
#4029	constant OPUS_GET_SAMPLE_RATE_REQUEST
#4031	constant OPUS_GET_FINAL_RANGE_REQUEST
#4033	constant OPUS_GET_PITCH_REQUEST
#4034	constant OPUS_SET_GAIN_REQUEST
#4045	constant OPUS_GET_GAIN_REQUEST
#4036	constant OPUS_SET_LSB_DEPTH_REQUEST
#4037	constant OPUS_GET_LSB_DEPTH_REQUEST
#4039	constant OPUS_GET_LAST_PACKET_DURATION_REQUEST
#4040	constant OPUS_SET_EXPERT_FRAME_DURATION_REQUEST
#4041	constant OPUS_GET_EXPERT_FRAME_DURATION_REQUEST
#4042	constant OPUS_SET_PREDICTION_DISABLED_REQUEST
#4043	constant OPUS_GET_PREDICTION_DISABLED_REQUEST
#4046	constant OPUS_SET_PHASE_INVERSION_DISABLED_REQUEST
#4047	constant OPUS_GET_PHASE_INVERSION_DISABLED_REQUEST
#4049	constant OPUS_GET_IN_DTX_REQUEST
#-1000	constant OPUS_AUTO
#-1	constant OPUS_BITRATE_MAX
#2048	constant OPUS_APPLICATION_VOIP
#2049	constant OPUS_APPLICATION_AUDIO
#2051	constant OPUS_APPLICATION_RESTRICTED_LOWDELAY
#3001	constant OPUS_SIGNAL_VOICE
#3002	constant OPUS_SIGNAL_MUSIC
#1101	constant OPUS_BANDWIDTH_NARROWBAND
#1102	constant OPUS_BANDWIDTH_MEDIUMBAND
#1103	constant OPUS_BANDWIDTH_WIDEBAND
#1104	constant OPUS_BANDWIDTH_SUPERWIDEBAND
#1105	constant OPUS_BANDWIDTH_FULLBAND
#5000	constant OPUS_FRAMESIZE_ARG
#5001	constant OPUS_FRAMESIZE_2_5_MS
#5002	constant OPUS_FRAMESIZE_5_MS
#5003	constant OPUS_FRAMESIZE_10_MS
#5004	constant OPUS_FRAMESIZE_20_MS
#5005	constant OPUS_FRAMESIZE_40_MS
#5006	constant OPUS_FRAMESIZE_60_MS
#5007	constant OPUS_FRAMESIZE_80_MS
#5008	constant OPUS_FRAMESIZE_100_MS
#5009	constant OPUS_FRAMESIZE_120_MS
#4028	constant OPUS_RESET_STATE

\ ------===< functions >===-------
c-function opus_strerror opus_strerror n -- s	( error -- )
c-function opus_get_version_string opus_get_version_string  -- s	( -- )
c-function opus_encoder_get_size opus_encoder_get_size n -- n	( channels -- )
c-function opus_encoder_create opus_encoder_create n n n a -- a	( Fs channels application error -- )
c-function opus_encoder_init opus_encoder_init a n n n -- n	( st Fs channels application -- )
c-function opus_encode opus_encode a a n a n -- n	( st pcm frame_size data max_data_bytes -- )
c-function opus_encode_float opus_encode_float a a n a n -- n	( st pcm frame_size data max_data_bytes -- )
c-function opus_encoder_destroy opus_encoder_destroy a -- void	( st -- )
c-function opus_encoder_ctl opus_encoder_ctl a n ... -- n	( st request <noname> -- )
c-function opus_decoder_get_size opus_decoder_get_size n -- n	( channels -- )
c-function opus_decoder_create opus_decoder_create n n a -- a	( Fs channels error -- )
c-function opus_decoder_init opus_decoder_init a n n -- n	( st Fs channels -- )
c-function opus_decode opus_decode a a n a n n -- n	( st data len pcm frame_size decode_fec -- )
c-function opus_decode_float opus_decode_float a a n a n n -- n	( st data len pcm frame_size decode_fec -- )
c-function opus_decoder_ctl opus_decoder_ctl a n ... -- n	( st request <noname> -- )
c-function opus_decoder_destroy opus_decoder_destroy a -- void	( st -- )
c-function opus_packet_parse opus_packet_parse a n a a a a -- n	( data len out_toc frames size payload_offset -- )
c-function opus_packet_get_bandwidth opus_packet_get_bandwidth a -- n	( data -- )
c-function opus_packet_get_samples_per_frame opus_packet_get_samples_per_frame a n -- n	( data Fs -- )
c-function opus_packet_get_nb_channels opus_packet_get_nb_channels a -- n	( data -- )
c-function opus_packet_get_nb_frames opus_packet_get_nb_frames a n -- n	( packet len -- )
c-function opus_packet_get_nb_samples opus_packet_get_nb_samples a n n -- n	( packet len Fs -- )
c-function opus_decoder_get_nb_samples opus_decoder_get_nb_samples a a n -- n	( dec packet len -- )
c-function opus_pcm_soft_clip opus_pcm_soft_clip a n n a -- void	( pcm frame_size channels softclip_mem -- )
c-function opus_repacketizer_get_size opus_repacketizer_get_size  -- n	( -- )
c-function opus_repacketizer_init opus_repacketizer_init a -- a	( rp -- )
c-function opus_repacketizer_create opus_repacketizer_create  -- a	( -- )
c-function opus_repacketizer_destroy opus_repacketizer_destroy a -- void	( rp -- )
c-function opus_repacketizer_cat opus_repacketizer_cat a a n -- n	( rp data len -- )
c-function opus_repacketizer_out_range opus_repacketizer_out_range a n n a n -- n	( rp begin end data maxlen -- )
c-function opus_repacketizer_get_nb_frames opus_repacketizer_get_nb_frames a -- n	( rp -- )
c-function opus_repacketizer_out opus_repacketizer_out a a n -- n	( rp data maxlen -- )
c-function opus_packet_pad opus_packet_pad a n n -- n	( data len new_len -- )
c-function opus_packet_unpad opus_packet_unpad a n -- n	( data len -- )
c-function opus_multistream_packet_pad opus_multistream_packet_pad a n n n -- n	( data len new_len nb_streams -- )
c-function opus_multistream_packet_unpad opus_multistream_packet_unpad a n n -- n	( data len nb_streams -- )

\ ----===< postfix >===-----
end-c-library
previous set-current
