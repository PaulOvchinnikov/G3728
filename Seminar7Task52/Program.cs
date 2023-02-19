Console.Clear();
Console.WriteLine("Привет! Это задание выполнено Павлом Овчинниковым при обучении основам языка С#");
// Console.WriteLine();
Console.WriteLine(@"
Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце. 
* Дополнительно вывести среднее арифметическое по диагоналям и диагональ выделить разным цветом.
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


/// Метод - генерация массива целых чисел 
// заполняем массив случайными целыми числами до 100
int[,] GetRandomArray(int m, int n)
{
    int[,] arr = new int[m, n];
    Random rand = new Random();
    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
        {
            arr[i, j] = rand.Next(1, 10);
        }
    return arr;
}



/// метод рассчета среднего арифметического по столбцам

void ArithmeticMean(int[,] arr)
{
    for (int j = 0; j < arr.GetLength(1); j++) // Счетчик по строкам
    {
        double summ = 0;

        for (int i = 0; i < arr.GetLength(0); i++) // Счетчик по столбцам
        { summ = summ + arr[i, j]; }
        double arithMean = summ / arr.GetLength(0);

        Console.WriteLine($"Среднее арифметическое столбца {j + 1} равно {arithMean} (сумму {summ} делим на {arr.GetLength(0)})");
    }
    Console.WriteLine();

}

/// метод рассчета среднего арифметического по диагонали

void DiagonalArithmeticMean(int[,] arr)
{
    double summ = 0;
    int count_d = 0;
    for (int j = 0; j < arr.GetLength(1); j++) // Счетчик по строкам
    {
        for (int i = 0; i < arr.GetLength(0); i++) // Счетчик по столбцам
        {
            if (i == j)
            {
                summ = summ + arr[i, j];
                count_d++;
            }
        }

    }
    double arithMean = summ / count_d;
    Console.ForegroundColor = ConsoleColor.Red; 
    Console.WriteLine();
    Console.WriteLine($"Среднее арифметическое диагонали равно {arithMean} (сумму {summ} делим на {count_d})");
    Console.ResetColor();

}
/// Метод ввода на экран двумерной матрицы 
void Print2DArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (i == j)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"{arr[i, j]} \t");
                Console.ResetColor();
            }

            // if (i == j)
            // {
            //     Console.ForegroundColor = ConsoleColor.Yellow;
            //     Console.Write($"{arr[i, j]} \t");
            //     Console.ResetColor();
            // }

            else

                Console.Write($"{arr[i, j]} \t");
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

int[,] arr = new int[m, n];
arr = GetRandomArray(m, n);

Print2DArray(arr);

ArithmeticMean(arr);
DiagonalArithmeticMean(arr);
