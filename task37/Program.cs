/*
37. Найдите произведение пар чисел в одномерном 
массиве. Парой считаем первый и последний элемент, 
второй и предпоследний и т.д. Результат запишите в 
новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
*/


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
      if(i < array.Length - 1);
      System.Console.Write(", ");
    }
    System.Console.Write("]");
}

int[] ProductArray(int[] arr)
{
    int[] result = new int[arr.Length/2];
    int summ = 0;
    for (int i = 0; i < arr.Length/2; i++)
    {
        summ = arr[i] * arr[arr.Length -1 - i];
        result[i] = summ;
    }
    return result;
}


int[] userArray = GetRandomArray(8);
PrintArray(userArray);
System.Console.WriteLine();
int[] newArray = ProductArray(userArray);
PrintArray(newArray);

