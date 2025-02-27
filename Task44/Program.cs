﻿// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8


Console.WriteLine("Укажите сколько чисел ряда Фибоначи вывести в консоль?");
int size = Convert.ToInt32(Console.ReadLine());

int [] fibo = Fibonachi(size);
PrintArray(fibo);


int[] Fibonachi(int n)
{
    int[] fibonacciSeries = new int[n];
    fibonacciSeries[0] = 0;
    fibonacciSeries[1] = 1;
    for (int i = 2; i < n; i++)
    {
        fibonacciSeries[i] = fibonacciSeries[i - 1] + fibonacciSeries[i - 2];
    }
    return fibonacciSeries;
}

void PrintArray(int[] arr)
{
    Console.Write("");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write(arr[i] + ", ");
        else Console.Write(arr[i]);
    }
    Console.WriteLine("");
}

// ряд Фибоначи для проверки:
// 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987, 1597, 2584, 4181, 6765, 10946, 17711
