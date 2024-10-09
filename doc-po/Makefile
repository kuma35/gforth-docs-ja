LANG_CODE = ja
SRC_DIR = ../doc
TEXI_EXT = .texi
POT_DIR = ./pot
PO_DIR = .
PO_EXT = .po
DST_DIR = ../doc-ja
PO4A = po4a
PO4A_CFG_DIR = ./po4a-cfg
PO4A_CFG_EXT = .cfg
IGNORE = version.texi fdl.texi gpl.texi

# 2024/05/09
# version.texi, fdl.texi は 翻訳対象から外す(doc/ から /doc-ja へ直にcp)
SRC_PACKAGE = $(filter-out $(IGNORE),$(notdir $(wildcard $(SRC_DIR)/*$(TEXI_EXT))))

SRC_FILES = $(addprefix $(SRC_DIR)/,$(SRC_PACKAGE))

$(warning SRC_FILES = $(SRC_FILES))

PO4A_CFG_FILES = $(addprefix $(PO4A_CFG_DIR)/,$(addsuffix $(PO4A_CFG_EXT),$(SRC_PACKAGE)))

$(warning PO4A_CFG_FILES = $(PO4A_CFG_FILES))

# PO_FILES = $(addprefix $(PO_DIR)/,$(SRC_PACKAGE:$(TEXI_EXT)=$(PO_EXT)))
PO_FILES = $(addprefix $(PO_DIR)/,$(addsuffix $(PO_EXT),$(SRC_PACKAGE)))

$(warning PO_FILES = $(PO_FILES))

DST_FILES = $(addprefix $(DST_DIR)/,$(SRC_PACKAGE))

$(warning DST_FILES = $(DST_FILES))

# $(error "debug stop")

$(PO4A_CFG_FILES): $(PO4A_CFG_DIR)/%$(PO4A_CFG_EXT) : $(SRC_DIR)/%$(SRC_EXT)
	bash mk-po4a-cfg.sh $< $(POT_DIR) $(LANG_CODE) $(PO_DIR) $(addprefix $(DST_DIR)/,$(notdir $<)) > $@
	cat $@

$(PO_FILES): $(PO_DIR)/%$(PO_EXT) : $(SRC_DIR)/%$(SRC_EXT) $(PO4A_CFG_FILES)
	# po4a-updatepo -M utf8 -f texinfo -m $< -p $@
	# po4a-updatepo --master-charset utf8 --format texinfo --master $< --po $@
	po4a --verbose --no-translations --keep 0 --master-charset UTF-8 $(addprefix $(PO4A_CFG_DIR)/,$(notdir $($<:$(PO_EXT)=$(PO4A_CFG_EXT))))


$(DST_FILES): $(DST_DIR)/%$(TEXI_EXT) : $(PO_DIR)/%$(PO_EXT) $(PO4A_CFG_FILES)
	# po4a-translate -f texinfo -keep 0 -M utf8 -m $(subst $(DST_DIR),$(SRC_DIR),$(@:$(PO_EXT)=$(TEXI_EXT))) -p $< -l $@
	# po4a-translate --format texinfo --keep 0 --master-charset utf8 --master $(subst $(DST_DIR),$(SRC_DIR),$(@:$(PO_EXT)=$(TEXI_EXT))) --po $< --localized $@
	po4a --verbose --no-update --keep 0 --master-charset UTF-8 $(addprefix $(PO4A_CFG_DIR)/,$(addsuffix $(PO4A_CFG_EXT),$(notdir $@)))


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
