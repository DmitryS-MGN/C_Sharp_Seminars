/*
Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

using System;
Console.Clear();

int TakeEntNum(string message)
{
    Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

void Integers(int n, int current = 1)
{
    if (current <= n)
    {
        System.Console.Write(n + "," + " ");
        Integers(n - 1, current);
    }
    else return;
}

int userNumber = TakeEntNum("Введите число: ");
System.Console.Write($"N = {userNumber} -> ");
Integers(userNumber);