/*
39. Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6]
Комментарий: эту задачу можно решить 2 способами:
1) менять числа местами в исходном массиве;
2) создать новый массив и в него записать перевёрнутый исходный массив по элементам.
*/

using System;
Console.Clear();

int TakeEntNum(string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int[] GetRandomArray(int size, int n, int j)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(n, j + 1);
    }
    return array;
}

// 1) Замена чисел местами в исходном массиве
/*
void Reverse(int[] arr)
{
    int temp = 0;

    for (int i = 0; i < arr.Length / 2; i++)
    {
        temp = arr[arr.Length - 1 - i];
        arr[arr.Length - 1 - i] = arr[i];
        arr[i] = temp;
    }
    System.Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(arr[i]);
        if (i < arr.Length - 1)
            System.Console.Write(", ");
    }
    System.Console.Write("] ");

}
*/

// 2) создать новый массив и в него записать перевёрнутый исходный массив по элементам.
int[] GetReversedArray(int[] arr)
{
    int[] result = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        result[result.Length - 1 - i] = arr[i];
    }
    return result;
}

void PrintArray(int[] arr, int[] arr2)
{
    System.Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(arr[i]);
        if (i < arr.Length - 1)
            System.Console.Write(", ");
    }
    System.Console.Write("] -> ");

    System.Console.Write("[");
    for (int i = 0; i < arr2.Length; i++)
    {
        System.Console.Write(arr2[i]);
        if (i < arr2.Length - 1)
            System.Console.Write(", ");
    }
    System.Console.Write("] ");
}

int userArraySize = TakeEntNum("Введите размер массива: ");
int startRangeElement = TakeEntNum("Введите число от котрого начинается диапазон массива: ");
int endRangeElement = TakeEntNum("Введите число которым заканчивается диапазон массива: ");

int[] userArray = GetRandomArray(userArraySize, startRangeElement, endRangeElement);
int[] userReversedArray = GetReversedArray(userArray);
PrintArray(userArray, userReversedArray);
//Reverse(userArray); -> для вывода ответа первого метода