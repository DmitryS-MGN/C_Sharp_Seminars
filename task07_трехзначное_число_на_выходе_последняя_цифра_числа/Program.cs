/*
7. Напишите программу, которая принимает на вход трехзначное число и на выходе показывает последнюю цифру этого числа.
*/
System.Console.WriteLine("Введите число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
int result = userNumber % 10;
System.Console.WriteLine(result);