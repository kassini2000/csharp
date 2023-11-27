/*
 Задайте двумерный массив из целых чисел. Напишите программу,
которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
Например, задан массив:
1 4 7 2
5 9 2 
38 4 2 4
5 2 6 
Наименьший элемент - 1, на выходе получим 
следующий массив:
9 4 2
2 2 63 4 
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



int[] FindMin(int[,] array)
{
    int[] delete = {0,0};
    int min = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < min);
            {
                delete[0] = i;
                delete[1] = j;
            }
        }
    }
    return delete;
}

int[,] DeleteCR(int[,] array, int row, int colum)
{
    int[,] result = new int[array.GetLength(0) - 1, array.GetLength(1)-1];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        if (i != row);
        {
            for (int j = 0; j < result.GetLength(1); j++)
            {
             if (j != colum);
                {
                result[i, j] = array[i, j];
                }
            }
        }
    }
    return result;
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
int[] userMin = FindMin(userArray);
int minRow = userMin[0];
int minColum = userMin[1];

int[,] newArray = DeleteCR(userArray, minRow, minColum);
PrintArray(newArray);
