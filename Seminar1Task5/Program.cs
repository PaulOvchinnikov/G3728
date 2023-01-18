// Задача №5
// Напишите программу, которая на вход принимает
// одно число (N), а на выходе показывает все целые
// числа в промежутке от -N до N.
// Например:
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> " -2, -1, 0, 1, 2"

Console.Clear();
Console.WriteLine();
Console.WriteLine("Hello!");
Console.WriteLine("Это задание выполнено Павлом Овчинниковым при обучении основам языка С#");
Console.WriteLine("Программа, которая на вход принимает число (N), а на выходе показывает все целые числа в промежутке от -N до N.");
Console.WriteLine(); // Строка для оформления интерфейса

Console.Write("Введите число: ");
string? inputNumber = Console.ReadLine();

if (inputNumber != null)
{
    int NumberN = int.Parse(inputNumber);
    for (int i = 0; i < NumberN * 2; i++)
    {
        Console.Write(i - NumberN);
        Console.Write(", ");
    }
Console.Write(NumberN);
}
Console.WriteLine();
Console.WriteLine("The End");
