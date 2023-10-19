
/*
найти большее из 2 чисел
a = 5; b = 7 -> первое число меньше чем второе
a = 2; b = 2 -> введенные числа равны
a = -3; b = -9 -> первое число больше второе
*/ 
Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 < number2)
{
     Console.WriteLine($"Первое число `{number1}` меньше чем второе `{number2}`");
}
 else if (number2 < number1)
    {
        Console.WriteLine($"Первое число `{number1}` больше чем второе `{number2}`");
    }
    else if (number2 == number1)
    {
        Console.WriteLine($"Введенные числа равны `{number1}`");
    }