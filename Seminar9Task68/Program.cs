// Console.Clear();
Console.WriteLine("Привет! Это задание выполнено Павлом Овчинниковым при обучении основам языка С#");
Console.WriteLine(@"
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
");
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Функция Аккермана ?! Заодно и вспомним, чего никогда не знали !");
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Ну что ж, не запусть ли нам подсчет Аккермана 5 на 5 :)");
Console.ResetColor();

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
    if (read_Data < 0)
    {
        Console.WriteLine($"{read_Data} не натуральное число");
        read_Data = ReadData("Введите натуральное число: ");
        Console.WriteLine();
    }
    return read_Data;
}

// Метод функции Аккермана для натуральных чисел от 0 до 3 ( двойная рекурсия)
Int32 Akkerman(int m, int n)
{
    // Метод функции Аккермана для натуральных чисел от 0 до 3 ( двойная рекурсия)
    if (m == 0)
        return n + 1;
    if ((m != 0) && (n == 0))
        return Akkerman(m - 1, 1);
    else
        return Akkerman(m - 1, Akkerman(m, n - 1));
}

/// Main - Блок решения задач
int m = 0; int n = 0;

m = ReadData("Введите натуральное число M (от 0 до 3): ");
n = ReadData("Введите натуральное число N M (от 0 до 3): ");
if (n > 3 || m > 3)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(@"При таких величинах M или N расчет не подойдет - значение функции Аккермана будет огромным! 
    Пожалейте комп, повторите ввод !");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(@"
 PS Википедия убила: например, число Аккермана A(4,4) настолько велико, что количество цифр в порядке этого числа многократно превосходит количество атомов в наблюдаемой части Вселенной. ");
    Console.ResetColor();
    m = ReadData("Введите натуральное число M (от 0 до 3): ");
    n = ReadData("Введите натуральное число N M (от 0 до 3): ");
};

Console.Write($"Значение функции Аккермана для {m} и {n}: {Akkerman(m, n)}");

Console.WriteLine(" ");
Console.WriteLine("The End");

