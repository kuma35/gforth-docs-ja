#!/bin/bash
# option NEWBIE 
pushd ${HOME}/work/gforth-docs-ja/doc-po/
ls -1 *.po | awk -f po_stat.awk $1
date
popd
