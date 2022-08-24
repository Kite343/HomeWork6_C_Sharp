/*
Доп. задча: Задайте двумерный массив со случайными числами от -10 до 10. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.)

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

Сумма элементов главной диагонали: 1+9+2 = 12
*/

int[,] arraysNumbers(int n)
{
    int[,] array = new int [n, n];
    for (int i = 0; i < n; i++)
    {
        for(int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(-10, 11);
        }
    }
    return array;
}

void PrintArrays(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {Console.Write("{0,4}", array[i, j]);}
        Console.WriteLine();
    }
}

void sumMainDiag(int[,] array)
{
    int sum = 0;
    for(int i = 0; i < array.GetLength(0); i++) sum += array[i, i];
    Console.WriteLine($"Сумма чисел главной диагонали равна {sum}");
}

Console.WriteLine("Задайте размер квадратной матрицы");
int[,] myArrays = arraysNumbers(int.Parse(Console.ReadLine()));
PrintArrays(myArrays);
Console.WriteLine();
sumMainDiag(myArrays);