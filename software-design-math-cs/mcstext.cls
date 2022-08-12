% Style for Mathematics and Computer Science lecture notes.
% Using .. in style name because latex was created before Git and knows nothing about relative paths to style files.
\ProvidesClass{../mcstext}[2022/08/11 version 1.00 Math-CS lecture slides]
\NeedsTeXFormat{LaTeX2e}

\ProcessOptions\relax

% Loading base document class 
\LoadClass[a5paper]{article}

% Setting up page geometry
\usepackage[a5paper, top=8mm, bottom=8mm, left=8mm, right=8mm]{geometry}

% Setting up support for Russian language.
\usepackage{polyglossia}
\setdefaultlanguage[babelshorthands=true]{russian}

% Setting up font.
\usepackage{fontspec}
\setmainfont{FreeSerif}
\newfontfamily{\russianfonttt}[Scale=0.7]{DejaVuSansMono}

% Loading common packages
\usepackage[font=scriptsize]{caption}

\usepackage{amsmath}
\usepackage{amssymb,amsfonts,textcomp}
\usepackage{color}
\usepackage{array}
\usepackage{hhline}
\usepackage{cite}
\usepackage{textcomp}

\usepackage{tabu}

\usepackage{graphicx}
\usepackage{indentfirst}
\usepackage{multirow}
\usepackage{subfig}
\usepackage{footnote}
\usepackage{minted}
\usepackage{bookmark}

\usepackage[hang,multiple]{footmisc}
\renewcommand{\footnotelayout}{\raggedright}

% Setting up nice-looking hyperlinks.
% \PassOptionsToPackage{hyphens}{url}\usepackage[xetex,linktocpage=true,plainpages=false,pdfpagelabels=false]{hyperref}
% \hypersetup{colorlinks=true, linkcolor=blue, citecolor=blue, filecolor=blue, urlcolor=blue, pdftitle=1, pdfauthor=, pdfsubject=, pdfkeywords=}

% Setting default column separator width.
\newlength\Colsep
\setlength\Colsep{10pt}

% Forbidding TeX to ever use margins.
\sloppy

% Defining text title command. Takes one argument --- title.
\newcommand{\texttitle}[2] {
    \pagestyle{plain}
    \title{#1}
    \author{Юрий Литвинов\\\small{y.litvinov@spbu.ru}}
    \date{}
}