/*
45. Напишите программу, которая будет создавать копию заданного одномерного массива с помощью поэлементного копирования.
*/

using System;
Console.Clear();

int TakeEntNum(string message)
{
    Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int[] GetRandomArray(int size, int n, int j)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(n, j + 1);
    }
    return array;
}

int[] GetCopiedArray(int[] arr)
{
    int[] result = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        result[i] = arr[i];
    }
    return result;
}

void PrintArray(int[] arr, int[] arr2)
{
    System.Console.WriteLine();
    System.Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(arr[i]);
        if (i < arr.Length - 1)
            System.Console.Write(", ");
    }
    System.Console.Write("] -> ");

    System.Console.Write("[");
    for (int i = 0; i < arr2.Length; i++)
    {
        System.Console.Write(arr2[i]);
        if (i < arr2.Length - 1)
            System.Console.Write(", ");
    }
    System.Console.Write("] ");
}

int userArraySize = TakeEntNum("Введите размер массива: ");
int startRangeElement = TakeEntNum("Введите число от котрого начинается диапазон массива: ");
int endRangeElement = TakeEntNum("Введите число которым заканчивается диапазон массива: ");

int[] userArray = GetRandomArray(userArraySize, startRangeElement, endRangeElement);
PrintArray(userArray, GetCopiedArray(userArray));