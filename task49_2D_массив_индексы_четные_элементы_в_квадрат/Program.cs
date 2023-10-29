/*
49. Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
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

int[,] GetModifiedArray2D(int[,] arr2D)
{
    int[,] modArr2D = new int[arr2D.GetLength(0), arr2D.GetLength(1)];
    for (int i = 0; i < arr2D.GetLength(0); i++)
    {
        for (int j = 0; j < arr2D.GetLength(1); j++)
        {
            if(i % 2 == 0 && j % 2 == 0)
            modArr2D[i, j] = arr2D[i, j] * arr2D[i, j];
            else 
            modArr2D[i, j] = arr2D[i, j];
        }
    }
    return modArr2D;
}

void PrintArray2D(int[,] arr2D)
{
    System.Console.WriteLine();
    for (int i = 0; i < arr2D.GetLength(0); i++)
    {
        System.Console.Write("[");
        for (int j = 0; j < arr2D.GetLength(1); j++)
        {
            System.Console.Write(+arr2D[i, j]);
            if (j < arr2D.GetLength(1) - 1)
                System.Console.Write(", ");
        }
        System.Console.Write("] ");  
        System.Console.WriteLine();
    }
}

int userArrayRows = TakeEntNum("Введите кол-во строк массива: ");
int userArrayColumns = TakeEntNum("Введите кол-во столбцов массива: ");
int startRangeElement = TakeEntNum("Введите число от котрого начинается диапазон массива: ");
int endRangeElement = TakeEntNum("Введите число которым заканчивается диапазон массива: ");

int[,] userRandomArray2D = GetRandomArray2D(userArrayRows, userArrayColumns, startRangeElement, endRangeElement);
int[,] userModifiedArray2D = GetModifiedArray2D(userRandomArray2D);

PrintArray2D(userRandomArray2D);
PrintArray2D(userModifiedArray2D);















