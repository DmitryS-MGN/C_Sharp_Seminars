/*
4. Напишите метод FindMax, который принимает на вход три числа и выдаёт максимальное из этих чисел.
*/
System.Console.WriteLine("Введите три числа: ");
System.Console.WriteLine("Число a ");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Число b ");
int b = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Число c ");
int c = Convert.ToInt32(Console.ReadLine());
static int FindMax(int a, int b, int c)
{
    int max = a;
    if (max < b)
    {
        max = b;
    }
    if (max < c)
    {
        max = c;
    }
    return max;
}
int result = FindMax(a, b, c);
System.Console.WriteLine($"Максимальное число: {result}");