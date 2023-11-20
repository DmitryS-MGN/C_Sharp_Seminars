/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
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

int[,] GetMultipliedArray2D(int[,]arr2D1, int[,]arr2D2)
{
    int[,] multipliedarr2D = new int[arr2D1.GetLength(0), arr2D1.GetLength(1)];
     for (int i = 0; i < multipliedarr2D.GetLength(0); i++)
        {
            for (int j = 0; j < multipliedarr2D.GetLength(1); j++)
            {
                   multipliedarr2D[i, j] = arr2D1[i, j] * arr2D2[i, j];
            }
        }
        return multipliedarr2D;
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

int userArrayRows = TakeEntNum("Введите кол-во строк массива: ");
int userArrayColumns = TakeEntNum("Введите кол-во столбцов массива: ");
int startRangeElement = TakeEntNum("Введите число от котрого начинается диапазон массива: ");
int endRangeElement = TakeEntNum("Введите число которым заканчивается диапазон массива: ");

int[,] userRandomArray2DFirst = GetRandomArray2D(userArrayRows, userArrayColumns, startRangeElement, endRangeElement);
int[,] userRandomArray2DSecond = GetRandomArray2D(userArrayRows, userArrayColumns, startRangeElement, endRangeElement);
int[,] userMultipliedArray2D = GetMultipliedArray2D(userRandomArray2DFirst,userRandomArray2DSecond);

PrintArray(userRandomArray2DFirst);
PrintArray(userRandomArray2DSecond);
System.Console.WriteLine("Результат умножения двух матриц:");
PrintArray(userMultipliedArray2D);