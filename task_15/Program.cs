/*
    Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

    6 -> да
    7 -> да
    1 -> нет
*/

int GetNumber()
{
    Console.WriteLine("Введите номер дня недели");
    string numberStr = Console.ReadLine();
    int number = int.Parse(numberStr);

    return number;
}

int number = GetNumber();

if (number == 6 || number == 7)
{
    Console.WriteLine("Выходной!");
}
else if (number > 0 && number < 6)
{
    Console.WriteLine("Не выходной!");
}
else
{
    Console.WriteLine("Такого дня недели не существует!");
}