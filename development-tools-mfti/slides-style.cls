% Style for SPbU lectures. Uses classic black-on-white theme with minimal visual clutter.
% Using .. in style name because latex was created before Git and knows nothing about relative paths to style files.
\ProvidesClass{../slides-style}[2022/08/14 version 1.00 SPbU lecture slides]
\NeedsTeXFormat{LaTeX2e}

\ProcessOptions\relax

% Loading Beamer as a base class. 
\LoadClass[xetex,mathserif,serif]{beamer}

% Loading common packages
\usepackage{polyglossia}
\setdefaultlanguage[babelshorthands=true]{russian}
\usepackage{tabu}
\usepackage{moresize}
\usepackage{bookmark}

% Loading minted and stopping it from highlighting every lexer error
% See https://tex.stackexchange.com/questions/343494/minted-red-box-around-greek-characters
\usepackage{minted}
\makeatletter
\AtBeginEnvironment{minted}{\dontdofcolorbox}
\def\dontdofcolorbox{\renewcommand\fcolorbox[4][]{##4}}
\makeatother

% Loading font (we use default)
\usepackage{fontspec}
\setmainfont{FreeSans}
\newfontfamily{\russianfonttt}{FreeSans}

% Loading "textpos" and setting length units --- for precise positioning of some images.
\usepackage{textpos}
\setlength{\TPHorizModule}{1cm}
\setlength{\TPVertModule}{1cm}

% Selecting Beamer outer theme with minimal clutter and template with frame numbers
\useoutertheme{default}
\setbeamertemplate{footline}[text line]{% 
    \hfill\strut{% 
        \scriptsize\color{black!60}% 
        \insertframenumber/\inserttotalframenumber 
    }% 
} 

% Link colors
\definecolor{links}{HTML}{2A1B81}
\hypersetup{colorlinks,linkcolor=,urlcolor=links}

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
    \author[Юрий Литвинов]{Юрий Литвинов\newline\small{\textcolor{gray}{y.litvinov@spbu.ru}}}
    \date{#3}
}