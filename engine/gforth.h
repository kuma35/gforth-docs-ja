/* gforth library header

  Authors: Anton Ertl, Bernd Paysan
  Copyright (C) 2016,2017,2019,2020,2022,2023 Free Software Foundation, Inc.

  This file is part of Gforth.

  Gforth is free software; you can redistribute it and/or
  modify it under the terms of the GNU General Public License
  as published by the Free Software Foundation, either version 3
  of the License, or (at your option) any later version.

  This program is distributed in the hope that it will be useful,
  but WITHOUT ANY WARRANTY; without even the implied warranty of
  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
  GNU General Public License for more details.

  You should have received a copy of the GNU General Public License
  along with this program; if not, see http://www.gnu.org/licenses/.
*/

#ifndef __GFORTH_H__
#define __GFORTH_H__ 1
#ifdef __cplusplus
extern "C" {
#endif

#include <setjmp.h>
#include <gforth/0.7.9_20240418/amd64/config.h>

#define GFORTH_VERSION_MAJOR 0
#define GFORTH_VERSION_MINOR 7
#define GFORTH_VERSION_MICRO 9
#define GFORTH_VERSION_DATE 20240418

typedef CELL_TYPE Cell;
typedef unsigned CELL_TYPE UCell;
typedef unsigned char Char;
typedef double Float;
typedef Char *Address;
typedef void *Label;
typedef Label *Xt;

typedef struct {
  Cell next_task;
  Cell prev_task;
  Cell save_task;
  Cell* sp0;
  Cell* rp0;
  Float* fp0;
  Address lp0;
  Xt *throw_entry;
  Cell *handler;
  Cell first_throw;
  Cell *wraphandler; /* experimental */
} user_area;

typedef struct {
  Cell magic;
  Cell *spx;
  Cell *rpx;
  Address lpx;
  Float *fpx;
  user_area* upx;
  Xt *s_ip;
  Cell *s_rp;
  jmp_buf * throw_jumpptr;
} stackpointers;

typedef struct {
  Address base;		/* base address of image (0 if relocatable) */
  UCell checksum;	/* checksum of ca's to protect against some
			   incompatible	binary/executable combinations
			   (0 if relocatable) */
  UCell image_size;	/* all sizes in bytes */
  UCell dict_size;
  UCell data_stack_size;
  UCell fp_stack_size;
  UCell return_stack_size;
  UCell locals_stack_size;
  Xt *boot_entry;	/* initial ip for booting (in BOOT) */
  Xt *throw_entry;	/* ip after signal (in THROW) */
  Xt *quit_entry;
  Xt *execute_entry;
  Xt *find_entry;
  Label *xt_base;         /* base of DOUBLE_INDIRECT xts[], for comp-i.fs */
  Label *label_base;      /* base of DOUBLE_INDIRECT labels[], for comp-i.fs */
} ImageHeader;
/* the image-header is created in main.fs */

extern PER_THREAD stackpointers gforth_SPs;

#define gforth_magic (gforth_SPs.magic)
#define gforth_SP (gforth_SPs.spx)
#define gforth_RP (gforth_SPs.rpx)
#define gforth_LP (gforth_SPs.lpx)
#define gforth_FP (gforth_SPs.fpx)
#define gforth_UP (gforth_SPs.upx)
#define saved_ip (gforth_SPs.s_ip)
#define saved_rp (gforth_SPs.s_rp)
#define throw_jmp_handler (gforth_SPs.throw_jumpptr)

extern void *gforth_engine(Xt *, stackpointers *);
extern Cell gforth_main(int argc, char **argv, char **env);
extern int gforth_args(int argc, char ** argv, char ** path, char ** imagename);
extern ImageHeader* gforth_loader(char* imagename, char* path);
extern user_area* gforth_stacks(Cell dsize, Cell rsize, Cell fsize, Cell lsize);
extern void gforth_free_stacks(user_area* t);
extern void gforth_free_dict();
extern Cell gforth_go(Xt* ip0);
extern Cell gforth_boot(int argc, char** argv, char* path);
extern void gforth_bootmessage();
extern Cell gforth_start(int argc, char ** argv);
extern Cell gforth_quit();
extern Xt gforth_find(Char * name);
extern Cell gforth_execute(Xt xt);
extern void gforth_cleanup();
extern void gforth_printmetrics();
extern void gforth_setstacks(user_area * t);

#ifdef __cplusplus
}
#endif
#endif /* __GFORTH_H__ */
