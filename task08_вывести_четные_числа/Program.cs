/*
8. Напишите метод PrintEvenNumbers, которая на вход принимает число (number), а на выходе выводит все чётные числа от 1 до number (включительно), разделеные знаком табуляции.
*/

System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
static void PrintEvenNumbers(int number)
    {
        for (int count = 2; count <= number; count += 2)
        {
            Console.Write($"{count}\t");
        }
    }
PrintEvenNumbers(number);