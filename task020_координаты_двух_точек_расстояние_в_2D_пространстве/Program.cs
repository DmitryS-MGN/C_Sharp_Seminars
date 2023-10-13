/*Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
*/

System.Console.WriteLine("Введите координаты точки A");
System.Console.WriteLine("Координата x1:");
int x1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Координата y1:");
int y1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координаты точки B");
System.Console.WriteLine("Координата x2:");
int x2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Координата y2:");
int y2 = Convert.ToInt32(Console.ReadLine());

double DistanceAB = Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)), 2);
System.Console.WriteLine(DistanceAB);