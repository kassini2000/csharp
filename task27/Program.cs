/*
Напишите программу, которая принимает на 
вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

System.Console.WriteLine("Bведите число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

int Summ(int a)
{
    int summ = 0;
    for (int i = a; i > 0; i = i / 10)
    {
        summ = summ + i % 10;
    }
    return summ;
}
int result = Summ(userNumber);
System.Console.WriteLine(result);