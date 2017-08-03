Supporting material for some courses of SPbSU SE chair and SPbAU MIT chair.

We use xetex (from TeXLive distribution) with "minted" package to typeset source code fragments. 
Minted requires installed Python 3 with "pygments" package and `--shell-escape` option for xelatex.

To build slides and texts you need to install TeXLive, Python 3 and "pygments" package. Then, build .tex files with

```
xelatex --shell-escape file-name.tex
```

To contribute feel free to fork this repository and make a pull request. Please provide a source for added information as TeX comments (reference to a book, article, blog post etc.)
