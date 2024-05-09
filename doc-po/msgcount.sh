#!/bin/bash
pushd ${HOME}/work/gforth-docs-ja/doc-po/
ls -1 *.po | gawk -f ./po_count.awk
date
popd
