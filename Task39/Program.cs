﻿// Задача 39: Напишите программу, которая перевернёт
// одномерный массив (последний элемент будет на первом
// месте, а первый - на последнем и т.д.)
// Примеры:
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

Console.WriteLine("Введите число, длину будущего входящего массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число, начало диапазона случайных чисел, которыми будет заполнен массив: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число, конец диапазона случайных чисел, которыми будет заполнен массив: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = CreateArrayRndInt(size, min, max);
Console.Write("Входящий массив: -> ");
PrintArray(array);
// int [] reverseArray = ReverseArray(array);
Console.Write("Перевернутый массив: -> ");
// ReverseArray(array);
ReverseArrayVersion2(array);
PrintArray(array);

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write(arr[i] + ", ");
        else Console.Write(arr[i]);
    }
    Console.WriteLine("]");
}

/*
int [] ReverseArray(int[] arr)
{
    int[] revArray = new int[arr.Length];
    for( int i = 0; i < arr.Length; i++)
    {
        revArray [i] = arr [arr.Length -1 -i];
    }
    return revArray;
}
*/

/*
void ReverseArray(int [] arr)
{
    for(int i = 0; i < arr.Length/2; i++)
    {
        int temp = arr [i];
        arr [i] = arr [arr.Length -1 -i];
        arr [arr.Length -1 -i] = temp;
    }
}
*/

void ReverseArrayVersion2(int [] arr)
{
    int index1 = 0;
    int index2 = arr.Length -1;

    while(index1 < index2)
    {
        int obj = arr [index1];
        arr [index1] = arr [index2];
        arr [index2] = obj;
        index1 ++;
        index2 --;
    }
}
