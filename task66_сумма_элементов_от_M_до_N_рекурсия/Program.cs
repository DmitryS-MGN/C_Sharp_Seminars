/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

using System;
Console.Clear();

int TakeEntNum(string message)
{
    Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int Sum(int n, int j)
{
    if (n <= j) return n + Sum(n + 1, j);
    else return 0;
}

int userNumberStart = TakeEntNum("Введите певое число: ");
int userNumberEnd = TakeEntNum("Введите второе число: ");

int userSum = Sum(userNumberStart, userNumberEnd);

System.Console.WriteLine($"M = {userNumberStart}; N = {userNumberEnd} -> {userSum}");