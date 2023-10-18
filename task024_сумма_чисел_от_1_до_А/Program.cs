/*24. Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
7 -> 28
4 -> 10
8 -> 36
*/

System.Console.Write("Введите число: ");
int userA = Convert.ToInt32(Console.ReadLine());

int Summ(int n)
{
    int result = 0;

    for (int i = 1; i <= n; i++)
    {
        result = result + i;
    }
    return result;
}

int userresult = Summ(userA);
System.Console.WriteLine(userresult);



