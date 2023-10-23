/*
35. Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
Пример для массива из 5, а не 123 элементов. В своем решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5
*/

using System;
Console.Clear();

int TakeEntNum(string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int[] GetUserArray(int size, int n, int j)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(n, j + 1);
    }
    return array;
}

//Решение через void внутри 
void PrintArray(int[] arr, int n)
{   //int count = 0;
    System.Console.WriteLine();
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {   
        Console.Write(arr[i]);
        if (i < arr.Length - 1)
            Console.Write(", ");
        //if (arr[i] > 9 && arr[i] < 100)
            //count++;
    }
    //Console.Write("] -> " + count);
    Console.Write($"] -> {n} ");
}

//Решение через int
int Amount(int[] arr)
{
    int result = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 9 && arr[i] < 100)
            result++;
    } 
    return result;
} 

int userArraySize = TakeEntNum("Введите размер массива: ");
int startRangeElement = TakeEntNum("Введите число от котрого начинается диапазон массива: ");
int endRangeElement = TakeEntNum("Введите число которым заканчивается диапазон массива: ");

int[] userArray = GetUserArray(userArraySize, startRangeElement, endRangeElement);
PrintArray(userArray, Amount(userArray));
