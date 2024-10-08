# Домашние работы по курсу "Программирование на C"
**Дедлайны по всем задачам** — две недели

## Домашняя работа 1. Введение

### Задача 1. Swap
**Баллов** — 1

Поменять значения двух целочисленных переменных местами (без привлечения третьей переменной и файлов)

### Задача 2. Нулевые элементы
**Баллов** — 1

Напишите программу, считающую количество нулевых элементов в массиве.

### Задача 3. Неполное частное
**Баллов** — 1

Написать алгоритм нахождения неполного частного от деления a на b (целые числа), используя только операции сложения, вычитания и умножения. Убедиться, что программа корректно (в смысле определения неполного частного из википедии) работает на отрицательных значениях и ругается на некорректных. 

### Задача 4. Счастливые билеты
**Баллов** — 1

Подсчитайте число «счастливых билетов» из шести цифр, всего существующих в мире (билет считается «счастливым», если сумма первых трёх цифр его номера равна сумме трёх последних). Считать способом, придуманным на паре — посчитать количество трёхзначных чисел со всеми возможными суммами цифр через массив, возвести в квадрат и сложить.

### Задача 5. Баланс скобок
**Баллов** — 1

Напишите алгоритм проверки баланса скобок в исходной строке (т.е. число открывающих скобок равно числу закрывающих и выполняется правило вложенности скобок). Скобки бывают только одного типа.

### Задача 6. Простые числа
**Баллов** — 1

Напишите программу, печатающую все простые числа, не превосходящие заданного числа.

### Задача 7. Подстрока
**Баллов** — 1

Заданы две строки: S и S1 . Найдите количество вхождений S1 в S как подстроки.

### Задача 8. Массив
**Баллов** — 1

Дан массив целых чисел x[1]...x[m + n], рассматриваемый как соединение двух его отрезков: начала x[1]...x[m] длины m и конца x[m + 1]...x[m + n] длины n. Не используя дополнительных массивов, переставить местами начало и конец. Делать способом, обсуждавшимся на паре — перевернуть один фрагмент, другой, и весь массив. Нужна отдельная функция, переворачивающая заданный кусок массива.

## Домашняя работа 2. Сложность алгоритмов

Ко всем задачам обязательны тесты. Также в этой домашней работе потребуется выделять память под массив с помощью malloc() и освобождать с помощью free().

### Задача 1. Числа Фибоначчи
**Баллов** — 2

Реализовать вычисление чисел Фибоначчи рекурсивно, реализовать итеративно, выяснить, с какого номера числа Фибоначчи рекурсивный вариант заметно медленнее итеративного. 

### Задача 2. Возведение в степень
**Баллов** — 2

Реализовать возведение в целую степень — в лоб (за линейное время) и за О(log n).

### Задача 3. Пузырёк и подсчёт
**Баллов** — 2

Написать сортировки пузырьком и подсчётом. С помощью функции clock() из time.h сравнить времена их работы на массиве из 100000 элементов. 

### Задача 4. Полукусорт
**Баллов** — 2

Написать программу, которая заполняет массив случайными значениями (с использованием функции rand из stdlib.h), потом преобразует его без использования дополнительных массивов так, что в начале массива будут элементы, меньшие первого, а в конце — большие либо равные первому. Программа должна работать за линейное время.

## Домашняя работа 3. Сортировки

### Задача 1. Умный QSort
**Баллов** — 3

Реализовать qsort, который для сортировки кусков массива размером меньше 10 использует сортировку вставкой.

### Задача 2. Поиск
**Баллов** — 3

Получить с клавиатуры два числа, n и k, сгенерировать случайно массив из n чисел, сгенерировать k случайных целых чисел, для каждого из них проверить, содержится ли оно в массиве. Надо придумать алгоритм с временной сложностью O(n log n + k log n), или лучший.

### Задача 3. Самый частый элемент
**Баллов** — 3

Найти наиболее часто встречающийся элемент в массиве быстрее, чем за O(n^2). Если таких элементов несколько, надо вывести любой из них.

### Задача 4. GitHub
**Баллов** — 2

Завести аккаунт с разумным именем на https://github.com. Выложить туда в ветку main уже зачтённые задачи (при этом придумав разумную структуру папок), все незачтённые выложить в отдельные ветки и сделать пуллреквесты. Имеет смысл посмотреть презентацию, https://git-scm.com/book/ru/v1 и поставить графический клиент типа https://tortoisegit.org/ для облегчения жизни.

## Домашняя работа 4. Внутреннее представление данных, модули и файлы

### Задача 1. Двоичное представление
**Баллов** — 3

Ввести два числа, перевести в двоичное представление в дополнительном коде и напечатать, сложить в столбик в двоичном представлении, вывести сумму, перевести в десятичное, вывести сумму в десятичном виде. Все сообщения писать по-русски.

### Задача 2. Модули и файлы
**Баллов** — 3

Переделать задачу 3 из прошлого задания так, чтобы сортировка была в отдельном модуле и читала входные данные из файла.

### Задача 3. Телефонный справочник
**Баллов** — 3

Написать программу — телефонный справочник. Она должна уметь хранить имена и номера телефонов, в интерактивном режиме осуществлять следующие операции:

- 0 - выйти
- 1 - добавить запись (имя и телефон)
- 2 - распечатать все имеющиеся записи
- 3 - найти телефон по имени
- 4 - найти имя по телефону
- 5 - сохранить текущие данные в файл

При запуске программа должна читать данные из файла (того самого, в который сохраняет данные), если файла нет — начинать с пустой базы номеров. Размер базы ограничен сотней записей.

## Домашняя работа 5. Динамические структуры данных

Все задачи решаются с помощью стека — его надо реализовать единожды в отдельном модуле, и использовать во всех этих задачах. Чтобы каждую задачу можно было сдавать в отдельной ветке, надо сначала сделать ветку для модуля "стек", реализовать там стек (и тесты для него, в отдельном модуле), а затем уже от неё отвести три ветки для конкретных задач. При этом правки к самому стеку надо делать в ветке для стека, а потом мерждить изменения из неё в ветки с задачами (это довольно типичный процесс разработки, когда одна фича зависит от другой). При этом пуллреквест из ветки для стека открывать не надо.

Комментарии ко всем функциям из заголовочного файла обязательны.

### Задача 1. Постфиксный калькулятор
**Баллов** — 3

Написать программу для вычисления арифметического выражения в постфиксной форме. С клавиатуры вводится последовательность цифр (для простоты) и операций +, -, *, /, представляющая выражение в постфиксной форме, должен выводиться результат вычисления. Например, на тесте 9 6 - 1 2 + * должно получиться 9.

### Задача 2. Продвинутый баланс скобок
**Баллов** — 3

Написать программу проверки баланса скобок в строке, скобки могут быть трёх видов: `()`, `[]`, `{}`. Скобочная последовательность вида `({)}` считается некорректной, `({})` — корректной.

### Задача 3. Сортировочная станция
**Баллов** — 3

Написать программу, преобразующую выражение из инфиксной формы в постфиксную. В выражении могут быть знаки `+`, `-`, `*`, `/`, скобки и цифры. Пример: `(1 + 1) * 2` должно преобразовываться в `1 1 + 2 *`. Алгоритм перевода предлагается найти самостоятельно (алгоритм "сортировочной станции" Э. Дейкстры).

## Домашняя работа 6. Абстрактные типы данных

### Задача 1. Сортированный список
**Баллов** — 3

Написать программу, которая в диалоговом режиме позволяет осуществлять следующие операции:

- 0 – выйти
- 1 – добавить значение в сортированный список
- 2 – удалить значение из списка
- 3 – распечатать список

Все операции должны сохранять сортированность. Начинаем с пустого списка.

### Задача 2. Считалочка
**Баллов** — 3

Отряд из 41-го сикария, защищавший галилейскую крепость Массада, не пожелал сдаваться в плен блокировавшим его превосходящим силам римлян. Сикарии стали в круг и договорились, что каждые два воина будут убивать третьего, пока не погибнут все. Самоубийство — тяжкий грех, но тот, кто в конце концов останется последним, должен будет его совершить. Иосиф Флавий, командовавший этим отрядом, якобы быстро рассчитал, где нужно стать ему и его другу, чтобы остаться последними, но не для того, чтобы убить друг друга, а чтобы сдать крепость римлянам. В нашем случае участвует n воинов и убивают каждого m-го. Требуется определить номер k начальной позиции воина, который должен будет остаться последним. Считать с помощью циклического списка.

### Задача 3. Сортировка слиянием
**Баллов** — 4

Реализовать сортировку слиянием. Во входном файле последовательность записей "имя — номер телефона". Программа должна отсортировать эти записи либо по имени, либо по номеру телефона, в зависимости от выбора пользователя, и вывести результат на экран. Количество записей заранее неизвестно, так что надо реализовывать списками на указателях. Подумайте, как обобщить код — просто раскопировать код сортировки для двух разных случаев, естественно, не пойдёт.

Особо обращайте внимание на утечки памяти.

## Домашняя работа 7. Деревья

### Задача 1. Дерево поиска
**Баллов** — 5

Реализовать АТД "словарь" на основе двоичного дерева поиска, хранящий ключи типа `int` и связанные с ними значения типа `char *`. Должны поддерживаться следующие операции:

- Добавить значение по заданному ключу в словарь. Если такой ключ уже есть, значение заменяется на новое.
- Получить значение по заданному ключу из словаря. Если такого ключа нет, возвращается NULL.
- Проверить наличие заданного ключа в словаре.
- Удалить заданный ключ и связанное с ним значение из словаря. Если такого ключа нет, функция ничего не делает.
- Программа должна работать в интерактивном режиме, то есть пользователю должно предоставляться меню, позволяющее выполнить эти операции. 

Особое внимание уделяйте работе с памятью (рекомендуется использовать отладчик памяти, чтобы проверить, что всё удаляется как надо).

### Задача 2. Дерево разбора
**Баллов** — 5

По дереву разбора арифметического выражения вычислить его значение. Дерево разбора хранится в файле в виде (<операция> <операнд1> <операнд2>), где <операнд1> и <операнд2> сами могут быть деревьями, либо числами. Например, выражение `(1 + 1) * 2` представляется в виде `(* (+ 1 1) 2)`. Должны поддерживаться операции `+`, `-`, `*`, `/` и целые числа в качестве аргументов. Требуется построить дерево в явном виде, распечатать его (не обязательно так же, как в файле), и посчитать значение выражения обходом дерева.

Может быть полезна функция `ungetc` (если не `'('`, возвращаем символ в поток и читаем число fscanf-ом). Можно считать, что входной файл корректен. Пример: по входному файлу `(* (+ 1 1) 2)` может печататься `( * ( + 1 1 ) 2 )` и выводиться 4.

## Домашняя работа 8. Cамобалансирующиеся деревья

### Задача 1. АВЛ-дерево
**Баллов** — 8

Реализовать словарь с ключами типа `char *` и значениями типа `char *` , на основе АВЛ-дерева. Должны поддерживаться следующие операции.

- Добавить значение по заданному ключу в словарь. Если такой ключ уже есть, значение заменяется на новое.
- Получить значение по заданному ключу из словаря. Если такого ключа нет, возвращается NULL.
- Проверить наличие заданного ключа.
- Удалить заданный ключ и связанное с ним значение из словаря. Если такого ключа нет, функция ничего не делает.

Программа должна работать в интерактивном режиме, то есть пользователю должно предоставляться меню, позволяющее выполнить эти операции.

## Домашняя работа 9. Хеш-таблицы

### Задача 1. Хеш-таблица
**Баллов** — 5

Посчитать частоты встречаемости слов в тексте с помощью хеш-таблицы. На входе файл с текстом, вывести на консоль все слова, встречающиеся в этом тексте с количеством раз, которое встречается каждое слово. Словом считается последовательность символов, разделённая пробелами, разные словоформы считаются разными словами. Хеш-таблицу реализовать в отдельном модуле, использующем модуль «Список». Подсчитать и вывести также коэффициент заполнения хеш-таблицы, максимальную и среднюю длину списка в сегменте таблицы.

## Домашняя работа 10. Графы

### Задача 1. Государства
**Баллов** — 7

Есть множество городов и дороги, связывающие эти города. Для каждой дороги задана её длина. Задача — распределить города между государствами по такому алгоритму: задаются `k` столиц каждого государства, далее по очереди каждому государству добавляется ближайший незанятый город, непосредственно связанный дорогой с каким-либо городом, уже принадлежащим государству (столицей или каким-либо городом, добавленным на одном из предыдущих шагов). Процесс продолжается до тех пор, пока все города не будут распределены. Граф дорог связный. Во входном файле: `n` — число городов и `m` — число дорог. Далее следуют сами дороги в формате: `i j len`, `i` и `j` — номера городов, `len` — длина дороги. Далее задано число `k` — число столиц, далее — `k` чисел — номера столиц. Надо вывести на консоль номера государств и списки городов, принадлежащих государствам.

### Задача 2. Сборка из консоли
**Баллов** — 3

Написать .bat-скрипт (либо .sh-скрипт, если у вас не Windows), который бы собрал с помощью MsBuild (или gcc или clang, если у вас не Windows) все проекты с тестами в main репозитория, после чего запустил тесты каждого (там, где они есть) и напечатал про каждый проект, прошли его тесты или нет. Под Windows вполне допустимо, чтобы всё работало только в Developer Command Prompt.

Может потребоваться модифицировать существующие решения, чтобы при наличии некоторого аргумента командной строки запускались только тесты, и правильно возвращался код возврата.

Поможет:

- погугить про argc/argv;
- справка по консольным командам: https://ss64.com/nt/;
- цикл FOR в cmd.

### Задача 3. CI (необязательная)
**Баллов** — 4

Реализовать на GitHub Actions сборку и запуск тестов для каждого нового коммита (включая ветки). В случае, если сборка не удалась или тесты не прошли, сборка должна отмечаться как проваленная.

## Домашняя работа 11. Подстроки, графы

### Задача 1. Поиск подстроки
**Баллов** — 4

Реализовать поиск подстроки алгоритмом Бойера-Мура, Рабина-Карпа или Кнута-Моррисса-Пратта (на ваш выбор). Из файла читается текст, с консоли — строка, программа должна выводить на консоль позицию первого вхождения введённой строки в файле.

### Задача 2. GraphViz
**Баллов** — 4

По данной матрице смежности графа сгенерировать его представление на языке dot, запустить на него программу dot из пакета GraphViz, получить .png-файл с визуализацией графа и показать его средствами стандартного просмотрщика изображений операционной системы. При этом всё должно происходить автоматически (могут помочь .bat/.sh-файлы или функция system стандартной библиотеки Си). dot.exe выкладывать в репозиторий не надо (достаточно указать в инструкции, где он должен лежать. +1 балл за использование переменной окружения для определения пути к dot.exe — при условии, что в инструкции будет написано, какую и во что выставлять).

## Домашняя работа 12. Автоматы

### Задача 1. Лексер вещественных чисел
**Баллов** — 3

Реализовать с помощью switch по состоянию лексический анализатор, проверяющий, является ли введённая последовательность символов вещественным числом (вещественное число задаётся регулярным выражением `digit+ (. digit+)? (E(+ | -)? digit+)?`, где `digit` — `[0..9]`).

### Задача 2. Лексер комментариев
**Баллов** — 3

С помощью ДКА с явной таблицей состояний, заданной в файле, вывести на консоль все комментарии С вида `/* комментарий */` из входного файла (вместе с символами "`/* */`").