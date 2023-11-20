/*
Задача 61: Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника
*/

using System;
Console.Clear();

int userArrayRows = TakeEntNum("Введите количество строк треугольника: ");
int[,] user2DArray = new int[userArrayRows, userArrayRows];
const int cellWidth = 3; // Ширина объекта в точках

int TakeEntNum(string message)
{
    Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

void FillTriangle(int[,] arr2D, int row)
{
    for (int i = 0; i < row; i++)
    {
        arr2D[i, 0] = 1;
        arr2D[i, i] = 1;
    }

    for (int i = 2; i < row; i++)
    {
        for (int j = 1; j <= i; j++)
        {
            arr2D[i, j] = arr2D[i - 1, j - 1] + arr2D[i - 1, j];
        }
    }
}

void PrintTriangle(int[,] arr2D, int row)
{
    int col = cellWidth * row;
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j <= i; j++)
        {
            Console.SetCursorPosition(col, i + 1);
            if (arr2D[i, j] != 0)
                Console.Write($"{arr2D[i, j],cellWidth}");

            col += cellWidth * 2;
        }

        col = cellWidth * row - cellWidth * (i + 1);
        Console.WriteLine();
    }
}

FillTriangle(user2DArray, userArrayRows);
PrintTriangle(user2DArray, userArrayRows);