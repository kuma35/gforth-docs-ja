#!/usr/bin/sh
# mk-po4a-cfg.sh <<src-pathfile(relative)>> <<pot-path(relative)>> <<lang(e.g: ja)>> <<po-path(relative)>> <<dst-pathfile(relative)>>
SRC_FILE=$1
POT_PATH=$2
LANGCODE=$3
PO_PATH=$4
DST_FILE=$5
echo "# generate by $0" `date`
echo "[po4a_langs] ${LANGCODE}"
echo "[po4a_paths] ${POT_PATH}/\$master.pot \$lang:${PO_PATH}/\$master.po"
echo "[type: texinfo] ${SRC_FILE} \$lang:${DST_FILE}"
