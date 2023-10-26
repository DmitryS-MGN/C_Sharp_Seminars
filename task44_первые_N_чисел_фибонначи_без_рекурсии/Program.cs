/*
44. Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8
*/

using System;
Console.Clear();

int TakeEntNum(string message)
{
    Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int[] Febonachi(int n)
{
    int size = n;
    if (n < 1)
        size = 1; // Происходит краш
    else if (n < 2)
        size = 2;

    int[] arr = new int[size];
    arr[0] = 0;
    arr[1] = 1;
    for (int i = 2; i < size; i++)
    {
        arr[i] = arr[i - 2] + arr[i - 1];
    }

    return arr;
}

void PrintArray(int[] arr, int n)
{
    System.Console.Write("Если N = " + n + " -> ");
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(" " + arr[i]);
    }
}

int userNumber = TakeEntNum("Введите число: ");
PrintArray(Febonachi(userNumber), userNumber);