# po_stat
# -*- coding:utf-8 -*-
# only list in-completed po files.
BEGIN {
    NEWBIE = 0  # default(0) 仕掛り print, 1: 未着手 print
    # printf("[%d]\n",ARGC)
    # printf("[%s]\n",ARGV[1])
    if (ARGC == 2) {
	if ( ARGV[1] == "NEWBIE" || ARGV[1] == "newbie" ) {
	    NEWBIE = 1
	    ARGC = 1  # ARGV[1]が入力ファイルとして扱われないようにする
	}
    }
    if (NEWBIE == 0) {
	print "status\t仕掛り"
    }
    if (NEWBIE == 1) {
	print "status\t未着手"
    }
}

{
    # 21 translated messages, 1 fuzzy translation, 16 untranslated messages.
    translated = 0
    fuzzy = 0
    untranslated = 0
    # print $0
    # msgfmt -v --statistics to stderr !! 
    "LANG=C msgfmt -v --statistics --output-file=/dev/null " $0 " 2>&1" | getline line
    # print "line=" line
    if (match(line, /([0-9]+)[ ]translated/, a)) {
	translated = a[1]
    }
    if (match(line, /([0-9]+)[ ]fuzzy/, b)) {
	fuzzy = b[1]
    }
    if (match(line, /([0-9]+)[ ]untranslated/, c)) {
	untranslated = c[1]
    }
    if (NEWBIE == 1 ) {
	# if ((translated <= 0) && (fuzzy == 0 || untranslated < 0 )) {
	if (translated <= 0) {
	    printf("%d+%df+%du\t%s\n", translated, fuzzy, untranslated, $0)
	}
    } else {
	if ((translated > 0) && (fuzzy != 0 || untranslated > 0 )) {
	    # print $0
	    # progress = (translated / (translated+fuzzy+untranslated)) * 100
	    # printf("%d+%df+%du(%3.2f%%)\t%s\n", translated, fuzzy, untranslated, progress, $0)
	    printf("%d+%df+%du\t%s\n", translated, fuzzy, untranslated, $0)
	}
    }
}
