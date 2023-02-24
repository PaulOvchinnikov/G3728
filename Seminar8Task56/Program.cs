Console.Clear();
Console.WriteLine("Привет! Это задание выполнено Павлом Овчинниковым при обучении основам языка С#");
Console.WriteLine(@"
Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов в строке
");
Console.WriteLine();

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

/// Метод печати в консоль двумерного массива
void Print2DArray(int[,] arr, int num_line)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        if (i == num_line) { Console.ForegroundColor = ConsoleColor.Green; }
        else { Console.ResetColor(); }

        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} \t");
        }
        Console.WriteLine();
    }
}

/// Main - Блок решения задачи
// Создание массива
int[,] int2DArray = create2DArray(
    InputNum("Введите число строк массива: "),
    InputNum("Введите число столбцов массива: "),
    InputNum("Введите минимум для значений в массиве: "),
    InputNum("Введите максимум для значений в массиве: ")
    );

/// Метод поиска строки с мининамальной суммой элементов
int MainFindLine(int[,] int2DArray)
{
    int sum_min = 0;
    int num_line = 0;

    for (int i = 0; i < int2DArray.GetLength(0); i++)
    {
        int sum = 0;

        for (int j = 0; j < int2DArray.GetLength(1); j++)
        {
            sum = sum + int2DArray[i, j];
        }

        if (i == 0) { sum_min = sum; }
        if (sum_min > sum)
        {
            sum_min = sum;
            num_line = i;
        }
    }
    Console.WriteLine();
    Console.WriteLine($"Строка номер {num_line + 1} имеет минимальную сумму элементов равную {sum_min}");
    return num_line;
}

int num_line = MainFindLine(int2DArray);
Print2DArray(int2DArray, num_line);

Console.WriteLine();
Console.WriteLine("The End");