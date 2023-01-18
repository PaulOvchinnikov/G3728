// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22


Console.WriteLine();
Console.WriteLine("Hello!");
Console.WriteLine("Это задание выполнено Павлом Овчинниковым при обучении основам языка С#");
Console.WriteLine("Программа на вход принимает три числа и выдаёт максимальное из этих чисел.");
Console.WriteLine();

Console.Write("Введите первое число: ");
string? inputNumber1 = Console.ReadLine();
Console.Write("Введите второе число: ");
string? inputNumber2 = Console.ReadLine();
Console.Write("Введите третье число: ");
string? inputNumber3 = Console.ReadLine();

if (inputNumber1 != null && inputNumber2 != null && inputNumber3 != null)
{   // Преобразуем введенные с клавиатурыстроки в числа
    int Number1 = int.Parse(inputNumber1);
    int Number2 = int.Parse(inputNumber2);
    int Number3 = int.Parse(inputNumber3);

    Console.WriteLine(); // вывод пустой строки для оформления интерфейса

// сравнение чисел и вывод наибольшего значения
    if (Number1 > Number2 && Number1 > Number3)
    {
        Console.Write("Первое число наибольшее из трёх: ");
        Console.WriteLine(Number1);
    }
    else
    {
        if (Number2 > Number3)
        {
            Console.Write("Второе число наибольшее из трёх: ");
            Console.WriteLine(Number2);
        }
        else
        {
            Console.Write("Третье число наибольшее из трёх: ");
            Console.WriteLine(Number3);
            // Console.WriteLine("Числа равны");
        }
    }
    Console.WriteLine();
}
