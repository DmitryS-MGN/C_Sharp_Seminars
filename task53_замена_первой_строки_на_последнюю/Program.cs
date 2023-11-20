/*
53. Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
8 4 2 4
5 9 2 3
1 4 7 2
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

int[,] CopyArray2D(int[,] arr2D)
{
    int[,] copyarr2D = new int[arr2D.GetLength(0), arr2D.GetLength(1)];
    for (int i = 0; i < arr2D.GetLength(0); i++)
    {
        for (int j = 0; j < arr2D.GetLength(1); j++)
        {
            copyarr2D[i, j] = arr2D[i, j];
        }
    }
    return copyarr2D;
}

int[,] GetChangeRowsArray2D(int[,] arr2D)
{
    int temp = 0;
    int[,] modarr2D = new int[arr2D.GetLength(0), arr2D.GetLength(1)];
    modarr2D = CopyArray2D(arr2D);
    for (int j = 0; j < arr2D.GetLength(1); j++)
    {
        temp = modarr2D[0,j];
        modarr2D[0,j] = modarr2D[arr2D.GetLength(0)-1,j];
        modarr2D[arr2D.GetLength(0)-1,j] = temp;
    }
    return modarr2D;
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

void PrintChangeRowsArray(int[,] arr2D)
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

int[,] userRandomArray2D = GetRandomArray2D(userArrayRows, userArrayColumns, startRangeElement, endRangeElement);
int[,] userCopyArray2D = CopyArray2D(userRandomArray2D);
int[,] userChangeRowsArray2D = GetChangeRowsArray2D(userRandomArray2D);

PrintArray(userRandomArray2D);
PrintChangeRowsArray(userChangeRowsArray2D);