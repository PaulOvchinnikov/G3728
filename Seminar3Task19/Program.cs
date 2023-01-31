// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да
// * Сделать вариант через СЛОВАРЬ четырехзначных палиндромов

Console.Clear();
Console.WriteLine();
Console.WriteLine("Привет! Это задание выполнено Павлом Овчинниковым при обучении основам языка С#");
Console.WriteLine();

// Сгенерим словарь четырехзначных палиндромов
var palindrom_dic = new Dictionary<int, string>();
for (int i = 1; i < 10; i++)
{
    for (int j = 0; j < 10; j++)
    {
        // Create a new Dictionary of strings with integer keys. 
        int current_palindrom = (i*1000+j*100+j*10+i);
        palindrom_dic.Add(current_palindrom, " это число - четырехзначный палиндром");
    }
}

// Метод ввода с клавиатуры и проверки на ненулевые условия 
string ReadData(string msg)
{
    Console.Write(msg);
    // Console.WriteLine();
    return Console.ReadLine() ?? "0";
}

string text = ReadData("Введите исследуемый на палиндром текст: ");

// Удаляем пробелы, спецсимволы  (*), (@), (#) и апострофа (') из строки 
// Ex: 23 34@4'3#3*2
// А роза упала на лапу Азора
// МЕНЯ ИСТИНА МАНИТ СИЯНЬЕМ
// Я ИДУ С МЕЧЕМ, СУДИЯ
// И ОН ВИДИТ СОН ЮНОСТИ ДИВНОЙ
// УМ ЗА РАМКИ ТУПО ПЛЫЛ, ПЛЫЛ ПО ПУТИ К МАРАЗМУ
// АРГЕНТИНА МАНИТ НЕГРА 
// ЛИДЕР БОДРО, ГОРДО БРЕДИЛ
// МАЛА КАСКА АКСАКАЛАМ 
// Я СЛИЧИЛ ТО И ТО - ВОТ И ОТЛИЧИЛСЯ
// ОНА НЕ ЖЕНА, НО
// ЕШЬ НЕМЫТОГО ТЫ МЕНЬШЕ!
// УЖ РЕДКО РУКОЮ ОКУРОК ДЕРЖУ 
// НЕ ДО ЛОГИКИ - ГОЛОДЕН
// ЕМ, УВЫ, В УМЕ 
// Я БАРИН И РАБ Я 
// АТАКА ЗАКАТА 
// УМЕН? ОТВЕТЬТЕ В ТОН ЕМУ 
// А ЩЁТКА - КАК ТЁЩА!
// ЗРЮ ГЮРЗ 
// А В ЕНИСЕЕ - СИНЕВА
// ОН - ВЕРБА, НО ОНА - БРЕВНО 
// СЕНСАЦИЯ: ДЕД ЯИЦА СНЕС! - палиндром
// СЕНСАЦИЯ: ДЕД ЯЙЦА СНЕС! - не палидром, но преобразуем в палиндром
// Я ЕЛ МЯСО ЛОСЯ, МЛЕЯ 
// ИДИ, МАКАР, К РАКАМ
// ОТЛИЧНО КОНЧИЛ-ТО 
// НЕ ГНИ ПАПИН ГЕН
// НЕ ЖЕНАТ, А НЕЖЕН
// А ЛИС, ОН УМЕН - КРЫСА СЫР К НЕМУ НОСИЛА
// ОГО, ВИЖУ ЖИВОГО
// МОРДА КАЗАКА ЗА КАДРОМ
// А ПУТАНА ТУПА
// ДОМ МОД
// НЕСУН ГНУСЕН
// ДА, ИСКАТЬ ТАКСИ - АД!
// ТЫ МОДЕН И НЕДОМЫТ
// НАЖАЛ КАБАН НА БАКЛАЖАН
// Я С ЛЕДИ ВСЕ ЖЕ СВИДЕЛСЯ
// ЛЕША НА ПОЛКЕ КЛОПА НАШЕЛ
// ЛОМ О СМОКИНГИ ГНИ, КОМСОМОЛ

string result_text = string.Empty;
result_text = text.Replace(" ", "");
result_text = result_text.Replace("Й", "И");
result_text = result_text.Replace("!", "");
result_text = result_text.Replace("?", "");
result_text = result_text.Replace("-", "");
result_text = result_text.Replace(".", "");
result_text = result_text.Replace(",", "");
result_text = result_text.Replace(":", "");
result_text = result_text.Replace(";", "");
result_text = result_text.Replace("*", "");
result_text = result_text.Replace("@", "");
result_text = result_text.Replace("#", "");
result_text = result_text.Replace("\'", "");
result_text = result_text.Replace("/", "");

Console.WriteLine("Удалили пробелы, символы звездочки (*) и апострофа (') из строки '{0}' в '{1}'", text, result_text);
// Console.Write("Удалили пробелы, символы звездочки (*) и апострофа (') из строки\n   {0}\n в\n   '{1}'", text, result_text); // Другое оформление 

// Часть 1 - Поиск через СЛОВАРЬ четырехзначных цифровых палиндромов
bool allDigits = result_text.All(char.IsDigit);
if (allDigits)
{ int digit_text = int.Parse(result_text ?? "0");
    // Проверка на отсутствующий в словаре ключ
if (!palindrom_dic.ContainsKey(digit_text))
{ Console.WriteLine(digit_text + " Данное число не является четырехзначным палиндромом"); }
else
{    Console.WriteLine(); // вывод пустой строки для оформления интерфейса
    Console.WriteLine(digit_text + palindrom_dic[digit_text]);
}}


// Часть 2 - Проверяет, является ли строка палиндромом

// Создаем зеркальную строку через массив
char[] text_array = result_text.ToCharArray(); // превратили строку в массив
Array.Reverse(text_array); // перевернули массив
string reverse_text = new string(text_array); // вернули из массива в строку
//Console.WriteLine(text +"->"+reverse_text);

// Решение и выврл результата - проверяем строку на палиндром
Console.WriteLine();
if (result_text == reverse_text)
{ Console.WriteLine(text+" -> "+reverse_text+" - Данная запись является палиндромом"); }
else
{ Console.WriteLine(text+" -> "+reverse_text+" - Данная запись не является палиндромом"); }