/*
    Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

    645 -> 5

    78 -> третьей цифры нет

    32679 -> 6
*/

string GetNumber()
{
    Console.WriteLine("Введите число");
    string numberStr = Console.ReadLine();

    return numberStr;
}

string number = GetNumber();

if (number.Length >= 3)
{
    Console.WriteLine(number[2]);
}
else
{
    Console.WriteLine("В введенном вами числе третьей цифры нет!");
}