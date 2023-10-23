/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/


Console.WriteLine("Введите число: ");
int userNumber1 = Convert.ToInt32(Console.ReadLine());
if (userNumber1 == 1)
{
    System.Console.WriteLine("Понедельник-это не выходной день");
}
else if (userNumber1 == 2)
{
    System.Console.WriteLine("Вторник-это не выходной день");
}
else if (userNumber1 == 3)
{
    System.Console.WriteLine("Среда-это не выходной день");
}
else if (userNumber1 == 4)
{
    System.Console.WriteLine("Четверг-это не выходной день");
}
else if (userNumber1 == 5)
{
   System.Console.WriteLine("Пятница-это не выходной день"); 
}
else if (userNumber1 == 6)
{
    System.Console.WriteLine("Суббота-это выходной день");
}
else if (userNumber1 == 7)
{
    System.Console.WriteLine("Воскресенье-это выходной день");
}
