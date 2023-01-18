// Задача №1
// Напишите программу, которая на вход принимает
// два числа и проверяет, является ли первое число
// квадратом второго.
// Например:
// a = 25; b = 5 -> да
// a = 2 b = 10 -> нет
// a = 9; b = -3 -> да
// a = -3 b = 9 -> нет

Console.WriteLine();
Console.WriteLine("Hello!");
Console.WriteLine("Это задание выполнено Павлом Овчинниковым при обучении основам языка С#");
Console.WriteLine("Программа на вход принимает два числа и проверяет, является ли первое число квадратом второго..");
Console.WriteLine();

Console.Write("Введите первое число: ");
string? inputNumber1 = Console.ReadLine();
Console.Write("Введите второе число: ");
string? inputNumber2 = Console.ReadLine();

if (inputNumber1 != null && inputNumber2 != null)
{
    if (Math.Pow(int.Parse(inputNumber2), 2) == int.Parse(inputNumber1))
    {
        Console.Write("Первое число является квадратом второго");
    }
    else
    {
        Console.Write("Первое число НЕ является квадратом второго");
    }
}
    Console.WriteLine();

