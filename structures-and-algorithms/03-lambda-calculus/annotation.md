# Лекция 3: Нетипизированное λ-исчисление

Лекция совсем не про F\#, а про математические основы функционального программирования. Рассмотрим:
- что такое лямбда-исчисление вообще, какая интуиция за ним стоит;
- формально введём лямбда-исчисление:
  - λ-терм,
  - свободные и связанные переменные,
  - подстановку, α-, β- и η-преобразования λ-термов,
  - аксиомы равенства и бета-редукции;
- разные стратегии редукции, и что результат всё равно один (теорема Чёрча-Россера, без доказательства);
- комбинаторы, комбинатор неподвижной точки, как через него ввести рекурсию;
- как собрать разные структуры данных из "голых" λ-термов:
  - булевы выражения,
  - числа (нумералы Чёрча),
  - пары,
  - списки.