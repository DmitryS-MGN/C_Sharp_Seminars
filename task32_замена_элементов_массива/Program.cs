/*32. Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2]
*/

using System;
Console.Clear();

int[] GetUserArray(int n, int j, int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(n, j + 1);
    }
    return array;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i]);
        if (i < arr.Length - 1)
            Console.Write(", ");
    }
    Console.Write("] -> ");

    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] * -1);
        if (i < arr.Length - 1)
            Console.Write(", ");
    }
    Console.Write("]");

}

int TakeEntNum(string message)  //Функция переводит стринговое значение в интовое при введении условия от пользователя
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int userArraySize = TakeEntNum ("Введите размер массива: ");
int startRangeElement = TakeEntNum ("Введите число от котрого начинается диапазон массива: ");
int endRangeElement = TakeEntNum ("Введите число которым заканчивается диапазон массива: ");

int[] userArray = GetUserArray(startRangeElement, endRangeElement, userArraySize);
PrintArray(userArray);