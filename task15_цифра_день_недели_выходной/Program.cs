/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/
System.Console.WriteLine("Введите число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
    if(userNumber == 6 || userNumber == 7)
    {
        System.Console.WriteLine("Да, выходной");
    }
    else if(userNumber <=5 && userNumber !=0)
    {
        System.Console.WriteLine("Нет, не выходной");
    }
    else System.Console.WriteLine("Это, не день недели");