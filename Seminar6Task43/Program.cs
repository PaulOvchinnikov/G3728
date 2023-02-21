Console.Clear();
// Console.WriteLine("Привет! Это задание выполнено Павлом Овчинниковым при обучении основам языка С#");
// Console.WriteLine(@"
// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// Например: b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
// (от Голикова А.С.) * Найдите площадь треугольника образованного пересечением 3 прямых.
// ");

// Console.WriteLine();

/// Метод ввода вещественного числа
// double ReadData(string msg)
// {
//     Console.Write(msg);
//     // double read_Data = double.Parse(Console.ReadLine() ?? "0");
//     string? read_string_Data = Console.ReadLine() ?? "0";
//     double read_Data;
//     while (!double.TryParse(read_string_Data, out read_Data))
//     {

//         Console.ForegroundColor = ConsoleColor.Red;
//         Console.Write("Ошибка! Повторите ввод: ");
//         Console.ResetColor();
//         read_string_Data = Console.ReadLine() ?? "0";
//     }
//     return read_Data;
// }


// /// Метод задания 3х прямых линий на плоскости
// double[,] EnterLine(double[,] c_l)
// {
//     /// Ввод с клавиатуры коэффициентов функций прямой линии на плоскости
//     Console.WriteLine("Задайте функцию прямой линии Аx + Вy + С = 0");
//     Console.WriteLine("Запятая - разделитель целой и дробной части вещественного числа");

//     for (int i = 0; i < 3; i++)
//     {
//         Console.WriteLine("Введите по одному через Enter значения коэф-в А,В и С для прямой №" + (i + 1));
//         for (int j = 0; j < 3; j++)
//         {
//             c_l[i, j] = ReadData("Введите " + (j + 1) + "й " + "коэффициент : ");
//         }
//         Console.WriteLine($"Задана {i + 1}-я прямая: {c_l[i, 0]}x + {c_l[i, 1]}y + {c_l[i, 2]} = 0");
//         Console.WriteLine();
//     }
//     return c_l;
// }

//  Метод вычисления точек пересечения  (координата вершины треугольника) 
double[,] CrossTwoLines(double[,] c_l, double[,] triangle_vertex)
{
    for (int i = 0; i < c_l.GetLength(0); i++)
    {
        for (int j = i + 1; j < c_l.GetLength(1); j++)
        {
            // double znl = (B1 * A2 - B2 * A1);
            double znl = (c_l[i, 1] * c_l[j, 0] - c_l[j, 1] * c_l[i, 0]);

            if (znl == 0)
            {
                Console.WriteLine("Прямые параллельные или совпадают и не создают треугольник!");
            }
            else
            { // Вычисление точки пересечения

                // X:= (C1 * B2 - C2 * B1) / (B1 * A2 - B2 * A1);
                // Y:= (C2 * A1 - C1 * A2) / (B1 * A2 - B2 * A1);

                // Console.WriteLine($" для {i} и {j} : {c_l[i, j]}, {c_l[i+1, j+1]}, {c_l[i+2, j+2]} ");

                triangle_vertex[i, 0] = (c_l[i, 2] * c_l[j, 1] - c_l[j, 2] * c_l[i, 1]) / znl;
                triangle_vertex[i, 1] = (c_l[j, 2] * c_l[i, 0] - c_l[i, 2] * c_l[j, 0]) / znl;

                Console.WriteLine("Прямые пересекаются в точке: " + triangle_vertex[i, 0] + ", " + triangle_vertex[i, 1]);
            }
            // Console.WriteLine($"Для i={i}, j={j}, Х={triangle_vertex[i, 0]}, Y={triangle_vertex[i, 1]}");
        }
    }
    return triangle_vertex;  // ЗДЕСЬ ГДЕ-ТО ОШИБКА ! ВОЗВРАЩАЕТ МАТРИЦУ, не ту, что получили в цикле! А с одной пустой сторокой
}

// /// Метод Вычисления расстояние между точками в 2D пространстве
// // double CalcLengthLine(double[,] arr)
// // {

// //     for (int i = 0; i < 3; i++)
// //     {
// //         for (int j = 0; j < 3; j++)
// //         {
// //     LengthLine = Math.Sqrt(Math.Pow((arr[] - x2), 2) + Math.Pow((y1 - y2), 2));

// //     return LengthLine;
// // }


// /// Метод Вычисления периметра треугольника
// // var TrianglePerimeter(sideA, sideB, sideC)
// // {
// //     p = (sideA + sideB + sideC);
// //     return;
// // }

// /// Метод Вычисления площади треугольника
// // var TriangleArea(sideA, sideB, sideC)
// // {
// //     var p = TrianglePerimeter(sideA, sideB, sideC);
// //     s = Math.Sqrt(p / 2 * (p / 2 - A) * (p / 2 - B) * (p / 2 - C));
// //     return s;
// // }

void Print2DArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} \t");
        }
        Console.WriteLine();
    }
}


/// Main - Блок решения задачи

double[,] c_l = { { 1, 3, 8 }, { -1, -1, 4 }, { 0.5, -1, 4 } };
// double[,] c_l = new double[3, 3]; // c_l constants_line Массив 3х прямых линий на плоскости

double[,] triangle_vertex = new double[3, 2]; // Массив 3х точек пересечения прямых - вершин треугольника
                                              // EnterLine(c_l);
Console.WriteLine("Массив 3х прямых линий на плоскости");
Print2DArray(c_l);
Console.WriteLine();

CrossTwoLines(c_l, triangle_vertex);
Console.WriteLine();

Console.WriteLine("Массив 3х точек пересечения прямых - вершин треугольника");
Print2DArray(triangle_vertex);
Console.WriteLine("ГДЕ-ТО ОШИБКА в методе CrossTwoLines! return ВОЗВРАЩАЕТ не ту МАТРИЦУ, что получили в цикле! А с одной пустой сторокой");


// // Console.WriteLine("Получаем треугольник со сторонами длинной: " + sideA + ", " + sideB + ", " + sideC);
// // Console.WriteLine("Периметр треугольника равен: {0}", TrianglePerimeter());
// // Console.WriteLine("Площадь треугольника равна: {0}", TriangleArea());
Console.WriteLine(" ");