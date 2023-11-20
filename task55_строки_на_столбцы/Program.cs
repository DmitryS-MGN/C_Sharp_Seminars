/*
55. Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
В случае, если это невозможно, программа должна вывести сообщение для пользователя.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
В итоге получается вот такой массив:
1 5 8 5
4 9 4 2
7 2 2 6
2 3 4 7
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

int[,] GetColumnsToRowsArray2D(int[,] arr2D)
{
    int[,] modarr2D = new int[arr2D.GetLength(1), arr2D.GetLength(0)];
    for (int i = 0; i < modarr2D.GetLength(0); i++)
    {
        for (int j = 0; j < modarr2D.GetLength(1); j++)
        {
            modarr2D[i, j] = arr2D[j, i];
        }
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

void PrintColumnsToRowsArray(int[,] arr2D)
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

int userArrayRows = TakeEntNum("Введите кол-во строк: ");
int userArrayColumns = TakeEntNum("Введите кол-во столбцов: ");
int startRangeElement = TakeEntNum("Введите число от котрого начинается диапазон массива: ");
int endRangeElement = TakeEntNum("Введите число которым заканчивается диапазон массива: ");

int[,] userRandomArray2D = GetRandomArray2D(userArrayRows, userArrayColumns, startRangeElement, endRangeElement);
int[,] userCopyArray2D = CopyArray2D(userRandomArray2D);
int[,] userColumnsToRowsArray2D = GetColumnsToRowsArray2D(userCopyArray2D);

PrintArray(userRandomArray2D);
PrintColumnsToRowsArray(userColumnsToRowsArray2D);







