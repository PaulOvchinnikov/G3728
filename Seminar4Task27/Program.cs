// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 114; 82 -> 10;   9012 -> 12

// * Сделать оценку времени алгоритма через вещественные числа и строки

Console.Clear();
Console.WriteLine("Hello! Это задание выполнено Павлом Овчинниковым при обучении основам языка C#");
Console.WriteLine();
Console.WriteLine("Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.");
Console.WriteLine("Задача 27* Сделать оценку времени алгоритма через вещественные числа и строки");
Console.WriteLine();

// Блок ReadData - Keyboard input of the string and parsing into real number 
Console.Write("Введите число (разделитель целой части: (,) запятая): ");
// Read_Data (msg);
double read_Data;
string read_string_Data = Console.ReadLine() ?? "0";
while (!double.TryParse(read_string_Data, out read_Data))
{
    Console.Write("Ошибка! Повторите ввод: ");
    read_string_Data = Console.ReadLine() ?? "0";
}

//  очистка строки от символов "," и "."
Console.WriteLine(read_string_Data);
read_string_Data = read_string_Data.Replace(",", "").Replace(".", "");
Console.WriteLine(read_string_Data);

// // // Блок решения задачи
// // Метод Арифметический рассчет суммы чисел
int RecursiveSum(int x) // перевели результат в int
{
    if (x == 0) return 0;
    return (x % 10 + RecursiveSum(x / 10));
    }

// Метод рассчета суммы чисел - работа со строкой через массив
int Array_Sum(int[] Char_of_String_Array)
{
    int sum_result = 0;
    for (int i = 0; i < Char_of_String_Array.Length; i++)
    { sum_result = sum_result + Char_of_String_Array[i]; }
    return sum_result;
}

// // Замер времени выполнения функции c рекурсией
DateTime time_start = DateTime.Now;
int digit_sum_1 = RecursiveSum(int.Parse(read_string_Data));
Console.WriteLine("Способ с рекурсией: Сумма цифр в строке " + read_string_Data + " равняется: " + digit_sum_1);
Console.WriteLine("Время вычисления: " + (DateTime.Now - time_start));
Console.WriteLine();

// Замер времени выполнения функции суммирования (сторока в массив)
time_start = DateTime.Now; // переменная time_start ранее определена в блоке замера с рекурсией
int[] Char_of_String_Array = read_string_Data.Select(i => (int)i - 48).ToArray(); // массив, смещение -48, что бы из символа получить корректную цифру (например char "4" = int (4)
int digit_sum_2 = Array_Sum(Char_of_String_Array);
Console.WriteLine("Способ с массивом символов: Сумма цифр в строке " + read_Data + " равняется: " + digit_sum_2);
Console.WriteLine("Время вычисления: " + (DateTime.Now - time_start));
Console.WriteLine();


// Вывод результата на экран
