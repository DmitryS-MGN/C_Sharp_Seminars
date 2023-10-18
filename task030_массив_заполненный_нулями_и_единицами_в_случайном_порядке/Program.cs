/*30. Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
*/

int[] GetRandomArray(int size) // int[] - тип массива
{
    int[] array = new int[size]; // Здесь, содаем новый пустой массив, в size указываем размер массива
    for (int i = 0; i < size; i++)
    {
    array[i] = new Random().Next(0, 2); // Здесь заполняем, каждый эллемент массива рандомным числом от 0 до 1
    }
    return array;
} 

void PrintArray(int[] arr) // Здесь мы на вход отдаем какой нибудь массив (просто для принятия переменной)
{
    for (int i = 0; i < arr.Length; i++)  // arr.Length - автоматически определяет длину нашего массива
    {
        System.Console.Write($"{arr[i]}, ");
    }

}

System.Console.Write("Задай размер массива: ");
int userSize = Convert.ToInt32(Console.ReadLine());

int[] userArray = GetRandomArray(userSize);
PrintArray(userArray);
    
