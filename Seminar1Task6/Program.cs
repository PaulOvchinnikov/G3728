// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да; -3 -> нет; 7 -> нет

Console.Clear();
Console.WriteLine();
Console.WriteLine("Hello!");
Console.WriteLine("Это задание выполнено Павлом Овчинниковым при обучении основам языка С#");
Console.WriteLine("Программа , которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).");
Console.WriteLine(); // Строка для оформления интерфейса

Console.Write("Введите число: ");
string? inputNumber = Console.ReadLine();

if (inputNumber != null)
{
    int Number = int.Parse(inputNumber);
    if (Number % 2 == 1)
    {
        Console.Write($"Число {Number} нечетное");
    }
    else
        {
        Console.Write($"Число {Number} четное");
        }
}
