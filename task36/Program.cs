/*
Напишите программу, которая находит сумму элементов 
с нечетными индексами в одномерном массиве целых чисел 
и выводит результат на экран.
Программа должна иметь метод SumOddElements, который 
принимает массив целых чисел и возвращает сумму 
элементов с нечетными индексами в массиве.
Программа должна иметь метод PrintArray, который 
выводит элементы массива на экран.
При выводе элементы массива должны быть 
разделены символом табуляции "\t".
*/

int Prompt(string message)
{
    System.Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int[] GetRandomArray(int size, int min, int max)
{
    int[] array = new int[size];
    Random rand = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rand.Next(min, max + 1);
    }
    return array;
}

int SumOddElements(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(i % 2 !=0)
        sum = sum + arr[i];
    }
    return sum;
}

void PrintArray(int[] array)
{
    System.Console.Write("[");
    for(int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i]);
        if (i < array.Length - 1)
            System.Console.Write("\t");
    }
    System.Console.WriteLine();
    System.Console.WriteLine($"{SumOddElements(array)}");
}


int userSize = Prompt("Длину массива: ");
int userMin = Prompt("Введите минимальное число: ");
int userMax = Prompt("Введите максимальное число: ");

int[] userArray = GetRandomArray(userSize, userMin, userMax);
PrintArray(userArray);

