/*
напишите программу замены элементов массива:
положительные замените отрицательными, и наоборот.
[-4, -8, 8, 2]->[4, 8, -8, -2]
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

void PrintArray(int[] array)
{
    System.Console.Write("[");
    for(int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i]);
        if (i < array.Length - 1)
            System.Console.Write(", ");
    }
    System.Console.Write("] -> [");
    for (int i = 0; i < array.Length; i++)
    {
      array[i] =  -1 * array[i];
       System.Console.Write(array[i]);
        if (i < array.Length - 1)
            System.Console.Write(", ");
    }
    System.Console.WriteLine("]");
}

int userSize = Prompt("Введите длину массива: ");
int userMin = Prompt("Введите минимальное число: ");
int userMax = Prompt("Введите максимальное число: ");

int[] userArray = GetRandomArray(userSize, userMin, userMax);
PrintArray(userArray);

