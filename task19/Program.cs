/*
Внутри класса Answer напишите метод IsPalindrome, 
который принимает на вход пятизначное число number и проверяет, 
является ли оно палиндромом.

Метод должен проверить является ли число пятизначным, в противном случае - вывести Число не пятизначное и False в следующей строке.

Для остальных чисел вернуть True или False.
14212 -> False
12821 -> True
234322 -> Число не пятизначное
*/

System.Console.WriteLine("Введите число: ");

int number = Convert.ToInt32(Console.ReadLine());
int number1 = number / 100000;
int number2 = number / 10000 % 10;
int number4 = number / 10 % 10;
int number5 = number % 10;

if  (number >= 100000 & number <= 10000)
{
    if (number1 == number5 & number2 == number4)
    {
        Console.WriteLine("true, это палиндром");
    }else 
    {
        Console.WriteLine("false");
    }
}
else 
{
    System.Console.WriteLine("число не пятизначное");
}
