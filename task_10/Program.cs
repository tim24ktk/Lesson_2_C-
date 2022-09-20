/*
    Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

    456 -> 5
    782 -> 8
    918 -> 1
*/

int GetNumber()
{
    Console.WriteLine("Введите трёхзначное число");
    string numberStr = Console.ReadLine();
    int number = int.Parse(numberStr);

    return number;
}

int number = GetNumber();

if (number.ToString().Length == 3)
{
    Console.WriteLine((number / 10) % 10);
}
else
{
    Console.WriteLine("Вы ввели число отличное от трёхзначного!");
}

