
/* 
Напишите программу, которая принимает на вход число (А)
и выдает сумму чисел от 1 до А.
7 -> 28
4 -> 10
8 -> 36
*/

System.Console.Write("Введите число: ");
int A = Convert.ToInt32(Console.ReadLine());

int summ = 0;

for (int i = 1; i <= A; i++)
{
    summ = summ + i;
}
System.Console.WriteLine(summ);
