/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

using System;
Console.Clear();

int TakeEntNum(string message)
{
    Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int[] GetUserArray(int size)
{
    System.Console.WriteLine("Вводите числа по одному: ");
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}

int CountPosNum(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) count++;
    }
    return count;
}

void PrintArray(int[] arr, int n)
{
    System.Console.WriteLine();
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(arr[i]);
        if (i < arr.Length - 1)
            System.Console.Write(", ");
    }
    System.Console.Write(" -> " + n);
}

int userArraySize = TakeEntNum("Введите количество чисел, которое хотите ввести: ");

int[] userArray = GetUserArray(userArraySize);
int userPosNum = CountPosNum(userArray);
PrintArray(userArray, userPosNum);