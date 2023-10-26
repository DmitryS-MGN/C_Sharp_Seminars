/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

using System;
Console.Clear();

double TakeEntNum(string message)
{
    Console.Write(message);
    double result = Convert.ToDouble(Console.ReadLine());
    return result;
}

void FindCord(double b1, double k1, double b2, double k2)
{
    System.Console.WriteLine();
    if (k1 == k2)
    {
        if (b1 == b2)System.Console.WriteLine("Прямые совпадают");
        else System.Console.WriteLine("Прямые параллельны");
        return;       
    }
    double x = Math.Round((-b2 + b1) / (-k1 + k2), 2);
    double y = Math.Round((k2 * x + b2), 2);
    System.Console.WriteLine($"Точка пересечения двух прямых -> ({x}; {y})");
}

System.Console.WriteLine("Введите четыре значения: ");
double userNum1 = TakeEntNum("b1 = ");
double userNum2 = TakeEntNum("k1 = ");
double userNum3 = TakeEntNum("b2 = ");
double userNum4 = TakeEntNum("k2 = ");

FindCord(userNum1, userNum2, userNum3, userNum4);