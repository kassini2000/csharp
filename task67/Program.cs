/*
Напишите программу, которая будет принимть на вход
число и возвращать сумму его цифр.
*/

Console.Clear();

System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());


int intN(int num)
{
    if(num % 10 > 0)
     return num % 10 + intN(num / 10);
    else
        return 0;
}

int result = intN(number);
System.Console.WriteLine(result);
