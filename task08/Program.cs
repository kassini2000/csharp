/*
напишите метод, который на вход принимает число number, 
и выводит является ли число четным.
number = 4 -> число четное
number = 7 -> число нечетное
*/
System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if(number % 2 ==0)
{
    System.Console.WriteLine($"Число `{number}` четное");
}
else
{
    System.Console.WriteLine($"Число `{number}` нечетное");
}