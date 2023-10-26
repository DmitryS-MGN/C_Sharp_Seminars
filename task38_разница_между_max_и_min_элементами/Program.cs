/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
FindMax(double[] array): Метод принимает на вход массив вещественных чисел array и возвращает максимальное число из массива.
FindMin(double[] array): Метод принимает на вход массив вещественных чисел array и возвращает минимальное число из массива.
CalcDifferenceBetweenMaxMin(double[] array): Метод принимает на вход массив вещественных чисел array и возвращает разницу между максимальным и минимальным числами в массиве.
*/

using System;
Console.Clear();

int TakeEntNum(string message)
{
    Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

double[] GetRandomArray(int size, int n, int j)
{
    double[] arr = new double[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(n, j) + new Random().NextDouble(); // Рандом из Double
    }
    return arr;
}

double FindMax(double[] arr)
{
    double result = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > result) result = arr[i];
    }
    return Math.Round(result, 2);
}

double FindMin(double[] arr)
{
    double result = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < result) result = arr[i];
    }
    return Math.Round(result, 2);
}

double CalcDifferenceBetweenMaxMin(double[] arr)
{
    return Math.Round(FindMax(arr) - FindMin(arr), 2); // Здесь мы берем, наш массив (можно завести новый массив), и используем методы FindMax и FindMin                                                                          
}                                                      // для поиска макс и мин значений массива и в качестве результата возвращаем разность между макс и мин.         

void PrintArray(double[] arr, double n, double j, double k)
{
    System.Console.WriteLine();
    System.Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(Math.Round(arr[i], 2));
        if (i < arr.Length - 1)
            System.Console.Write(", ");
    }
    Console.Write($"] -> ({n} - {j}) -> {k}");
}

int userArraySize = TakeEntNum("Введите размер массива: ");
int startRangeElement = TakeEntNum("Введите число от котрого начинается диапазон массива: ");
int endRangeElement = TakeEntNum("Введите число которым заканчивается диапазон массива: ");

double[] userArray = GetRandomArray(userArraySize, startRangeElement, endRangeElement);
double userFindMax = FindMax(userArray);
double userFindMin = FindMin(userArray);
double userDiffBetMaxMin = CalcDifferenceBetweenMaxMin(userArray);
PrintArray(userArray, userFindMax, userFindMin, userDiffBetMaxMin);
