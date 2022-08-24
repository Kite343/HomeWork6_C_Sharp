/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3
*/

void NumsPositiv (int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++){if(array[i] > 0)count += 1;}
    Console.WriteLine($"В вашем списке положительных чисел {count}");
}

Console.WriteLine("Введите эелементы массива одной строкой через пробел");
int[] myArray = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
Console.WriteLine(string.Join(", ", myArray));
NumsPositiv(myArray);