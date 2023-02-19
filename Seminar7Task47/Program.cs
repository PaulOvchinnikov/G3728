Console.Clear();
Console.WriteLine("Привет! Это задание выполнено Павлом Овчинниковым при обучении основам языка С#");
// Console.WriteLine();
Console.WriteLine(@"
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
* При выводе матрицы показывать каждую цифру разного цвета(цветов всего 16)
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


/// Метод - генерация массива вещественных чисел 
// заполняем массив случайными трехзначными числами 
double[,] GetRandomArray(int m, int n)
{
    double[,] arr = new double[m, n];
    Random rand = new Random();
    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
        {
            arr[i, j] = rand.Next(1, 9999) + rand.NextDouble();
        }
    return arr;
}


void Print2DArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            //  случайный цвет текста из палитры в 16 цветов
            Random r = new Random();
            Console.ForegroundColor = (ConsoleColor)r.Next(0, 16);

            Console.Write($"{arr[i, j]} \t");
        }
        Console.WriteLine();
    }
    Console.ResetColor();
    Console.WriteLine();

}

/// Main - Блок решения задачи

int m = ReadData("Введите размер массива - число строк: ");
int n = ReadData("Введите размер массива - число столбцов: ");

double[,] color_arr = new double[m, n];
color_arr = GetRandomArray(m, n);

Print2DArray(color_arr);