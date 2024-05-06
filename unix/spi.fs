\ This file has been generated using SWIG and fsi,
\ and is already platform dependent, search for the corresponding
\ fsi-file to compile it where no one has compiled it before ;)
\ Forth systems have their own own dynamic loader and don't need addional C-Code.
\ That's why this file will just print normal forth-code once compiled
\ and can be used directly with include or require.
\ As all comments are stripped during the compilation, please
\ insert the copyright notice of the original file here.

\ ----===< int constants >===-----
#107	constant SPI_IOC_MAGIC

\ -------===< structs >===--------
\ spi_ioc_transfer
begin-structure spi_ioc_transfer
	drop 16 4 +field spi_ioc_transfer-len
	drop 0 8 +field spi_ioc_transfer-tx_buf
	drop 28 1 +field spi_ioc_transfer-tx_nbits
	drop 29 1 +field spi_ioc_transfer-rx_nbits
	drop 20 4 +field spi_ioc_transfer-speed_hz
	drop 26 1 +field spi_ioc_transfer-bits_per_word
	drop 31 1 +field spi_ioc_transfer-pad
	drop 8 8 +field spi_ioc_transfer-rx_buf
	drop 24 2 +field spi_ioc_transfer-delay_usecs
	drop 27 1 +field spi_ioc_transfer-cs_change
	drop 30 1 +field spi_ioc_transfer-word_delay_usecs
drop 32 end-structure
