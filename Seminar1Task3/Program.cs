// Задача №3
// Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.
// Например:
// 3 -> Среда
// 5 -> Пятница

Console.WriteLine();
Console.WriteLine("Hello!");
Console.WriteLine("Это задание выполнено Павлом Овчинниковым при обучении основам языка С#");
Console.WriteLine("Программа печатает название дня недели по номеру дня");
Console.WriteLine();

// Вариант 1 через массив
// string[] WeekDays = new string[7];
// WeekDays[0] = "Понедельник";
// WeekDays[1] = "Вторник";
// WeekDays[2] = "Среда";
// WeekDays[3] = "Четверг"; 
// WeekDays[4] = "Пятница";
// WeekDays[5] = "Суббота";
// WeekDays[6] = "Воскресение";

// Console.Write("Введите номер дня недели от 1 до 7: ");
// string? inputNumber = Console.ReadLine();

// if (inputNumber != null)
// {
//     Console.Write("это ");
//     Console.WriteLine(WeekDays[int.Parse(inputNumber)-1]);
// }
// Console.Write("это ");
// Console.WriteLine(WeekDays[int.Parse(inputNumber) - 1]);


// Вариант 2 Switch / Case
string WeekDays = string.Empty; // ОБЪЯВЛЯЕМ НОВУЮ пустую ПЕРЕМЕННУЮ WeekDays
Console.Write("Введите номер дня недели от 1 до 7: ");
string? inputNumber = Console.ReadLine();

if (inputNumber != null)
{
    int DaysNumber = int.Parse(inputNumber);
    switch (DaysNumber)
    {
        case 1: WeekDays = "Понедельник"; break;
        case 2: WeekDays = "Вторник"; break;
        case 3: WeekDays = "Среда"; break;
        case 4: WeekDays = "Четверг"; break;
        case 5: WeekDays = "Пятница"; break;
        case 6: WeekDays = "Суббота"; break;
        case 7: WeekDays = "Воскресение"; break;
        default: WeekDays = "Введён неверный день недели (введите от 1 до 7)"; break;
    }
}
Console.Write("это ");
Console.WriteLine(WeekDays);
