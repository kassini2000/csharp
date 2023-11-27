/*
 Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
{ 1, 9, 9, 0, 2, 8, 0, 9 }
0 встречается 2 раза
1 встречается 1 раз
2 встречается 1 раз
8 встречается 1 раз
9 встречается 3 раза

1, 2, 3
4, 6, 1
2, 1, 6
1 встречается 3 раза
2 встречается 2 раза
3 встречается 1 раз
4 встречается 1 раз
6 встречается 2 раза
*/


int Prompt(string message)
{
    System.Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}


int[,] GetArray(int start, int end, int row, int colum)
{
    int[,] array = new int[row, colum];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < colum; j++)
        {
            array[i, j] = new Random().Next(start, end + 1);
        }
    }
    return array;
}

void PrintCount(int[,] array)
{
    for (int k = 0; k <= FindMax(array); k++)
    {
        int count = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if(k == array[i, j]) count++;
            }
        }
        System.Console.WriteLine($"Число {k} встречается {count} раза.");
    }
}

int FindMax(int[,] array)
{
    int max = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
       for (int j = 0; j < array.GetLength(1); j++)
       {
        if(array[i, j] > max) max = array[i, j];
       } 
    }
    return max;
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}


int userRow = Prompt("Введите количество строк: ");
int userColum = Prompt("Введите количество столбцов: ");
int userStart = Prompt("Введите начало диапозона: ");
int userEnd = Prompt("Введите конец диапозона: ");
int[,] userArray = GetArray(userStart, userEnd, userRow, userColum);
PrintArray(userArray);
PrintCount(userArray);


