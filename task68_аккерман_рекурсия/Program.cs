/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

using System;
Console.Clear();

int TakeEntNum(string message)
{
    Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int Akkerman(int n, int j)
{
    if (n == 0) return j + 1;
    if (n != 0 && j == 0) return Akkerman(n - 1, 1);
    if (n > 0 && j > 0) return Akkerman(n - 1, Akkerman(n, j - 1));
    return Akkerman(n, j);
}

int userNumberStart = TakeEntNum("Введите певое число: ");
int userNumberEnd = TakeEntNum("Введите второе число: ");

int userAkkerman = Akkerman(userNumberStart,userNumberEnd);

System.Console.WriteLine($"m = {userNumberStart}, n = {userNumberEnd} -> A(m,n) = {userAkkerman}");