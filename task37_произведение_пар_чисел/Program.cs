/*
37. Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
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

int[] ProductArray(int[] arr)
{
    int[] result = new int[arr.Length - arr.Length / 2];
    int product = 0;
    for (int i = 0; i < arr.Length - arr.Length / 2; i++)
    {
        if(i == arr.Length - 1 - i) // Условие окончания цикла for для массива с нечетным количеством элементов
        {
            result[i] = arr[i];
            break; //заканчивает цикл
        }
        product = arr[i] * arr[arr.Length - 1 - i]; //Разворот массива, для движения с конца массива 
        result[i] = product;
    }
    return result;
}

void PrintArray(int[] arr, int[] arr2)
{
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
int[] userProductArray = ProductArray(userArray);
PrintArray(userArray, userProductArray);


