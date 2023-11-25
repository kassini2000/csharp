﻿/*
Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8
*/

int Prompt(string message)
{
    System.Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int[] Febobachi(int number)
{
int size = number;
if (number < 2)
size = 2;

int[] array = new int[size];
array[0] = 0;
array[1] = 1;
for (int i = 2; i < size; i++)
{
array[i] = array[i - 1] + array[i - 2];
}
return array;
}

void PrintArray(int[] arr)
{
System.Console.Write("Число N = " + arr.Length + ": ");
Console.ForegroundColor = ConsoleColor.DarkBlue;
for (int i = 0; i < arr.Length; i++)
{
System.Console.Write(" " + arr[i]);
}
Console.ResetColor();
}

int number = Prompt("Введите десятичное число: ");
PrintArray(Febobachi(number));
