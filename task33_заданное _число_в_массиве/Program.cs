/*33. Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да
*/

using System;
Console.Clear();

int TakeEntNum(string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int[] GetUserArray(int size, int n, int j)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(n, j + 1);
    }
    return array;
}

void PrintArray(int[] arr, bool var) // Добавляем переменну var для значение буловой функции
{
    System.Console.WriteLine();
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i]);
        if (i < arr.Length - 1)
            Console.Write(", ");
    }
    Console.Write("] -> ");
    if (var == true) System.Console.WriteLine("Да"); // Если в буловой функции было значение true
    else System.Console.WriteLine("Нет"); // Если в буловой функции было значение false
}

bool SearchElemnet(int[] arr, int n) // Булова функция, показывает значение True или False, в зависимости от условий
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (n == arr[i])
            return true;
    }
    return false;
}

int userArraySize = TakeEntNum("Введите размер массива: ");
int startRangeElement = TakeEntNum("Введите число от котрого начинается диапазон массива: ");
int endRangeElement = TakeEntNum("Введите число которым заканчивается диапазон массива: ");
int userSearchElemnet = TakeEntNum("Введите искомое число: ");

int[] userArray = GetUserArray(userArraySize, startRangeElement, endRangeElement);
PrintArray(userArray, SearchElemnet(userArray, userSearchElemnet)); // Добавляем значение буловой функции
