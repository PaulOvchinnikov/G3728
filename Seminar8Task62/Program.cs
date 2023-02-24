using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

Console.Clear();
Console.WriteLine("Привет! Это задание выполнено Павлом Овчинниковым при обучении основам языка С#");
Console.WriteLine(@"
Задача 62. Напишите программу, которая заполнит спирально массив M на N.
");
Console.WriteLine();

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

// Mетод заполнения трехмерного массива по спирали


int[,] CreateSnakeArray(int n, int m)
{
    int[,] arr = new int[n, m];
    int row = 0, col = 0, dx = 1, dy = 0, dirChanges = 0, side = m;

    for (int i = 0; i < arr.Length; i++)
    {
        arr[row, col] = i + 1;
        if (--side == 0) // закончилось число элементов в строке, поворот
        {
            side = m * (dirChanges % 2) + n * ((dirChanges + 1) % 2) - (dirChanges / 2 - 1) - 2;
            int temp = dx;
            dx = -dy; // поворот
            dy = temp;
            dirChanges++;
        }
        col += dx; // эквивалентно col = col + dx
        row += dy;
    }
    return arr;
}

/// Метод печати в консоль двумерного массива 
void Print2DArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} \t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

/// Main - Блок решения задачи
int n = ReadData("Введите размер массива - число строк: ");
int m = ReadData("Введите размер массива - число столбцов: ");

int[,] SnakeArray = new int[n,m];
SnakeArray = CreateSnakeArray(n, m);

Console.WriteLine();
Print2DArray(SnakeArray);
Console.WriteLine("The End");


