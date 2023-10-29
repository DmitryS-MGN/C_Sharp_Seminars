/*
Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

using System;
Console.Clear();

int TakeEntNum(string message)
{
    Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int[,] GetRandomArray2D(int rows, int columns, int startElem, int endElem)
{
    int[,] arr2D = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            arr2D[i, j] = new Random().Next(startElem, endElem + 1);
        }
    }
    return arr2D;
}

void PrintArray(int[,] arr2D)
{
    System.Console.WriteLine();
    System.Console.Write("[ ] \t");
    for (int j = 0; j < arr2D.GetLength(1); j++)
    {
        System.Console.Write($"[{j}] \t");
    }
    System.Console.WriteLine();
    for (int i = 0; i < arr2D.GetLength(0); i++)
    {
        System.Console.Write($"[{i}] \t");
        for (int j = 0; j < arr2D.GetLength(1); j++)
        {
            Console.Write(" " + arr2D[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

double[] FindAverageInColumns(int[,] arr2D)
{
    double[] arr = new double[arr2D.GetLength(1)]; //Длина нового массива равна количеству столбцов в двумерном массиве
    int sum = 0;
    for (int j = 0; j < arr2D.GetLength(1); j++)
    {
        sum = 0; // Обнуляем значение суммы для нового столбца
        for (int i = 0; i < arr2D.GetLength(0); i++)
        {
            sum = sum + arr2D[i, j];
        }
        arr[j] = sum / arr2D.GetLength(1); //Делим сумму элементов строк в столбце на количество строк в массиве и добовляем результат (среднне арефм)в индекс нового массива
    }
    return arr;
}

void PrintAverageArray(double[] arr)
{
    Console.Write("Среднее арефметическое каждого столбца: ");
    for (int i = 0; i < arr.Length; i++) 
    {
        Console.Write($"{arr[i]:f2}\t");
    }
}

int userArrayRows = TakeEntNum("Введите кол-во строк массива: ");
int userArrayColumns = TakeEntNum("Введите кол-во столбцов массива: ");
int startRangeElement = TakeEntNum("Введите число от котрого начинается диапазон массива: ");
int endRangeElement = TakeEntNum("Введите число которым заканчивается диапазон массива: ");

int[,] userRandomArray2D = GetRandomArray2D(userArrayRows, userArrayColumns, startRangeElement, endRangeElement);
double[] userAverageInColumns = FindAverageInColumns(userRandomArray2D);

PrintArray(userRandomArray2D);
FindAverageInColumns(userRandomArray2D);
PrintAverageArray(userAverageInColumns); // Распичатываем наш массив со средним арефметическим каждого столбца


