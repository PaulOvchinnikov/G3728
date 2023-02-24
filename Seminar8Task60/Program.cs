using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


Console.Clear();
Console.WriteLine("Привет! Это задание выполнено Павлом Овчинниковым при обучении основам языка С#");
Console.WriteLine(@"
Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
");
Console.WriteLine();

// Mетод генерации трехмерного массива случайными неповторяющимися числами

int[,,] create3DArray(int x, int y, int z, int min, int max)
{
    Random rnd = new Random();

    int[,,] arr = new int[x, y, z];
    int count = 0;

    for (int i = 0; i < x; i++)
        for (int j = 0; j < y; j++)
            for (int k = 0; k < z; k++)
            {
                int temp_num = rnd.Next(10, 99);  // Задаём рандомное двузначное число
                                           // Проверяем существует в имеющимся массиве arr это рандомное число
                for (int u = 0; u < x; u++)
                    for (int v = 0; v < y; v++)
                        for (int w = 0; w < z; w++)

                            if (temp_num != arr[u, v, w])
                                count ++; // Если такого числа не существует, то будет count=27.  Если существует count<9.

                                    // Проверка. Если count=27 то данному элементу массива присваеваем рандомный элемент.
                                    // Если count<27 то выполняется функция "continue". 
                                    if (count == 27)
                                    {
                                        arr[i, j, k] = temp_num;
                                        count = 0;
                                    }
                                    else
                                    {
                                        count = 0;
                                        k = (k - 1);
                                        continue;
                                    }

            }
    return arr;
}


/// Метод печати в консоль трехмерного массива c индексами элементов
void Print3DArray(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                Console.Write($"{arr[i, j, k]} ({i},{j},{k}) \t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }

}

/// Main - Блок решения задачи
int[,,] new3DArr = create3DArray(3, 3, 3, 10, 99); // число строк, число столбцов, минимум и максимум для значений в массиве
// максимальное значение элемента массива не может быть меньше числа элементов массива, иначе значения будут поторяться
Console.WriteLine("Сгенерирован массив 3х3х3 случайных неповторяющихся чисел: ");
Print3DArray(new3DArr);
Console.WriteLine("The End");


