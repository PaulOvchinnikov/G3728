Console.Clear();
Console.WriteLine("Привет! Это задание выполнено Павлом Овчинниковым при обучении основам языка С#");
Console.WriteLine(@"
Задача 54: Задайте двумерный массив. 
Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
");


// Console.WriteLine();

//Ввод целого числа с клавиатуры 
int InputNum(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

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

/// Метод сортировки по возрастанию значений и печати в консоле
void ADS(int[] intArray)
{
    Array.Sort(intArray);
    foreach (int i in intArray)
    {
        Console.Write(i + " ");
    }
    Console.WriteLine();
}

/// Метод сортировки по убыванию значений
// void DESC(int[] intArray)
// {
//     Array.Reverse(intArray);
//     foreach (int i in intArray)
//     {
//         Console.Write(i + " ");
//     }
//     Console.WriteLine();
// }

/// Main - Блок решения задачи
// Создание массива
int[,] int2DArray = create2DArray(
    InputNum("Введите число строк массива: "),
    InputNum("Введите число столбцов массива: "),
    InputNum("Введите минимум для значений в массиве: "),
    InputNum("Введите максимум для значений в массиве: ")
    );

Print2DArray(int2DArray);

Console.WriteLine("Массив, отсортированный построчно:");

int[] intArray = new int[int2DArray.GetLength(1)];
for (int i = 0; i < int2DArray.GetLength(0); i++)
{
    for (int j = 0; j < int2DArray.GetLength(1); j++)
    {
        intArray[j] = int2DArray[i, j];
    }
    ADS(intArray);
}

Console.WriteLine("The End");