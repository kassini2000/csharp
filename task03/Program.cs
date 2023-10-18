/*
3. Напишите программу, которая будет выдавать название 
дня недели по заданному номеру. 
*/ 

Console.WriteLine("Введите число: ");
int userNumber1 = Convert.ToInt32(Console.ReadLine());
if (userNumber1 == 1)
{
    System.Console.WriteLine("Monday");
}
else if (userNumber1 == 2)
{
    System.Console.WriteLine("Tuesday");
}
else if (userNumber1 == 3)
{
    System.Console.WriteLine("Wednesday");
}
else if (userNumber1 == 4)
{
    System.Console.WriteLine("Thursday");
}
else if (userNumber1 == 5)
{
   System.Console.WriteLine("Friday"); 
}
else if (userNumber1 == 6)
{
    System.Console.WriteLine("Saturday");
}
else if (userNumber1 == 7)
{
    System.Console.WriteLine("Sunday");
}
