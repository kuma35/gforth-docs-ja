#!/bin/sh
PROJ=${HOME}/work/gforth-docs-ja
cd ${PROJ}/doc-po
make ja
exitcode=$?
if [ ${exitcode} -ne 0 ]; then
    notify-send -u critical gforth-docs-ja "doc-po/Makefile エラー"
    exit ${exitcode}
fi
cd ${PROJ}/doc-ja
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

# gen file "dir" for info. and publish to docs/info/
#make -f ${PROJ}/doc-po/publish-info.mak
#exitcode=$?
#if [ ${exitcode} -ne 0 ]; then
#    notify-send -u critical gforth-docs-ja "publish-info.mak エラー"
#    exit ${exitcode}
#fi
# restore htmls and manpaese in Documentation-ja
#${PROJ}/doc-po/restore-htmls.sh
#${PROJ}/doc-po/restore-manpages.sh
# for github pages
# DIFF=diff ${PROJ}/doc-po/install-webdoc-only-html.sh ${PROJ}/docs/htmldocs
#gawk -f ${PROJ}/Documentation-po/publish-index.awk TEMPLATE=${PROJ}/Documentation-po/index.html.template OUTPUT=${PROJ}/docs/index.html < ${PROJ}/../git/GIT-VERSION-FILE
#exitcode=$?
#if [ ${exitcode} -ne 0 ]; then
#    notify-send -u critical git-docs-ja "publish-index.awk エラー"
#    exit ${exitcode}
#fi
# restore htmls in docs
#cd ${PROJ}/docs
#${PROJ}/Documentation-po/restore-htmls.sh
#
notify-send -u normal gforth-docs-ja "compile完了。"

