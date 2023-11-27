/*
Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
В случае, если это невозможно, программа должна вывести сообщение для пользователя.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
В итоге получается вот такой массив:
1 5 8 5
4 9 4 2
7 2 2 6
2 3 4 7
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

int[,] CopyArray(int[,]array)
{
    int[,] result = new int [array.GetLength(0), array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            result [i, j] = array[i,j];
        }
    }
    return result;
}
int[,] ChangeRows (int[,] array)
{
    int temp = 0;
    int[,] result = new int[array.GetLength(0), array.GetLength(1)];
    result = CopyArray(array);
    for (int j = 0; j < array.GetLength(1); j++)
    {
        temp = result[0, j];
        result[0, j] = result[array.GetLength(0)-1, j];
        result[array.GetLength(0)-1, j] = temp;
    }
    return result;
}
int[,] Replace(int[,]array)
{
    int[,] result = CopyArray(array);
    int temp = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
       for (int j = 0; j < i; j++)
       {
        if(i != j)
        {
            temp = result[i ,j];
            result[i, j] = result[j, i];
            result[j, i] = temp;
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

int userRow = Prompt("Введите количество строк и столбцов: ");
int userColum = userRow;
int userStart = Prompt("Введите начало диапозона: ");
int userEnd = Prompt("Введите конец диапозона: ");
int[,] userArray = GetArray(userStart, userEnd, userRow, userColum);
PrintArray(userArray);

int[,] newArray = Replace(userArray);
System.Console.WriteLine();
PrintArray(newArray);
