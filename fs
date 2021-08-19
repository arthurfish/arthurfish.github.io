#/bin/bash
find . | xargs grep "$1$2$3$4$5$6$7$8$9" 2> /dev/null | less
