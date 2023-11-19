/* 
Задайте массив. Напишите программу, которая 
определяет, присутствует ли заданное число в массиве.
4;[6. 7. 19. 345. 3] -> now
3;[6. 7. 19. 345. 3] -> yes
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
    System.Console.Write("]");
    System.Console.WriteLine();
}
bool findNum(int[] array, int num)
{
    for (int i = 0; i < array.Length; i++)
    {
        if(num == array[i])
        return true;
    }
    return false;
}

int userSize = Prompt("Введите длину массива: ");
int userMin = Prompt("Введите минимальное число: ");
int userMax = Prompt("Введите максимальное число: ");


int[] userArray = GetRandomArray(userSize, userMin, userMax);
PrintArray(userArray);

System.Console.WriteLine("Какое число ищем? ");
int userNum = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(findNum(userArray, userNum));




