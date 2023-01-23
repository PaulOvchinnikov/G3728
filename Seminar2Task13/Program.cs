// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine();
Console.WriteLine("Привет! Это задание выполнено Павлом Овчинниковым при обучении основам языка С#");
Console.WriteLine("Решено в общем виде");
Console.WriteLine("Программа на вход принимает число и искомую позицию и на выходе");
Console.WriteLine("выводит цифру данной позиции или сообщает, что такой цифры нет.");
Console.WriteLine();

//Entering a number and checking conditions (for three-digit number); 
// Блок ввода с клавиатуры. Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
int number = ReadData("Введите число либо цифру / Type a number or digit on the keyboard : ");
int digital_position = ReadData("Введите разряд числа, значение которой Вы ищите / Еnter the desired position : ");


// Вариант решения через переобразования строки в матрицу 
string value = number.ToString();
char[] numberArray = value.ToCharArray();

// Проверка на наличие такой позиции числа
if (digital_position > numberArray.Length)
{Console.WriteLine("Такой позиции в числе "+ number + "нет");} 

// вывод результата в консоль терминала
Console.WriteLine(); // вывод пустой строки для оформления интерфейса
Console.Write(digital_position + " цифра в числе " + number + " это: ");
Console.Write(numberArray[digital_position-1]);