# Домашние работы по курсу "Объектно-ориентированное программирование на C#"

## Домашняя работа 1. Введение

### Задача 1. Барроуз-Уилер

**Баллов** — 4

Реализовать преобразование Барроуза-Уилера. На вход подаётся строка, на выходе должна получиться строка, преобразованная Барроузом-Уилером, и позиция конца строки в результате преобразования. Реализовать также и обратное преобразование, принимающее преобразованную строку и позицию, и возвращающую исходную строку. Проверить, что исходная строка действительно восстанавливается.

+1 балл за решение, где в прямом преобразовании не строится явно таблица вращений строк;

Подумайте, как представлять вращение строки без лишних строк.

Обратное преобразование также не должно строить таблицу явно, но это хорошо описано в интернетах (построение циклической перестановки), поэтому реализация не принесёт дополнительного балла (зато её отсутствие будет минусом).

## Домашняя работа 2. Объектно-ориентированное программирование

### Задача 1. Бор

**Баллов** — 5

Реализовать в виде класса структуру данных "Бор" (http://neerc.ifmo.ru/wiki/index.php?title=%D0%91%D0%BE%D1%80)

Должны быть поддержаны следующие методы:

- `bool Add(string element)` (возвращает true, если такой строки ещё не было, работает за O(|element|))
- `bool Contains(string element)` (работает за O(|element|))
- `bool Remove(string element)` (возвращает true, если элемент реально был в дереве, работает за O(|element|))
- `int HowManyStartsWithPrefix(String prefix)` (работает за O(|prefix|))

И свойство 

- `int Size` (работает за O(1))

## Домашняя работа 3. Модульное тестирование

### Задача 1. Тесты для стекового калькулятора
**Баллов** — 2

Реализовать модульные тесты к задаче 2 домашней работы 2. Модульные тесты должны проверять работоспособность стекового калькулятора на корректных и некорректных строках, в случае использования разных стеков, при этом не содержать дублирующегося кода.

### Задача 2. LZW
**Баллов** — 6

На основе структуры данных "Бор" из д/з 2 (возможно, её придётся модифицировать для поддержки посимвольного добавления) реализовать алгоритм Лемпеля — Зива — Уэлча. Требуется написать консольное приложение, которое в качестве аргумента командной строки принимает путь к файлу, который надо сжать или разжать, и ключ -c, означающий, что файл надо сжать, или -u, означающий, что надо разжать. В качестве результата должен создаваться новый файл:

- если выполняется сжатие, файл именуется как "имя изначального файла".zipped;
- если выполняется разжатие, расширение .zipped отбрасывается.

Вы вправе в сжатом файле хранить любую дополнительную информацию. Обратите внимание, что сжиматься могут не только тексты, но и бинарные файлы — для тестирования будет сжат/разжат .exe-файл и запущен после разжатия.

Программа после сжатия должна печатать коэффициент сжатия на консоль.

Применение преобразования Барроуза-Уилера из задания 1 и измерение его влияния на коэффициент сжатия (то есть сколько без него/сколько с ним на нескольких достаточно больших тестах) принесёт вам один дополнительный балл.

Использование кодовых последовательностей переменной длины принесёт ещё один балл. 

Кроме того, ещё один балл будет разыгран среди решений сданных в срок: его получит решение с самым большим коэффициентом сжатия (подсказка: кодовые последовательности "оптимальной" длины, не кратной 8, могут быть путём к победе, потому что мало кто сможет это правильно сделать). Вспомните пару про двоичное представление данных из первого семестра.

Модульные тесты обязательны.

## Домашняя работа 4. Исключения и обработка ошибок

### Задача 1. Дерево разбора
**Баллов** — 5

Решить задачу о вычислении выражения по дереву разбора из прошлого семестра. Реализовать иерархию классов, описывающих дерево разбора, используя их, реализовать класс, вычисляющий значение выражения по дереву. Классы, представляющие операнды и операторы, должны сами уметь себя вычислять и печатать. Входной файл может быть некорректен, необходимо использовать исключения для сигнализации об ошибках (и тестировать, что они действительно бросаются).

Исходное условие:

По дереву разбора арифметического выражения вычислить его значение. Дерево разбора хранится в файле в виде `(<операция> <операнд1> <операнд2>)`, где `<операнд1>` и `<операнд2>` сами могут быть деревьями, либо числами. Например, выражение `(1 + 1) * 2` представляется в виде `(* (+ 1 1) 2)`. Должны поддерживаться операции `+`, `-`, `*`, `/` и целые числа в качестве аргументов. Требуется построить дерево в явном виде, распечатать его (не обязательно так же, как в файле), и посчитать значение выражения обходом дерева. Пример — по входному файлу `(* (+ 1 1) 2)` может печататься `( * ( + 1 1 ) 2 )` и выводиться 4.

### Задача 2. UniqueList
**Баллов** — 3

Без использования библиотечных контейнеров и массивов реализовать класс "Список" с методами добавления, удаления и изменения элемента по позиции, и, унаследовавшись от него, реализовать класс UniqueList, который не содержит повторяющихся значений. Реализовать классы исключений, которые генерируются при попытке добавления в такой список уже существующего или при попытке удаления несуществующего элемента.

## Домашняя работа 5. Экосистема open source проектов

### Задача 1. Роутеры
**Баллов** — 7

Есть участок сети, состоящий из роутеров, связанных Ethernet-соединениями. Поскольку разные куски этой сети администрируют разные организации, у сети отсутствует единая архитектура, что часто приводит к избыточным соединениям между роутерами, либо наоборот, изоляции участков сети. Современные сетевые протоколы устроены так, что избыточные соединения почти столь же опасны, как и их отсутствие — если роутер не знает маршрута до целевого узла, он рассылает пакеты по всем портам, кроме того, откуда пакет пришёл, в надежде, что кто-то из роутеров-адресатов сможет его доставить. Поэтому не исключена ситуация, когда пакеты начинают ходить по кругу до тех пор, пока не исчерпается их время жизни (Time To Live, TTL), что приводит к лавине дублирующихся пакетов, нагружает сеть и снижает общую производительность. 

Ваша задача — написать консольное приложение, которое по данной топологии сети генерирует конфигурацию для каждого роутера и проверяет, что все роутеры достижимы. Топология задана в файле в виде списка роутеров и того, к каким другим роутерам они подключены каналами какой пропускной способности, например,

```
1: 2 (10), 3 (5)
2: 3 (1)
```

задаёт сеть из трёх роутеров, где первый связан со вторым и третьим, второй с первым и третьим, третий с первым и вторым. Причём канал между первым и вторым имеет в десять раз большую пропускную способность, чем между вторым и третьим. Вы должны вывести в файл аналогичную таблицу, где оставлены только те соединения, которые необходимы для обеспечения связности сети, без циклов, например,

```
1: 2 (10), 3 (5)
```

Причём конфигурация должна быть в каком-то смысле оптимальной: сумма пропускных способностей всех каналов в сети должна быть максимальной.

Если построить такую таблицу невозможно (то есть сеть изначально была не связной), программа должна вывести в поток ошибок (обратите внимание, не в файл и не совсем на консоль) сообщение, что сеть не связна, и завершить работу с ненулевым кодом возврата. Пути до входного и выходного файлов должны приниматься в качестве параметров.

Сборка и запуск юнит-тестов на GitHub Actions для этой задачи обязательны.

## Домашняя работа 6. Событийно-ориентированное программирование

### Задача 1. Map, Filter, Fold
**Баллов** — 2

Реализовать функции Map, Filter и Fold:

- Map принимает список и функцию, преобразующую элемент списка. Возвращаться должен список, полученный применением переданной функции к каждому элементу переданного списка. Например, `Map(new List<int>() {1, 2, 3}, x => x * 2)` должен возвращать список `[2; 4; 6]`.
- Filter принимает список и функцию, возвращающую булевое значение по элементу списка. Возвращаться должен список, составленный из тех элементов переданного списка, для которых переданная функция вернула true.
- Fold принимает список, начальное значение и функцию, которая берёт текущее накопленное значение и текущий элемент списка, и возвращает следующее накопленное значение. Сама Fold возвращает накопленное значение, получившееся после всего прохода списка. Например, `Fold(new List<int>() {1, 2, 3}, 1, (acc, elem) => acc * elem)` работала бы так: сначала в acc клался бы 1, потом умножался бы на 1, потом результат (1) умножался бы на 2, потом результат (2) умножался бы на 3, потом результат (6) возвращался бы в качестве ответа.

Если умеете генерики, подумайте, как сделать тип функций наиболее общим (за +1 балл к оценке, если работа сдана до лекции про генерики).

### Задача 2. Игра
**Баллов** — 4

На базе класса, генерирующего события по нажатию на клавиши управления курсором (EventLoop с пары), реализовать консольное приложение, позволяющее управлять персонажем, перемещающимся по карте. Карта состоит из свободного пространства и стен, и должна грузиться из файла. Приложение должно отображать карту и персонажа (символом `@`) в окне консоли, и позволять персонажу перемещаться по карте, реагируя на клавиши управления курсором. Будут полезны свойства Console.CursorLeft и Console.CursorTop. Каждый раз перерисовывать всю карту нельзя.

Обратите внимание, для данной задачи, как и для остальных, обязательны юнит-тесты, однако использовать функции управления устройством "Консоль" (такие как Console.CursorLeft и Console.CursorTop) из юнит-тестов не получится. Подумайте, как применить знания про лямбда-функции, чтобы тесты не пытались делать то, чего делать не могут, но в "боевом" режиме всё работало.

## Домашняя работа 7. Пользовательский интерфейс

### Задача 1. Калькулятор
**Баллов** — 6

Написать калькулятор с пользовательским интерфейсом (по примеру стандартного калькулятора вашей любимой операционной системы). Калькулятор должен вычислять операторы немедленно, то есть если пользователь нажимает «7», «+», «3», «+», на экране должно отобразиться «10». Ввод кнопочный, то есть разбор и прямое редактирование выражения делать не надо (соответственно, скобки, приоритет операций и т.п. калькулятор не должен поддерживать). Рекомендуется вспомнить про конечные автоматы для упрощения формализации вещей в духе «если оператор нажат первый раз, ждём второй операнд, если второй операнд уже есть, печатаем ответ и запоминаем оператор».

Юнит-тесты здесь обязательны на всю функциональность, не связанную непосредственно со взаимодействием с пользователем, поэтому стоит сразу реализовывать калькулятор правильно — тонкий и глупый слой пользовательского интерфейса и отдельно класс с бизнес-логикой, который даже не знает про существование GUI.

Использование data binding для отображения результатов вычисления принесёт вам один дополнительный балл сверх максимума за эту задачу.

## Домашняя работа 8. Контейнеры и генерики

### Задача 1. Список с пропусками
**Баллов** — 5

Реализовать генерик-коллекцию на базе списка с пропусками (https://en.wikipedia.org/wiki/Skip_list). При этом коллекция должна реализовывать интерфейс `System.Collections.Generic.IList<T>` (https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1). Надо следовать всем правилам реализации структуры данных в библиотеке:

- проверять на корректность все аргументы всех public-методов и свойств, бросать подходящие исключения;
- реализовать инвалидацию итератора при изменении коллекции;
- разобраться, что за свойство `IsReadOnly`;
- разобраться с `IComparable<T>`;
- можно использовать `System.Collections.Generic.List<T>` как пример.

При этом, как обычно, нужны юнит-тесты, в которых надо не забыть проверить, что по списку можно ходить `foreach`.

## Домашняя работа 9. Визуальное моделирование, UML

### Задача 1. Реверси
**Баллов** — 4

Нарисовать на UML диаграмму классов для игры «реверси», с несколькими видами «ботов», которые могли бы играть вместо человека. Диаграмма должна быть довольно подробным проектом системы. Реализовывать этот проект не нужно. Желательно пользоваться средствами визуального моделирования наподобие Visual Paradigm (https://www.visual-paradigm.com/download/community.jsp) либо https://www.diagrams.net/, присылать скриншоты с диаграммой и исходники (файлы .vpp в случае Visual Paradigm).

Плюс 4 балла сверх максимума за реализацию по созданному проекту (но именно в таком порядке: сначала сдаёте диаграмму, получаете одобрение, только потом садитесь писать код).

## Домашняя работа 10. Доклады

### Задача 1 (дополнительная). SCP-087
**Баллов** — 6

Сделать с помощью Unity очередной клон компьютерной игры SCP-087 (https://ru.wikipedia.org/wiki/SCP-087). Игра в жанре сурвайвал-хоррор должна представлять собой спуск с фонариком по тёмной бесконечной лестнице, при этом с вероятностью N% (где N должно как-то удобно задаваться) на очередной лестничной клетке появляется ужасное нечто и убивает главного героя, на чём игра заканчивается, показав сообщение, что игрок проиграл. Моделировать главного героя не требуется, «летающей камеры» достаточно, в качестве ужасного нечто можно использовать любую достаточно ужасную 3д-модель (шар, куб или чайник вполне подойдут). Желательно (хотя и не обязательно) звуковое сопровождение, создающее гнетущую атмосферу экзистенциального ужаса, и соответствующие текстуры на стенах. См. также http://scpfoundation.net/scp-087. Использовать только актуальную версию Unity.

## Дополнительные задачи

### Архиватор Хаффмана
**Баллов** — 6

Спроектировать в максимально объектно-ориентированном стиле и реализовать консольную утилиту, выполняющую сжатие/разжатие произвольного файла по алгоритму Хаффмана (описание которого предлагается найти самостоятельно). Утилита должна принимать два параметра:

- имя файла, который необходимо сжать или разжать;
- ключ `--compress` или `--uncompress`. Также должны поддерживаться их сокращённые формы, `-c` и `-u`, соответственно.

При получении ключа `--compress` (`-c`) программа должна создать файл с именем, соответствующем исходному, и расширением `.zipped`, куда вывести сжатое алгоритмом Хаффмана содержимое исходного файла, плюс любую дополнительную информацию, которую считаете нужной добавить для разжатия. Также должен печататься коэффициент сжатия (отношение исходной длины файла к сжатой). 
 
При получении ключа `--uncompress` (`-u`) программа должна создать файл, имя которого соответствует полученному в первом аргументе, но без расширения `.zipped`, и содержащий исходную информацию. Последовательное применение утилиты с ключами `--compress` и `--uncompress` должно возвращать файл в исходное состояние.

Обратите внимание, что сжатию могут подвергаться произвольные бинарные файлы.