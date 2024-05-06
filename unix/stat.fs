begin-structure file-stat
  drop 0 8 +field st_dev
  drop 8 8 +field st_ino
  drop 24 4 +field st_mode
  drop 28 4 +field st_uid
  drop 32 4 +field st_gid
  drop 40 8 +field st_rdev
  drop 48 8 +field st_size
  drop 56 8 +field st_blksize
  drop 64 8 +field st_blocks
  drop 72 16 +field st_atime
  drop 88 16 +field st_mtime
  drop 104 16 +field st_ctime
drop 144 end-structure
