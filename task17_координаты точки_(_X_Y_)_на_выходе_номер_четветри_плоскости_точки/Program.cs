/*17. Напишите программу, которая принимает на вход координаты точки (x и y), причём x ≠ 0 и y ≠ 0 и выдаёт 
номер четверти плоскости, в которой находится эта точка.
*/


string f(int x, int y)
{
    if (x > 0 && y > 0)
        return "1 четверть";
    else if (x < 0 && y > 0)
        return "2 четверть";
    else if (x < 0 && y < 0)
        return "3 четверть";
    return "4 четверть";
    
}


System.Console.WriteLine("Введите первое число: ");
int x = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число: ");
int y = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(f(x, y));
