Console.Clear();
Console.WriteLine("Привет! Это задание выполнено Павлом Овчинниковым при обучении основам языка С#");
// Console.WriteLine();
Console.WriteLine(@"
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.

* Заполнить числами Фиббоначи и выделить цветом найденную цифру
");

Console.WriteLine();

/// Метод ввода целого числа
int ReadData(string msg)
{
    Console.Write(msg);
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


/// Метод - заполения массива числами Фибаначчи 
long[,] GetFibanacciArray(int m, int n)
{
    // if ((n <= 0) || (m <= 0))
    //     return null;

    long[,] arr = new long[m, n];
    long[] fibanacci = new long[m * n];
    fibanacci[0] = 0;
    fibanacci[1] = 1;

    int k = 0;
    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
        {
            if (k >= 2)
            {
                fibanacci[k] = fibanacci[k - 1] + fibanacci[k - 2];
                arr[i, j] = fibanacci[k];
            }
            else
            {
                if (k == 0) { arr[i, j] = 0; }
                if (k == 1) { arr[i, j] = 1; }
            }
            k++;

        }
    return arr;
}

/// Метод ввода на экран двумерной матрицы 

void Print2DArray(long[,] arr, int line, int row)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if ((i == line-1) && (j == row-1))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"{arr[i, j]} \t");
                Console.ResetColor();
            }
            else Console.Write($"{arr[i, j]} \t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();

}

/// Main - Блок решения задачи
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Решение задачи:");
Console.ResetColor();

int m = ReadData("Введите размер массива - число строк: ");
int n = ReadData("Введите размер массива - число столбцов: ");

long[,] arr = new long[m, n];
arr = GetFibanacciArray(m, n);

int line = ReadData("Введите индекс строки элемента, который Вы ищите: ");
int row = ReadData("Введите индекс столбца элемента, который Вы ищите: ");

if ((line > m) || (row > n))
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Ошибка! Такого элемента в массиве нет!");
    Console.ResetColor();
}

Print2DArray(arr, line, row);