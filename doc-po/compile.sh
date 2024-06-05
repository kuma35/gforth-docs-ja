#!/bin/bash
PROJ=${HOME}/work/gforth-docs-ja
BRANCH=docs-ja-0
cd ${PROJ}/doc-po
make ja
exitcode=$?
if [ ${exitcode} -ne 0 ]; then
    notify-send -u critical gforth-docs-ja "doc-po/Makefile エラー"
    exit ${exitcode}
fi
cd ${PROJ}/doc-ja

for no_translate_file in Makefile Makefile.in fdl.texi gpl.texi version.texi gforth.css gforth.js ; do
    cp -n ../doc/${no_translate_file} .
done

# 2024.05.08
# make から ターゲット ps はとりあえず外す。エラー出たので。
# l.2: Unicode char @u8:こ not defined for Texinfo
# make info html txt
make info $*
exitcode=$?
if [ ${exitcode} -ne 0 ]; then
    notify-send -u critical gforth-docs-ja "doc-ja/Makefile エラー"
    exit ${exitcode}
fi

# info 用 dir ファイル生成
rm -f dir
install-info --info-file=gforth.info --dir-file=dir
install-info --info-file=vmgen.info --dir-file=dir

# cp htmls
cp -rp --update ${PROJ}/doc-ja/gforth/* ${PROJ}/docs/${BRANCH}/gforth/
cp -rp --update ${PROJ}/doc-ja/vmgen/* ${PROJ}/docs/${BRANCH}/vmgen/

# restore htmls and manpaese in Documentation-ja
#${PROJ}/doc-po/restore-htmls.sh

notify-send -u normal gforth-docs-ja "compile完了。"

