/*
Задайте двумерный массив размером m×n, 
заполненный случайными целыми числами.
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
        array[i, j] = new Random().Next(start, end +1);
    }
}
return array;
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
int[,] userarray = GetArray(userStart, userEnd, userRow, userColum);
 PrintArray(userarray);


