﻿/*
Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10
*/

int Prompt(string message)
{
    System.Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

string Converte(int number)
{
    string result = "";
    int temp = 0;
    for (int i = number; i > 0; i /=2)
    {
        temp = i % 2;
        result = temp + result;
    }
    return result;
}
int userNum = Prompt("Введите число: ");
System.Console.WriteLine(Converte(userNum));

