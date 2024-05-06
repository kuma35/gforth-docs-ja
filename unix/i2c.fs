\ This file has been generated using SWIG and fsi,
\ and is already platform dependent, search for the corresponding
\ fsi-file to compile it where no one has compiled it before ;)
\ Forth systems have their own own dynamic loader and don't need addional C-Code.
\ That's why this file will just print normal forth-code once compiled
\ and can be used directly with include or require.
\ As all comments are stripped during the compilation, please
\ insert the copyright notice of the original file here.

\ ----===< int constants >===-----
#1	constant I2C_M_RD
#16	constant I2C_M_TEN
#512	constant I2C_M_DMA_SAFE
#1024	constant I2C_M_RECV_LEN
#2048	constant I2C_M_NO_RD_ACK
#4096	constant I2C_M_IGNORE_NAK
#8192	constant I2C_M_REV_DIR_ADDR
#16384	constant I2C_M_NOSTART
#32768	constant I2C_M_STOP
#1	constant I2C_FUNC_I2C
#2	constant I2C_FUNC_10BIT_ADDR
#4	constant I2C_FUNC_PROTOCOL_MANGLING
#8	constant I2C_FUNC_SMBUS_PEC
#16	constant I2C_FUNC_NOSTART
#32	constant I2C_FUNC_SLAVE
#32768	constant I2C_FUNC_SMBUS_BLOCK_PROC_CALL
#65536	constant I2C_FUNC_SMBUS_QUICK
#131072	constant I2C_FUNC_SMBUS_READ_BYTE
#262144	constant I2C_FUNC_SMBUS_WRITE_BYTE
#524288	constant I2C_FUNC_SMBUS_READ_BYTE_DATA
#1048576	constant I2C_FUNC_SMBUS_WRITE_BYTE_DATA
#2097152	constant I2C_FUNC_SMBUS_READ_WORD_DATA
#4194304	constant I2C_FUNC_SMBUS_WRITE_WORD_DATA
#8388608	constant I2C_FUNC_SMBUS_PROC_CALL
#16777216	constant I2C_FUNC_SMBUS_READ_BLOCK_DATA
#33554432	constant I2C_FUNC_SMBUS_WRITE_BLOCK_DATA
#67108864	constant I2C_FUNC_SMBUS_READ_I2C_BLOCK
#134217728	constant I2C_FUNC_SMBUS_WRITE_I2C_BLOCK
#268435456	constant I2C_FUNC_SMBUS_HOST_NOTIFY
#393216	constant I2C_FUNC_SMBUS_BYTE
#1572864	constant I2C_FUNC_SMBUS_BYTE_DATA
#6291456	constant I2C_FUNC_SMBUS_WORD_DATA
#50331648	constant I2C_FUNC_SMBUS_BLOCK_DATA
#201326592	constant I2C_FUNC_SMBUS_I2C_BLOCK
#251592712	constant I2C_FUNC_SMBUS_EMUL
#268402696	constant I2C_FUNC_SMBUS_EMUL_ALL
#32	constant I2C_SMBUS_BLOCK_MAX
#1	constant I2C_SMBUS_READ
#0	constant I2C_SMBUS_WRITE
#0	constant I2C_SMBUS_QUICK
#1	constant I2C_SMBUS_BYTE
#2	constant I2C_SMBUS_BYTE_DATA
#3	constant I2C_SMBUS_WORD_DATA
#4	constant I2C_SMBUS_PROC_CALL
#5	constant I2C_SMBUS_BLOCK_DATA
#6	constant I2C_SMBUS_I2C_BLOCK_BROKEN
#7	constant I2C_SMBUS_BLOCK_PROC_CALL
#8	constant I2C_SMBUS_I2C_BLOCK_DATA
#1793	constant I2C_RETRIES
#1794	constant I2C_TIMEOUT
#1795	constant I2C_SLAVE
#1798	constant I2C_SLAVE_FORCE
#1796	constant I2C_TENBIT
#1797	constant I2C_FUNCS
#1799	constant I2C_RDWR
#1800	constant I2C_PEC
#1824	constant I2C_SMBUS
#42	constant I2C_RDWR_IOCTL_MAX_MSGS
#42	constant I2C_RDRW_IOCTL_MAX_MSGS

\ -------===< structs >===--------
\ i2c_msg
begin-structure i2c_msg
	drop 4 2 +field i2c_msg-len
	drop 8 8 +field i2c_msg-buf
	drop 2 2 +field i2c_msg-flags
	drop 0 2 +field i2c_msg-addr
drop 16 end-structure
\ i2c_smbus_data
begin-structure i2c_smbus_data
	drop 0 34 +field i2c_smbus_data-block
	drop 0 2 +field i2c_smbus_data-word
	drop 0 1 +field i2c_smbus_data-byte
drop 34 end-structure
\ i2c_smbus_ioctl_data
begin-structure i2c_smbus_ioctl_data
	drop 1 1 +field i2c_smbus_ioctl_data-command
	drop 8 8 +field i2c_smbus_ioctl_data-data
	drop 4 4 +field i2c_smbus_ioctl_data-size
	drop 0 1 +field i2c_smbus_ioctl_data-read_write
drop 16 end-structure
\ i2c_rdwr_ioctl_data
begin-structure i2c_rdwr_ioctl_data
	drop 8 4 +field i2c_rdwr_ioctl_data-nmsgs
	drop 0 8 +field i2c_rdwr_ioctl_data-msgs
drop 16 end-structure
