/*
31. Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.
*/

Console.Clear();

// Ответ выводится через return
int[] GetArray(int n, int j, int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(n, j + 1);
    }
    return array;
}

void PrintArray(int[] arr)
{
    System.Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(arr[i]);
        if (i < arr.Length - 1)
            System.Console.Write(", ");
    }
    System.Console.Write("]"); 
}

int ArrayPositiveSum(int[] arr)
{
    int result = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            result = result + arr[i];
        }
    }
    return result;
}

int ArrayNegativeSum(int[] arr)
{
    int result = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < 0)
        {
            result = result + arr[i];
        }
    }
    return result;
}

int[] userArray = GetArray(-9, 9, 12);
PrintArray(userArray);

int positiveSum = ArrayPositiveSum(userArray);
int negativeSum = ArrayNegativeSum(userArray);

Console.Write($" Cумма положительных чисел равна: {positiveSum}, Cумма отрицательных чисел равна: {negativeSum}.");

// Ответ выводится через void
int[] GetArray(int n, int j, int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(n, j + 1);
    }
    return array;
}

void PrintArray(int[] arr)
{
    System.Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(arr[i]);
        if (i < arr.Length - 1)
            System.Console.Write(", ");
    }
    System.Console.Write("]");
}

void ArrayPositiveNegativeSum(int[] arr)
{   int positiveSum = 0;
    int negativeSum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            positiveSum = positiveSum + arr[i];
        }
        else
        {
            negativeSum = negativeSum + arr[i];
        }    
    }
    Console.Write($" Cумма положительных чисел равна: {positiveSum}, Cумма отрицательных чисел равна: {negativeSum}.");
}

int[] userArray = GetArray(-9, 9, 12);
PrintArray(userArray);
ArrayPositiveNegativeSum(userArray);
