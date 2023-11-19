/*
Напишите программу, которая подсчитывает количество 
четных элементов в массиве целых положительных трехзначных
чисел и выводит результат на экран.
Программа должна иметь метод CountEvenElements, 
который принимает массив целых положительных 
трехзначных чисел и возвращает количество 
четных элементов в массиве.
Программа должна иметь метод PrintArray, 
который выводит элементы массива на экран.
При выводе элементы массива должны быть разделены 
символом табуляции "\t".
Если аргументы командной строки не переданы, 
программа использует массив по умолчанию, 
который содержит следующие значения: 
{100, 102, 105, 166, 283, 764, 300, 499, 133}.
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

int CountEvenElements(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] % 2 ==0)
        count++;
    }
    return count;
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
    System.Console.WriteLine($"{CountEvenElements(array)}");
}


int userSize = Prompt("Длину массива: ");
int userMin = Prompt("Введите минимальное число: ");
int userMax = Prompt("Введите максимальное число: ");

int[] userArray = GetRandomArray(userSize, userMin, userMax);
PrintArray(userArray);
