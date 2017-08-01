Supporting material for some courses of SPbSU SE chair and SPbAU MIT chair.

We use xetex (from TeXLive distribution) with "minted" package to typeset source code fragments. 
Minted requires installed Python 3 with "pygments" package and `--shell-escape` option for xelatex.

To build slides and texts you need to install TeXLive, Python 3 and "pygments" package. Then, build .tex files with

```
xelatex --shell-escape file-name.tex
```
