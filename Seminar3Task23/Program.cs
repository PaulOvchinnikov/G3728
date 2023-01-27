// // Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// // 3 -> 1, 8, 27
// // 5 -> 1, 8, 27, 64, 125
// // * Вывести таблицу с границами и значениями друг над другом

Console.Clear();
Console.WriteLine();
Console.WriteLine("Hello! Это задание выполнено Павлом Овчинниковым при обучении основам языка С#");
Console.WriteLine();

// Блок ввода с клавиатуры и проверка на ненулевые условия 
int ReadData(string msg)
{
    Console.Write(msg);
    Console.WriteLine();
    return int.Parse(Console.ReadLine() ?? "0");
}

// ограничимся кубами размером в int (2 147 483 647) => хватит 10 разрядов под значение
int input_N = ReadData("Введите целое число до 1000 / Type on the keyboard a digit till 1000");

static string SymbolLine(char s, int n)
{
    return new string(s, n);
}


// Блок решения: Формирование заголовка вертикальной таблицы 
// Console.WriteLine("\u2554\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2564\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2557");
Console.WriteLine("\u2554" + SymbolLine('\u2550', 12) + "\u2564" + SymbolLine('\u2550', 12) + "\u2557"); //максимум 12: 10 разрядов + 2 пробела
Console.WriteLine("\u2551    Число   " + "\u2502  Куб числа " + "\u2551");
//Console.WriteLine("\u2560\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u256A\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2563");
Console.WriteLine("\u2560" + SymbolLine('\u2550', 12) + "\u256A" + SymbolLine('\u2550', 12) + "\u2563");


// Блок решения: Формирование строки вывода 
for (int i = 1; i < input_N; i++)
{
    Console.WriteLine("\u2551 " + String.Format("{0,-10}", i) + " \u2502 " + String.Format("{0,-10}", (i * i * i)) + " \u2551");
    // Console.WriteLine("\u255F\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u253C\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2500\u2562");
    Console.WriteLine("\u255F" + SymbolLine('\u2500', 12) + "\u253C" + SymbolLine('\u2500', 12) + "\u2562");
}
// Формирование формирование последней строки вывода 
Console.WriteLine("\u2551 " + String.Format("{0,-10}", input_N) + " \u2502 " + String.Format("{0,-10}", input_N * input_N * input_N) + " \u2551");

// Формирование нижней линии вертикальной таблицы 
// Console.WriteLine("\u255A\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2567\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u255D");
Console.WriteLine("\u255A" + SymbolLine('\u2550',12) + "\u2567" + SymbolLine('\u2550',12) + "\u255D");

Console.WriteLine("The End");

