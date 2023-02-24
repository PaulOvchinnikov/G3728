Console.Clear();
Console.WriteLine("Привет! Это задание выполнено Павлом Овчинниковым при обучении основам языка С#");
Console.WriteLine(@"
Pflfxf 58. Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
");
Console.WriteLine();

// Mетод генерации двумерного массива случайными числами
int[,] create2DArray(int m, int n, int num1, int num2)
{
    Random rnd = new Random();
    int[,] arr = new int[m, n];
    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
        {
            arr[i, j] = rnd.Next(Math.Min(num1, num2), Math.Max(num1, num2));  // заполним массив минимальными и максимальными значениями
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
}

/// Main - Блок решения задачи
// Создание массива
int[,] First2DArray = create2DArray(3, 3, 0, 99); // число строк, число столбцов, минимум и максимум для значений в массиве
int[,] Second2DArray = create2DArray(3, 3, 0, 99);

/// Метод перемножения матриц общий для матриц любой размерности
static int[,] Multiplication(int[,] a, int[,] b)
{
    if (a.GetLength(1) != b.GetLength(0)) throw new Exception("Матрицы нельзя перемножить");
    int[,] result_arr = new int[a.GetLength(0), b.GetLength(1)];
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < b.GetLength(1); j++)
        {
            for (int k = 0; k < b.GetLength(0); k++)
            {
                result_arr[i, j] += a[i, k] * b[k, j];
            }
        }
    }
    return result_arr;
}
Console.WriteLine("Исходная первая матрица :");
Print2DArray(First2DArray);
Console.WriteLine("Исходная вторая матрица :");
Print2DArray(Second2DArray);
Console.WriteLine("Результат произведения матриц:");
int[,] result_arr = new int[3, 3];
result_arr = Multiplication(First2DArray, Second2DArray);
Print2DArray(result_arr);
Console.WriteLine("The End");