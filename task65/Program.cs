/*
Задайте значение M и N. Напишите программу, 
которая выдает все натуральные числа от M до N.
*/

Console.Clear();

System.Console.WriteLine("Введите число: ");
int namber1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Ведите число: ");
int namber2 = Convert.ToInt32(Console.ReadLine());

void intN(int first, int last)
{
    if(last >= first)
    {
        System.Console.Write(first + " ");
        intN(first + 1, last);
    }
    else
       return;
}

intN(namber1, namber2);

