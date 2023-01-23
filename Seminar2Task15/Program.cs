// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да;  7 -> да;  1 -> нет
// Задача 15*: Напишите программу, которая принимает на вход дату и проверяет на праздничный день через метод Dictionary

Console.WriteLine();
Console.WriteLine("Привет! Это задание выполнено Павлом Овчинниковым при обучении основам языка С#");
Console.WriteLine();

Console.WriteLine("Вариант 1 (Задача 15)");
Console.WriteLine("Программу принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.");

 // Блок ввода с клавиатуры
string WeekDays = string.Empty; // ОБЪЯВЛЯЕМ НОВУЮ пустую ПЕРЕМЕННУЮ WeekDays
Link_1:
Console.Write("Введите номер дня недели от 1 до 7: ");
int DaysNumber = int.Parse(Console.ReadLine() ?? "0");

// Блок решения задачи через Метод SWITCH / CASE
    switch (DaysNumber)
    {
        case 1: WeekDays = "Понедельник"; break;
        case 2: WeekDays = "Вторник"; break;
        case 3: WeekDays = "Среда"; break;
        case 4: WeekDays = "Четверг"; break;
        case 5: WeekDays = "Пятница"; break;
        case 6: WeekDays = "ВЫХОДНОЙ - Суббота. Ура!"; break;
        case 7: WeekDays = "ВЫХОДНОЙ -Воскресение/ Ура!!!"; break;
        default: WeekDays = "Введён неверный день недели (введите от 1 до 7)"; goto Link_1;
    }
// Блок ввода результата на экран
Console.WriteLine("это " + WeekDays);
Console.WriteLine("");

Console.WriteLine("Вариант 2 (Задача 15*)");
Console.WriteLine("Программа на вход принимает на вход дату и проверяет на праздничный день (через метод Dictionary)");
Console.WriteLine("");

// Блок ввода с клавиатуры -  опрашивает в цикле ввод даты, пока не будет введено правильное значение
DateTime Read_day()
{
    DateTime day;
    string input;
    do
    {
        Console.Write("Введите дату в формате ДД.ММ.ГГГГ (день.месяц.год): ");
        input = Console.ReadLine();
    }
    while (!DateTime.TryParseExact(input, "dd.MM.yyyy", null, System.Globalization.DateTimeStyles.None, out day));
    return day;
}

var find_day = Read_day();
var sort_find_day = find_day.ToShortDateString();     // Возвращает строку только с датой, без времени

// Блок решения задачи через Метод Dictionary
string str = sort_find_day.Substring(0, 5); // Возвращает строку только с днем месяца, без года

var holydays = new Dictionary<string, string>()
{
    ["01.01"] = "1 января — Новой год",
    ["07.01"] = "7 января — Рождество Христово",
    ["23.02"] = "23 февраля — День защитника Отечества",
    ["08.03"] = "8 марта — Международный женский день",
    ["01.05"] = "1 мая — Праздник Весны и Труда",
    ["09.05"] = "9 мая — День Победы",
    ["12.06"] = "12 июня — День России",
    ["04.11"] = "4 ноября — День народного единства",
    // ["00.00"] = "Это НЕпраздничный день",
};
// Проверка на отсутствующий в словаре ключ
if (!holydays.ContainsKey(str))
{ Console.WriteLine(sort_find_day + " это НЕпраздничный день "); }
else
{// вывод результата в консоль терминала
    Console.WriteLine(); // вывод пустой строки для оформления интерфейса
                         // Console.WriteLine(str);
    Console.WriteLine(sort_find_day + " это " + holydays[str]);
}

