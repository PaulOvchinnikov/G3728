Console.Clear();
Console.WriteLine("Привет! Это задание выполнено Павлом Овчинниковым при обучении основам языка С#");
Console.WriteLine(@"
Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.
Выполнить с помощью рекурсии.
");
// Console.WriteLine();

/// Метод ввода натурального числа (С РЕКУРСИЕЙ !)
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
    if (read_Data < 1)
    {
        Console.WriteLine($"{read_Data} не натуральное число");
        read_Data = ReadData("Введите натуральное число: ");
        Console.WriteLine();
    }
    return read_Data;
}

// Метод формирования сумммы ряда натуральных чисел (рекурсия)
int NumberSum(int m, int n)
{
    if (m == n) return n;              // Если M=N
    return n + NumberSum(m, n - 1);    // Если M<N
}


/// Main - Блок решения задач
int m = 0; int n = 0;
do
{
    m = ReadData("Введите натуральное число M начала отсчета: ");
    n = ReadData("Введите натуральное число N окончания отсчета: ");
    if (n < m)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Ошибка M < N! Повторите ввод !");
        Console.ResetColor();
    };
}
while (n < m);

Console.Write($"Сумма натуральных чисел от {m} до {n}: {NumberSum(m, n)}");

Console.WriteLine(" ");
Console.WriteLine("The End");

