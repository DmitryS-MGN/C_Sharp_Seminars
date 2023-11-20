/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
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

int[] RowSumArray(int[,] arr2D)
{
    int sum = 0;
    int[] arr = new int[arr2D.GetLength(0)];
    for (int i = 0; i < arr2D.GetLength(0); i++)
    {
        sum = 0;
        for (int j = 0; j < arr2D.GetLength(1); j++)
        {
            sum += arr2D[i, j];
        }
        arr[i] = sum;
    }
    return arr;
}

void Print2DArray(int[,] arr2D)
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

void PrintSumRowArray(int[] arr)
{
    System.Console.WriteLine();
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write($"[{i}] -> {arr[i]}, ");
    }
    System.Console.WriteLine();
}

void MinRow(int[] arr)
{
    int min = 0;
    int row = 0;
    int temp = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {   
        if (temp > arr[i])
        {
            temp = arr[i];
            row = i;
        }
        else 
        {
            min = temp;
        }
    } 
    System.Console.WriteLine();
    System.Console.Write($"Наименьшая строка -> {row}");
}

int userArrayRows = TakeEntNum("Введите кол-во строк массива: ");
int userArrayColumns = TakeEntNum("Введите кол-во столбцов массива: ");
int startRangeElement = TakeEntNum("Введите число от котрого начинается диапазон массива: ");
int endRangeElement = TakeEntNum("Введите число которым заканчивается диапазон массива: ");

int[,] userRandomArray2D = GetRandomArray2D(userArrayRows, userArrayColumns, startRangeElement, endRangeElement);
int[] userArray = RowSumArray(userRandomArray2D);

Print2DArray(userRandomArray2D);
PrintSumRowArray(userArray);
MinRow(userArray);
