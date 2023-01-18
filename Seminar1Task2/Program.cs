// Задача 2
// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine();
Console.WriteLine("Hello!");
Console.WriteLine("Это задание выполнено Павлом Овчинниковым при обучении основам языка С#");
Console.WriteLine("Программа на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.");
Console.WriteLine();

Console.Write("Введите первое число: ");
string? inputNumber1 = Console.ReadLine();
Console.Write("Введите второе число: ");
string? inputNumber2 = Console.ReadLine();

if (inputNumber1 != null && inputNumber2 != null)
{   int Number1 = int.Parse(inputNumber1);
    int Number2 = int.Parse(inputNumber2);

    if (Number1 > Number2)
    {         Console.WriteLine("Первое число больше второго");    }
    else
    {   if (Number1 == Number2)
        { Console.WriteLine("Числа равны");}
        else
        { Console.WriteLine("Второе число больше первого"); }
    }
}
    Console.WriteLine();

