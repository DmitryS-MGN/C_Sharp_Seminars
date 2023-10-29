/*
48. Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
m = 3, n = 4.
0 1 2 3 
1 2 3 4
2 3 4 5
*/

using System;
Console.Clear();

int TakeEntNum(string message)
{
    Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int[,] GetArray2D(int rows, int columns)
{
    int[,] arr2D = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            arr2D[i, j] = i + j;
        }
    }
    return arr2D;
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

PrintArray2D(GetArray2D(userArrayRows, userArrayColumns));