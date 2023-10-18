/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/


int Summ(int n)
{
    int result = 0;
    for (int i = n; i > 0; i /= 10)
    {
        result = result + i % 10;
    }
    return result;
}

System.Console.WriteLine("Введите число ");
int userNumber = Convert.ToInt32(Console.ReadLine());

int userResult = Summ(userNumber);
System.Console.WriteLine(userResult);


