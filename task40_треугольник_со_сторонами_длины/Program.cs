/*
40. Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.

Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон -> a + b > c && a + c > b && b + c > a
*/

using System;
Console.Clear();

int TakeEntNum(string message)
{
    Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

bool Triangle(int n, int j, int k)
{
    if (n + j > k && n + k > j && j + k > n) return true;
    else return false;
}

void PrintAnswer(bool var)
{
    System.Console.WriteLine();
    if (var == true) System.Console.WriteLine($"Да, треугольника со сторонами такой длины существует");
    else System.Console.WriteLine($"Нет, треугольника со сторонами такой длины не существует");
}

int firstNumber = TakeEntNum("Введите первое число: ");
int secondNumber = TakeEntNum("Введите второе число: ");
int thirdNumber = TakeEntNum("Введите третье число: ");

PrintAnswer(Triangle(firstNumber, secondNumber, thirdNumber));