/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

void crosspoint(double[] y1, double[] y2)
{
    double x = (y2[1] - y1[1]) / (y1[0] - y2[0]);
    double y = y1[0] * x + y1[1];
    Console.WriteLine($"Точка пересечения прямых ({x}, {y})");
}

Console.WriteLine("Введите коэффициенты k и b уравнения первой прямой через пробел");
double[] line1 = Console.ReadLine().Split(" ").Select(x => double.Parse(x)).ToArray();
Console.WriteLine("Введите коэффициенты k и b уравнения второй прямой через пробел");
double[] line2 = Console.ReadLine().Split(" ").Select(x => double.Parse(x)).ToArray();
crosspoint(line1, line2);