/*
42. Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10
*/

using System;
Console.Clear();

int TakeEntNum(string message)
{
    Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

string ConvertToBinary(int n) // -> решение через string
{
    string result = "";
    int tmp = 0;
    for (int i = n; i > 0; i /= 2)
    {
        tmp = i % 2; // остаток от деления на 2
        result = tmp + result; // в стринговой переменной сложение происходит -> 2 + 2 = 22 (для обратного порядка сначала занчение tmp затем + result)
    }
    return result;
}

/* int ConvertToBinary(int n) // -> решение через int 
    Решение через int
    int result = 0;
    int ten = 1;
    while (number > 0)
    {
        result = number % 2 * ten + result;
        number = number / 2;
        ten = ten * 10;
    }
    return result;
    */

void PrintAnswer(int n, string j)
{
    System.Console.WriteLine($"{n} -> {j}");
}

/*void PrintAnswer(int n, int j) // -> для решения через int
{
    System.Console.WriteLine($"{n} -> {j}");
}
*/

int userNumber = TakeEntNum("Введите число: ");

string userBinary = ConvertToBinary(userNumber);
//int userBinary = ConvertToBinary(userNumber); // - > для решения через int
PrintAnswer(userNumber, userBinary);