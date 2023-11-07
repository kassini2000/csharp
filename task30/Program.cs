/*
Напишите программу, которая выводит массив из 8 
элементов, заполненный 0 и 1 в случайном порядке.
*/
int[] GetRandomArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        size[i] = new Random().Next(0,2);
    }
    return array;
}

void PrintArray(int[] arr)
{
    for (i = 0; i < arr.Length; i++)
    {
      System.Console.Write($"{arr[i]}, ");  
    }

}
int[] userArray = GetRandomArray(9);
PrintArray(userArray);
