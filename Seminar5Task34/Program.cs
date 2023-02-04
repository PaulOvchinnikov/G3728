// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// * Отсортировать массив методом пузырька

Console.Clear();
Console.WriteLine("Привет! Это задание выполнено Павлом Овчинниковым при обучении основам языка С#");
Console.WriteLine("Задача 34: Программа покажет количество чётных чисел в массиве,");
Console.WriteLine("заполненном случайными положительными трёхзначными числами.");
Console.WriteLine("Задача 34* Отсортировать массив методом пузырька");
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
// Блок решения задачи
int m = ReadData("Введите размер массива: ");
// заполняем массив случайными трехзнаюными числами 
int[] arr = new int[m];
Random rand = new Random();
int even_count = 0;
for (int i = 0; i < m; i++)
{
    arr[i] = rand.Next(100, 999);
    if (arr[i] % 2 == 0) even_count++; // заполняем массив случайными трехзнаюными числами 

}

// Блок вывода решения на экран
void PrintArray(int[] put_array)
{
Console.WriteLine();
int arr_rows = 1;
// int arr_columns =1; 
// for (int i = 0; i < m; i++)
// {
for (int st = 0; st < m / arr_rows; st++)
{ Console.Write(put_array[st] + " "); }
Console.WriteLine();
}

Console.WriteLine("Число четных элементов массива равно: " + even_count);

// Метод - реверсирование элементов массива 
// void ReverseArray(ulong[] items)
// {
//   ulong t;

//   // реверсирование массива
//   for (int i = 0; i < items.Length / 2; i++)
//   {
//     t = items[i];
//     items[i] = items[items.Length - i - 1];
//     items[items.Length - i - 1] = t;
//   }
//   return;
// }

// Метод - упорядочить элементы массива методом пузырька
void BoubleSorting(int[] put_array)
{
    for (int i = 0; i < put_array.Length; i++)
        for (int j = i + 1; j < put_array.Length; j++)
            if (put_array[i] > put_array[j])
            {
                int temp = put_array[i];
                put_array[i] = put_array[j];
                put_array[j] = temp;
            }
}

PrintArray(arr);
BoubleSorting(arr);
Console.WriteLine ();

Console.WriteLine ("Отсортированный массив: ");
PrintArray(arr);
