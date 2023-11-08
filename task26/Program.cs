/*
Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

/*
System.Console.WriteLine("Введите число: ");
double userNumber = Convert.ToInt32(Console.ReadLine());
double exponent = 3;
double result = Math.Pow(userNumber, exponent);

System.Console.WriteLine(result);
*/
System.Console.WriteLine("Введите число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

double Num (double number)
{
    int exponent = 3;

 for(int i = 0; i < exponent; i++)
 {
    number = Math.Pow(userNumber, exponent);;
 }
 return number;
}
 double result = Num(userNumber);
 System.Console.WriteLine(result);
