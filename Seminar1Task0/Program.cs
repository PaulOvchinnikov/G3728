// Задача №0
// Напишите программу, которая на вход принимает
// число и выдаёт его квадрат (число умноженное на
// само себя).
// Например: 4 -> 16 -3 -> 9 -7 -> 49 

Console.WriteLine();
Console.WriteLine("Hello!");
Console.WriteLine("Это задание выполнено Павлом Овчинниковым при обучении основам языка С#");
Console.WriteLine("Программа рассчитывает квадрат целого числа.");
Console.WriteLine();
Console.Write("Введите число: ");

string? inputNumber = Console.ReadLine();
if (inputNumber!=null)
{
    // Вариант 1 построчечного программирования в лоб :)
    // int Number = int.Parse(inputNumber);
    // int result = Number * Number;
    Console.Write("Квадрат введенного числа равен: ");
    // Console.WriteLine(result);

    Console.WriteLine(Math.Pow(int.Parse(inputNumber),2));
    Console.WriteLine();
}

