// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Clear();
Console.WriteLine();
Console.WriteLine("Hello!");
Console.WriteLine("Это задание выполнено Павлом Овчинниковым при обучении основам языка С#");
Console.WriteLine("Программа на вход принимает число и выдаёт все чётные числа до данного числа.");
Console.WriteLine(); // Строка для оформления интерфейса

Console.Write("Введите трёхзначное число: ");
string? inputNumber = Console.ReadLine();

// if (inputNumber != null)
int NumberN = int.Parse(inputNumber);
int lastDigil = NumberN % 10;
Console.Write($"Последняя цифра в числе: ");
Console.WriteLine(lastDigil);

Console.WriteLine();
Console.WriteLine("See you, goodbye!");
