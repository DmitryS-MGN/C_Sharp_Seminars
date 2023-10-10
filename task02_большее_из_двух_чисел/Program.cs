/*
2. Напишите программу, которая на вход принимает два числа и проверяет является ли первое число квадратом второго.
*/

System.Console.WriteLine("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
 if (firstNumber == secondNumber)
        {
            Console.WriteLine($"Введенные числа равны `{firstNumber}`");
        }
        if (firstNumber > secondNumber)
        {
            Console.WriteLine($"Первое число `{firstNumber}` больше чем второе число `{secondNumber}`");
        }
        if (firstNumber < secondNumber)
        {
            Console.WriteLine($"Первое число `{firstNumber}` меньше чем второе число `{secondNumber}`");
        }