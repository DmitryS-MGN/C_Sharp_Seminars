/*
63. Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
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
    if (n < current) return;
    else
    {
        System.Console.Write(current + " ");
        Integers(n, current + 1);
    }
}

int userNumber = TakeEntNum("Введите число: ");

Integers(userNumber);