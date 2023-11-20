/*
Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить
массив, добавляя индексы каждого элемента.
*/

using System;
Console.Clear();

int TakeEntNum(string message)
{
    Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int[,,] GetRandom3DArray(int rows, int columns, int depths)
{
    int[,,] arr3D = new int[rows, columns, depths];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int k = 0; k < depths; k++)
            {
                arr3D[i, j, k] = new Random().Next(10, 100);
            }
        }
    }
    return arr3D;
}

void Print3DArray(int[,,] arr3D)
{
    for (int i = 0; i < arr3D.GetLength(0); i++)
    {
        for (int j = 0; j < arr3D.GetLength(1); j++)
        {
            for (int k = 0; k < arr3D.GetLength(2); k++)
            {
                System.Console.Write($"index [{i},{j},{k}] -> [{arr3D[i, j, k]}]; ");
            }
            System.Console.WriteLine();
        }
        System.Console.WriteLine();
    }
}

int userArrayRows = TakeEntNum("Введите кол-во строк массива: ");
int userArrayColumns = TakeEntNum("Введите кол-во столбцов массива: ");
int userArrayDepths = TakeEntNum("Введите глубину массива: ");

int[,,] userRandom3DArray = GetRandom3DArray(userArrayRows, userArrayColumns, userArrayDepths);

Print3DArray(userRandom3DArray);