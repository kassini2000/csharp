/*
Задайте массив из 12 элементов, 
заполненный случайными числами в промежутке [-9, 9].
Найдите сумму положительных и отрецательных 
элементов массива.
*/

using System;
Console.Clear();

int[] GetRandomArray(int start, int end, int size)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(start,end);
    }
    return array;
} 
void PrintArray(int[] array)
{
    System.Console.Write("[");
    for(int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i]);
        if(i < array.Length - 1);
        System.Console.Write(", ");
    }
    System.Console.Write("]");
}
int TakeEntNum(string message)
{
    System.Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}
int SummPositiveNum(int[] array)
{
    int result = 0;
    for(int i =0; i < array.Length; i++)
    {
        if(int[] array > 0) result += array[i];
    }
    return result;
}
int SummNegativeNum(int[] array)
{
    int result = 0;
    for(int i =0; i < array.Length; i++)
    {
        if(int[] array < 0) result += array[i];
    }
    return result; 
}

int userStart = TakeEntNum("Пожалуйста введите число начало массива: ");
int userEnd = TakeEntNum("Пожалуйста введите  число  конец массива: ");
int userSize = TakeEntNum("Пожалуйста введите размер массива: ");

int[] userArray = GetRandomArray(userStart, userEnd, userSize);
PrintArray(userArray);

int posSumm = SummPositiveNum(userArray);
int negSumm = SummNegativeNum(userArray);

System.Console.WriteLine($" {posSumm}, {negSumm} ");

