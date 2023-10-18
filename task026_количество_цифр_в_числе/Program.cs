/*26. Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5
*/

System.Console.WriteLine("Введите число ");
int userNumber = Convert.ToInt32(Console.ReadLine());

int Quant(int n)
{
    int count = 0;
    for (int i = userNumber; i > 0; i /= 10)
    {
        count = count + 1;
    }
    return count;
}

int userResult = Quant(userNumber);
System.Console.WriteLine(userResult);