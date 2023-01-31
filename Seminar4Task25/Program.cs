// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵); // 2, 4 -> 16
// * Написать калькулятор с операциями +, -, /, * и возведение в степень

Console.Clear();
Console.WriteLine("Привет! Это задание выполнено Павлом Овчинниковым при обучении основам языка С#");
Console.WriteLine("Задача 25* Написать калькулятор с операциями +, -, /, * и возведение в степень");
// 3, 5 -> 243 (3⁵); // 2, 4 -> 16
Console.WriteLine();


// Блок ввода с клавиатуры и проверка на ненулевые условия 
double ReadData(string msg)
{
    Console.Write(msg);
    // double read_Data = double.Parse(Console.ReadLine() ?? "0");
    string? read_string_Data = Console.ReadLine() ?? "0";
    double read_Data;
    while (!double.TryParse(read_string_Data, out read_Data))
    {
        Console.Write("Ошибка! Повторите ввод: ");
        read_string_Data = Console.ReadLine() ?? "0";
    }
    return read_Data;
}

char ReadOperand(string msg)
{
    Console.Write(msg);
    char oper = Convert.ToChar(Console.ReadLine() ?? "0");
    //     while (oper != ("+"or"-"or"/"or"*"or"^"))
    //     {     Console.Write("Ошибка! Повторите ввод: "); }
    return oper;
}
double number_A = ReadData("Введите число А: ");
double number_B = ReadData("Введите число B: ");
char oper = ReadOperand("Введите операцию +, -, /, *, возведение в степень: ");
double total = 0;

// Блок решения задачи 25*
switch (oper)
{
    case '+': total = number_A + number_B; break;
    case  '-':  total = number_A - number_B; break;
    case  '*':  total = number_A * number_B; break;
    case  '/':  total = number_A / number_B; break;
    case  '^':  total = Math.Pow(number_A, number_B); break;
    case  'q':  total = Math.Sqrt(number_A); break;
    default: Console.WriteLine("Неизвестный оператор."); break;
}
Console.WriteLine("Значение выражения " + number_A + " " + oper + " " + number_B + " равно " + total + ".");

Console.WriteLine("");
Console.WriteLine("The End");
