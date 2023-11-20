/*
67. Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
*/

using System;
Console.Clear();

int TakeEntNum(string message)
{
    Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int SumNumber(int n)
{
    if(n % 10 > 0) return n % 10 + SumNumber(n / 10);
    else return 0;
}

int userNumber = TakeEntNum("Введите число: ");
int userSum = SumNumber(userNumber);

System.Console.WriteLine(userSum);