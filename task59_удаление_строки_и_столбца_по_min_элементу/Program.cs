/*
59. Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Наименьший элемент - 1, на выходе получим
следующий массив:
9 2 3
4 2 4
2 6 7
*/

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

(int, int) FindMinIndex(int[,] arr2D)
{
    int minRow = 0;
    int minColumn = 0;
    int min = arr2D[0, 0];
    for (int i = 0; i < arr2D.GetLength(0); i++)
    {
        for (int j = 0; j < arr2D.GetLength(1); j++)
        {
            if (arr2D[i, j] < min)
            {
                min = arr2D[i, j];
                minRow = i;
                minColumn = j;
            }
        }
    }
    return (minRow, minColumn);
}

int[,] DeleteMinColumnRow(int[,] arr2D, int row, int column)
{
    int[,] result = new int[arr2D.GetLength(0) - 1, arr2D.GetLength(1) - 1];
    int x = 0;

    for (int i = 0; i < arr2D.GetLength(0); i++)
    {
        if (i == row)
        {
            row = -1;
            continue;
        }
        int y = 0;
        for (int j = 0; j < arr2D.GetLength(1); j++)
        {
            if (j == column) continue;
            result[x, y] = arr2D[i, j];
            y++;
        }
        x++;
    }
    return result;
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

int[,] userRandomArray2D = GetRandomArray2D(userArrayRows, userArrayColumns, startRangeElement, endRangeElement);
int[,] userCopyArray2D = CopyArray2D(userRandomArray2D);
(int minRow, int minColumn) = FindMinIndex(userCopyArray2D);
int[,] userModifiedArray2D = DeleteMinColumnRow(userCopyArray2D, minRow, minColumn);


PrintArray(userRandomArray2D);
PrintArray(userModifiedArray2D);


