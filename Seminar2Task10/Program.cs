// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine();
Console.WriteLine("Hello!");
Console.WriteLine("Это задание выполнено Павлом Овчинниковым при обучении основам языка С#");
Console.WriteLine("Программа на вход принимает трёхзначное число и на выходе показывает вторую цифру этого числа.");
Console.WriteLine();

//Entering a number and checking conditions (for three-digit number); 
// блок ввода с клавиатуры и проверка на условия задачи
// выводит сообщение - Возможно, аргумент-ссылка, допускающий значение NULL

int number = 0;
while (number < 100 || number > 999)
{
    Console.Write("Введите трёхзначное число: ");
    string? inputNumber = Console.ReadLine();
    if (inputNumber != null)
     { number = int.Parse(inputNumber); }

    if (number < 100 || number > 999)
    {  Console.WriteLine("По условию число должно быть трехзначным (от 100 до 999)");   }

}
// Вариант 1 Решение "в лоб"
// int digit1 = number/1000;
// int digit2 = number%10;

// // Вариант решения через переобразования строки в матрицу 

string value = number.ToString();
char[] numberArray = value.ToCharArray();

// вывод результата в консоль терминала
Console.WriteLine(); // вывод пустой строки для оформления интерфейса
Console.Write("Вторая цифра в числе " + number + " это: ");
Console.WriteLine(numberArray[1]);
