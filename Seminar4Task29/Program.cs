// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// * Ввести с клавиатуры длину массива и диапазон значений элементов
// Дополнительно: Написать программу которая из имен через запятую выберет 
// случайное имя и выведет в терминал Игорь, Антон, Сергей, Павел, Света,, Саша, Дима, Валя -> Антон 
// Подсказка: Для разбора строки использовать метод string.split(). 
// Для выбора случайного имени метод Random.Next(1,<длина массива имен>+1).

Console.Clear();
Console.WriteLine("Привет! Это задание выполнено Павлом Овчинниковым при обучении основам языка С#");
Console.WriteLine("Задача 29* Написать программу которая из имён выберет случайное имя и выведет в терминал");
Console.WriteLine();


// Блок ввода с клавиатуры и проверка на ненулевые условия 
string ReadString(string msg)
{
    Console.Write(msg);
    return (Console.ReadLine() ?? "0");
}

// string list_elemets = ReadString("Введите через запятую значения массива: ");

// Блок решения задачи *;
string list_elemets = ReadString ("Введите список через запятую: ");
char[] separators = new char[] { ' ', ',', '.' };
string[] result_Array = new string[100];
// {
int i = 0;
string[] subs = list_elemets.Split(separators, StringSplitOptions.RemoveEmptyEntries);
foreach (string sub in subs)
{
    // Console.WriteLine($"Substring: {sub}");
    result_Array[i] = sub;
    Console.WriteLine(i+"-й элемент массива: " + result_Array[i]);
    i++;
}

// Случайный выбор и вывод одного из элементов массива
Console.WriteLine("ВНИМАНИЕ: победитель бежит в магазин!");
Console.WriteLine(result_Array[new Random().Next(0, i)]);
