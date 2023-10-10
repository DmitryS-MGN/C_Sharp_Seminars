/*
9. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
78 -> 8
12 -> 2
85 -> 8 
*/
int number = new Random().Next(10, 100);
System.Console.WriteLine(number);
int celoe = number / 10;
int desyatoye = number % 10;
    if( celoe > desyatoye) 
        {
            System.Console.WriteLine("Наибольшое число: " + celoe);
        }
    else 
        {
            System.Console.WriteLine("Наибольшое число: " + desyatoye);
        }