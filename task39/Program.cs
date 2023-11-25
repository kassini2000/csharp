﻿/*
Напишите программу, которая перевернёт одномерный 
массив (последний элемент будет на первом месте, 
а первый - на последнем и т.д.)
[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6]
Комментарий: эту задачу можно решить 2 способами:
1) менять числа местами в исходном массиве;
2) создать новый массив и в него записать 
перевёрнутый исходный массив по элементам.
*/

int Prompt(string message)
{
    System.Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int[] GetRandomArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(0, 10);
    }
    return array;
}

void PrintArray(int[] array)
{
    System.Console.Write("[");
    for(int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i]);
        if (i < array.Length - 1)
            System.Console.Write(", ");
    }
    System.Console.WriteLine("]");
    System.Console.WriteLine();
}

void Reverse(int[] array)
{
    int temp = 0;
    for (int i = 0; i < array.Length / 2; i++)
    {
       temp = array[array.Length -1 -i];
       array[array.Length -1 -i] = array[i];
       array[i] = temp;
    }
}


int userSize = Prompt("Задай размер массива: ");

int[] userArray = GetRandomArray(userSize);
PrintArray(userArray);
System.Console.WriteLine();
Reverse(userArray);
PrintArray(userArray);

