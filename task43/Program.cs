/*
Напишите программу, которая найдёт точку 
пересечения двух прямых, заданных уравнениями 
y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

int Prompt(string message)
{
    System.Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

void Point(double a, double b, double c, double d)
{
   double x = (c-a) / (b-d);
   double y = b * x + a;
   if(b == d) System.Console.WriteLine("прямые не пересекаются");
   else System.Console.WriteLine($" -> {x} , {y}");
}


double B1 = Prompt("Введите число В1: ");
double K1 = Prompt("Введите число К1: ");
double B2 = Prompt("Введите число В2: ");
double K2 = Prompt("Введите число К2: ");
Point(B1, K1, B2, K2);

