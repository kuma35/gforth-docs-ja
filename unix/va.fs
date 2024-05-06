\ This file has been generated using SWIG and fsi,
\ and is already platform dependent, search for the corresponding
\ fsi-file to compile it where no one has compiled it before ;)
\ Forth systems have their own own dynamic loader and don't need addional C-Code.
\ That's why this file will just print normal forth-code once compiled
\ and can be used directly with include or require.
\ As all comments are stripped during the compilation, please
\ insert the copyright notice of the original file here.

\ ----===< prefix >===-----
cs-vocabulary va

get-current also va definitions

c-library va
s" va" add-lib
s" ((struct VAD:x.spx[arg0]" ptr-declare $+[]!
\c #include <va/va.h>
\c #include <va/va_vpp.h>
\c #include <va/va_backend.h>

\ ----===< int constants >===-----
#0	constant VA_STATUS_SUCCESS
#1	constant VA_STATUS_ERROR_OPERATION_FAILED
#2	constant VA_STATUS_ERROR_ALLOCATION_FAILED
#3	constant VA_STATUS_ERROR_INVALID_DISPLAY
#4	constant VA_STATUS_ERROR_INVALID_CONFIG
#5	constant VA_STATUS_ERROR_INVALID_CONTEXT
#6	constant VA_STATUS_ERROR_INVALID_SURFACE
#7	constant VA_STATUS_ERROR_INVALID_BUFFER
#8	constant VA_STATUS_ERROR_INVALID_IMAGE
#9	constant VA_STATUS_ERROR_INVALID_SUBPICTURE
#10	constant VA_STATUS_ERROR_ATTR_NOT_SUPPORTED
#11	constant VA_STATUS_ERROR_MAX_NUM_EXCEEDED
#12	constant VA_STATUS_ERROR_UNSUPPORTED_PROFILE
#13	constant VA_STATUS_ERROR_UNSUPPORTED_ENTRYPOINT
#14	constant VA_STATUS_ERROR_UNSUPPORTED_RT_FORMAT
#15	constant VA_STATUS_ERROR_UNSUPPORTED_BUFFERTYPE
#16	constant VA_STATUS_ERROR_SURFACE_BUSY
#17	constant VA_STATUS_ERROR_FLAG_NOT_SUPPORTED
#18	constant VA_STATUS_ERROR_INVALID_PARAMETER
#19	constant VA_STATUS_ERROR_RESOLUTION_NOT_SUPPORTED
#20	constant VA_STATUS_ERROR_UNIMPLEMENTED
#21	constant VA_STATUS_ERROR_SURFACE_IN_DISPLAYING
#22	constant VA_STATUS_ERROR_INVALID_IMAGE_FORMAT
#23	constant VA_STATUS_ERROR_DECODING_ERROR
#24	constant VA_STATUS_ERROR_ENCODING_ERROR
#25	constant VA_STATUS_ERROR_INVALID_VALUE
#32	constant VA_STATUS_ERROR_UNSUPPORTED_FILTER
#33	constant VA_STATUS_ERROR_INVALID_FILTER_CHAIN
#34	constant VA_STATUS_ERROR_HW_BUSY
#36	constant VA_STATUS_ERROR_UNSUPPORTED_MEMORY_TYPE
#37	constant VA_STATUS_ERROR_NOT_ENOUGH_BUFFER
#38	constant VA_STATUS_ERROR_TIMEDOUT
#4294967295	constant VA_STATUS_ERROR_UNKNOWN
#0	constant VA_FRAME_PICTURE
#1	constant VA_TOP_FIELD
#2	constant VA_BOTTOM_FIELD
#4	constant VA_TOP_FIELD_FIRST
#8	constant VA_BOTTOM_FIELD_FIRST
#4	constant VA_ENABLE_BLEND
#8	constant VA_CLEAR_DRAWABLE
#240	constant VA_SRC_COLOR_MASK
#16	constant VA_SRC_BT601
#32	constant VA_SRC_BT709
#64	constant VA_SRC_SMPTE_240
#0	constant VA_FILTER_SCALING_DEFAULT
#256	constant VA_FILTER_SCALING_FAST
#512	constant VA_FILTER_SCALING_HQ
#768	constant VA_FILTER_SCALING_NL_ANAMORPHIC
#3840	constant VA_FILTER_SCALING_MASK
#0	constant VA_FILTER_INTERPOLATION_DEFAULT
#4096	constant VA_FILTER_INTERPOLATION_NEAREST_NEIGHBOR
#8192	constant VA_FILTER_INTERPOLATION_BILINEAR
#12288	constant VA_FILTER_INTERPOLATION_ADVANCED
#61440	constant VA_FILTER_INTERPOLATION_MASK
#4	constant VA_PADDING_LOW
#8	constant VA_PADDING_MEDIUM
#16	constant VA_PADDING_HIGH
#32	constant VA_PADDING_LARGE
#0	constant VA_EXEC_SYNC
#1	constant VA_EXEC_ASYNC
#0	constant VA_EXEC_MODE_DEFAULT
#1	constant VA_EXEC_MODE_POWER_SAVING
#2	constant VA_EXEC_MODE_PERFORMANCE
#0	constant VA_FEATURE_NOT_SUPPORTED
#1	constant VA_FEATURE_SUPPORTED
#2	constant VA_FEATURE_REQUIRED
#1	constant VA_RT_FORMAT_YUV420
#2	constant VA_RT_FORMAT_YUV422
#4	constant VA_RT_FORMAT_YUV444
#8	constant VA_RT_FORMAT_YUV411
#16	constant VA_RT_FORMAT_YUV400
#256	constant VA_RT_FORMAT_YUV420_10
#512	constant VA_RT_FORMAT_YUV422_10
#1024	constant VA_RT_FORMAT_YUV444_10
#4096	constant VA_RT_FORMAT_YUV420_12
#8192	constant VA_RT_FORMAT_YUV422_12
#16384	constant VA_RT_FORMAT_YUV444_12
#65536	constant VA_RT_FORMAT_RGB16
#131072	constant VA_RT_FORMAT_RGB32
#1048576	constant VA_RT_FORMAT_RGBP
#2097152	constant VA_RT_FORMAT_RGB32_10
#2147483648	constant VA_RT_FORMAT_PROTECTED
#2097152	constant VA_RT_FORMAT_RGB32_10BPP
#256	constant VA_RT_FORMAT_YUV420_10BPP
#1	constant VA_RC_NONE
#2	constant VA_RC_CBR
#4	constant VA_RC_VBR
#8	constant VA_RC_VCM
#16	constant VA_RC_CQP
#32	constant VA_RC_VBR_CONSTRAINED
#64	constant VA_RC_ICQ
#128	constant VA_RC_MB
#256	constant VA_RC_CFS
#512	constant VA_RC_PARALLEL
#1024	constant VA_RC_QVBR
#2048	constant VA_RC_AVBR
#4096	constant VA_RC_TCBRC
#1	constant VA_DEC_SLICE_MODE_NORMAL
#2	constant VA_DEC_SLICE_MODE_BASE
#0	constant VA_DEC_PROCESSING_NONE
#1	constant VA_DEC_PROCESSING
#0	constant VA_ENC_PACKED_HEADER_NONE
#1	constant VA_ENC_PACKED_HEADER_SEQUENCE
#2	constant VA_ENC_PACKED_HEADER_PICTURE
#4	constant VA_ENC_PACKED_HEADER_SLICE
#8	constant VA_ENC_PACKED_HEADER_MISC
#16	constant VA_ENC_PACKED_HEADER_RAW_DATA
#0	constant VA_ENC_INTERLACED_NONE
#1	constant VA_ENC_INTERLACED_FRAME
#2	constant VA_ENC_INTERLACED_FIELD
#4	constant VA_ENC_INTERLACED_MBAFF
#8	constant VA_ENC_INTERLACED_PAFF
#1	constant VA_ENC_SLICE_STRUCTURE_POWER_OF_TWO_ROWS
#2	constant VA_ENC_SLICE_STRUCTURE_ARBITRARY_MACROBLOCKS
#4	constant VA_ENC_SLICE_STRUCTURE_EQUAL_ROWS
#8	constant VA_ENC_SLICE_STRUCTURE_MAX_SLICE_SIZE
#16	constant VA_ENC_SLICE_STRUCTURE_ARBITRARY_ROWS
#32	constant VA_ENC_SLICE_STRUCTURE_EQUAL_MULTI_ROWS
#0	constant VA_ENC_QUANTIZATION_NONE
#1	constant VA_ENC_QUANTIZATION_TRELLIS_SUPPORTED
#1	constant VA_PREDICTION_DIRECTION_PREVIOUS
#2	constant VA_PREDICTION_DIRECTION_FUTURE
#4	constant VA_PREDICTION_DIRECTION_BI_NOT_EMPTY
#0	constant VA_ENC_INTRA_REFRESH_NONE
#1	constant VA_ENC_INTRA_REFRESH_ROLLING_COLUMN
#2	constant VA_ENC_INTRA_REFRESH_ROLLING_ROW
#16	constant VA_ENC_INTRA_REFRESH_ADAPTIVE
#32	constant VA_ENC_INTRA_REFRESH_CYCLIC
#65536	constant VA_ENC_INTRA_REFRESH_P_FRAME
#131072	constant VA_ENC_INTRA_REFRESH_B_FRAME
#262144	constant VA_ENC_INTRA_REFRESH_MULTI_REF
#1	constant VA_PC_CIPHER_AES
#1	constant VA_PC_BLOCK_SIZE_128
#2	constant VA_PC_BLOCK_SIZE_192
#4	constant VA_PC_BLOCK_SIZE_256
#1	constant VA_PC_CIPHER_MODE_ECB
#2	constant VA_PC_CIPHER_MODE_CBC
#4	constant VA_PC_CIPHER_MODE_CTR
#1	constant VA_PC_SAMPLE_TYPE_FULLSAMPLE
#2	constant VA_PC_SAMPLE_TYPE_SUBSAMPLE
#0	constant VA_PC_USAGE_DEFAULT
#1	constant VA_PC_USAGE_WIDEVINE
#0	constant VA_PROCESSING_RATE_NONE
#1	constant VA_PROCESSING_RATE_ENCODE
#2	constant VA_PROCESSING_RATE_DECODE
#2147483648	constant VA_ATTRIB_NOT_SUPPORTED
#4294967295	constant VA_INVALID_ID
#4294967295	constant VA_INVALID_SURFACE
#0	constant VA_SURFACE_ATTRIB_NOT_SUPPORTED
#1	constant VA_SURFACE_ATTRIB_GETTABLE
#2	constant VA_SURFACE_ATTRIB_SETTABLE
#1	constant VA_SURFACE_ATTRIB_MEM_TYPE_VA
#2	constant VA_SURFACE_ATTRIB_MEM_TYPE_V4L2
#4	constant VA_SURFACE_ATTRIB_MEM_TYPE_USER_PTR
#1	constant VA_SURFACE_EXTBUF_DESC_ENABLE_TILING
#2	constant VA_SURFACE_EXTBUF_DESC_CACHED
#4	constant VA_SURFACE_EXTBUF_DESC_UNCACHED
#8	constant VA_SURFACE_EXTBUF_DESC_WC
#2147483648	constant VA_SURFACE_EXTBUF_DESC_PROTECTED
#0	constant VA_SURFACE_ATTRIB_USAGE_HINT_GENERIC
#1	constant VA_SURFACE_ATTRIB_USAGE_HINT_DECODER
#2	constant VA_SURFACE_ATTRIB_USAGE_HINT_ENCODER
#4	constant VA_SURFACE_ATTRIB_USAGE_HINT_VPP_READ
#8	constant VA_SURFACE_ATTRIB_USAGE_HINT_VPP_WRITE
#16	constant VA_SURFACE_ATTRIB_USAGE_HINT_DISPLAY
#32	constant VA_SURFACE_ATTRIB_USAGE_HINT_EXPORT
#1	constant VA_PROGRESSIVE
#1	constant VA_ENCRYPTION_TYPE_FULLSAMPLE_CTR
#2	constant VA_ENCRYPTION_TYPE_FULLSAMPLE_CBC
#4	constant VA_ENCRYPTION_TYPE_SUBSAMPLE_CTR
#8	constant VA_ENCRYPTION_TYPE_SUBSAMPLE_CBC
#0	constant VA_SLICE_DATA_FLAG_ALL
#1	constant VA_SLICE_DATA_FLAG_BEGIN
#2	constant VA_SLICE_DATA_FLAG_MIDDLE
#4	constant VA_SLICE_DATA_FLAG_END
#2	constant VA_MB_TYPE_MOTION_FORWARD
#4	constant VA_MB_TYPE_MOTION_BACKWARD
#8	constant VA_MB_TYPE_MOTION_PATTERN
#16	constant VA_MB_TYPE_MOTION_INTRA
#1	constant VA_PICTURE_H264_INVALID
#2	constant VA_PICTURE_H264_TOP_FIELD
#4	constant VA_PICTURE_H264_BOTTOM_FIELD
#8	constant VA_PICTURE_H264_SHORT_TERM_REFERENCE
#16	constant VA_PICTURE_H264_LONG_TERM_REFERENCE
#255	constant VA_CODED_BUF_STATUS_PICTURE_AVE_QP_MASK
#256	constant VA_CODED_BUF_STATUS_LARGE_SLICE_MASK
#512	constant VA_CODED_BUF_STATUS_SLICE_OVERFLOW_MASK
#1024	constant VA_CODED_BUF_STATUS_BITRATE_OVERFLOW
#2048	constant VA_CODED_BUF_STATUS_BITRATE_HIGH
#4096	constant VA_CODED_BUF_STATUS_FRAME_SIZE_OVERFLOW
#32768	constant VA_CODED_BUF_STATUS_BAD_BITSTREAM
#16711680	constant VA_CODED_BUF_STATUS_AIR_MB_OVER_THRESHOLD
#251658240	constant VA_CODED_BUF_STATUS_NUMBER_PASSES_MASK
#268435456	constant VA_CODED_BUF_STATUS_SINGLE_NALU
#1	constant VA_EXPORT_SURFACE_READ_ONLY
#2	constant VA_EXPORT_SURFACE_WRITE_ONLY
#3	constant VA_EXPORT_SURFACE_READ_WRITE
#4	constant VA_EXPORT_SURFACE_SEPARATE_LAYERS
#8	constant VA_EXPORT_SURFACE_COMPOSED_LAYERS
#-1	constant VA_TIMEOUT_INFINITE
#842094158	constant VA_FOURCC_NV12
#825382478	constant VA_FOURCC_NV21
#875839817	constant VA_FOURCC_AI44
#1094862674	constant VA_FOURCC_RGBA
#1480738642	constant VA_FOURCC_RGBX
#1095911234	constant VA_FOURCC_BGRA
#1481787202	constant VA_FOURCC_BGRX
#1111970369	constant VA_FOURCC_ARGB
#1111970392	constant VA_FOURCC_XRGB
#1380401729	constant VA_FOURCC_ABGR
#1380401752	constant VA_FOURCC_XBGR
#1498831189	constant VA_FOURCC_UYVY
#844715353	constant VA_FOURCC_YUY2
#1448433985	constant VA_FOURCC_AYUV
#825316942	constant VA_FOURCC_NV11
#842094169	constant VA_FOURCC_YV12
#942682704	constant VA_FOURCC_P208
#808596553	constant VA_FOURCC_I420
#875714137	constant VA_FOURCC_YV24
#842225241	constant VA_FOURCC_YV32
#808466521	constant VA_FOURCC_Y800
#860048713	constant VA_FOURCC_IMC3
#1345401140	constant VA_FOURCC_411P
#1378955572	constant VA_FOURCC_411R
#1211249204	constant VA_FOURCC_422H
#1446130228	constant VA_FOURCC_422V
#1345598516	constant VA_FOURCC_444P
#1346520914	constant VA_FOURCC_RGBP
#1347569474	constant VA_FOURCC_BGRP
#909199186	constant VA_FOURCC_RGB565
#909199170	constant VA_FOURCC_BGR565
#808530521	constant VA_FOURCC_Y210
#842084953	constant VA_FOURCC_Y212
#909193817	constant VA_FOURCC_Y216
#808531033	constant VA_FOURCC_Y410
#842085465	constant VA_FOURCC_Y412
#909194329	constant VA_FOURCC_Y416
#909203033	constant VA_FOURCC_YV16
#808530000	constant VA_FOURCC_P010
#842084432	constant VA_FOURCC_P012
#909193296	constant VA_FOURCC_P016
#808529993	constant VA_FOURCC_I010
#1448433993	constant VA_FOURCC_IYUV
#808669761	constant VA_FOURCC_A2R10G10B10
#808665665	constant VA_FOURCC_A2B10G10R10
#808669784	constant VA_FOURCC_X2R10G10B10
#808665688	constant VA_FOURCC_X2B10G10R10
#538982489	constant VA_FOURCC_Y8
#540422489	constant VA_FOURCC_Y16
#1498765654	constant VA_FOURCC_VYUY
#1431918169	constant VA_FOURCC_YVYU
#877089345	constant VA_FOURCC_ARGB64
#877085249	constant VA_FOURCC_ABGR64
#1448434008	constant VA_FOURCC_XYUV
#1	constant VA_LSB_FIRST
#2	constant VA_MSB_FIRST
#1	constant VA_SUBPICTURE_CHROMA_KEYING
#2	constant VA_SUBPICTURE_GLOBAL_ALPHA
#4	constant VA_SUBPICTURE_DESTINATION_IS_SCREEN_COORD
#0	constant VA_ROTATION_NONE
#1	constant VA_ROTATION_90
#2	constant VA_ROTATION_180
#3	constant VA_ROTATION_270
#0	constant VA_MIRROR_NONE
#1	constant VA_MIRROR_HORIZONTAL
#2	constant VA_MIRROR_VERTICAL
#0	constant VA_OOL_DEBLOCKING_FALSE
#1	constant VA_OOL_DEBLOCKING_TRUE
#0	constant VA_RENDER_MODE_UNDEFINED
#1	constant VA_RENDER_MODE_LOCAL_OVERLAY
#2	constant VA_RENDER_MODE_LOCAL_GPU
#4	constant VA_RENDER_MODE_EXTERNAL_OVERLAY
#8	constant VA_RENDER_MODE_EXTERNAL_GPU
#0	constant VA_RENDER_DEVICE_UNDEFINED
#1	constant VA_RENDER_DEVICE_LOCAL
#2	constant VA_RENDER_DEVICE_EXTERNAL
#0	constant VA_DISPLAY_ATTRIB_NOT_SUPPORTED
#1	constant VA_DISPLAY_ATTRIB_GETTABLE
#2	constant VA_DISPLAY_ATTRIB_SETTABLE
#1	constant VA_PICTURE_HEVC_INVALID
#2	constant VA_PICTURE_HEVC_FIELD_PIC
#4	constant VA_PICTURE_HEVC_BOTTOM_FIELD
#8	constant VA_PICTURE_HEVC_LONG_TERM_REFERENCE
#16	constant VA_PICTURE_HEVC_RPS_ST_CURR_BEFORE
#32	constant VA_PICTURE_HEVC_RPS_ST_CURR_AFTER
#64	constant VA_PICTURE_HEVC_RPS_LT_CURR
#1	constant VA_BLEND_GLOBAL_ALPHA
#2	constant VA_BLEND_PREMULTIPLIED_ALPHA
#16	constant VA_BLEND_LUMA_KEY
#1	constant VA_PROC_PIPELINE_SUBPICTURES
#2	constant VA_PROC_PIPELINE_FAST
#1	constant VA_PROC_FILTER_MANDATORY
#4	constant VA_PIPELINE_FLAG_END
#0	constant VA_CHROMA_SITING_UNKNOWN
#1	constant VA_CHROMA_SITING_VERTICAL_TOP
#2	constant VA_CHROMA_SITING_VERTICAL_CENTER
#3	constant VA_CHROMA_SITING_VERTICAL_BOTTOM
#4	constant VA_CHROMA_SITING_HORIZONTAL_LEFT
#8	constant VA_CHROMA_SITING_HORIZONTAL_CENTER
#0	constant VA_SOURCE_RANGE_UNKNOWN
#1	constant VA_SOURCE_RANGE_REDUCED
#2	constant VA_SOURCE_RANGE_FULL
#1	constant VA_TONE_MAPPING_HDR_TO_HDR
#2	constant VA_TONE_MAPPING_HDR_TO_SDR
#4	constant VA_TONE_MAPPING_HDR_TO_EDR
#8	constant VA_TONE_MAPPING_SDR_TO_HDR
#1	constant VA_DEINTERLACING_BOTTOM_FIELD_FIRST
#2	constant VA_DEINTERLACING_BOTTOM_FIELD
#4	constant VA_DEINTERLACING_ONE_FIELD
#8	constant VA_DEINTERLACING_FMD_ENABLE
#16	constant VA_DEINTERLACING_SCD_ENABLE
#0	constant VA_PROC_HVS_DENOISE_DEFAULT
#1	constant VA_PROC_HVS_DENOISE_AUTO_BDRATE
#2	constant VA_PROC_HVS_DENOISE_AUTO_SUBJECTIVE
#3	constant VA_PROC_HVS_DENOISE_MANUAL
#0	constant VA_3DLUT_CHANNEL_UNKNOWN
#1	constant VA_3DLUT_CHANNEL_RGB_RGB
#2	constant VA_3DLUT_CHANNEL_YUV_RGB
#4	constant VA_3DLUT_CHANNEL_VUY_RGB
#1447117872	constant VA_DISPLAY_MAGIC

\ --------===< enums >===---------
#-1	constant VAProfileNone
#0	constant VAProfileMPEG2Simple
#1	constant VAProfileMPEG2Main
#2	constant VAProfileMPEG4Simple
#3	constant VAProfileMPEG4AdvancedSimple
#4	constant VAProfileMPEG4Main
#5	constant VAProfileH264Baseline
#6	constant VAProfileH264Main
#7	constant VAProfileH264High
#8	constant VAProfileVC1Simple
#9	constant VAProfileVC1Main
#10	constant VAProfileVC1Advanced
#11	constant VAProfileH263Baseline
#12	constant VAProfileJPEGBaseline
#13	constant VAProfileH264ConstrainedBaseline
#14	constant VAProfileVP8Version0_3
#15	constant VAProfileH264MultiviewHigh
#16	constant VAProfileH264StereoHigh
#17	constant VAProfileHEVCMain
#18	constant VAProfileHEVCMain10
#19	constant VAProfileVP9Profile0
#20	constant VAProfileVP9Profile1
#21	constant VAProfileVP9Profile2
#22	constant VAProfileVP9Profile3
#23	constant VAProfileHEVCMain12
#24	constant VAProfileHEVCMain422_10
#25	constant VAProfileHEVCMain422_12
#26	constant VAProfileHEVCMain444
#27	constant VAProfileHEVCMain444_10
#28	constant VAProfileHEVCMain444_12
#29	constant VAProfileHEVCSccMain
#30	constant VAProfileHEVCSccMain10
#31	constant VAProfileHEVCSccMain444
#32	constant VAProfileAV1Profile0
#33	constant VAProfileAV1Profile1
#34	constant VAProfileHEVCSccMain444_10
#35	constant VAProfileProtected
#1	constant VAEntrypointVLD
#2	constant VAEntrypointIZZ
#3	constant VAEntrypointIDCT
#4	constant VAEntrypointMoComp
#5	constant VAEntrypointDeblocking
#6	constant VAEntrypointEncSlice
#7	constant VAEntrypointEncPicture
#8	constant VAEntrypointEncSliceLP
#10	constant VAEntrypointVideoProc
#11	constant VAEntrypointFEI
#12	constant VAEntrypointStats
#13	constant VAEntrypointProtectedTEEComm
#14	constant VAEntrypointProtectedContent
#0	constant VAConfigAttribRTFormat
#1	constant VAConfigAttribSpatialResidual
#2	constant VAConfigAttribSpatialClipping
#3	constant VAConfigAttribIntraResidual
#4	constant VAConfigAttribEncryption
#5	constant VAConfigAttribRateControl
#6	constant VAConfigAttribDecSliceMode
#7	constant VAConfigAttribDecJPEG
#8	constant VAConfigAttribDecProcessing
#10	constant VAConfigAttribEncPackedHeaders
#11	constant VAConfigAttribEncInterlaced
#13	constant VAConfigAttribEncMaxRefFrames
#14	constant VAConfigAttribEncMaxSlices
#15	constant VAConfigAttribEncSliceStructure
#16	constant VAConfigAttribEncMacroblockInfo
#18	constant VAConfigAttribMaxPictureWidth
#19	constant VAConfigAttribMaxPictureHeight
#20	constant VAConfigAttribEncJPEG
#21	constant VAConfigAttribEncQualityRange
#22	constant VAConfigAttribEncQuantization
#23	constant VAConfigAttribEncIntraRefresh
#24	constant VAConfigAttribEncSkipFrame
#25	constant VAConfigAttribEncROI
#26	constant VAConfigAttribEncRateControlExt
#27	constant VAConfigAttribProcessingRate
#28	constant VAConfigAttribEncDirtyRect
#29	constant VAConfigAttribEncParallelRateControl
#30	constant VAConfigAttribEncDynamicScaling
#31	constant VAConfigAttribFrameSizeToleranceSupport
#32	constant VAConfigAttribFEIFunctionType
#33	constant VAConfigAttribFEIMVPredictors
#34	constant VAConfigAttribStats
#35	constant VAConfigAttribEncTileSupport
#36	constant VAConfigAttribCustomRoundingControl
#37	constant VAConfigAttribQPBlockSize
#38	constant VAConfigAttribMaxFrameSize
#39	constant VAConfigAttribPredictionDirection
#40	constant VAConfigAttribMultipleFrame
#41	constant VAConfigAttribContextPriority
#42	constant VAConfigAttribDecAV1Features
#43	constant VAConfigAttribTEEType
#44	constant VAConfigAttribTEETypeClient
#45	constant VAConfigAttribProtectedContentCipherAlgorithm
#46	constant VAConfigAttribProtectedContentCipherBlockSize
#47	constant VAConfigAttribProtectedContentCipherMode
#48	constant VAConfigAttribProtectedContentCipherSampleType
#49	constant VAConfigAttribProtectedContentUsage
#50	constant VAConfigAttribEncHEVCFeatures
#51	constant VAConfigAttribEncHEVCBlockSizes
#52	constant VAConfigAttribEncAV1
#53	constant VAConfigAttribEncAV1Ext1
#54	constant VAConfigAttribEncAV1Ext2
#55	constant VAConfigAttribTypeMax
#1	constant VAGenericValueTypeInteger
#2	constant VAGenericValueTypeFloat
#3	constant VAGenericValueTypePointer
#4	constant VAGenericValueTypeFunc
#0	constant VASurfaceAttribNone
#1	constant VASurfaceAttribPixelFormat
#2	constant VASurfaceAttribMinWidth
#3	constant VASurfaceAttribMaxWidth
#4	constant VASurfaceAttribMinHeight
#5	constant VASurfaceAttribMaxHeight
#6	constant VASurfaceAttribMemoryType
#7	constant VASurfaceAttribExternalBufferDescriptor
#8	constant VASurfaceAttribUsageHint
#9	constant VASurfaceAttribDRMFormatModifiers
#10	constant VASurfaceAttribCount
#0	constant VAPictureParameterBufferType
#1	constant VAIQMatrixBufferType
#2	constant VABitPlaneBufferType
#3	constant VASliceGroupMapBufferType
#4	constant VASliceParameterBufferType
#5	constant VASliceDataBufferType
#6	constant VAMacroblockParameterBufferType
#7	constant VAResidualDataBufferType
#8	constant VADeblockingParameterBufferType
#9	constant VAImageBufferType
#10	constant VAProtectedSliceDataBufferType
#11	constant VAQMatrixBufferType
#12	constant VAHuffmanTableBufferType
#13	constant VAProbabilityBufferType
#21	constant VAEncCodedBufferType
#22	constant VAEncSequenceParameterBufferType
#23	constant VAEncPictureParameterBufferType
#24	constant VAEncSliceParameterBufferType
#25	constant VAEncPackedHeaderParameterBufferType
#26	constant VAEncPackedHeaderDataBufferType
#27	constant VAEncMiscParameterBufferType
#28	constant VAEncMacroblockParameterBufferType
#29	constant VAEncMacroblockMapBufferType
#30	constant VAEncQPBufferType
#41	constant VAProcPipelineParameterBufferType
#42	constant VAProcFilterParameterBufferType
#43	constant VAEncFEIMVBufferType
#44	constant VAEncFEIMBCodeBufferType
#45	constant VAEncFEIDistortionBufferType
#46	constant VAEncFEIMBControlBufferType
#47	constant VAEncFEIMVPredictorBufferType
#48	constant VAStatsStatisticsParameterBufferType
#49	constant VAStatsStatisticsBufferType
#50	constant VAStatsStatisticsBottomFieldBufferType
#51	constant VAStatsMVBufferType
#52	constant VAStatsMVPredictorBufferType
#53	constant VAEncMacroblockDisableSkipMapBufferType
#54	constant VAEncFEICTBCmdBufferType
#55	constant VAEncFEICURecordBufferType
#56	constant VADecodeStreamoutBufferType
#57	constant VASubsetsParameterBufferType
#58	constant VAContextParameterUpdateBufferType
#59	constant VAProtectedSessionExecuteBufferType
#60	constant VAEncryptionParameterBufferType
#61	constant VABufferTypeMax
#0	constant VAEncMiscParameterTypeFrameRate
#1	constant VAEncMiscParameterTypeRateControl
#2	constant VAEncMiscParameterTypeMaxSliceSize
#3	constant VAEncMiscParameterTypeAIR
#4	constant VAEncMiscParameterTypeMaxFrameSize
#5	constant VAEncMiscParameterTypeHRD
#6	constant VAEncMiscParameterTypeQualityLevel
#7	constant VAEncMiscParameterTypeRIR
#8	constant VAEncMiscParameterTypeQuantization
#9	constant VAEncMiscParameterTypeSkipFrame
#10	constant VAEncMiscParameterTypeROI
#11	constant VAEncMiscParameterTypeMultiPassFrameSize
#12	constant VAEncMiscParameterTypeTemporalLayerStructure
#13	constant VAEncMiscParameterTypeDirtyRect
#14	constant VAEncMiscParameterTypeParallelBRC
#15	constant VAEncMiscParameterTypeSubMbPartPel
#16	constant VAEncMiscParameterTypeEncQuality
#17	constant VAEncMiscParameterTypeCustomRoundingControl
#18	constant VAEncMiscParameterTypeFEIFrameControl
#19	constant VAEncMiscParameterTypeExtensionData
#1	constant VAEncPackedHeaderSequence
#2	constant VAEncPackedHeaderPicture
#3	constant VAEncPackedHeaderSlice
#4	constant VAEncPackedHeaderRawData
#2147483648	constant VAEncPackedHeaderMiscMask
#0	constant VAMvMode1Mv
#1	constant VAMvMode1MvHalfPel
#2	constant VAMvMode1MvHalfPelBilinear
#3	constant VAMvModeMixedMv
#4	constant VAMvModeIntensityCompensation
#0	constant VAEncPictureTypeIntra
#1	constant VAEncPictureTypePredictive
#2	constant VAEncPictureTypeBidirectional
#1	constant VASurfaceRendering
#2	constant VASurfaceDisplaying
#4	constant VASurfaceReady
#8	constant VASurfaceSkipped
#0	constant VADecodeSliceMissing
#1	constant VADecodeMBError
#0	constant VADISPLAYATTRIB_BLE_OFF
#1	constant VADISPLAYATTRIB_BLE_LOW
#2	constant VADISPLAYATTRIB_BLE_MEDIUM
#3	constant VADISPLAYATTRIB_BLE_HIGH
#4	constant VADISPLAYATTRIB_BLE_NONE
#0	constant VADisplayAttribBrightness
#1	constant VADisplayAttribContrast
#2	constant VADisplayAttribHue
#3	constant VADisplayAttribSaturation
#4	constant VADisplayAttribBackgroundColor
#5	constant VADisplayAttribDirectSurface
#6	constant VADisplayAttribRotation
#7	constant VADisplayAttribOutofLoopDeblock
#8	constant VADisplayAttribBLEBlackMode
#9	constant VADisplayAttribBLEWhiteMode
#10	constant VADisplayAttribBlueStretch
#11	constant VADisplayAttribSkinColorCorrection
#12	constant VADisplayAttribCSCMatrix
#13	constant VADisplayAttribBlendColor
#14	constant VADisplayAttribOverlayAutoPaintColorKey
#15	constant VADisplayAttribOverlayColorKey
#16	constant VADisplayAttribRenderMode
#17	constant VADisplayAttribRenderDevice
#18	constant VADisplayAttribRenderRect
#19	constant VADisplayAttribSubDevice
#20	constant VADisplayAttribCopy
#0	constant VACopyObjectSurface
#1	constant VACopyObjectBuffer
#0	constant VAProcFilterNone
#1	constant VAProcFilterNoiseReduction
#2	constant VAProcFilterDeinterlacing
#3	constant VAProcFilterSharpening
#4	constant VAProcFilterColorBalance
#5	constant VAProcFilterSkinToneEnhancement
#6	constant VAProcFilterTotalColorCorrection
#7	constant VAProcFilterHVSNoiseReduction
#8	constant VAProcFilterHighDynamicRangeToneMapping
#9	constant VAProcFilter3DLUT
#10	constant VAProcFilterCount
#0	constant VAProcDeinterlacingNone
#1	constant VAProcDeinterlacingBob
#2	constant VAProcDeinterlacingWeave
#3	constant VAProcDeinterlacingMotionAdaptive
#4	constant VAProcDeinterlacingMotionCompensated
#5	constant VAProcDeinterlacingCount
#0	constant VAProcColorBalanceNone
#1	constant VAProcColorBalanceHue
#2	constant VAProcColorBalanceSaturation
#3	constant VAProcColorBalanceBrightness
#4	constant VAProcColorBalanceContrast
#5	constant VAProcColorBalanceAutoSaturation
#6	constant VAProcColorBalanceAutoBrightness
#7	constant VAProcColorBalanceAutoContrast
#8	constant VAProcColorBalanceCount
#0	constant VAProcColorStandardNone
#1	constant VAProcColorStandardBT601
#2	constant VAProcColorStandardBT709
#3	constant VAProcColorStandardBT470M
#4	constant VAProcColorStandardBT470BG
#5	constant VAProcColorStandardSMPTE170M
#6	constant VAProcColorStandardSMPTE240M
#7	constant VAProcColorStandardGenericFilm
#8	constant VAProcColorStandardSRGB
#9	constant VAProcColorStandardSTRGB
#10	constant VAProcColorStandardXVYCC601
#11	constant VAProcColorStandardXVYCC709
#12	constant VAProcColorStandardBT2020
#13	constant VAProcColorStandardExplicit
#14	constant VAProcColorStandardCount
#0	constant VAProcTotalColorCorrectionNone
#1	constant VAProcTotalColorCorrectionRed
#2	constant VAProcTotalColorCorrectionGreen
#3	constant VAProcTotalColorCorrectionBlue
#4	constant VAProcTotalColorCorrectionCyan
#5	constant VAProcTotalColorCorrectionMagenta
#6	constant VAProcTotalColorCorrectionYellow
#7	constant VAProcTotalColorCorrectionCount
#0	constant VAProcHighDynamicRangeMetadataNone
#1	constant VAProcHighDynamicRangeMetadataHDR10
#2	constant VAProcHighDynamicRangeMetadataTypeCount
#0	constant VAProcDefaultMode
#1	constant VAProcPowerSavingMode
#2	constant VAProcPerformanceMode
#240	constant VA_DISPLAY_MAJOR_MASK
#16	constant VA_DISPLAY_X11
#17	constant VA_DISPLAY_GLX
#32	constant VA_DISPLAY_ANDROID
#48	constant VA_DISPLAY_DRM
#49	constant VA_DISPLAY_DRM_RENDERNODES
#64	constant VA_DISPLAY_WAYLAND

\ -------===< structs >===--------
\ VARectangle
begin-structure VARectangle
drop 8 end-structure
\ VAMotionVector
begin-structure VAMotionVector
drop 8 end-structure
\ VAConfigAttrib
begin-structure VAConfigAttrib
drop 8 end-structure
\ VAConfigAttribValDecJPEG
begin-structure VAConfigAttribValDecJPEG
drop 4 end-structure
\ VAConfigAttribValMaxFrameSize
begin-structure VAConfigAttribValMaxFrameSize
drop 4 end-structure
\ VAConfigAttribValEncJPEG
begin-structure VAConfigAttribValEncJPEG
drop 4 end-structure
\ VAConfigAttribValEncROI
begin-structure VAConfigAttribValEncROI
drop 4 end-structure
\ VAConfigAttribValEncRateControlExt
begin-structure VAConfigAttribValEncRateControlExt
drop 4 end-structure
\ VAConfigAttribValMultipleFrame
begin-structure VAConfigAttribValMultipleFrame
drop 4 end-structure
\ VAConfigAttribValContextPriority
begin-structure VAConfigAttribValContextPriority
drop 4 end-structure
\ VAGenericValue
begin-structure VAGenericValue
drop 16 end-structure
\ _VAGenericValue_value
begin-structure _VAGenericValue_value
	drop 0 4 +field _VAGenericValue_value-i
	drop 0 8 +field _VAGenericValue_value-p
	drop 0 8 +field _VAGenericValue_value-fn
	drop 0 4 +field _VAGenericValue_value-f
drop 8 end-structure
\ VASurfaceAttrib
begin-structure VASurfaceAttrib
drop 24 end-structure
\ VASurfaceAttribExternalBuffers
begin-structure VASurfaceAttribExternalBuffers
drop 80 end-structure
\ VAContextParameterUpdateBuffer
begin-structure VAContextParameterUpdateBuffer
drop 40 end-structure
\ VAEncryptionSegmentInfo
begin-structure VAEncryptionSegmentInfo
drop 112 end-structure
\ VAEncryptionParameters
begin-structure VAEncryptionParameters
drop 200 end-structure
\ VAProcessingRateParameterEnc
begin-structure VAProcessingRateParameterEnc
drop 16 end-structure
\ VAProcessingRateParameterDec
begin-structure VAProcessingRateParameterDec
drop 8 end-structure
\ VAProcessingRateParameter
begin-structure VAProcessingRateParameter
drop 16 end-structure
\ VAEncPackedHeaderParameterBuffer
begin-structure VAEncPackedHeaderParameterBuffer
drop 28 end-structure
\ VAEncMiscParameterBuffer
begin-structure VAEncMiscParameterBuffer
drop 4 end-structure
\ VAEncMiscParameterTemporalLayerStructure
begin-structure VAEncMiscParameterTemporalLayerStructure
drop 152 end-structure
\ VAEncMiscParameterRateControl
begin-structure VAEncMiscParameterRateControl
drop 60 end-structure
\ VAEncMiscParameterFrameRate
begin-structure VAEncMiscParameterFrameRate
drop 24 end-structure
\ VAEncMiscParameterMaxSliceSize
begin-structure VAEncMiscParameterMaxSliceSize
drop 20 end-structure
\ VAEncMiscParameterAIR
begin-structure VAEncMiscParameterAIR
drop 28 end-structure
\ VAEncMiscParameterRIR
begin-structure VAEncMiscParameterRIR
drop 28 end-structure
\ VAEncMiscParameterHRD
begin-structure VAEncMiscParameterHRD
drop 24 end-structure
\ VAEncMiscParameterBufferMaxFrameSize
begin-structure VAEncMiscParameterBufferMaxFrameSize
drop 24 end-structure
\ VAEncMiscParameterBufferMultiPassFrameSize
begin-structure VAEncMiscParameterBufferMultiPassFrameSize
drop 56 end-structure
\ VAEncMiscParameterBufferQualityLevel
begin-structure VAEncMiscParameterBufferQualityLevel
drop 20 end-structure
\ VAEncMiscParameterQuantization
begin-structure VAEncMiscParameterQuantization
drop 8 end-structure
\ VAEncMiscParameterSkipFrame
begin-structure VAEncMiscParameterSkipFrame
drop 24 end-structure
\ VAEncROI
begin-structure VAEncROI
drop 10 end-structure
\ VAEncMiscParameterBufferROI
begin-structure VAEncMiscParameterBufferROI
drop 40 end-structure
\ VAEncMiscParameterBufferDirtyRect
begin-structure VAEncMiscParameterBufferDirtyRect
drop 16 end-structure
\ VAEncMiscParameterParallelRateControl
begin-structure VAEncMiscParameterParallelRateControl
drop 16 end-structure
\ VAEncMiscParameterEncQuality
begin-structure VAEncMiscParameterEncQuality
drop 224 end-structure
\ VAEncMiscParameterCustomRoundingControl
begin-structure VAEncMiscParameterCustomRoundingControl
drop 4 end-structure
\ _VAEncMiscParameterCustomRoundingControl_rounding_offset_setting
begin-structure _VAEncMiscParameterCustomRoundingControl_rounding_offset_setting
	drop 0 4 +field _VAEncMiscParameterCustomRoundingControl_rounding_offset_setting-value
drop 4 end-structure
\ VASliceParameterBufferBase
begin-structure VASliceParameterBufferBase
drop 12 end-structure
\ VAHuffmanTableBufferJPEGBaseline
begin-structure VAHuffmanTableBufferJPEGBaseline
drop 436 end-structure
\ _VAHuffmanTableBufferJPEGBaseline_huffman_table
begin-structure _VAHuffmanTableBufferJPEGBaseline_huffman_table
	drop 16 12 +field _VAHuffmanTableBufferJPEGBaseline_huffman_table-dc_values
	drop 44 162 +field _VAHuffmanTableBufferJPEGBaseline_huffman_table-ac_values
	drop 206 2 +field _VAHuffmanTableBufferJPEGBaseline_huffman_table-pad
	drop 0 16 +field _VAHuffmanTableBufferJPEGBaseline_huffman_table-num_dc_codes
	drop 28 16 +field _VAHuffmanTableBufferJPEGBaseline_huffman_table-num_ac_codes
drop 208 end-structure
\ VAPictureParameterBufferMPEG2
begin-structure VAPictureParameterBufferMPEG2
drop 40 end-structure
\ _VAPictureParameterBufferMPEG2_picture_coding_extension
begin-structure _VAPictureParameterBufferMPEG2_picture_coding_extension
	drop 0 4 +field _VAPictureParameterBufferMPEG2_picture_coding_extension-value
drop 4 end-structure
\ VAIQMatrixBufferMPEG2
begin-structure VAIQMatrixBufferMPEG2
drop 288 end-structure
\ VASliceParameterBufferMPEG2
begin-structure VASliceParameterBufferMPEG2
drop 48 end-structure
\ VAMacroblockParameterBufferMPEG2
begin-structure VAMacroblockParameterBufferMPEG2
drop 48 end-structure
\ _VAMacroblockParameterBufferMPEG2_macroblock_modes
begin-structure _VAMacroblockParameterBufferMPEG2_macroblock_modes
	drop 0 4 +field _VAMacroblockParameterBufferMPEG2_macroblock_modes-value
drop 4 end-structure
\ VAPictureParameterBufferMPEG4
begin-structure VAPictureParameterBufferMPEG4
drop 64 end-structure
\ VAIQMatrixBufferMPEG4
begin-structure VAIQMatrixBufferMPEG4
drop 152 end-structure
\ VASliceParameterBufferMPEG4
begin-structure VASliceParameterBufferMPEG4
drop 40 end-structure
\ VAPictureParameterBufferVC1
begin-structure VAPictureParameterBufferVC1
drop 104 end-structure
\ _VAPictureParameterBufferVC1_raw_coding
begin-structure _VAPictureParameterBufferVC1_raw_coding
	drop 0 4 +field _VAPictureParameterBufferVC1_raw_coding-value
drop 4 end-structure
\ VASliceParameterBufferVC1
begin-structure VASliceParameterBufferVC1
drop 36 end-structure
\ VAPictureH264
begin-structure VAPictureH264
drop 36 end-structure
\ VAPictureParameterBufferH264
begin-structure VAPictureParameterBufferH264
drop 672 end-structure
\ VAIQMatrixBufferH264
begin-structure VAIQMatrixBufferH264
drop 240 end-structure
\ VASliceParameterBufferH264
begin-structure VASliceParameterBufferH264
drop 3128 end-structure
\ VAEncSliceParameterBuffer
begin-structure VAEncSliceParameterBuffer
drop 28 end-structure
\ VAEncSequenceParameterBufferH263
begin-structure VAEncSequenceParameterBufferH263
drop 36 end-structure
\ VAEncPictureParameterBufferH263
begin-structure VAEncPictureParameterBufferH263
drop 36 end-structure
\ VAEncSequenceParameterBufferMPEG4
begin-structure VAEncSequenceParameterBufferMPEG4
drop 60 end-structure
\ VAEncPictureParameterBufferMPEG4
begin-structure VAEncPictureParameterBufferMPEG4
drop 44 end-structure
\ VACodedBufferSegment
begin-structure VACodedBufferSegment
drop 48 end-structure
\ VABufferInfo
begin-structure VABufferInfo
	drop 24 16 +field VABufferInfo-va_reserved
	drop 0 8 +field VABufferInfo-handle
	drop 8 4 +field VABufferInfo-type
	drop 12 4 +field VABufferInfo-mem_type
	drop 16 8 +field VABufferInfo-mem_size
drop 40 end-structure
\ VASurfaceDecodeMBErrors
begin-structure VASurfaceDecodeMBErrors
drop 32 end-structure
\ VAImageFormat
begin-structure VAImageFormat
drop 48 end-structure
\ VAImage
begin-structure VAImage
drop 120 end-structure
\ VADisplayAttribValSubDevice
begin-structure VADisplayAttribValSubDevice
drop 4 end-structure
\ VADisplayAttribute
begin-structure VADisplayAttribute
drop 36 end-structure
\ VAPictureHEVC
begin-structure VAPictureHEVC
drop 28 end-structure
\ VACopyObject
begin-structure VACopyObject
drop 40 end-structure
\ _VACopyObject_object
begin-structure _VACopyObject_object
	drop 0 4 +field _VACopyObject_object-buffer_id
	drop 0 4 +field _VACopyObject_object-surface_id
drop 4 end-structure
\ VACopyOption
begin-structure VACopyOption
drop 4 end-structure
\ VABlendState
begin-structure VABlendState
drop 16 end-structure
\ VAProcPipelineCaps
begin-structure VAProcPipelineCaps
drop 176 end-structure
\ VAProcFilterValueRange
begin-structure VAProcFilterValueRange
drop 32 end-structure
\ VAProcColorProperties
begin-structure VAProcColorProperties
drop 8 end-structure
\ VAHdrMetaDataHDR10
begin-structure VAHdrMetaDataHDR10
drop 60 end-structure
\ VAProcFilterCapHighDynamicRange
begin-structure VAProcFilterCapHighDynamicRange
drop 40 end-structure
\ VAHdrMetaData
begin-structure VAHdrMetaData
drop 40 end-structure
\ VAProcPipelineParameterBuffer
begin-structure VAProcPipelineParameterBuffer
drop 224 end-structure
\ VAProcFilterParameterBufferBase
begin-structure VAProcFilterParameterBufferBase
drop 4 end-structure
\ VAProcFilterParameterBuffer
begin-structure VAProcFilterParameterBuffer
drop 24 end-structure
\ VAProcFilterParameterBufferDeinterlacing
begin-structure VAProcFilterParameterBufferDeinterlacing
drop 28 end-structure
\ VAProcFilterParameterBufferColorBalance
begin-structure VAProcFilterParameterBufferColorBalance
drop 28 end-structure
\ VAProcFilterParameterBufferTotalColorCorrection
begin-structure VAProcFilterParameterBufferTotalColorCorrection
drop 12 end-structure
\ VAProcFilterParameterBufferHVSNoiseReduction
begin-structure VAProcFilterParameterBufferHVSNoiseReduction
drop 40 end-structure
\ VAProcFilterParameterBufferHDRToneMapping
begin-structure VAProcFilterParameterBufferHDRToneMapping
drop 112 end-structure
\ VAProcFilterParameterBuffer3DLUT
begin-structure VAProcFilterParameterBuffer3DLUT
drop 88 end-structure
\ VAProcFilterCap3DLUT
begin-structure VAProcFilterCap3DLUT
drop 80 end-structure
\ VAProcFilterCap
begin-structure VAProcFilterCap
drop 48 end-structure
\ VAProcFilterCapDeinterlacing
begin-structure VAProcFilterCapDeinterlacing
drop 20 end-structure
\ VAProcFilterCapColorBalance
begin-structure VAProcFilterCapColorBalance
drop 52 end-structure
\ VAProcFilterCapTotalColorCorrection
begin-structure VAProcFilterCapTotalColorCorrection
drop 36 end-structure
\ VADriverContext
begin-structure VADriverContext
	drop 96 8 +field VADriverContext-handle
	drop 120 8 +field VADriverContext-display_type
	drop 88 8 +field VADriverContext-str_vendor
	drop 48 4 +field VADriverContext-x11_screen
	drop 68 4 +field VADriverContext-max_attributes
	drop 52 4 +field VADriverContext-version_major
	drop 80 4 +field VADriverContext-max_display_attributes
	drop 152 8 +field VADriverContext-pDisplayContext
	drop 56 4 +field VADriverContext-version_minor
	drop 60 4 +field VADriverContext-max_profiles
	drop 40 8 +field VADriverContext-native_dpy
	drop 160 8 +field VADriverContext-error_callback
	drop 168 8 +field VADriverContext-info_callback
	drop 184 296 +field VADriverContext-reserved
	drop 76 4 +field VADriverContext-max_subpic_formats
	drop 72 4 +field VADriverContext-max_image_formats
	drop 0 8 +field VADriverContext-pDriverData
	drop 112 8 +field VADriverContext-glx
	drop 104 8 +field VADriverContext-drm_state
	drop 144 8 +field VADriverContext-override_driver_name
	drop 32 8 +field VADriverContext-vtable_tpi
	drop 64 4 +field VADriverContext-max_entrypoints
drop 480 end-structure
\ VADisplayContext
begin-structure VADisplayContext
	drop 48 8 +field VADisplayContext-opaque
	drop 64 8 +field VADisplayContext-vafool
	drop 96 8 +field VADisplayContext-info_callback_user_context
	drop 80 8 +field VADisplayContext-error_callback_user_context
	drop 16 8 +field VADisplayContext-pDriverContext
	drop 8 8 +field VADisplayContext-pNext
	drop 112 8 +field VADisplayContext-vaGetDriverNameByIndex
	drop 88 8 +field VADisplayContext-info_callback
	drop 72 8 +field VADisplayContext-error_callback
	drop 120 240 +field VADisplayContext-reserved
	drop 24 8 +field VADisplayContext-vaIsValid
	drop 104 8 +field VADisplayContext-vaGetNumCandidates
	drop 56 8 +field VADisplayContext-vatrace
	drop 0 4 +field VADisplayContext-vadpy_magic
	drop 40 8 +field VADisplayContext-vaGetDriverName
	drop 32 8 +field VADisplayContext-vaDestroy
drop 360 end-structure

\ --===< function pointers >===---
c-funptr VADriverContext-error_callback() {((struct VADriverContext*)ptr)->error_callback} a s -- void	( pDriverContext message -- )
c-funptr VADriverContext-info_callback() {((struct VADriverContext*)ptr)->info_callback} a s -- void	( pDriverContext message -- )
c-funptr VADisplayContext-vaIsValid() {((struct VADisplayContext*)ptr)->vaIsValid} a -- n	( ctx -- )
c-funptr VADisplayContext-vaDestroy() {((struct VADisplayContext*)ptr)->vaDestroy} a -- void	( ctx -- )
c-funptr VADisplayContext-vaGetDriverName() {((struct VADisplayContext*)ptr)->vaGetDriverName} a a -- n	( ctx driver_name -- )
c-funptr VADisplayContext-vaGetNumCandidates() {((struct VADisplayContext*)ptr)->vaGetNumCandidates} a a -- n	( ctx num_candidates -- )
c-funptr VADisplayContext-vaGetDriverNameByIndex() {((struct VADisplayContext*)ptr)->vaGetDriverNameByIndex} a a n -- n	( ctx driver_name candidate_index -- )

\ ------===< callbacks >===-------
c-callback VAMessageCallback: a s -- void	( user_context message -- )
c-callback VAPrivFunc:  -- n	( <noname> -- )
c-callback VAGenericFunc:  -- void	( <noname> -- )
c-callback VADriverInit: a -- n	( driver_context -- )

\ ------===< functions >===-------
c-function vaErrorStr vaErrorStr n -- s	( error_status -- )
c-function vaSetErrorCallback vaSetErrorCallback a a a -- a	( dpy callback user_context -- )
c-function vaSetInfoCallback vaSetInfoCallback a a a -- a	( dpy callback user_context -- )
c-function vaDisplayIsValid vaDisplayIsValid a -- n	( dpy -- )
c-function vaSetDriverName vaSetDriverName a a -- n	( dpy driver_name -- )
c-function vaInitialize vaInitialize a a a -- n	( dpy major_version minor_version -- )
c-function vaTerminate vaTerminate a -- n	( dpy -- )
c-function vaQueryVendorString vaQueryVendorString a -- s	( dpy -- )
c-function vaGetLibFunc vaGetLibFunc a s -- a	( dpy func -- )
c-function vaMaxNumProfiles vaMaxNumProfiles a -- n	( dpy -- )
c-function vaMaxNumEntrypoints vaMaxNumEntrypoints a -- n	( dpy -- )
c-function vaMaxNumConfigAttributes vaMaxNumConfigAttributes a -- n	( dpy -- )
c-function vaQueryConfigProfiles vaQueryConfigProfiles a a a -- n	( dpy profile_list num_profiles -- )
c-function vaQueryConfigEntrypoints vaQueryConfigEntrypoints a n a a -- n	( dpy profile entrypoint_list num_entrypoints -- )
c-function vaGetConfigAttributes vaGetConfigAttributes a n n a n -- n	( dpy profile entrypoint attrib_list num_attribs -- )
c-function vaCreateConfig vaCreateConfig a n n a n a -- n	( dpy profile entrypoint attrib_list num_attribs config_id -- )
c-function vaDestroyConfig vaDestroyConfig a u -- n	( dpy config_id -- )
c-function vaQueryConfigAttributes vaQueryConfigAttributes a u a a a a -- n	( dpy config_id profile entrypoint attrib_list num_attribs -- )
c-function vaQuerySurfaceAttributes vaQuerySurfaceAttributes a u a a -- n	( dpy config attrib_list num_attribs -- )
c-function vaCreateSurfaces vaCreateSurfaces a u u u a u a u -- n	( dpy format width height surfaces num_surfaces attrib_list num_attribs -- )
c-function vaDestroySurfaces vaDestroySurfaces a a n -- n	( dpy surfaces num_surfaces -- )
c-function vaCreateContext vaCreateContext a u n n n a n a -- n	( dpy config_id picture_width picture_height flag render_targets num_render_targets context -- )
c-function vaDestroyContext vaDestroyContext a u -- n	( dpy context -- )
c-function vaCreateMFContext vaCreateMFContext a a -- n	( dpy mf_context -- )
c-function vaMFAddContext vaMFAddContext a u u -- n	( dpy mf_context context -- )
c-function vaMFReleaseContext vaMFReleaseContext a u u -- n	( dpy mf_context context -- )
c-function vaQueryProcessingRate vaQueryProcessingRate a u a a -- n	( dpy config proc_buf processing_rate -- )
c-function vaCreateBuffer vaCreateBuffer a u n u u a a -- n	( dpy context type size num_elements data buf_id -- )
c-function vaCreateBuffer2 vaCreateBuffer2 a u n u u a a a -- n	( dpy context type width height unit_size pitch buf_id -- )
c-function vaBufferSetNumElements vaBufferSetNumElements a u u -- n	( dpy buf_id num_elements -- )
c-function vaMapBuffer vaMapBuffer a u a -- n	( dpy buf_id pbuf -- )
c-function vaUnmapBuffer vaUnmapBuffer a u -- n	( dpy buf_id -- )
c-function vaDestroyBuffer vaDestroyBuffer a u -- n	( dpy buffer_id -- )
c-function vaAcquireBufferHandle vaAcquireBufferHandle a u a -- n	( dpy buf_id buf_info -- )
c-function vaReleaseBufferHandle vaReleaseBufferHandle a u -- n	( dpy buf_id -- )
c-function vaExportSurfaceHandle vaExportSurfaceHandle a u u u a -- n	( dpy surface_id mem_type flags descriptor -- )
c-function vaBeginPicture vaBeginPicture a u u -- n	( dpy context render_target -- )
c-function vaRenderPicture vaRenderPicture a u a n -- n	( dpy context buffers num_buffers -- )
c-function vaEndPicture vaEndPicture a u -- n	( dpy context -- )
c-function vaMFSubmit vaMFSubmit a u a n -- n	( dpy mf_context contexts num_contexts -- )
c-function vaSyncSurface vaSyncSurface a u -- n	( dpy render_target -- )
c-function vaSyncSurface2 vaSyncSurface2 a u n -- n	( dpy surface timeout_ns -- )
c-function vaQuerySurfaceStatus vaQuerySurfaceStatus a u a -- n	( dpy render_target status -- )
c-function vaQuerySurfaceError vaQuerySurfaceError a u n a -- n	( dpy surface error_status error_info -- )
c-function vaSyncBuffer vaSyncBuffer a u n -- n	( dpy buf_id timeout_ns -- )
c-function vaMaxNumImageFormats vaMaxNumImageFormats a -- n	( dpy -- )
c-function vaQueryImageFormats vaQueryImageFormats a a a -- n	( dpy format_list num_formats -- )
c-function vaCreateImage vaCreateImage a a n n a -- n	( dpy format width height image -- )
c-function vaDestroyImage vaDestroyImage a u -- n	( dpy image -- )
c-function vaSetImagePalette vaSetImagePalette a u a -- n	( dpy image palette -- )
c-function vaGetImage vaGetImage a u n n u u u -- n	( dpy surface x y width height image -- )
c-function vaPutImage vaPutImage a u u n n u u n n u u -- n	( dpy surface image src_x src_y src_width src_height dest_x dest_y dest_width dest_height -- )
c-function vaDeriveImage vaDeriveImage a u a -- n	( dpy surface image -- )
c-function vaMaxNumSubpictureFormats vaMaxNumSubpictureFormats a -- n	( dpy -- )
c-function vaQuerySubpictureFormats vaQuerySubpictureFormats a a a a -- n	( dpy format_list flags num_formats -- )
c-function vaCreateSubpicture vaCreateSubpicture a u a -- n	( dpy image subpicture -- )
c-function vaDestroySubpicture vaDestroySubpicture a u -- n	( dpy subpicture -- )
c-function vaSetSubpictureImage vaSetSubpictureImage a u u -- n	( dpy subpicture image -- )
c-function vaSetSubpictureChromakey vaSetSubpictureChromakey a u u u u -- n	( dpy subpicture chromakey_min chromakey_max chromakey_mask -- )
c-function vaSetSubpictureGlobalAlpha vaSetSubpictureGlobalAlpha a u r -- n	( dpy subpicture global_alpha -- )
c-function vaAssociateSubpicture vaAssociateSubpicture a u a n n n u u n n u u u -- n	( dpy subpicture target_surfaces num_surfaces src_x src_y src_width src_height dest_x dest_y dest_width dest_height flags -- )
c-function vaDeassociateSubpicture vaDeassociateSubpicture a u a n -- n	( dpy subpicture target_surfaces num_surfaces -- )
c-function vaMaxNumDisplayAttributes vaMaxNumDisplayAttributes a -- n	( dpy -- )
c-function vaQueryDisplayAttributes vaQueryDisplayAttributes a a a -- n	( dpy attr_list num_attributes -- )
c-function vaGetDisplayAttributes vaGetDisplayAttributes a a n -- n	( dpy attr_list num_attributes -- )
c-function vaSetDisplayAttributes vaSetDisplayAttributes a a n -- n	( dpy attr_list num_attributes -- )
c-function vaCopy vaCopy a a a a{*(VACopyOption*)} -- n	( dpy dst src option -- )
c-function vaQueryVideoProcFilters vaQueryVideoProcFilters a u a a -- n	( dpy context filters num_filters -- )
c-function vaQueryVideoProcFilterCaps vaQueryVideoProcFilterCaps a u n a a -- n	( dpy context type filter_caps num_filter_caps -- )
c-function vaQueryVideoProcPipelineCaps vaQueryVideoProcPipelineCaps a u a u a -- n	( dpy context filters num_filters pipeline_caps -- )

\ ----===< postfix >===-----
end-c-library
previous set-current
