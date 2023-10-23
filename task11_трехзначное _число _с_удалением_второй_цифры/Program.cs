/*
11. Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру, этого числа.
*/
int number = new Random().Next(100, 1000);
System.Console.WriteLine(number);
int celoe = number / 100;
int sotoye = number % 10;
// System.Console.WriteLine($"Ответ: {celoe}{sotoye}"); - изначальное мое решение
int dvukhznachnoye = celoe * 10 + sotoye; // - Более правильное решение, где ответ, является именно числом
System.Console.WriteLine("Ответ: " + dvukhznachnoye); 


