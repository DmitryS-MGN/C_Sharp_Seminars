/*Задача 18: Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой
четверти (x и y).
*/

string numberRange(int i)
{
    if (i == 1)
    {
        return "(x > 0 && y > 0)";
    }
    else if (i == 2)
    {
        return "(x < 0 && y > 0)";
    }
    else if (i == 3)
    {
        return "(x < 0 && y < 0)";
    }
    else if (i == 4)
    {
        return "(x > 0 && y < 0)";
    }
    else
    {
        return "Не номер четверти";
    }

}

System.Console.WriteLine("Введите номер четверти: ");
int quaterNumber = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(numberRange(quaterNumber));