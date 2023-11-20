/*
69. Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
*/

using System;
Console.Clear();

int TakeEntNum(string message)
{
    Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int Exponent(int n, int j)
{
    if (j == 1) return n;
    else return n * Exponent(n, j - 1);
}

int userNumberА = TakeEntNum("Введите число А: ");
int userNumberB = TakeEntNum("Введите число B: ");
int userResult = Exponent(userNumberА, userNumberB);

System.Console.WriteLine(userResult);