/*
57. Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
{ 1, 9, 9, 0, 2, 8, 0, 9 }
0 встречается 2 раза
1 встречается 1 раз
2 встречается 1 раз
8 встречается 1 раз
9 встречается 3 раза

1, 2, 3
4, 6, 1
2, 1, 6
1 встречается 3 раза
2 встречается 2 раза
3 встречается 1 раз
4 встречается 1 раз
6 встречается 2 раза
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

int FindMax(int[,] arr2D)
{
    int max = 0;
    for (int i = 0; i < arr2D.GetLength(0); i++)
    {
        for (int j = 0; j < arr2D.GetLength(1); j++)
        {
            if (arr2D[i, j] > max)
                max = arr2D[i, j];
        }
    }
    return max;
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

void FrequencyDictionary(int[,] arr2D)
{
    System.Console.WriteLine();
    for (int k = 0; k <= FindMax(arr2D); k++)
    {
        int count = 0;
        for (int i = 0; i < arr2D.GetLength(0); i++)
        {
            for (int j = 0; j < arr2D.GetLength(0); j++)
            {
                if (k == arr2D[i, j])
                    count++;
            }
        }
        if (count == 0) continue;
        else System.Console.WriteLine($"Число {k} встречается {count} раза");
    }
}

int userArrayRows = TakeEntNum("Введите кол-во строк массива: ");
int userArrayColumns = TakeEntNum("Введите кол-во столбцов массива: ");
int startRangeElement = TakeEntNum("Введите число от котрого начинается диапазон массива: ");
int endRangeElement = TakeEntNum("Введите число которым заканчивается диапазон массива: ");

int[,] userRandomArray2D = GetRandomArray2D(userArrayRows, userArrayColumns, startRangeElement, endRangeElement);

PrintArray(userRandomArray2D);
FrequencyDictionary(userRandomArray2D);