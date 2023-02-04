// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
// * Отсортируйте массив методом вставки и методом подсчета, а затем найдите разницу между первым и последним элементом. 
// Для задачи со звездочкой использовать заполнение массива целыми числами.

Console.Clear();
Console.WriteLine("Привет! Это задание выполнено Павлом Овчинниковым при обучении основам языка С#");
Console.WriteLine();
Console.WriteLine("Задача 38: Задайте массив вещественных чисел.");
Console.WriteLine("Найдите разницу между максимальным и минимальным элементов массива.");
Console.WriteLine("* Отсортируйте массив методом вставки и методом подсчета, ");
Console.WriteLine("а затем найдите разницу между первым и последним элементом. ");
Console.WriteLine("Для задачи со звездочкой использовать заполнение массива целыми числами.");
Console.WriteLine();

// Блок ввода с клавиатуры и проверка на ненулевые условия 
int ReadData(string msg)
{
    Console.Write(msg);
    // double read_Data = double.Parse(Console.ReadLine() ?? "0");
    string? read_string_Data = Console.ReadLine() ?? "0";
    int read_Data;
    while (!int.TryParse(read_string_Data, out read_Data))
    {
        Console.Write("Ошибка! Повторите ввод: ");
        read_string_Data = Console.ReadLine() ?? "0";
    }
    return read_Data;
}
/// Метод - генерация массива вещественных чисел 
// заполняем массив случайными трехзначными числами 
double[] GetRandomArray(int m)
{
    double[] arr = new double[m];
    Random rand = new Random();
    for (int i = 0; i < m; i++)
    {
        arr[i] = rand.Next(100, 999) + rand.NextDouble();
    }
    return arr;
}

/// Метод - генерация массива вещественных чисел 
// заполняем массив случайными трехзначными числами 
int[] GetRandomIntArray(int m)
{
    int[] arr = new int[m];
    Random rand = new Random();
    for (int i = 0; i < m; i++)
    {
        arr[i] = rand.Next(100, 999);
    }
    return arr;
}

// Метод - ввод на экран элементов массива по N в строке
void PrintDoubleArray(double[] put_array)
{
    int i = 0;
    int n = ReadData("Введите число - сколько элементов выводить в строку: ");
    // int n = 5;
    while (i < put_array.Length)
    {
        for (int columns = 0; columns < n; columns++)
        {
            Console.Write(put_array[i] + "\t");
            i++;
            if (i >= put_array.Length) break;
        }
        Console.WriteLine();
    }
}
void PrintIntArray(int[] put_array)
{
    int i = 0;
    int n = ReadData("Введите число - сколько элементов выводить в строку: ");
    // int n = 5;
    while (i < put_array.Length)
    {
        for (int columns = 0; columns < n; columns++)
        {
            Console.Write(put_array[i] + "\t");
            i++;
            if (i >= put_array.Length) break;
        }
        Console.WriteLine();
    }
}
// Метод - реверсирование элементов массива 
//double[] ReverseArray(double[] arr)
// {
//   double temp;
//   for (int i = 0; i < arr.Length / 2; i++)
//   {
//     temp = arr[i];
//     arr[i] = arr[arr.Length - i - 1];
//     arr[arr.Length - i - 1] = temp;
//   }
//   return;
// }

// Метод - сортировка массива методом пузырька
void BoublingSort(double[] put_array)
{
    for (int i = 0; i < put_array.Length; i++)
        for (int j = i + 1; j < put_array.Length; j++)
            if (put_array[i] > put_array[j])
            {
                double temp = put_array[i];
                put_array[i] = put_array[j];
                put_array[j] = temp;
            }
}


// Метод - сортировка массива методом вставками
void InsertingSort(double[] put_array)
{
    {
        for (int i = 1; i < put_array.Length; i++)
        {
            double k = put_array[i];
            int j = i - 1;
            while (j >= 0 && put_array[j] > k) //меняем элементы массива между собой
            {
                put_array[j + 1] = put_array[j];
                put_array[j] = k;
                j--;
            }
        }
    }

}

// Метод - сортировка массива методом подсчета 
// как-то +\- объяснено в https://www.codeproject.com/Articles/9324/How-Count-Sort-Works
// РАБОТАЕТ ТОЛЬКО НА ЦЕЛОЧИСЛЕННЫХ МАССИВАХ !!! ПЕРЕЙТИ НА ВЕЩЕСТВЕННЫЕ ЧИСЛА НЕ СМОГ 
// PS - убил  5 дней ))))  МРАК для понимания ! - 5 дней головной боли. 
// без Результата, только техдолг вырос ))


void CountingSort(int[] arr)
{
    int max = (int)arr.Max();
    int min = (int)arr.Min();

    int[] count = new int[max - min + 1];
    int z = 0;

    for (int i = 0; i < count.Length; i++)
    {
        count[i] = 0;
    }
    for (int i = 0; i < arr.Length; i++)
    {
        count[arr[i] - min]++;
    }

    for (int i = min; i <= max; i++)
    {
        while (count[i - min]-- > 0)
        {
            arr[z] = i;
            z++;
        }
    }
}


// / void CountingSort(double[] put_array)
// {
//     //Найдём максимальное число в массиве
//     double Max = put_array[0];
//     for (int i = 1; i < put_array.Length; i++)
//     {
//         if (put_array[i] > Max)
//         { Max = put_array[i]; } //Максимальное число в массиве
//     }

//     //Создадим новый массив длины k, по умолчанию наполненный нулями       
//     int k = (int)Max + 1; //+1 потому, что вещественное число округляется в меньшую сторону
//     double[] tempArray = new double[k];

//     //Запишем в него элементs
//     for (int i = 0; i < k; i++)
//     { tempArray[put_array[i]]++; }

//     //Вставим элементы в исходный массив
//     int b = 0;
//     for (int i = 0; i < k + 1; ++i)
//     {
//         for (int j = 0; j < tempArray[i]; ++j)
//         {
//             put_array[b++] = i;
//         }
//     }
// }


// // вариант сортировки подсчетом
// int[] CountingSort(int[] put_array)
// {
//     double Max = put_array[0];
 
//     for (int i = 1; i < put_array.Length; i++)
//     {
//         if (put_array[i] > Max)
//         { Max = put_array[i]; } //Максимальное число в массиве
//     }
//     int k = (int)Max;

//     var count = new double[k + 1];
//     for (var i = 0; i < put_array.Length; i++)
//     {
//         count[put_array[i]]++;
//     }

//     var index = 0;
//     for (var i = 0; i < count.Length; i++)
//     {
//         for (var j = 0; j < count[i]; j++)
//         {
//             put_array[index] = i;
//             index++;
//         }
//     }
//     return put_array;
// }

// Блок вывода решения на экран
int m = ReadData("Введите размер массива: ");
double[] get_array = GetRandomArray(m);
Console.WriteLine();

// Вывод результатов на экран
Console.WriteLine("Сгенерирован массив случайных чисел. ");
PrintDoubleArray(get_array);

// Блок замеров времени выполнения сортировки методами Пузырька, Вставки, Подсчета
DateTime time_start;
double[] arr = get_array;

Console.WriteLine("Сравнение времени выполнения сортировки алгоритмами Пузырька, Вставки, Подсчета");
Console.WriteLine();

// Замер времени выполнения сортировки методами Пузырька
Console.WriteLine("Сортируем Массив методом пузырька");
time_start = DateTime.Now;
BoublingSort(arr);
Console.WriteLine("Время сортировки методом пузырька: " + (DateTime.Now - time_start));
PrintDoubleArray(arr);
Console.WriteLine();

// Замер времени выполнения сортировки методами Вставки
arr = get_array; // Присвоить массиву первоначальное значение, что бы оценить время сортировки
Console.WriteLine("Сортируем Массив методом вставки");
time_start = DateTime.Now;
InsertingSort(arr);
Console.WriteLine("Время сортировки методом вставки: " + (DateTime.Now - time_start));
PrintDoubleArray(arr);
Console.WriteLine();

// Замер времени выполнения сортировки методами Подсчета
int[] get_int_array = GetRandomIntArray(m);
Console.WriteLine("Сортируем Массив методом подсчета");
time_start = DateTime.Now;
CountingSort(get_int_array);
Console.WriteLine("Время сортировки методом подсчета: " + (DateTime.Now - time_start));
PrintIntArray(get_int_array);
