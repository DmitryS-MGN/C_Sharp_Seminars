/* Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях 
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

using System;
Console.Clear();

int TakeEntNum(string message)
{
    Console.WriteLine(message);
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

int SumOddElements(int[] arr)
{
    int result = 0;
    for (int i = 1; i < arr.Length; i+=2)
    {
        result +=arr[i];
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
    Console.Write($"] -> {n}");
}

int userArraySize = TakeEntNum("Введите размер массива: ");
int startRangeElement = TakeEntNum("Введите число от котрого начинается диапазон массива: ");
int endRangeElement = TakeEntNum("Введите число которым заканчивается диапазон массива: ");

int[] userArray = GetRandomArray(userArraySize, startRangeElement, endRangeElement);
PrintArray(userArray, SumOddElements(userArray));