/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/


// Решение через Math.Pow
double Invol(int n, int j)
{
    double result = Math.Pow(n, j);
    return result;
}

System.Console.Write("Введите число A: ");
int userA = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите число B: ");
int userB = Convert.ToInt32(Console.ReadLine());

double userResult = Invol(userA, userB);
System.Console.WriteLine(userResult);

// решение через цикл
int Invol(int n, int j)
{
     int result = 1;
    for (int i = 1; i <= j; i++)
    {
        result = result * n;
    }
    return result;
}

System.Console.Write("Введите число A: ");
int userA = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите число B: ");
int userB = Convert.ToInt32(Console.ReadLine());

int userResult = Invol(userA, userB);
System.Console.WriteLine(userResult);
