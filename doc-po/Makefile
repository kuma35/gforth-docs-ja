
SRC_DIR = ../doc
TEXI_EXT = .texi
PO_DIR = .
PO_EXT = .po
DST_DIR = ../doc-ja
IGNORE = version.texi fdl.texi gpl.texi

# 2024/05/09
# version.texi, fdl.texi は 翻訳対象から外す(doc/ から /doc-ja へ直にcp)
SRC_PACKAGE = $(filter-out $(IGNORE),$(notdir $(wildcard $(SRC_DIR)/*$(TEXI_EXT))))

SRC_FILES = $(addprefix $(SRC_DIR)/,$(SRC_PACKAGE))

# $(warning SRC_FILES = $(SRC_FILES))

PO_FILES = $(addprefix $(PO_DIR)/,$(SRC_PACKAGE:$(TEXI_EXT)=$(PO_EXT)))

# $(warning PO_FILES = $(PO_FILES))

DST_FILES = $(addprefix $(DST_DIR)/,$(SRC_PACKAGE))

# $(warning DST_FILES = $(DST_FILES))

$(PO_FILES): $(PO_DIR)/%$(PO_EXT) : $(SRC_DIR)/%$(TEXI_EXT)
	po4a-updatepo --format texinfo --master-charset utf8 --master $< --po $@

$(DST_FILES): $(DST_DIR)/%$(TEXI_EXT) : $(PO_DIR)/%$(PO_EXT)
	po4a-translate --format texinfo --master-charset utf8 --keep 0 --master $(subst $(DST_DIR),$(SRC_DIR),$(@:$(PO_EXT)=$(TEXI_EXT))) --po $< --localized $@


# doc/Makefile に 追加した場合に反映させる。
$(DST_DIR)/Makefile : $(SRC_DIR)/Makefile
	cp $< $@

ja: $(DST_FILES) $(DST_DIR)/Makefile

# rsyncの $(SRC_DIR)の直後の / 重要。超重要
# cmds-*.txt are templates. not need translation. copy from $(SRC_DIR) to $(DST_DIR)
# rsync -av --exclude "*.txt" $(SRC_DIR)/ $(DST_DIR)
# clean:
#	find $(DST_DIR) -type f | xargs rm -f
#	for fname in ChangeLog dir_sample Makefile Makefile.in trampvar.text.in ;do cp $(SRC_DIR)/$fname $(DST_DIR)/ ;done


# .PHONEY: ja clean

all: ja
