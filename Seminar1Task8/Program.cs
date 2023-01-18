// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Clear();
Console.WriteLine();
Console.WriteLine("Hello!");
Console.WriteLine("Это задание выполнено Павлом Овчинниковым при обучении основам языка С#");
Console.WriteLine("Программа на вход принимает число и выдаёт все чётные числа до данного числа.");
Console.WriteLine(); // Строка для оформления интерфейса

Console.Write("Введите число: ");
string? inputNumber = Console.ReadLine();

if (inputNumber != null)
{
    int NumberN = int.Parse(inputNumber);
    for (int i = 1; i < NumberN; i++)
    {
        if (i % 2 == 0)
        {
            Console.Write(i);
            Console.Write(", ");
        }
    }
    if (NumberN % 2 == 0)
    { Console.Write(NumberN); }
}

Console.WriteLine();
Console.WriteLine("See you, goodbye!");
