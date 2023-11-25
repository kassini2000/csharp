/*
Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: 
Aₘₙ = m+n. Выведите полученный массив на экран.
*/
pablic static void Main(string[] args)
{
    int m = 3;
    int n = 3;
    int[,] arr = new int[3, 3];
    for (int i = 0; i < arr.Length; i++)
    {
       arr[i] = new int[3];
       for (int j = 0; j < arr[i].Length; j++)
       {
        arr[i, j] = i +j;
       }
    }
    PrintArr(arr);
}

void PrintArr(int[,]arr)
{
    foreach (var row in arr)
    {
        System.Console.WriteLine($"[{strin.Join(" ", row)}]");
    }
}