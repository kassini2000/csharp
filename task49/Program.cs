/*
 Задайте двумерный массив. Найдите элементы, 
 у которых оба индекса чётные, и замените 
 эти элементы на их квадраты.
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

int[,] ModyFy(int[,]array)
{
    int[,] result = array;
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = 0; j < array.Length; j++)
        {
            if(i % 2 == 0 && j % 2 ==0)
            result [i, j] = array[i,j] * array[i,j];
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
int[,] newArray = ModyFy(userArray);
System.Console.WriteLine();
PrintArray(newArray);

