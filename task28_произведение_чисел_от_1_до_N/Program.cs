/*28. Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
4 -> 24
5 -> 120
*/

System.Console.Write("Введите число: ");
int userN = Convert.ToInt32(Console.ReadLine());

int Product(int n)
{
    int result = 1;

    for (int i = 1; i <= n; i++)
    {
        result = result * i;
    }
    return result;
}

int userResult = Product(userN);
System.Console.WriteLine(userResult);
