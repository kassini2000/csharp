/*
Напишите программу для работы с массивом вещественных
чисел.Реализуйте класс ArrayOperations, который 
содержит следующие статические методы:
FindMax(double[] array): Метод принимает на вход массив
вещественных чисел array и возвращает максимальное число 
из массива.
FindMin(double[] array): Метод принимает на вход
массив вещественных чисел array и возвращает 
минимальное число из массива.
CalcDifferenceBetweenMaxMin(double[] array): Метод 
принимает на вход массив вещественных чисел array и 
возвращает разницу между максимальным и 
минимальным числами в массиве.
PrintArray(double[] array): Метод для вывода 
массива на экран. Он принимает на вход массив 
array и выводит его элементы с двумя знаками 
после запятой через табуляцию.
*/

int Prompt(string message)
{
    System.Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

double[] GetRandomArray(int size, int min, int max)
{
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = Math.Round(new Random().NextDouble() * (max + 0.01 - min) + min, 2);
    }
    return array;
}

double FindMax(double[] array)
{
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if(max < array[i])
        max = array[i];
    }
    return max;
}
double FindMin(double[] array)
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if(min < array[i])
        min = array[i];
    }
    return min;
}
double CalcDifferenceBetweenMaxMin(double[] array)
{
    double result = FindMax(array) - FindMin(array);
    return result;
}

void PrintArray(double[] arr)
{
    System.Console.Write("[");
    for(int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(arr[i]);
        if (i < arr.Length - 1)
            System.Console.Write("\t");
    }
    System.Console.WriteLine();
    System.Console.WriteLine($"{FindMin(arr)}");
    System.Console.WriteLine($"{FindMax(arr)}");
    System.Console.WriteLine($"{CalcDifferenceBetweenMaxMin(arr)}");
}


int userSize = Prompt("Длину массива: ");
int userMin = Prompt("Введите минимальное число: ");
int userMax = Prompt("Введите максимальное число: ");

double[] userArray = GetRandomArray(userSize, userMin, userMax);
PrintArray(userArray);



