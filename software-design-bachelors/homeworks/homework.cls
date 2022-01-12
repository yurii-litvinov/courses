\ProvidesClass{homework}[2021/01/12 version 1.00 HSE/SPbSU homework class]
\NeedsTeXFormat{LaTeX2e}

\ProcessOptions\relax
\LoadClass[a4paper,12pt]{article}

\usepackage[a4paper, top=10mm, bottom=10mm, left=10mm, right=10mm]{geometry}

\usepackage{fontspec}
\setmainfont[Mapping=tex-text]{CMU Serif}
\setmonofont[Mapping=tex-text]{CMU Typewriter Text}
\usepackage{polyglossia}
\setdefaultlanguage{russian}
\setotherlanguage{english}

\usepackage{indentfirst}
\usepackage[colorlinks=true,urlcolor=blue,linkcolor=black,filecolor=black,citecolor=black]{hyperref}

\usepackage{minted}

\usepackage{enumitem}
\setlist{noitemsep,topsep=1mm}

\usepackage[small,compact]{titlesec}

\sloppy
\raggedbottom
\pagestyle{plain}

\usepackage{xkeyval}

\define@key{hw}{title}{\def\hw@title{#1}}
\define@key{hw}{publicationDate}{\def\hw@publicationDate{#1}}
\define@key{hw}{deadline}{\def\hw@deadline{#1}}
\define@key{hw}{score}{\def\hw@score{#1}}

\newcommand\makeHomeworkHeading[1]{
    \setkeys{hw}{#1}
    
    \begin{center}
        {\Large \hw@title}

        \vspace{3mm}
        {\hw@publicationDate}
    \end{center}
    \thispagestyle{empty}

    \textbf{Дедлайн: 10:00 \hw@deadline}

    \textbf{Баллов: \hw@score}
    \vspace{5mm}
}