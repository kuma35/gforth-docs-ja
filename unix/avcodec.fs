\ This file has been generated using SWIG and fsi,
\ and is already platform dependent, search for the corresponding
\ fsi-file to compile it where no one has compiled it before ;)
\ Forth systems have their own own dynamic loader and don't need addional C-Code.
\ That's why this file will just print normal forth-code once compiled
\ and can be used directly with include or require.
\ As all comments are stripped during the compilation, please
\ insert the copyright notice of the original file here.

\ ----===< prefix >===-----
c-library avcodec
s" avcodec" add-lib
s" ((struct AV:x.spx[arg0]" ptr-declare $+[]!
\c #include <libavcodec/avcodec.h>
\c #include <libavutil/pixfmt.h>
\c #undef gforth_d2ll
\c #define gforth_d2ll(x1,x2) av_make_q(x1,x2)

\ ----===< int constants >===-----
#64	constant AV_INPUT_BUFFER_PADDING_SIZE
#16384	constant AV_INPUT_BUFFER_MIN_SIZE
#1	constant AV_CODEC_FLAG_UNALIGNED
#2	constant AV_CODEC_FLAG_QSCALE
#4	constant AV_CODEC_FLAG_4MV
#8	constant AV_CODEC_FLAG_OUTPUT_CORRUPT
#16	constant AV_CODEC_FLAG_QPEL
#32	constant AV_CODEC_FLAG_DROPCHANGED
#512	constant AV_CODEC_FLAG_PASS1
#1024	constant AV_CODEC_FLAG_PASS2
#2048	constant AV_CODEC_FLAG_LOOP_FILTER
#8192	constant AV_CODEC_FLAG_GRAY
#32768	constant AV_CODEC_FLAG_PSNR
#65536	constant AV_CODEC_FLAG_TRUNCATED
#262144	constant AV_CODEC_FLAG_INTERLACED_DCT
#524288	constant AV_CODEC_FLAG_LOW_DELAY
#4194304	constant AV_CODEC_FLAG_GLOBAL_HEADER
#8388608	constant AV_CODEC_FLAG_BITEXACT
#16777216	constant AV_CODEC_FLAG_AC_PRED
#536870912	constant AV_CODEC_FLAG_INTERLACED_ME
#2147483648	constant AV_CODEC_FLAG_CLOSED_GOP
#1	constant AV_CODEC_FLAG2_FAST
#4	constant AV_CODEC_FLAG2_NO_OUTPUT
#8	constant AV_CODEC_FLAG2_LOCAL_HEADER
#8192	constant AV_CODEC_FLAG2_DROP_FRAME_TIMECODE
#32768	constant AV_CODEC_FLAG2_CHUNKS
#65536	constant AV_CODEC_FLAG2_IGNORE_CROP
#4194304	constant AV_CODEC_FLAG2_SHOW_ALL
#268435456	constant AV_CODEC_FLAG2_EXPORT_MVS
#536870912	constant AV_CODEC_FLAG2_SKIP_MANUAL
#1073741824	constant AV_CODEC_FLAG2_RO_FLUSH_NOOP
#1	constant AV_CODEC_EXPORT_DATA_MVS
#2	constant AV_CODEC_EXPORT_DATA_PRFT
#4	constant AV_CODEC_EXPORT_DATA_VIDEO_ENC_PARAMS
#8	constant AV_CODEC_EXPORT_DATA_FILM_GRAIN
#1	constant AV_GET_BUFFER_FLAG_REF
#1	constant AV_GET_ENCODE_BUFFER_FLAG_REF
#-1	constant FF_COMPRESSION_DEFAULT
#0	constant FF_CMP_SAD
#1	constant FF_CMP_SSE
#2	constant FF_CMP_SATD
#3	constant FF_CMP_DCT
#4	constant FF_CMP_PSNR
#5	constant FF_CMP_BIT
#6	constant FF_CMP_RD
#7	constant FF_CMP_ZERO
#8	constant FF_CMP_VSAD
#9	constant FF_CMP_VSSE
#10	constant FF_CMP_NSSE
#11	constant FF_CMP_W53
#12	constant FF_CMP_W97
#13	constant FF_CMP_DCTMAX
#14	constant FF_CMP_DCT264
#15	constant FF_CMP_MEDIAN_SAD
#256	constant FF_CMP_CHROMA
#1	constant SLICE_FLAG_CODED_ORDER
#2	constant SLICE_FLAG_ALLOW_FIELD
#4	constant SLICE_FLAG_ALLOW_PLANE
#0	constant FF_MB_DECISION_SIMPLE
#1	constant FF_MB_DECISION_BITS
#2	constant FF_MB_DECISION_RD
#1	constant FF_BUG_AUTODETECT
#4	constant FF_BUG_XVID_ILACE
#8	constant FF_BUG_UMP4
#16	constant FF_BUG_NO_PADDING
#32	constant FF_BUG_AMV
#64	constant FF_BUG_QPEL_CHROMA
#128	constant FF_BUG_STD_QPEL
#256	constant FF_BUG_QPEL_CHROMA2
#512	constant FF_BUG_DIRECT_BLOCKSIZE
#1024	constant FF_BUG_EDGE
#2048	constant FF_BUG_HPEL_CHROMA
#4096	constant FF_BUG_DC_CLIP
#8192	constant FF_BUG_MS
#16384	constant FF_BUG_TRUNCATED
#32768	constant FF_BUG_IEDGE
#2	constant FF_COMPLIANCE_VERY_STRICT
#1	constant FF_COMPLIANCE_STRICT
#0	constant FF_COMPLIANCE_NORMAL
#-1	constant FF_COMPLIANCE_UNOFFICIAL
#-2	constant FF_COMPLIANCE_EXPERIMENTAL
#1	constant FF_EC_GUESS_MVS
#2	constant FF_EC_DEBLOCK
#256	constant FF_EC_FAVOR_INTER
#1	constant FF_DEBUG_PICT_INFO
#2	constant FF_DEBUG_RC
#4	constant FF_DEBUG_BITSTREAM
#8	constant FF_DEBUG_MB_TYPE
#16	constant FF_DEBUG_QP
#64	constant FF_DEBUG_DCT_COEFF
#128	constant FF_DEBUG_SKIP
#256	constant FF_DEBUG_STARTCODE
#1024	constant FF_DEBUG_ER
#2048	constant FF_DEBUG_MMCO
#4096	constant FF_DEBUG_BUGS
#32768	constant FF_DEBUG_BUFFERS
#65536	constant FF_DEBUG_THREADS
#8388608	constant FF_DEBUG_GREEN_MD
#16777216	constant FF_DEBUG_NOMC
#1	constant AV_EF_CRCCHECK
#2	constant AV_EF_BITSTREAM
#4	constant AV_EF_BUFFER
#8	constant AV_EF_EXPLODE
#32768	constant AV_EF_IGNORE_ERR
#65536	constant AV_EF_CAREFUL
#131072	constant AV_EF_COMPLIANT
#262144	constant AV_EF_AGGRESSIVE
#0	constant FF_DCT_AUTO
#1	constant FF_DCT_FASTINT
#2	constant FF_DCT_INT
#3	constant FF_DCT_MMX
#5	constant FF_DCT_ALTIVEC
#6	constant FF_DCT_FAAN
#0	constant FF_IDCT_AUTO
#1	constant FF_IDCT_INT
#2	constant FF_IDCT_SIMPLE
#3	constant FF_IDCT_SIMPLEMMX
#7	constant FF_IDCT_ARM
#8	constant FF_IDCT_ALTIVEC
#10	constant FF_IDCT_SIMPLEARM
#14	constant FF_IDCT_XVID
#16	constant FF_IDCT_SIMPLEARMV5TE
#17	constant FF_IDCT_SIMPLEARMV6
#20	constant FF_IDCT_FAAN
#22	constant FF_IDCT_SIMPLENEON
#24	constant FF_IDCT_NONE
#128	constant FF_IDCT_SIMPLEAUTO
#1	constant FF_THREAD_FRAME
#2	constant FF_THREAD_SLICE
#-99	constant FF_PROFILE_UNKNOWN
#-100	constant FF_PROFILE_RESERVED
#0	constant FF_PROFILE_AAC_MAIN
#1	constant FF_PROFILE_AAC_LOW
#2	constant FF_PROFILE_AAC_SSR
#3	constant FF_PROFILE_AAC_LTP
#4	constant FF_PROFILE_AAC_HE
#28	constant FF_PROFILE_AAC_HE_V2
#22	constant FF_PROFILE_AAC_LD
#38	constant FF_PROFILE_AAC_ELD
#128	constant FF_PROFILE_MPEG2_AAC_LOW
#131	constant FF_PROFILE_MPEG2_AAC_HE
#0	constant FF_PROFILE_DNXHD
#1	constant FF_PROFILE_DNXHR_LB
#2	constant FF_PROFILE_DNXHR_SQ
#3	constant FF_PROFILE_DNXHR_HQ
#4	constant FF_PROFILE_DNXHR_HQX
#5	constant FF_PROFILE_DNXHR_444
#20	constant FF_PROFILE_DTS
#30	constant FF_PROFILE_DTS_ES
#40	constant FF_PROFILE_DTS_96_24
#50	constant FF_PROFILE_DTS_HD_HRA
#60	constant FF_PROFILE_DTS_HD_MA
#70	constant FF_PROFILE_DTS_EXPRESS
#0	constant FF_PROFILE_MPEG2_422
#1	constant FF_PROFILE_MPEG2_HIGH
#2	constant FF_PROFILE_MPEG2_SS
#3	constant FF_PROFILE_MPEG2_SNR_SCALABLE
#4	constant FF_PROFILE_MPEG2_MAIN
#5	constant FF_PROFILE_MPEG2_SIMPLE
#512	constant FF_PROFILE_H264_CONSTRAINED
#2048	constant FF_PROFILE_H264_INTRA
#66	constant FF_PROFILE_H264_BASELINE
#578	constant FF_PROFILE_H264_CONSTRAINED_BASELINE
#77	constant FF_PROFILE_H264_MAIN
#88	constant FF_PROFILE_H264_EXTENDED
#100	constant FF_PROFILE_H264_HIGH
#110	constant FF_PROFILE_H264_HIGH_10
#2158	constant FF_PROFILE_H264_HIGH_10_INTRA
#118	constant FF_PROFILE_H264_MULTIVIEW_HIGH
#122	constant FF_PROFILE_H264_HIGH_422
#2170	constant FF_PROFILE_H264_HIGH_422_INTRA
#128	constant FF_PROFILE_H264_STEREO_HIGH
#144	constant FF_PROFILE_H264_HIGH_444
#244	constant FF_PROFILE_H264_HIGH_444_PREDICTIVE
#2292	constant FF_PROFILE_H264_HIGH_444_INTRA
#44	constant FF_PROFILE_H264_CAVLC_444
#0	constant FF_PROFILE_VC1_SIMPLE
#1	constant FF_PROFILE_VC1_MAIN
#2	constant FF_PROFILE_VC1_COMPLEX
#3	constant FF_PROFILE_VC1_ADVANCED
#0	constant FF_PROFILE_MPEG4_SIMPLE
#1	constant FF_PROFILE_MPEG4_SIMPLE_SCALABLE
#2	constant FF_PROFILE_MPEG4_CORE
#3	constant FF_PROFILE_MPEG4_MAIN
#4	constant FF_PROFILE_MPEG4_N_BIT
#5	constant FF_PROFILE_MPEG4_SCALABLE_TEXTURE
#6	constant FF_PROFILE_MPEG4_SIMPLE_FACE_ANIMATION
#7	constant FF_PROFILE_MPEG4_BASIC_ANIMATED_TEXTURE
#8	constant FF_PROFILE_MPEG4_HYBRID
#9	constant FF_PROFILE_MPEG4_ADVANCED_REAL_TIME
#10	constant FF_PROFILE_MPEG4_CORE_SCALABLE
#11	constant FF_PROFILE_MPEG4_ADVANCED_CODING
#12	constant FF_PROFILE_MPEG4_ADVANCED_CORE
#13	constant FF_PROFILE_MPEG4_ADVANCED_SCALABLE_TEXTURE
#14	constant FF_PROFILE_MPEG4_SIMPLE_STUDIO
#15	constant FF_PROFILE_MPEG4_ADVANCED_SIMPLE
#1	constant FF_PROFILE_JPEG2000_CSTREAM_RESTRICTION_0
#2	constant FF_PROFILE_JPEG2000_CSTREAM_RESTRICTION_1
#32768	constant FF_PROFILE_JPEG2000_CSTREAM_NO_RESTRICTION
#3	constant FF_PROFILE_JPEG2000_DCINEMA_2K
#4	constant FF_PROFILE_JPEG2000_DCINEMA_4K
#0	constant FF_PROFILE_VP9_0
#1	constant FF_PROFILE_VP9_1
#2	constant FF_PROFILE_VP9_2
#3	constant FF_PROFILE_VP9_3
#1	constant FF_PROFILE_HEVC_MAIN
#2	constant FF_PROFILE_HEVC_MAIN_10
#3	constant FF_PROFILE_HEVC_MAIN_STILL_PICTURE
#4	constant FF_PROFILE_HEVC_REXT
#1	constant FF_PROFILE_VVC_MAIN_10
#33	constant FF_PROFILE_VVC_MAIN_10_444
#0	constant FF_PROFILE_AV1_MAIN
#1	constant FF_PROFILE_AV1_HIGH
#2	constant FF_PROFILE_AV1_PROFESSIONAL
#192	constant FF_PROFILE_MJPEG_HUFFMAN_BASELINE_DCT
#193	constant FF_PROFILE_MJPEG_HUFFMAN_EXTENDED_SEQUENTIAL_DCT
#194	constant FF_PROFILE_MJPEG_HUFFMAN_PROGRESSIVE_DCT
#195	constant FF_PROFILE_MJPEG_HUFFMAN_LOSSLESS
#247	constant FF_PROFILE_MJPEG_JPEG_LS
#1	constant FF_PROFILE_SBC_MSBC
#0	constant FF_PROFILE_PRORES_PROXY
#1	constant FF_PROFILE_PRORES_LT
#2	constant FF_PROFILE_PRORES_STANDARD
#3	constant FF_PROFILE_PRORES_HQ
#4	constant FF_PROFILE_PRORES_4444
#5	constant FF_PROFILE_PRORES_XQ
#0	constant FF_PROFILE_ARIB_PROFILE_A
#1	constant FF_PROFILE_ARIB_PROFILE_C
#0	constant FF_PROFILE_KLVA_SYNC
#1	constant FF_PROFILE_KLVA_ASYNC
#-99	constant FF_LEVEL_UNKNOWN
#-1	constant FF_SUB_CHARENC_MODE_DO_NOTHING
#0	constant FF_SUB_CHARENC_MODE_AUTOMATIC
#1	constant FF_SUB_CHARENC_MODE_PRE_DECODER
#2	constant FF_SUB_CHARENC_MODE_IGNORE
#1	constant FF_CODEC_PROPERTY_LOSSLESS
#2	constant FF_CODEC_PROPERTY_CLOSED_CAPTIONS
#0	constant FF_SUB_TEXT_FMT_ASS
#512	constant AV_HWACCEL_CODEC_CAP_EXPERIMENTAL
#1	constant AV_HWACCEL_FLAG_IGNORE_LEVEL
#2	constant AV_HWACCEL_FLAG_ALLOW_HIGH_DEPTH
#4	constant AV_HWACCEL_FLAG_ALLOW_PROFILE_MISMATCH
#1	constant AV_SUBTITLE_FLAG_FORCED
#4	constant AV_PARSER_PTS_NB
#1	constant PARSER_FLAG_COMPLETE_FRAMES
#2	constant PARSER_FLAG_ONCE
#4	constant PARSER_FLAG_FETCHED_OFFSET
#4096	constant PARSER_FLAG_USE_CODEC_TS
#1024	constant AVPALETTE_SIZE
#256	constant AVPALETTE_COUNT

\ --------===< enums >===---------
#-16	constant AVDISCARD_NONE
#0	constant AVDISCARD_DEFAULT
#8	constant AVDISCARD_NONREF
#16	constant AVDISCARD_BIDIR
#24	constant AVDISCARD_NONINTRA
#32	constant AVDISCARD_NONKEY
#48	constant AVDISCARD_ALL
#0	constant AV_AUDIO_SERVICE_TYPE_MAIN
#1	constant AV_AUDIO_SERVICE_TYPE_EFFECTS
#2	constant AV_AUDIO_SERVICE_TYPE_VISUALLY_IMPAIRED
#3	constant AV_AUDIO_SERVICE_TYPE_HEARING_IMPAIRED
#4	constant AV_AUDIO_SERVICE_TYPE_DIALOGUE
#5	constant AV_AUDIO_SERVICE_TYPE_COMMENTARY
#6	constant AV_AUDIO_SERVICE_TYPE_EMERGENCY
#7	constant AV_AUDIO_SERVICE_TYPE_VOICE_OVER
#8	constant AV_AUDIO_SERVICE_TYPE_KARAOKE
#9	constant AV_AUDIO_SERVICE_TYPE_NB
#0	constant SUBTITLE_NONE
#1	constant SUBTITLE_BITMAP
#2	constant SUBTITLE_TEXT
#3	constant SUBTITLE_ASS
#0	constant AV_PICTURE_STRUCTURE_UNKNOWN
#1	constant AV_PICTURE_STRUCTURE_TOP_FIELD
#2	constant AV_PICTURE_STRUCTURE_BOTTOM_FIELD
#3	constant AV_PICTURE_STRUCTURE_FRAME
#-1	constant AV_PIX_FMT_NONE
#0	constant AV_PIX_FMT_YUV420P
#1	constant AV_PIX_FMT_YUYV422
#2	constant AV_PIX_FMT_RGB24
#3	constant AV_PIX_FMT_BGR24
#4	constant AV_PIX_FMT_YUV422P
#5	constant AV_PIX_FMT_YUV444P
#6	constant AV_PIX_FMT_YUV410P
#7	constant AV_PIX_FMT_YUV411P
#8	constant AV_PIX_FMT_GRAY8
#9	constant AV_PIX_FMT_MONOWHITE
#10	constant AV_PIX_FMT_MONOBLACK
#11	constant AV_PIX_FMT_PAL8
#12	constant AV_PIX_FMT_YUVJ420P
#13	constant AV_PIX_FMT_YUVJ422P
#14	constant AV_PIX_FMT_YUVJ444P
#15	constant AV_PIX_FMT_UYVY422
#16	constant AV_PIX_FMT_UYYVYY411
#17	constant AV_PIX_FMT_BGR8
#18	constant AV_PIX_FMT_BGR4
#19	constant AV_PIX_FMT_BGR4_BYTE
#20	constant AV_PIX_FMT_RGB8
#21	constant AV_PIX_FMT_RGB4
#22	constant AV_PIX_FMT_RGB4_BYTE
#23	constant AV_PIX_FMT_NV12
#24	constant AV_PIX_FMT_NV21
#25	constant AV_PIX_FMT_ARGB
#26	constant AV_PIX_FMT_RGBA
#27	constant AV_PIX_FMT_ABGR
#28	constant AV_PIX_FMT_BGRA
#29	constant AV_PIX_FMT_GRAY16BE
#30	constant AV_PIX_FMT_GRAY16LE
#31	constant AV_PIX_FMT_YUV440P
#32	constant AV_PIX_FMT_YUVJ440P
#33	constant AV_PIX_FMT_YUVA420P
#34	constant AV_PIX_FMT_RGB48BE
#35	constant AV_PIX_FMT_RGB48LE
#36	constant AV_PIX_FMT_RGB565BE
#37	constant AV_PIX_FMT_RGB565LE
#38	constant AV_PIX_FMT_RGB555BE
#39	constant AV_PIX_FMT_RGB555LE
#40	constant AV_PIX_FMT_BGR565BE
#41	constant AV_PIX_FMT_BGR565LE
#42	constant AV_PIX_FMT_BGR555BE
#43	constant AV_PIX_FMT_BGR555LE
#46	constant AV_PIX_FMT_VAAPI
#47	constant AV_PIX_FMT_YUV420P16LE
#48	constant AV_PIX_FMT_YUV420P16BE
#49	constant AV_PIX_FMT_YUV422P16LE
#50	constant AV_PIX_FMT_YUV422P16BE
#51	constant AV_PIX_FMT_YUV444P16LE
#52	constant AV_PIX_FMT_YUV444P16BE
#53	constant AV_PIX_FMT_DXVA2_VLD
#54	constant AV_PIX_FMT_RGB444LE
#55	constant AV_PIX_FMT_RGB444BE
#56	constant AV_PIX_FMT_BGR444LE
#57	constant AV_PIX_FMT_BGR444BE
#58	constant AV_PIX_FMT_YA8
#58	constant AV_PIX_FMT_Y400A
#58	constant AV_PIX_FMT_GRAY8A
#59	constant AV_PIX_FMT_BGR48BE
#60	constant AV_PIX_FMT_BGR48LE
#61	constant AV_PIX_FMT_YUV420P9BE
#62	constant AV_PIX_FMT_YUV420P9LE
#63	constant AV_PIX_FMT_YUV420P10BE
#64	constant AV_PIX_FMT_YUV420P10LE
#65	constant AV_PIX_FMT_YUV422P10BE
#66	constant AV_PIX_FMT_YUV422P10LE
#67	constant AV_PIX_FMT_YUV444P9BE
#68	constant AV_PIX_FMT_YUV444P9LE
#69	constant AV_PIX_FMT_YUV444P10BE
#70	constant AV_PIX_FMT_YUV444P10LE
#71	constant AV_PIX_FMT_YUV422P9BE
#72	constant AV_PIX_FMT_YUV422P9LE
#73	constant AV_PIX_FMT_GBRP
#73	constant AV_PIX_FMT_GBR24P
#74	constant AV_PIX_FMT_GBRP9BE
#75	constant AV_PIX_FMT_GBRP9LE
#76	constant AV_PIX_FMT_GBRP10BE
#77	constant AV_PIX_FMT_GBRP10LE
#78	constant AV_PIX_FMT_GBRP16BE
#79	constant AV_PIX_FMT_GBRP16LE
#80	constant AV_PIX_FMT_YUVA422P
#81	constant AV_PIX_FMT_YUVA444P
#82	constant AV_PIX_FMT_YUVA420P9BE
#83	constant AV_PIX_FMT_YUVA420P9LE
#84	constant AV_PIX_FMT_YUVA422P9BE
#85	constant AV_PIX_FMT_YUVA422P9LE
#86	constant AV_PIX_FMT_YUVA444P9BE
#87	constant AV_PIX_FMT_YUVA444P9LE
#88	constant AV_PIX_FMT_YUVA420P10BE
#89	constant AV_PIX_FMT_YUVA420P10LE
#90	constant AV_PIX_FMT_YUVA422P10BE
#91	constant AV_PIX_FMT_YUVA422P10LE
#92	constant AV_PIX_FMT_YUVA444P10BE
#93	constant AV_PIX_FMT_YUVA444P10LE
#94	constant AV_PIX_FMT_YUVA420P16BE
#95	constant AV_PIX_FMT_YUVA420P16LE
#96	constant AV_PIX_FMT_YUVA422P16BE
#97	constant AV_PIX_FMT_YUVA422P16LE
#98	constant AV_PIX_FMT_YUVA444P16BE
#99	constant AV_PIX_FMT_YUVA444P16LE
#100	constant AV_PIX_FMT_VDPAU
#101	constant AV_PIX_FMT_XYZ12LE
#102	constant AV_PIX_FMT_XYZ12BE
#103	constant AV_PIX_FMT_NV16
#104	constant AV_PIX_FMT_NV20LE
#105	constant AV_PIX_FMT_NV20BE
#106	constant AV_PIX_FMT_RGBA64BE
#107	constant AV_PIX_FMT_RGBA64LE
#108	constant AV_PIX_FMT_BGRA64BE
#109	constant AV_PIX_FMT_BGRA64LE
#110	constant AV_PIX_FMT_YVYU422
#111	constant AV_PIX_FMT_YA16BE
#112	constant AV_PIX_FMT_YA16LE
#113	constant AV_PIX_FMT_GBRAP
#114	constant AV_PIX_FMT_GBRAP16BE
#115	constant AV_PIX_FMT_GBRAP16LE
#116	constant AV_PIX_FMT_QSV
#117	constant AV_PIX_FMT_MMAL
#118	constant AV_PIX_FMT_D3D11VA_VLD
#119	constant AV_PIX_FMT_CUDA
#120	constant AV_PIX_FMT_0RGB
#121	constant AV_PIX_FMT_RGB0
#122	constant AV_PIX_FMT_0BGR
#123	constant AV_PIX_FMT_BGR0
#124	constant AV_PIX_FMT_YUV420P12BE
#125	constant AV_PIX_FMT_YUV420P12LE
#126	constant AV_PIX_FMT_YUV420P14BE
#127	constant AV_PIX_FMT_YUV420P14LE
#128	constant AV_PIX_FMT_YUV422P12BE
#129	constant AV_PIX_FMT_YUV422P12LE
#130	constant AV_PIX_FMT_YUV422P14BE
#131	constant AV_PIX_FMT_YUV422P14LE
#132	constant AV_PIX_FMT_YUV444P12BE
#133	constant AV_PIX_FMT_YUV444P12LE
#134	constant AV_PIX_FMT_YUV444P14BE
#135	constant AV_PIX_FMT_YUV444P14LE
#136	constant AV_PIX_FMT_GBRP12BE
#137	constant AV_PIX_FMT_GBRP12LE
#138	constant AV_PIX_FMT_GBRP14BE
#139	constant AV_PIX_FMT_GBRP14LE
#140	constant AV_PIX_FMT_YUVJ411P
#141	constant AV_PIX_FMT_BAYER_BGGR8
#142	constant AV_PIX_FMT_BAYER_RGGB8
#143	constant AV_PIX_FMT_BAYER_GBRG8
#144	constant AV_PIX_FMT_BAYER_GRBG8
#145	constant AV_PIX_FMT_BAYER_BGGR16LE
#146	constant AV_PIX_FMT_BAYER_BGGR16BE
#147	constant AV_PIX_FMT_BAYER_RGGB16LE
#148	constant AV_PIX_FMT_BAYER_RGGB16BE
#149	constant AV_PIX_FMT_BAYER_GBRG16LE
#150	constant AV_PIX_FMT_BAYER_GBRG16BE
#151	constant AV_PIX_FMT_BAYER_GRBG16LE
#152	constant AV_PIX_FMT_BAYER_GRBG16BE
#153	constant AV_PIX_FMT_XVMC
#154	constant AV_PIX_FMT_YUV440P10LE
#155	constant AV_PIX_FMT_YUV440P10BE
#156	constant AV_PIX_FMT_YUV440P12LE
#157	constant AV_PIX_FMT_YUV440P12BE
#158	constant AV_PIX_FMT_AYUV64LE
#159	constant AV_PIX_FMT_AYUV64BE
#160	constant AV_PIX_FMT_VIDEOTOOLBOX
#161	constant AV_PIX_FMT_P010LE
#162	constant AV_PIX_FMT_P010BE
#163	constant AV_PIX_FMT_GBRAP12BE
#164	constant AV_PIX_FMT_GBRAP12LE
#165	constant AV_PIX_FMT_GBRAP10BE
#166	constant AV_PIX_FMT_GBRAP10LE
#167	constant AV_PIX_FMT_MEDIACODEC
#168	constant AV_PIX_FMT_GRAY12BE
#169	constant AV_PIX_FMT_GRAY12LE
#170	constant AV_PIX_FMT_GRAY10BE
#171	constant AV_PIX_FMT_GRAY10LE
#172	constant AV_PIX_FMT_P016LE
#173	constant AV_PIX_FMT_P016BE
#174	constant AV_PIX_FMT_D3D11
#175	constant AV_PIX_FMT_GRAY9BE
#176	constant AV_PIX_FMT_GRAY9LE
#177	constant AV_PIX_FMT_GBRPF32BE
#178	constant AV_PIX_FMT_GBRPF32LE
#179	constant AV_PIX_FMT_GBRAPF32BE
#180	constant AV_PIX_FMT_GBRAPF32LE
#181	constant AV_PIX_FMT_DRM_PRIME
#182	constant AV_PIX_FMT_OPENCL
#183	constant AV_PIX_FMT_GRAY14BE
#184	constant AV_PIX_FMT_GRAY14LE
#185	constant AV_PIX_FMT_GRAYF32BE
#186	constant AV_PIX_FMT_GRAYF32LE
#187	constant AV_PIX_FMT_YUVA422P12BE
#188	constant AV_PIX_FMT_YUVA422P12LE
#189	constant AV_PIX_FMT_YUVA444P12BE
#190	constant AV_PIX_FMT_YUVA444P12LE
#191	constant AV_PIX_FMT_NV24
#192	constant AV_PIX_FMT_NV42
#193	constant AV_PIX_FMT_VULKAN
#194	constant AV_PIX_FMT_Y210BE
#195	constant AV_PIX_FMT_Y210LE
#196	constant AV_PIX_FMT_X2RGB10LE
#197	constant AV_PIX_FMT_X2RGB10BE
#198	constant AV_PIX_FMT_NB
#0	constant AVCOL_PRI_RESERVED0
#1	constant AVCOL_PRI_BT709
#2	constant AVCOL_PRI_UNSPECIFIED
#3	constant AVCOL_PRI_RESERVED
#4	constant AVCOL_PRI_BT470M
#5	constant AVCOL_PRI_BT470BG
#6	constant AVCOL_PRI_SMPTE170M
#7	constant AVCOL_PRI_SMPTE240M
#8	constant AVCOL_PRI_FILM
#9	constant AVCOL_PRI_BT2020
#10	constant AVCOL_PRI_SMPTE428
#10	constant AVCOL_PRI_SMPTEST428_1
#11	constant AVCOL_PRI_SMPTE431
#12	constant AVCOL_PRI_SMPTE432
#22	constant AVCOL_PRI_EBU3213
#22	constant AVCOL_PRI_JEDEC_P22
#23	constant AVCOL_PRI_NB
#0	constant AVCOL_TRC_RESERVED0
#1	constant AVCOL_TRC_BT709
#2	constant AVCOL_TRC_UNSPECIFIED
#3	constant AVCOL_TRC_RESERVED
#4	constant AVCOL_TRC_GAMMA22
#5	constant AVCOL_TRC_GAMMA28
#6	constant AVCOL_TRC_SMPTE170M
#7	constant AVCOL_TRC_SMPTE240M
#8	constant AVCOL_TRC_LINEAR
#9	constant AVCOL_TRC_LOG
#10	constant AVCOL_TRC_LOG_SQRT
#11	constant AVCOL_TRC_IEC61966_2_4
#12	constant AVCOL_TRC_BT1361_ECG
#13	constant AVCOL_TRC_IEC61966_2_1
#14	constant AVCOL_TRC_BT2020_10
#15	constant AVCOL_TRC_BT2020_12
#16	constant AVCOL_TRC_SMPTE2084
#16	constant AVCOL_TRC_SMPTEST2084
#17	constant AVCOL_TRC_SMPTE428
#17	constant AVCOL_TRC_SMPTEST428_1
#18	constant AVCOL_TRC_ARIB_STD_B67
#19	constant AVCOL_TRC_NB
#0	constant AVCOL_SPC_RGB
#1	constant AVCOL_SPC_BT709
#2	constant AVCOL_SPC_UNSPECIFIED
#3	constant AVCOL_SPC_RESERVED
#4	constant AVCOL_SPC_FCC
#5	constant AVCOL_SPC_BT470BG
#6	constant AVCOL_SPC_SMPTE170M
#7	constant AVCOL_SPC_SMPTE240M
#8	constant AVCOL_SPC_YCGCO
#8	constant AVCOL_SPC_YCOCG
#9	constant AVCOL_SPC_BT2020_NCL
#10	constant AVCOL_SPC_BT2020_CL
#11	constant AVCOL_SPC_SMPTE2085
#12	constant AVCOL_SPC_CHROMA_DERIVED_NCL
#13	constant AVCOL_SPC_CHROMA_DERIVED_CL
#14	constant AVCOL_SPC_ICTCP
#15	constant AVCOL_SPC_NB
#0	constant AVCOL_RANGE_UNSPECIFIED
#1	constant AVCOL_RANGE_MPEG
#2	constant AVCOL_RANGE_JPEG
#3	constant AVCOL_RANGE_NB
#0	constant AVCHROMA_LOC_UNSPECIFIED
#1	constant AVCHROMA_LOC_LEFT
#2	constant AVCHROMA_LOC_CENTER
#3	constant AVCHROMA_LOC_TOPLEFT
#4	constant AVCHROMA_LOC_TOP
#5	constant AVCHROMA_LOC_BOTTOMLEFT
#6	constant AVCHROMA_LOC_BOTTOM
#7	constant AVCHROMA_LOC_NB

\ -------===< structs >===--------
\ RcOverride
begin-structure RcOverride
	drop 12 4 +field RcOverride-quality_factor
	drop 8 4 +field RcOverride-qscale
	drop 0 4 +field RcOverride-start_frame
	drop 4 4 +field RcOverride-end_frame
drop 16 end-structure
\ AVPanScan
begin-structure AVPanScan
	drop 12 12 +field AVPanScan-position
	drop 0 4 +field AVPanScan-id
	drop 8 4 +field AVPanScan-height
	drop 4 4 +field AVPanScan-width
drop 24 end-structure
\ AVCPBProperties
begin-structure AVCPBProperties
	drop 12 4 +field AVCPBProperties-buffer_size
	drop 16 8 +field AVCPBProperties-vbv_delay
	drop 0 8 +field AVCPBProperties-max_bitrate
	drop 4 8 +field AVCPBProperties-min_bitrate
	drop 8 8 +field AVCPBProperties-avg_bitrate
drop 24 end-structure
\ AVProducerReferenceTime
begin-structure AVProducerReferenceTime
	drop 0 8 +field AVProducerReferenceTime-wallclock
	drop 8 4 +field AVProducerReferenceTime-flags
drop 16 end-structure
\ AVCodecContext
begin-structure AVCodecContext
	drop 640 4 +field AVCodecContext-workaround_bugs
	drop 120 4 +field AVCodecContext-height
	drop 480 4 +field AVCodecContext-qmax
	drop 484 4 +field AVCodecContext-max_qdiff
	drop 816 4 +field AVCodecContext-nsse_weight
	drop 624 8 +field AVCodecContext-stats_out
	drop 452 4 +field AVCodecContext-request_sample_fmt
	drop 408 4 +field AVCodecContext-sample_fmt
	drop 412 4 +field AVCodecContext-frame_size
	drop 632 8 +field AVCodecContext-stats_in
	drop 884 8 +field AVCodecContext-pkt_timebase
	drop 472 4 +field AVCodecContext-qblur
	drop 820 4 +field AVCodecContext-profile
	drop 388 4 +field AVCodecContext-chroma_sample_location
	drop 32 8 +field AVCodecContext-priv_data
	drop 828 4 +field AVCodecContext-skip_loop_filter
\ 	drop 1072 8 +field AVCodecContext-get_encode_buffer
	drop 416 4 +field AVCodecContext-frame_number
	drop 896 8 +field AVCodecContext-codec_descriptor
	drop 380 4 +field AVCodecContext-colorspace
	drop 904 8 +field AVCodecContext-pts_correction_num_faulty_pts
	drop 840 8 +field AVCodecContext-subtitle_header
	drop 64 4 +field AVCodecContext-bit_rate_tolerance
	drop 252 4 +field AVCodecContext-ildct_cmp
	drop 792 4 +field AVCodecContext-active_thread_type
	drop 788 4 +field AVCodecContext-thread_type
	drop 372 4 +field AVCodecContext-color_primaries
	drop 456 8 +field AVCodecContext-get_buffer2
	drop 644 4 +field AVCodecContext-strict_std_compliance
	drop 16 8 +field AVCodecContext-codec
	drop 524 4 +field AVCodecContext-rc_min_vbv_overflow_use
	drop 512 8 +field AVCodecContext-rc_min_rate
	drop 1064 4 +field AVCodecContext-export_side_data
	drop 1000 4 +field AVCodecContext-nb_coded_side_data
	drop 992 8 +field AVCodecContext-coded_side_data
	drop 672 8 +field AVCodecContext-hwaccel
	drop 928 8 +field AVCodecContext-pts_correction_last_dts
	drop 1008 8 +field AVCodecContext-hw_frames_ctx
	drop 688 64 +field AVCodecContext-error
	drop 68 4 +field AVCodecContext-global_quality
	drop 276 4 +field AVCodecContext-me_subpel_quality
	drop 404 4 +field AVCodecContext-channels
	drop 284 4 +field AVCodecContext-slice_flags
	drop 280 4 +field AVCodecContext-me_range
	drop 848 4 +field AVCodecContext-subtitle_header_size
	drop 488 4 +field AVCodecContext-rc_buffer_size
	drop 504 8 +field AVCodecContext-rc_max_rate
	drop 952 4 +field AVCodecContext-seek_preroll
	drop 256 4 +field AVCodecContext-dia_size
	drop 272 4 +field AVCodecContext-pre_dia_size
	drop 768 4 +field AVCodecContext-lowres
	drop 124 4 +field AVCodecContext-coded_width
	drop 188 4 +field AVCodecContext-i_quant_offset
	drop 172 4 +field AVCodecContext-b_quant_offset
	drop 8 4 +field AVCodecContext-log_level_offset
	drop 224 8 +field AVCodecContext-slice_offset
	drop 832 4 +field AVCodecContext-skip_idct
	drop 364 4 +field AVCodecContext-mv0_threshold
	drop 332 4 +field AVCodecContext-mb_lmin
	drop 1016 4 +field AVCodecContext-sub_text_format
	drop 152 8 +field AVCodecContext-get_format
	drop 192 4 +field AVCodecContext-lumi_masking
	drop 196 4 +field AVCodecContext-temporal_cplx_masking
	drop 200 4 +field AVCodecContext-spatial_cplx_masking
	drop 204 4 +field AVCodecContext-p_masking
	drop 208 4 +field AVCodecContext-dark_masking
	drop 800 8 +field AVCodecContext-execute
	drop 880 4 +field AVCodecContext-sw_pix_fmt
	drop 136 4 +field AVCodecContext-pix_fmt
	drop 680 8 +field AVCodecContext-hwaccel_context
	drop 1040 4 +field AVCodecContext-hwaccel_flags
	drop 656 4 +field AVCodecContext-err_recognition
	drop 496 8 +field AVCodecContext-rc_override
	drop 492 4 +field AVCodecContext-rc_override_count
	drop 212 4 +field AVCodecContext-slice_count
	drop 384 4 +field AVCodecContext-color_range
	drop 652 4 +field AVCodecContext-debug
	drop 476 4 +field AVCodecContext-qmin
	drop 344 4 +field AVCodecContext-bidir_refine
	drop 112 4 +field AVCodecContext-delay
	drop 144 8 +field AVCodecContext-draw_horiz_band
	drop 328 4 +field AVCodecContext-skip_bottom
	drop 96 4 +field AVCodecContext-extradata_size
	drop 1044 4 +field AVCodecContext-apply_cropping
	drop 664 8 +field AVCodecContext-reordered_opaque
	drop 944 4 +field AVCodecContext-sub_charenc_mode
	drop 80 4 +field AVCodecContext-flags2
	drop 132 4 +field AVCodecContext-gop_size
	drop 468 4 +field AVCodecContext-qcompress
	drop 240 4 +field AVCodecContext-me_cmp
	drop 648 4 +field AVCodecContext-error_concealment
	drop 88 8 +field AVCodecContext-extradata
	drop 352 4 +field AVCodecContext-keyint_min
	drop 976 8 +field AVCodecContext-codec_whitelist
	drop 448 4 +field AVCodecContext-audio_service_type
	drop 248 4 +field AVCodecContext-mb_cmp
	drop 268 4 +field AVCodecContext-me_pre_cmp
	drop 1048 4 +field AVCodecContext-extra_hw_frames
	drop 176 4 +field AVCodecContext-has_b_frames
	drop 160 4 +field AVCodecContext-max_b_frames
	drop 960 8 +field AVCodecContext-chroma_intra_matrix
	drop 296 8 +field AVCodecContext-intra_matrix
	drop 304 8 +field AVCodecContext-inter_matrix
	drop 72 4 +field AVCodecContext-compression_level
	drop 420 4 +field AVCodecContext-block_align
	drop 784 4 +field AVCodecContext-thread_count
	drop 260 4 +field AVCodecContext-last_predictor_count
	drop 232 8 +field AVCodecContext-sample_aspect_ratio
	drop 1020 4 +field AVCodecContext-trailing_padding
	drop 868 4 +field AVCodecContext-initial_padding
	drop 116 4 +field AVCodecContext-width
	drop 968 8 +field AVCodecContext-dump_separator
	drop 392 4 +field AVCodecContext-slices
	drop 920 8 +field AVCodecContext-pts_correction_last_pts
	drop 936 8 +field AVCodecContext-sub_charenc
	drop 28 4 +field AVCodecContext-codec_tag
	drop 48 8 +field AVCodecContext-opaque
	drop 400 4 +field AVCodecContext-sample_rate
	drop 356 4 +field AVCodecContext-refs
	drop 76 4 +field AVCodecContext-flags
	drop 1024 8 +field AVCodecContext-max_pixels
	drop 56 8 +field AVCodecContext-bit_rate
	drop 1032 8 +field AVCodecContext-hw_device_ctx
	drop 872 8 +field AVCodecContext-framerate
	drop 836 4 +field AVCodecContext-skip_frame
	drop 108 4 +field AVCodecContext-ticks_per_frame
	drop 912 8 +field AVCodecContext-pts_correction_num_faulty_dts
	drop 40 8 +field AVCodecContext-internal
	drop 528 4 +field AVCodecContext-rc_initial_buffer_occupancy
	drop 424 4 +field AVCodecContext-cutoff
	drop 324 4 +field AVCodecContext-skip_top
	drop 244 4 +field AVCodecContext-me_sub_cmp
	drop 12 4 +field AVCodecContext-codec_type
	drop 764 4 +field AVCodecContext-bits_per_raw_sample
	drop 760 4 +field AVCodecContext-bits_per_coded_sample
	drop 556 4 +field AVCodecContext-trellis
	drop 1052 4 +field AVCodecContext-discard_damaged_percentage
	drop 756 4 +field AVCodecContext-idct_algo
	drop 752 4 +field AVCodecContext-dct_algo
	drop 984 4 +field AVCodecContext-properties
	drop 128 4 +field AVCodecContext-coded_height
	drop 808 8 +field AVCodecContext-execute2
	drop 1056 8 +field AVCodecContext-max_samples
	drop 24 4 +field AVCodecContext-codec_id
	drop 376 4 +field AVCodecContext-color_trc
	drop 440 8 +field AVCodecContext-request_channel_layout
	drop 432 8 +field AVCodecContext-channel_layout
	drop 100 8 +field AVCodecContext-time_base
	drop 948 4 +field AVCodecContext-skip_alpha
	drop 0 8 +field AVCodecContext-av_class
	drop 824 4 +field AVCodecContext-level
	drop 336 4 +field AVCodecContext-mb_lmax
	drop 288 4 +field AVCodecContext-mb_decision
	drop 320 4 +field AVCodecContext-intra_dc_precision
	drop 520 4 +field AVCodecContext-rc_max_available_vbv_use
	drop 396 4 +field AVCodecContext-field_order
	drop 184 4 +field AVCodecContext-i_quant_factor
	drop 164 4 +field AVCodecContext-b_quant_factor
drop 1080 end-structure
\ AVHWAccel
begin-structure AVHWAccel
	drop 16 4 +field AVHWAccel-pix_fmt
	drop 24 8 +field AVHWAccel-alloc_frame
	drop 0 8 +field AVHWAccel-name
	drop 20 4 +field AVHWAccel-capabilities
	drop 48 8 +field AVHWAccel-decode_slice
	drop 40 8 +field AVHWAccel-decode_params
	drop 104 8 +field AVHWAccel-frame_params
	drop 100 4 +field AVHWAccel-caps_internal
	drop 64 4 +field AVHWAccel-frame_priv_data_size
	drop 96 4 +field AVHWAccel-priv_data_size
	drop 12 4 +field AVHWAccel-id
	drop 8 4 +field AVHWAccel-type
	drop 72 8 +field AVHWAccel-decode_mb
	drop 88 8 +field AVHWAccel-uninit
	drop 56 8 +field AVHWAccel-end_frame
	drop 32 8 +field AVHWAccel-start_frame
	drop 80 8 +field AVHWAccel-init
drop 112 end-structure
\ AVSubtitleRect
begin-structure AVSubtitleRect
	drop 8 4 +field AVSubtitleRect-w
	drop 16 4 +field AVSubtitleRect-nb_colors
	drop 0 4 +field AVSubtitleRect-x
	drop 120 32 +field AVSubtitleRect-data
	drop 4 4 +field AVSubtitleRect-y
	drop 152 16 +field AVSubtitleRect-linesize
	drop 168 4 +field AVSubtitleRect-type
	drop 176 8 +field AVSubtitleRect-text
	drop 192 4 +field AVSubtitleRect-flags
	drop 12 4 +field AVSubtitleRect-h
	drop 184 8 +field AVSubtitleRect-ass
drop 200 end-structure
\ AVSubtitle
begin-structure AVSubtitle
	drop 12 4 +field AVSubtitle-num_rects
	drop 16 8 +field AVSubtitle-rects
	drop 0 2 +field AVSubtitle-format
	drop 4 4 +field AVSubtitle-start_display_time
	drop 8 4 +field AVSubtitle-end_display_time
	drop 24 8 +field AVSubtitle-pts
drop 32 end-structure
\ AVCodecParserContext
begin-structure AVCodecParserContext
	drop 56 8 +field AVCodecParserContext-dts
	drop 40 4 +field AVCodecParserContext-pict_type
	drop 344 4 +field AVCodecParserContext-format
	drop 328 4 +field AVCodecParserContext-width
	drop 48 8 +field AVCodecParserContext-pts
	drop 152 32 +field AVCodecParserContext-cur_frame_dts
	drop 80 4 +field AVCodecParserContext-fetch_timestamp
	drop 200 32 +field AVCodecParserContext-cur_frame_end
	drop 312 4 +field AVCodecParserContext-duration
	drop 0 8 +field AVCodecParserContext-priv_data
	drop 120 32 +field AVCodecParserContext-cur_frame_pts
	drop 324 4 +field AVCodecParserContext-output_picture_number
	drop 256 4 +field AVCodecParserContext-pts_dts_delta
	drop 252 4 +field AVCodecParserContext-dts_ref_dts_delta
	drop 340 4 +field AVCodecParserContext-coded_height
	drop 320 4 +field AVCodecParserContext-picture_structure
	drop 8 8 +field AVCodecParserContext-parser
	drop 304 8 +field AVCodecParserContext-last_pos
	drop 248 4 +field AVCodecParserContext-dts_sync_point
	drop 316 4 +field AVCodecParserContext-field_order
	drop 332 4 +field AVCodecParserContext-height
	drop 16 8 +field AVCodecParserContext-frame_offset
	drop 24 8 +field AVCodecParserContext-cur_offset
	drop 32 8 +field AVCodecParserContext-next_frame_offset
	drop 88 32 +field AVCodecParserContext-cur_frame_offset
	drop 72 8 +field AVCodecParserContext-last_dts
	drop 296 8 +field AVCodecParserContext-pos
	drop 184 4 +field AVCodecParserContext-flags
	drop 232 4 +field AVCodecParserContext-key_frame
	drop 44 4 +field AVCodecParserContext-repeat_pict
	drop 336 4 +field AVCodecParserContext-coded_width
	drop 64 8 +field AVCodecParserContext-last_pts
	drop 264 32 +field AVCodecParserContext-cur_frame_pos
	drop 84 4 +field AVCodecParserContext-cur_frame_start_index
	drop 192 8 +field AVCodecParserContext-offset
drop 352 end-structure
\ AVCodecParser
begin-structure AVCodecParser
	drop 48 8 +field AVCodecParser-split
	drop 0 20 +field AVCodecParser-codec_ids
	drop 20 4 +field AVCodecParser-priv_data_size
	drop 24 8 +field AVCodecParser-parser_init
	drop 32 8 +field AVCodecParser-parser_parse
	drop 40 8 +field AVCodecParser-parser_close
drop 64 end-structure

\ --===< function pointers >===---
c-funptr AVCodecContext-draw_horiz_band() {((struct AVCodecContext*)ptr)->draw_horiz_band} a a a n n n -- void	( s src offset y type height -- )
c-funptr AVCodecContext-get_format() {((struct AVCodecContext*)ptr)->get_format} a a -- n	( s fmt -- )
c-funptr AVCodecContext-get_buffer2() {((struct AVCodecContext*)ptr)->get_buffer2} a a n -- n	( s frame flags -- )
c-funptr AVCodecContext-execute() {((struct AVCodecContext*)ptr)->execute} a a a a n n -- n	( c func arg2 ret count size -- )
c-funptr AVCodecContext-execute2() {((struct AVCodecContext*)ptr)->execute2} a a a a n -- n	( c func arg2 ret count -- )
\ c-funptr AVCodecContext-get_encode_buffer() {((struct AVCodecContext*)ptr)->get_encode_buffer} a a n -- n	( s pkt flags -- )
c-funptr AVHWAccel-alloc_frame() {((struct AVHWAccel*)ptr)->alloc_frame} a a -- n	( avctx frame -- )
c-funptr AVHWAccel-start_frame() {((struct AVHWAccel*)ptr)->start_frame} a a n -- n	( avctx buf buf_size -- )
c-funptr AVHWAccel-decode_params() {((struct AVHWAccel*)ptr)->decode_params} a n a n -- n	( avctx type buf buf_size -- )
c-funptr AVHWAccel-decode_slice() {((struct AVHWAccel*)ptr)->decode_slice} a a n -- n	( avctx buf buf_size -- )
c-funptr AVHWAccel-end_frame() {((struct AVHWAccel*)ptr)->end_frame} a -- n	( avctx -- )
c-funptr AVHWAccel-decode_mb() {((struct AVHWAccel*)ptr)->decode_mb} a -- void	( s -- )
c-funptr AVHWAccel-init() {((struct AVHWAccel*)ptr)->init} a -- n	( avctx -- )
c-funptr AVHWAccel-uninit() {((struct AVHWAccel*)ptr)->uninit} a -- n	( avctx -- )
c-funptr AVHWAccel-frame_params() {((struct AVHWAccel*)ptr)->frame_params} a a -- n	( avctx hw_frames_ctx -- )
c-funptr AVCodecParser-parser_init() {((struct AVCodecParser*)ptr)->parser_init} a -- n	( s -- )
c-funptr AVCodecParser-parser_parse() {((struct AVCodecParser*)ptr)->parser_parse} a a a a a n -- n	( s avctx poutbuf poutbuf_size buf buf_size -- )
c-funptr AVCodecParser-parser_close() {((struct AVCodecParser*)ptr)->parser_close} a -- void	( s -- )
c-funptr AVCodecParser-split() {((struct AVCodecParser*)ptr)->split} a a n -- n	( avctx buf buf_size -- )

\ ------===< functions >===-------
c-function avcodec_version avcodec_version  -- u	( -- )
c-function avcodec_configuration avcodec_configuration  -- s	( -- )
c-function avcodec_license avcodec_license  -- s	( -- )
c-function avcodec_alloc_context3 avcodec_alloc_context3 a -- a	( codec -- )
c-function avcodec_free_context avcodec_free_context a -- void	( avctx -- )
c-function avcodec_get_class avcodec_get_class  -- a	( -- )
c-function avcodec_get_subtitle_rect_class avcodec_get_subtitle_rect_class  -- a	( -- )
c-function avcodec_parameters_from_context avcodec_parameters_from_context a a -- n	( par codec -- )
c-function avcodec_parameters_to_context avcodec_parameters_to_context a a -- n	( codec par -- )
c-function avcodec_open2 avcodec_open2 a a a -- n	( avctx codec options -- )
c-function avcodec_close avcodec_close a -- n	( avctx -- )
c-function avsubtitle_free avsubtitle_free a -- void	( sub -- )
c-function avcodec_default_get_buffer2 avcodec_default_get_buffer2 a a n -- n	( s frame flags -- )
\ c-function avcodec_default_get_encode_buffer avcodec_default_get_encode_buffer a a n -- n	( s pkt flags -- )
c-function avcodec_align_dimensions avcodec_align_dimensions a a a -- void	( s width height -- )
c-function avcodec_align_dimensions2 avcodec_align_dimensions2 a a a a -- void	( s width height linesize_align -- )
c-function avcodec_enum_to_chroma_pos avcodec_enum_to_chroma_pos a a n -- n	( xpos ypos pos -- )
c-function avcodec_chroma_pos_to_enum avcodec_chroma_pos_to_enum n n -- n	( xpos ypos -- )
c-function avcodec_decode_subtitle2 avcodec_decode_subtitle2 a a a a -- n	( avctx sub got_sub_ptr avpkt -- )
c-function avcodec_send_packet avcodec_send_packet a a -- n	( avctx avpkt -- )
c-function avcodec_receive_frame avcodec_receive_frame a a -- n	( avctx frame -- )
c-function avcodec_send_frame avcodec_send_frame a a -- n	( avctx frame -- )
c-function avcodec_receive_packet avcodec_receive_packet a a -- n	( avctx avpkt -- )
c-function avcodec_get_hw_frames_parameters avcodec_get_hw_frames_parameters a a n a -- n	( avctx device_ref hw_pix_fmt out_frames_ref -- )
c-function av_parser_iterate av_parser_iterate a -- a	( opaque -- )
c-function av_parser_init av_parser_init n -- a	( codec_id -- )
c-function av_parser_parse2 av_parser_parse2 a a a a a n n n n -- n	( s avctx poutbuf poutbuf_size buf buf_size pts dts pos -- )
c-function av_parser_close av_parser_close a -- void	( s -- )
c-function avcodec_encode_subtitle avcodec_encode_subtitle a a n a -- n	( avctx buf buf_size sub -- )
c-function avcodec_pix_fmt_to_codec_tag avcodec_pix_fmt_to_codec_tag n -- u	( pix_fmt -- )
c-function avcodec_find_best_pix_fmt_of_list avcodec_find_best_pix_fmt_of_list a n n a -- n	( pix_fmt_list src_pix_fmt has_alpha loss_ptr -- )
c-function avcodec_default_get_format avcodec_default_get_format a a -- n	( s fmt -- )
c-function avcodec_string avcodec_string a n a n -- void	( buf buf_size enc encode -- )
c-function av_get_profile_name av_get_profile_name a n -- s	( codec profile -- )
c-function avcodec_profile_name avcodec_profile_name n n -- s	( codec_id profile -- )
c-function avcodec_default_execute avcodec_default_execute a a a a n n -- n	( c func arg ret count size -- )
c-function avcodec_default_execute2 avcodec_default_execute2 a a a a n -- n	( c func arg ret count -- )
c-function avcodec_fill_audio_frame avcodec_fill_audio_frame a n n a n n -- n	( frame nb_channels sample_fmt buf buf_size align -- )
c-function avcodec_flush_buffers avcodec_flush_buffers a -- void	( avctx -- )
c-function av_get_bits_per_sample av_get_bits_per_sample n -- n	( codec_id -- )
c-function av_get_pcm_codec av_get_pcm_codec n n -- n	( fmt be -- )
c-function av_get_exact_bits_per_sample av_get_exact_bits_per_sample n -- n	( codec_id -- )
c-function av_get_audio_frame_duration av_get_audio_frame_duration a n -- n	( avctx frame_bytes -- )
c-function av_get_audio_frame_duration2 av_get_audio_frame_duration2 a n -- n	( par frame_bytes -- )
c-function av_fast_padded_malloc av_fast_padded_malloc a a n -- void	( ptr size min_size -- )
c-function av_fast_padded_mallocz av_fast_padded_mallocz a a n -- void	( ptr size min_size -- )
c-function av_xiphlacing av_xiphlacing a u -- u	( s v -- )
c-function avcodec_is_open avcodec_is_open a -- n	( s -- )
c-function av_cpb_properties_alloc av_cpb_properties_alloc a -- a	( size -- )

\ ----===< postfix >===-----
end-c-library
