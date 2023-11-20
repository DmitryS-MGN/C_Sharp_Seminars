/*
65. Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
*/

using System;
Console.Clear();

int TakeEntNum(string message)
{
    Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

void Integers(int n, int j)
{
    if (n <= j) 
    {
        System.Console.Write(n + " ");
        Integers(n + 1, j);
    }
    else return;
}

int userNumberStart = TakeEntNum("Введите начальное число: ");
int userNumberEnd = TakeEntNum("Введите конечно число: ");

Integers(userNumberStart, userNumberEnd);