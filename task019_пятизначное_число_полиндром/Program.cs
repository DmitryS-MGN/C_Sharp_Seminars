/* Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
23432 -> да
12821 -> да
*/


System.Console.WriteLine("Введите пятизначное число ");
int number = Convert.ToInt32(Console.ReadLine());
int revnumber = 0;
if (number >= 10000 & number <= 99999)
{
    for (int i = number; i > 0; i /= 10)
    {
        revnumber = revnumber * 10 + i % 10;
    }
    if (number == revnumber)
    {
        System.Console.WriteLine($"{number} True");
    }
    else System.Console.WriteLine($"{number} False");
}
else System.Console.WriteLine("Число не пятизначное False");


/*Решение через for еще один вариант
System.Console.WriteLine("Введите пятизначное число ");
int number = Convert.ToInt32(Console.ReadLine());
if (10000 > number || number > 99999)
{
    System.Console.WriteLine("Число не пятизначное");
    return false;
}
int reverse = 0;
for (int i = number; i > 0; i /= 10)
{
    int remain = i % 10;
    reverse = reverse * 10 + remain;
}
if(number == reverse)
{
    return true;
}
else 
{
    return false;
}
*/

/*подробное решенеие, где мы берем элементы number c 1 по 5 без 3 по отдельности и сравниваем их
System.Console.WriteLine("Введите пятизначное число ");
int number = Convert.ToInt32(Console.ReadLine());
int number1 = number / 10000; 
int number2 = number / 1000 % 10;
int number4 = number / 10 % 10;
int number5 = number % 10;

if (number >= 10000 & number <= 99999)
{
    if(number1 == number5 & number2 == number4)
    {
        System.Console.WriteLine($"{number} True");
    }
    else
    {
        System.Console.WriteLine($"{number} False");
    }
}
else
{
   System.Console.WriteLine("Число не пятизначное False");
    
}
*/