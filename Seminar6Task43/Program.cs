Console.Clear();
Console.WriteLine("Привет! Это задание выполнено Павлом Овчинниковым при обучении основам языка С#");
Console.WriteLine(@"
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
Например: b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
(от Голикова А.С.) * Найдите площадь треугольника образованного пересечением 3 прямых.
");

// Console.WriteLine();

/// Метод ввода вещественного числа
double ReadData(string msg)
{
    Console.Write(msg);
    // double read_Data = double.Parse(Console.ReadLine() ?? "0");
    string? read_string_Data = Console.ReadLine() ?? "0";
    double read_Data;
    while (!double.TryParse(read_string_Data, out read_Data))
    {

        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("Ошибка! Повторите ввод: ");
        Console.ResetColor();
        read_string_Data = Console.ReadLine() ?? "0";
    }
    return read_Data;
}


// /// Метод задания 3х прямых линий на плоскости
double[,] EnterLine(double[,] c_l)
{
    /// Ввод с клавиатуры коэффициентов функций прямой линии на плоскости
    Console.WriteLine("Задайте функцию прямой линии Аx + Вy + С = 0");
    Console.WriteLine("Запятая - разделитель целой и дробной части вещественного числа");

    for (int i = 0; i < 3; i++)
    {
        Console.WriteLine("Введите по одному через Enter значения коэф-в А,В и С для прямой №" + (i + 1));
        for (int j = 0; j < 3; j++)
        {
            c_l[i, j] = ReadData("Введите " + (j + 1) + "й " + "коэффициент : ");
        }
        Console.WriteLine($"Задана {i + 1}-я прямая: {c_l[i, 0]}x + {c_l[i, 1]}y + {c_l[i, 2]} = 0");
        Console.WriteLine();
    }
    return c_l;
}

//  Метод вычисления точек пересечения  (координата вершины треугольника) 
double[,] CrossTwoLines(double[,] c_l, double[,] triangle_vertex)
{
    int k = 0;
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
                triangle_vertex[k, 0] = (c_l[i, 2] * c_l[j, 1] - c_l[j, 2] * c_l[i, 1]) / znl;
                triangle_vertex[k, 1] = (c_l[j, 2] * c_l[i, 0] - c_l[i, 2] * c_l[j, 0]) / znl;
                k++;
            }
        }
    }
    return triangle_vertex;
}

/// Метод Вычисления расстояние между точками в 2D пространстве
double[] CalcSide(double[,] arr)
{
    double[] sides = new double[3]; // Массив из 3х сторон треугольника

    sides[0] = Math.Sqrt(Math.Pow((arr[0, 0] - arr[1, 0]), 2) + Math.Pow((arr[0, 1] - arr[1, 1]), 2));
    sides[1] = Math.Sqrt(Math.Pow((arr[0, 0] - arr[2, 0]), 2) + Math.Pow((arr[0, 1] - arr[2, 1]), 2));
    sides[2] = Math.Sqrt(Math.Pow((arr[1, 0] - arr[2, 0]), 2) + Math.Pow((arr[1, 1] - arr[2, 1]), 2));

    return sides;
}

/// Метод Вычисления периметра треугольника
double TrianglePerimeter(double[] sides)
{
    double p = (sides[0] + sides[1] + sides[2]);
    return p;
}

/// Метод Вычисления площади треугольника
double TriangleArea(double[] sides)
{
    double p = (sides[0] + sides[1] + sides[2]); // Вычисления периметра треугольника
    double triangle_area = Math.Sqrt(p / 2 * (p / 2 - sides[0]) * (p / 2 - sides[1]) * (p / 2 - sides[2]));
    return triangle_area;
}

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

// double[,] c_l = { { 1, 3, 8 }, { -1, -1, 4 }, { 0.5, -1, 4 } };
// double[,] c_l = { { 1, 0, 0 }, { 0, 1, 0 }, { 4, 3, -12 } }; // Египетский треугольник

// определяем переменные - массивы коэф-в прямых линий, точки их пересечения и длины сторон треугольника
double[,] c_l = new double[3, 3]; // Массив 3х прямых линий на плоскости c_l от constants_of_lines
double[,] triangle_vertex = new double[3, 2]; // Массив 3х точек пересечения прямых - вершин треугольника
double[] sides = new double[3]; // Массив из 3х сторон треугольника

EnterLine(c_l);  // Вводим коэф. линий с клавиатуры

Console.WriteLine("Массив 3х прямых линий на плоскости");
Print2DArray(c_l);
Console.WriteLine();

CrossTwoLines(c_l, triangle_vertex);
Console.WriteLine();

Console.WriteLine("Массив 3х точек пересечения прямых - вершин треугольника");
Print2DArray(triangle_vertex);
Console.WriteLine();

sides = CalcSide(triangle_vertex);
Console.WriteLine($"Получаем треугольник со сторонами: {sides[0]} , {sides[1]} , {sides[2]}");
Console.WriteLine();

double triangle_area = TriangleArea(sides);
Console.WriteLine($"Площадь треугольника равна: {triangle_area}");
double p = TrianglePerimeter(sides);
Console.WriteLine($"Периметр треугольника равен: {p}");
Console.WriteLine();
Console.WriteLine(" Ура! Хитрость обманула здравый смысл");