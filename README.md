Напишите программу "Дом, который построил Джек".

В программе должна быть коллекция строк. Каждая строка - строка стихотворения "Дом, который построил Джек".

Изначально коллекция пустая

Также в программе есть 9 классов - Part1, Part2, Part3, ..., Part9

В каждом классе PartN есть метод AddPart, который на вход принимает коллекцию строк, добавляет в нее новые строки и сохраняет получившуюся коллекцию в свойство "Poem". Требуется это делать так, чтобы исходная коллекция не изменилась. Какие именно строки добавляет каждый класс посмотрите здесь - https://russkaja-skazka.ru/dom-kotoryiy-postroil-dzhek-stihi-samuil-marshak/ (например Part3 добавляет третий параграф стихотворения)

Надо создать экземпляры этих классов, а затем последовательно вызвать каждый из методов AddPart, передавай в него результат вызова предыдущего метода, примерно так: 'MyPart3(MyPart2.Poem)'

В конце работы программы надо вывести значение свойства "Poem" у каждого из классов и убедиться, что изменяя коллекцию в одном классе Вы не затрагивали коллекцию в предыдущем.
