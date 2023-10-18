
/*
1. Напишите программу, которач на вход принимает 2 числа и проверяет является
ли первое число квадратом второго.
a = 25; b = 5 -> да
a = 2; b = 10 -> нет
a = 9; b = -3 -> да
a = 3; b = 9 -> нет
*/
Console.WriteLine("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine()); 
if (firstNumber * firstNumber == secondNumber)
{
    System.Console.WriteLine("да, является квадратом второго числа");
}
else {
    System.Console.WriteLine("нет, не является квадратом второго числа");
}