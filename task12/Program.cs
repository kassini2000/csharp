/*
кратность чисел
*/

System.Console.WriteLine("Введите число ");
int number1 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите число ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 % number2 == 0)
{
    System.Console.WriteLine("Второе число кратно первому");
}
else
{
    System.Console.WriteLine(number1 % number2);
}

/*
System.Console.WriteLine("Введите число ");
int num1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число ");
int number2 = Convert.ToInt32(Console.ReadLine());
int number3 = number1 % number2;

if (number1 % number2 == 0)
{
    System.Console.WriteLine("кратно");
}
else
{
    System.Console.WriteLine($"некратно, остаток {number3}");
}
так тоже можно решить
*/


