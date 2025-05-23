# Лекция 8: Синтаксический анализ, часть 2: FParsec vs FsLex/FsYacc

Вторая лекция про синтаксический анализ, на сей раз уже на F\#. Попробуем, используя знания с предыдущей лекции, реализовать несложный парсер арифметических выражений двумя способами:

- на парсер-комбинаторной библиотеке FParsec;
- на генераторе синтаксических анализаторов FSLex/FsYacc.

Для этого придётся:

- реализовать представление AST;
- определить грамматику и семантические действия;
- для FParsec — факторизовать грамматику;
- для FParsec — описать Parse Tree и построение AST по Parse Tree.

---

- Слайды: https://github.com/yurii-litvinov/courses/blob/master/programming-4th-semester/09-syntax-analysis-2/09-syntax-analysis-2-slides.pdf