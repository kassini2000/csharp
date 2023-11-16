/*
Напишите программу, которая выводит массив 
из 8 элементов, заполненный 
0 и 1 в случайном порядке.
*/
Console.Clear();

int[] GetRandomArray(int start, int end, int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(size + 1);
    }
    return array;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
      System.Console.Write(arr[i]);
      if (i < arr.Length - 1) 
      System.Console.WriteLine(", "); 
    }
    PrintArray(arr);

} 
System.Console.WriteLine("задай диапазон массива от: ");
int userStart = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("задай диапазон массива до: ");
int userEnd = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("задай размер массива до: ");
int userSize = Convert.ToInt32(Console.ReadLine());

int[] result = GetRandomArray(userStart, userEnd, userSize);
Console.WriteLine(result);

