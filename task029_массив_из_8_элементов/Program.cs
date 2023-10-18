/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. (Усложненный вариант, где пользователь сам задает диапазон массива и его размер)
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

int[] UserArrayNumber(int n, int j, int size)
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
    Console.ForegroundColor = ConsoleColor.Cyan; //добавляет цвет выводимому ответу 
    System.Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Thread.Sleep(100); // добавляет паузу между выводимыми элементами массива в ответе
        System.Console.Write(arr[i]);
        if( i < arr.Length - 1)
        System.Console.Write(", ");
    }
    System.Console.Write("]");
    Console.ResetColor(); //возвращает изначальный цвет дальнешему тексту в терминале
}

System.Console.Write("Введите размер массива: ");
int userArraySize = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите число от котрого начинается диапазон массива: ");
int startRangeElement = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите число которым заканчивается диапазон массива: ");
int endRangeElement = Convert.ToInt32(Console.ReadLine());


int[] userArray = UserArrayNumber(startRangeElement, endRangeElement, userArraySize);
PrintArray(userArray);


/*
int[] GetRandomArray(int size) 
{
    int[] array = new int[size]; 
    for (int i = 0; i < size; i++)
    {
    array[i] = new Random().Next(0, 100); 
    }
    return array;
} 

void PrintArray(int[] arr) 
{
    for (int i = 0; i < arr.Length; i++)  
    {
        System.Console.Write($"{arr[i]} ");
    }

}

int[] userArray = GetRandomArray(8);
PrintArray(userArray);
  */
