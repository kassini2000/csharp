/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа
или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

System.Console.WriteLine("введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

//int result = -1;

if (number >=100)
{
    number = number / 10;
    number = number % 10;
    System.Console.WriteLine(number);
}
else if (number > 999)
{
    number = -1;
    System.Console.WriteLine(number);
}else if (number < 100)
{
    System.Console.WriteLine("третьей цифры нет");
}


