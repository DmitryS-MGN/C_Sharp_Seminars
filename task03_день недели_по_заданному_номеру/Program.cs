/*
3. Напишите программу, которая будет выдавать день недели, по заданному номеру.
*/
System.Console.WriteLine("Введите число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
if (userNumber == 1)
{
    Console.WriteLine("Понедельник");
}
if (userNumber == 2)
{
    Console.WriteLine("Вторник");
}
if (userNumber == 3)
{
    Console.WriteLine("Среда");
}
if (userNumber == 4)
{
    Console.WriteLine("Четверг");
}
if (userNumber == 5)
{
    Console.WriteLine("Пятница");
}
if (userNumber == 6)
{
    Console.WriteLine("Суббота");
}
if (userNumber == 7)
{
    Console.WriteLine("Воскресенье");
}
else
{
    Console.WriteLine("Нет такого дня недели");
}