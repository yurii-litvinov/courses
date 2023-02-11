% Style for Computer Science Center slides. Uses "night" color scheme, corporate colors and minimizes visual clutter.
% Using .. in style name because latex was created before Git and knows nothing about relative paths to style files.
\ProvidesClass{../cscslides}[2021/02/03 version 1.00 CSC lecture slides]
\NeedsTeXFormat{LaTeX2e}

\ProcessOptions\relax

% Loading Beamer as a base class. 
\LoadClass[xetex,mathserif,serif]{beamer}

% Loading common packages
\usepackage{polyglossia}
\setdefaultlanguage[babelshorthands=true]{russian}
\usepackage{tabu}
\usepackage{moresize}

% Loading minted and stopping it from highlighting every lexer error
% See https://tex.stackexchange.com/questions/343494/minted-red-box-around-greek-characters
\usepackage{minted}
\makeatletter
\AtBeginEnvironment{minted}{\dontdofcolorbox}
\def\dontdofcolorbox{\renewcommand\fcolorbox[4][]{##4}}
\makeatother

% Loading font (we use default font instead of corporate for the sake of simplicity, maybe we should change that)
\usepackage{fontspec}
\setmainfont{FreeSans}
\newfontfamily{\russianfonttt}{FreeSans}

% Loading "textpos" and setting length units --- for precise positioning of some images.
\usepackage{textpos}
\setlength{\TPHorizModule}{1cm}
\setlength{\TPVertModule}{1cm}

% Selecting Beamer outer theme with minimal clutter
\useoutertheme{default}

% Setting base color theme which we will heavily modify below (it shall be in separate style file, but...)
% Main text color iss default for "cormorant", for example.
\usecolortheme{cormorant}

% Two main colors from brandbook. Green, which we will use for nearly everything:
\definecolor{cscmain}{RGB}{7, 195, 159}

% Black-grey, which we will use as a slide background.
\definecolor{cscblack}{RGB}{0, 0, 0}

% Link colors
\hypersetup{colorlinks,linkcolor=,urlcolor=cscmain}

% Slide element colors
\setbeamercolor{titlelike}{fg=cscmain,bg=cscblack}
\setbeamercolor{background canvas}{bg=cscblack}
\setbeamercolor{item}{fg=cscmain}
\setbeamercolor{structure}{fg=cscmain}

% Remove slide navigation buttons
\beamertemplatenavigationsymbolsempty

% Setting line separation for tables, to have some vertical space between text and row border in table rows.
\tabulinesep=1.2mm


% At last, some custom commands that shall output same-looking text for all slides:
% Attribution info, mostly for "borrowed" images:
\newcommand{\attribution}[1] {
    \begin{flushright}\begin{scriptsize}\textcolor{gray}{\copyright\ #1}\end{scriptsize}\end{flushright}
}

% Slide title command. Takes three arguments --- title, date and subtitle (third is optional)
\newcommand{\slidetitle}[3][{}] {
    \title{#2}
    \subtitle{#1}
    \author[Юрий Литвинов]{Юрий Литвинов\\\small{\textcolor{gray}{yurii.litvinov@gmail.com}}}
    \date{#3}
}

% Convenience command that includes an image. Takes image name, size as a fraction of text width, and optional attribution.
\newcommand{\image}[3][{}] {
    \begin{center}
        \includegraphics[width=#3\textwidth]{#2}
    \end{center}
    \if\relax\detokenize{#1}\relax
    \else
        \attribution{#1}
    \fi
}