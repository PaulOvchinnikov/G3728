// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
// * Сделать метод загрузки точек

Console.WriteLine();
Console.WriteLine("Привет! Это задание выполнено Павлом Овчинниковым при обучении основам языка С#");
Console.WriteLine();

//Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
// //Выводим результат на консоль терминала
// void PrintData(string msg, double res)
// {
//     Console.WriteLine(msg + res);

//Метод вычисления расстояние между точками в 3D пространстве
double CalcLenght(int x1, int x2, int y1, int y2, int z1, int z2)
{
    double result = 0;
    result = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)) + Math.Pow(z1 - z2, 2);
    return result;
}

//Вводим координаты точек
int coordX1 = ReadData("Введите координату x1: ");
int coordX2 = ReadData("Введите координату x2: ");
int coordY1 = ReadData("Введите координату y1: ");
int coordY2 = ReadData("Введите координату y2: ");
int coordZ1 = ReadData("Введите координату z1: ");
int coordZ2 = ReadData("Введите координату z2: ");

//Вызов метода рассчёта расстояния между точками в 3D | Calculation of the distance between points in 3D
double points_distance = CalcLenght(coordX1, coordX2, coordY1, coordY2, coordZ1, coordZ2);

//Выводим результат в терминал
Console.WriteLine("Расстояние между точками: " + points_distance);
