/* Задача 35: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в
массиве. 
[345, 897, 568, 234] -> 2
*/

using System;
Console.Clear();

int TakeEntNum(string message)
{
    Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int[] GetRandomArray(int size/*,int n, int j*/)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

int CountEvenElements(int[] arr)
{
    int result = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) result++;
    }
    return result;
}

void PrintArray(int[] arr, int n)
{
    System.Console.WriteLine();
    System.Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(arr[i]);
        if (i < arr.Length - 1)
            System.Console.Write(", ");
    }
    Console.Write($"] -> {n}" );
}

int userArraySize = TakeEntNum("Введите размер массива: ");
//int startRangeElement = TakeEntNum("Введите число от котрого начинается диапазон массива: ");
//int endRangeElement = TakeEntNum("Введите число которым заканчивается диапазон массива: ");

int[] userArray = GetRandomArray(userArraySize/*, startRangeElement, endRangeElement*/);
PrintArray(userArray, CountEvenElements(userArray));