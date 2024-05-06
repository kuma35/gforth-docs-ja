\ This file has been generated using SWIG and fsi,
\ and is already platform dependent, search for the corresponding
\ fsi-file to compile it where no one has compiled it before ;)
\ Forth systems have their own own dynamic loader and don't need addional C-Code.
\ That's why this file will just print normal forth-code once compiled
\ and can be used directly with include or require.
\ As all comments are stripped during the compilation, please
\ insert the copyright notice of the original file here.

\ ----===< prefix >===-----
c-library png16
s" png16" add-lib
\c #include <libpng16/png.h>
\c #ifdef __gnu_linux__
\c #undef stderr
\c extern struct _IO_FILE *stderr;
\c #endif

\ ----===< int constants >===-----
#8	constant CHAR_BIT
#255	constant UCHAR_MAX
#65535	constant USHRT_MAX
#-2147483648	constant INT_MIN
#2147483647	constant INT_MAX
#4294967295	constant UINT_MAX
#16	constant PNG_LIBPNG_VER_SONUM
#16	constant PNG_LIBPNG_VER_DLLNUM
#1	constant PNG_LIBPNG_VER_MAJOR
#6	constant PNG_LIBPNG_VER_MINOR
#37	constant PNG_LIBPNG_VER_RELEASE
#0	constant PNG_LIBPNG_VER_BUILD
#1	constant PNG_LIBPNG_BUILD_ALPHA
#2	constant PNG_LIBPNG_BUILD_BETA
#3	constant PNG_LIBPNG_BUILD_RC
#4	constant PNG_LIBPNG_BUILD_STABLE
#7	constant PNG_LIBPNG_BUILD_RELEASE_STATUS_MASK
#8	constant PNG_LIBPNG_BUILD_PATCH
#16	constant PNG_LIBPNG_BUILD_PRIVATE
#32	constant PNG_LIBPNG_BUILD_SPECIAL
#4	constant PNG_LIBPNG_BUILD_BASE_TYPE
#10637	constant PNG_LIBPNG_VER
#4	constant PNG_LIBPNG_BUILD_TYPE
#0	constant PNG_DISPOSE_OP_NONE
#1	constant PNG_DISPOSE_OP_BACKGROUND
#2	constant PNG_DISPOSE_OP_PREVIOUS
#0	constant PNG_BLEND_OP_SOURCE
#1	constant PNG_BLEND_OP_OVER
#-3	constant PNG_TEXT_COMPRESSION_NONE_WR
#-2	constant PNG_TEXT_COMPRESSION_zTXt_WR
#-1	constant PNG_TEXT_COMPRESSION_NONE
#0	constant PNG_TEXT_COMPRESSION_zTXt
#1	constant PNG_ITXT_COMPRESSION_NONE
#2	constant PNG_ITXT_COMPRESSION_zTXt
#3	constant PNG_TEXT_COMPRESSION_LAST
#1	constant PNG_HAVE_IHDR
#2	constant PNG_HAVE_PLTE
#8	constant PNG_AFTER_IDAT
#100000	constant PNG_FP_1
#50000	constant PNG_FP_HALF
#1	constant PNG_COLOR_MASK_PALETTE
#2	constant PNG_COLOR_MASK_COLOR
#4	constant PNG_COLOR_MASK_ALPHA
#0	constant PNG_COLOR_TYPE_GRAY
#3	constant PNG_COLOR_TYPE_PALETTE
#2	constant PNG_COLOR_TYPE_RGB
#6	constant PNG_COLOR_TYPE_RGB_ALPHA
#4	constant PNG_COLOR_TYPE_GRAY_ALPHA
#6	constant PNG_COLOR_TYPE_RGBA
#4	constant PNG_COLOR_TYPE_GA
#0	constant PNG_COMPRESSION_TYPE_BASE
#0	constant PNG_COMPRESSION_TYPE_DEFAULT
#0	constant PNG_FILTER_TYPE_BASE
#64	constant PNG_INTRAPIXEL_DIFFERENCING
#0	constant PNG_FILTER_TYPE_DEFAULT
#0	constant PNG_INTERLACE_NONE
#1	constant PNG_INTERLACE_ADAM7
#2	constant PNG_INTERLACE_LAST
#0	constant PNG_OFFSET_PIXEL
#1	constant PNG_OFFSET_MICROMETER
#2	constant PNG_OFFSET_LAST
#0	constant PNG_EQUATION_LINEAR
#1	constant PNG_EQUATION_BASE_E
#2	constant PNG_EQUATION_ARBITRARY
#3	constant PNG_EQUATION_HYPERBOLIC
#4	constant PNG_EQUATION_LAST
#0	constant PNG_SCALE_UNKNOWN
#1	constant PNG_SCALE_METER
#2	constant PNG_SCALE_RADIAN
#3	constant PNG_SCALE_LAST
#0	constant PNG_RESOLUTION_UNKNOWN
#1	constant PNG_RESOLUTION_METER
#2	constant PNG_RESOLUTION_LAST
#0	constant PNG_sRGB_INTENT_PERCEPTUAL
#1	constant PNG_sRGB_INTENT_RELATIVE
#2	constant PNG_sRGB_INTENT_SATURATION
#3	constant PNG_sRGB_INTENT_ABSOLUTE
#4	constant PNG_sRGB_INTENT_LAST
#79	constant PNG_KEYWORD_MAX_LENGTH
#256	constant PNG_MAX_PALETTE_LENGTH
#1	constant PNG_INFO_gAMA
#2	constant PNG_INFO_sBIT
#4	constant PNG_INFO_cHRM
#8	constant PNG_INFO_PLTE
#16	constant PNG_INFO_tRNS
#32	constant PNG_INFO_bKGD
#64	constant PNG_INFO_hIST
#128	constant PNG_INFO_pHYs
#256	constant PNG_INFO_oFFs
#512	constant PNG_INFO_tIME
#1024	constant PNG_INFO_pCAL
#2048	constant PNG_INFO_sRGB
#4096	constant PNG_INFO_iCCP
#8192	constant PNG_INFO_sPLT
#16384	constant PNG_INFO_sCAL
#32768	constant PNG_INFO_IDAT
#65536	constant PNG_INFO_eXIf
#131072	constant PNG_INFO_acTL
#262144	constant PNG_INFO_fcTL
#0	constant PNG_TRANSFORM_IDENTITY
#1	constant PNG_TRANSFORM_STRIP_16
#2	constant PNG_TRANSFORM_STRIP_ALPHA
#4	constant PNG_TRANSFORM_PACKING
#8	constant PNG_TRANSFORM_PACKSWAP
#16	constant PNG_TRANSFORM_EXPAND
#32	constant PNG_TRANSFORM_INVERT_MONO
#64	constant PNG_TRANSFORM_SHIFT
#128	constant PNG_TRANSFORM_BGR
#256	constant PNG_TRANSFORM_SWAP_ALPHA
#512	constant PNG_TRANSFORM_SWAP_ENDIAN
#1024	constant PNG_TRANSFORM_INVERT_ALPHA
#2048	constant PNG_TRANSFORM_STRIP_FILLER
#2048	constant PNG_TRANSFORM_STRIP_FILLER_BEFORE
#4096	constant PNG_TRANSFORM_STRIP_FILLER_AFTER
#8192	constant PNG_TRANSFORM_GRAY_TO_RGB
#16384	constant PNG_TRANSFORM_EXPAND_16
#32768	constant PNG_TRANSFORM_SCALE_16
#1	constant PNG_FLAG_MNG_EMPTY_PLTE
#4	constant PNG_FLAG_MNG_FILTER_64
#5	constant PNG_ALL_MNG_FEATURES
#0	constant PNG_CRC_DEFAULT
#1	constant PNG_CRC_ERROR_QUIT
#2	constant PNG_CRC_WARN_DISCARD
#3	constant PNG_CRC_WARN_USE
#4	constant PNG_CRC_QUIET_USE
#5	constant PNG_CRC_NO_CHANGE
#0	constant PNG_NO_FILTERS
#8	constant PNG_FILTER_NONE
#16	constant PNG_FILTER_SUB
#32	constant PNG_FILTER_UP
#64	constant PNG_FILTER_AVG
#128	constant PNG_FILTER_PAETH
#56	constant PNG_FAST_FILTERS
#248	constant PNG_ALL_FILTERS
#0	constant PNG_FILTER_VALUE_NONE
#1	constant PNG_FILTER_VALUE_SUB
#2	constant PNG_FILTER_VALUE_UP
#3	constant PNG_FILTER_VALUE_AVG
#4	constant PNG_FILTER_VALUE_PAETH
#5	constant PNG_FILTER_VALUE_LAST
#1	constant PNG_DESTROY_WILL_FREE_DATA
#1	constant PNG_SET_WILL_FREE_DATA
#2	constant PNG_USER_WILL_FREE_DATA
#8	constant PNG_FREE_HIST
#16	constant PNG_FREE_ICCP
#32	constant PNG_FREE_SPLT
#64	constant PNG_FREE_ROWS
#128	constant PNG_FREE_PCAL
#256	constant PNG_FREE_SCAL
#4096	constant PNG_FREE_PLTE
#8192	constant PNG_FREE_TRNS
#16384	constant PNG_FREE_TEXT
#32768	constant PNG_FREE_EXIF
#65535	constant PNG_FREE_ALL
#16928	constant PNG_FREE_MUL
#0	constant PNG_HANDLE_CHUNK_AS_DEFAULT
#1	constant PNG_HANDLE_CHUNK_NEVER
#2	constant PNG_HANDLE_CHUNK_IF_SAFE
#3	constant PNG_HANDLE_CHUNK_ALWAYS
#4	constant PNG_HANDLE_CHUNK_LAST
#7	constant PNG_INTERLACE_ADAM7_PASSES

\ -------===< structs >===--------
\ png_color
begin-structure png_color
drop 3 end-structure
\ png_color_16
begin-structure png_color_16
drop 10 end-structure
\ png_color_8
begin-structure png_color_8
drop 5 end-structure
\ png_sPLT_entry
begin-structure png_sPLT_entry
drop 10 end-structure
\ png_sPLT_t
begin-structure png_sPLT_t
drop 32 end-structure
\ png_time
begin-structure png_time
drop 8 end-structure
\ png_row_info
begin-structure png_row_info
drop 24 end-structure

\ ------===< callbacks >===-------
c-callback png_error_ptr: a s -- void	( <noname> <noname> -- )
c-callback png_rw_ptr: a a u -- void	( <noname> <noname> <noname> -- )
c-callback png_flush_ptr: a -- void	( <noname> -- )
c-callback png_read_status_ptr: a u n -- void	( <noname> <noname> <noname> -- )
c-callback png_write_status_ptr: a u n -- void	( <noname> <noname> <noname> -- )
c-callback png_malloc_ptr: a u -- a	( <noname> <noname> -- )
c-callback png_free_ptr: a a -- void	( <noname> <noname> -- )

\ ------===< functions >===-------
c-function png_access_version_number png_access_version_number  -- u	( -- )
c-function png_set_sig_bytes png_set_sig_bytes a n -- void	( png_ptr num_bytes -- )
c-function png_sig_cmp png_sig_cmp a u u -- n	( sig start num_to_check -- )
c-function png_create_read_struct png_create_read_struct s a a a -- a	( user_png_ver error_ptr error_fn warn_fn -- )
c-function png_create_write_struct png_create_write_struct s a a a -- a	( user_png_ver error_ptr error_fn warn_fn -- )
c-function png_get_compression_buffer_size png_get_compression_buffer_size a -- u	( png_ptr -- )
c-function png_set_compression_buffer_size png_set_compression_buffer_size a u -- void	( png_ptr size -- )
c-function png_longjmp png_longjmp a n -- void	( png_ptr val -- )
c-function png_write_sig png_write_sig a -- void	( png_ptr -- )
c-function png_write_chunk png_write_chunk a a a u -- void	( png_ptr chunk_name data length -- )
c-function png_write_chunk_start png_write_chunk_start a a u -- void	( png_ptr chunk_name length -- )
c-function png_write_chunk_data png_write_chunk_data a a u -- void	( png_ptr data length -- )
c-function png_write_chunk_end png_write_chunk_end a -- void	( png_ptr -- )
c-function png_create_info_struct png_create_info_struct a -- a	( png_ptr -- )
\ c-function png_info_init_3 png_info_init_3 a u -- void	( info_ptr png_info_struct_size -- )
c-function png_write_info_before_PLTE png_write_info_before_PLTE a a -- void	( png_ptr info_ptr -- )
c-function png_write_info png_write_info a a -- void	( png_ptr info_ptr -- )
c-function png_start_read_image png_start_read_image a -- void	( png_ptr -- )
c-function png_read_update_info png_read_update_info a a -- void	( png_ptr info_ptr -- )
c-function png_write_row png_write_row a a -- void	( png_ptr row -- )
c-function png_write_rows png_write_rows a a u -- void	( png_ptr row num_rows -- )
c-function png_write_image png_write_image a a -- void	( png_ptr image -- )
c-function png_write_end png_write_end a a -- void	( png_ptr info_ptr -- )
c-function png_destroy_info_struct png_destroy_info_struct a a -- void	( png_ptr info_ptr_ptr -- )
c-function png_destroy_read_struct png_destroy_read_struct a a a -- void	( png_ptr_ptr info_ptr_ptr end_info_ptr_ptr -- )
c-function png_destroy_write_struct png_destroy_write_struct a a -- void	( png_ptr_ptr info_ptr_ptr -- )
c-function png_set_crc_action png_set_crc_action a n n -- void	( png_ptr crit_action ancil_action -- )
c-function png_set_error_fn png_set_error_fn a a a a -- void	( png_ptr error_ptr error_fn warning_fn -- )
c-function png_get_error_ptr png_get_error_ptr a -- a	( png_ptr -- )
c-function png_set_write_fn png_set_write_fn a a a a -- void	( png_ptr io_ptr write_data_fn output_flush_fn -- )
c-function png_set_read_fn png_set_read_fn a a a -- void	( png_ptr io_ptr read_data_fn -- )
c-function png_get_io_ptr png_get_io_ptr a -- a	( png_ptr -- )
c-function png_set_read_status_fn png_set_read_status_fn a a -- void	( png_ptr read_row_fn -- )
c-function png_set_write_status_fn png_set_write_status_fn a a -- void	( png_ptr write_row_fn -- )
c-function png_malloc png_malloc a u -- a	( png_ptr size -- )
c-function png_calloc png_calloc a u -- a	( png_ptr size -- )
c-function png_malloc_warn png_malloc_warn a u -- a	( png_ptr size -- )
c-function png_free png_free a a -- void	( png_ptr ptr -- )
c-function png_free_data png_free_data a a u n -- void	( png_ptr info_ptr free_me num -- )
c-function png_data_freer png_data_freer a a n u -- void	( png_ptr info_ptr freer mask -- )
c-function png_error png_error a s -- void	( png_ptr error_message -- )
c-function png_chunk_error png_chunk_error a s -- void	( png_ptr error_message -- )
c-function png_get_valid png_get_valid a a u -- u	( png_ptr info_ptr flag -- )
c-function png_get_rowbytes png_get_rowbytes a a -- u	( png_ptr info_ptr -- )
c-function png_get_channels png_get_channels a a -- u	( png_ptr info_ptr -- )
c-function png_get_IHDR png_get_IHDR a a a a a a a a a -- u	( png_ptr info_ptr width height bit_depth color_type interlace_method compression_method filter_method -- )
c-function png_set_IHDR png_set_IHDR a a u u n n n n n -- void	( png_ptr info_ptr width height bit_depth color_type interlace_method compression_method filter_method -- )
c-function png_get_PLTE png_get_PLTE a a a a -- u	( png_ptr info_ptr palette num_palette -- )
c-function png_set_PLTE png_set_PLTE a a a n -- void	( png_ptr info_ptr palette num_palette -- )
c-function png_set_invalid png_set_invalid a a n -- void	( png_ptr info_ptr mask -- )
c-function png_get_copyright png_get_copyright a -- s	( png_ptr -- )
c-function png_get_header_ver png_get_header_ver a -- s	( png_ptr -- )
c-function png_get_header_version png_get_header_version a -- s	( png_ptr -- )
c-function png_get_libpng_ver png_get_libpng_ver a -- s	( png_ptr -- )
c-function png_get_uint_31 png_get_uint_31 a a -- u	( png_ptr buf -- )
c-function png_get_acTL png_get_acTL a a a a -- u	( png_ptr info_ptr num_frames num_plays -- )
c-function png_set_acTL png_set_acTL a a u u -- u	( png_ptr info_ptr num_frames num_plays -- )
c-function png_get_num_frames png_get_num_frames a a -- u	( png_ptr info_ptr -- )
c-function png_get_num_plays png_get_num_plays a a -- u	( png_ptr info_ptr -- )
c-function png_get_next_frame_fcTL png_get_next_frame_fcTL a a a a a a a a a a -- u	( png_ptr info_ptr width height x_offset y_offset delay_num delay_den dispose_op blend_op -- )
c-function png_set_next_frame_fcTL png_set_next_frame_fcTL a a u u u u u u u u -- u	( png_ptr info_ptr width height x_offset y_offset delay_num delay_den dispose_op blend_op -- )
c-function png_get_next_frame_width png_get_next_frame_width a a -- u	( png_ptr info_ptr -- )
c-function png_get_next_frame_height png_get_next_frame_height a a -- u	( png_ptr info_ptr -- )
c-function png_get_next_frame_x_offset png_get_next_frame_x_offset a a -- u	( png_ptr info_ptr -- )
c-function png_get_next_frame_y_offset png_get_next_frame_y_offset a a -- u	( png_ptr info_ptr -- )
c-function png_get_next_frame_delay_num png_get_next_frame_delay_num a a -- u	( png_ptr info_ptr -- )
c-function png_get_next_frame_delay_den png_get_next_frame_delay_den a a -- u	( png_ptr info_ptr -- )
c-function png_get_next_frame_dispose_op png_get_next_frame_dispose_op a a -- u	( png_ptr info_ptr -- )
c-function png_get_next_frame_blend_op png_get_next_frame_blend_op a a -- u	( png_ptr info_ptr -- )
c-function png_get_first_frame_is_hidden png_get_first_frame_is_hidden a a -- u	( png_ptr info_ptr -- )
c-function png_set_first_frame_is_hidden png_set_first_frame_is_hidden a a u -- u	( png_ptr info_ptr is_hidden -- )
c-function png_read_frame_head png_read_frame_head a a -- void	( png_ptr info_ptr -- )
c-function png_write_frame_head png_write_frame_head a a a u u u u u u u u -- void	( png_ptr info_ptr row_pointers width height x_offset y_offset delay_num delay_den dispose_op blend_op -- )
c-function png_write_frame_tail png_write_frame_tail a a -- void	( png_ptr info_ptr -- )

\ ----===< postfix >===-----
end-c-library
