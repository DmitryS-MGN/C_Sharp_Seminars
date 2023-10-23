/* Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние
между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

System.Console.WriteLine("Введите координаты точки A");
System.Console.WriteLine("Координата x1:");
int x1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Координата y1:");
int y1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Координата z1:");
int z1 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите координаты точки B");
System.Console.WriteLine("Координата x2:");
int x2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Координата y2:");
int y2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Координата z2:");
int z2 = Convert.ToInt32(Console.ReadLine());

double result = Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2)),2);
System.Console.WriteLine($"A ({x1},{y1},{z1}); B ({x2},{y2},{z2}), -> " + result);

/*Решение через массивы 
double squareX = Math.Pow(pointB[0] - pointA[0], 2);
double squareY = Math.Pow(pointB[1] - pointA[1], 2);
double squareZ = Math.Pow(pointB[2] - pointA[2], 2);
double result = Math.Sqrt(squareX + squareY + squareZ);
return result;
*/