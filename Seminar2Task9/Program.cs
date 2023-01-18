вывести случайное число и показать максимальную цифру этого числа

//..вариант 1
System.Random numSintezator = new System.Random

int rndNum = numSintezator.Next(10, 100);
Console.WriteLine ("Случайное число: " + rndNum)ж

int Digital1 = rndNum/10;
int Digital2 = rndNum%10;


if (Digital1>Digital2)
{
    Console.WriteLine ("Первое число больше")
}
