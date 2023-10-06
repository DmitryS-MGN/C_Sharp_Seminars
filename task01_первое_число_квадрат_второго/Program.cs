/*
1. Напишите программу, которая на вход принимает два числа и проверяет является ли первое число квадратом второго.
*/
System.Console.WriteLine("Введите первое число: ");
int userNumber1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число: ");
int userNumber2 = Convert.ToInt32(Console.ReadLine());
if (userNumber1 == userNumber2 * userNumber2)
{
    Console.WriteLine($"Да, первое число {userNumber1}, является квадратом второго {userNumber2}");
}
else
{
    Console.WriteLine($"Нет, первое число {userNumber1}, не является квадратом второго {userNumber2}");
}
