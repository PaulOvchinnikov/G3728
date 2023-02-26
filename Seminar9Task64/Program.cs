using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

Console.Clear();
Console.WriteLine("Привет! Это задание выполнено Павлом Овчинниковым при обучении основам языка С#");
Console.WriteLine(@"
Задача 64: Задайте значение N. Напишите программу, которая выведет все 
натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.
");
// Console.WriteLine();


/// Метод ввода вещественного числа
int ReadData(string msg)
{
    Console.Write(msg);
    // double read_Data = double.Parse(Console.ReadLine() ?? "0");
    string? read_string_Data = Console.ReadLine() ?? "0";
    int read_Data;
    while (!int.TryParse(read_string_Data, out read_Data))
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("Ошибка! Повторите ввод: ");
        Console.ResetColor();
        read_string_Data = Console.ReadLine() ?? "0";
    }
    return read_Data;
}


// Метод формирования ряда натуральных чисел (рекурсия)
void NaturalNumbers(int n)
{
    if (n < 1)
    {
        Console.WriteLine($"{n} не натуральное число");
        n = ReadData("Введите натуральное число: ");
        Console.WriteLine();
    }
    if (n == 1)
    {
        Console.Write("1 .");
        return;
    }
    Console.Write($"{n}, ");
    NaturalNumbers(n - 1);
}

/// Main - Блок решения задач
int n = ReadData("Введите натуральное число: ");
Console.Write($"Ряд натуральных чисел от {n} до 1: \t");

NaturalNumbers(n);

Console.WriteLine();
Console.WriteLine("The End");