/*
5. Напишите программу, где на вход принимается число n, на выходе показывает все целые числа в промежутке от –n до n.
*/
System.Console.WriteLine("Введите число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
for (int startNumber = userNumber * -1; startNumber <= userNumber; startNumber++)
{
    Console.Write($" {startNumber};");
}