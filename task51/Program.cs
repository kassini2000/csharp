/*
Задайте двумерный массив. Найдите сумму элементов, 
находящихся на главной диагонали 
(с индексами (0,0); (1;1) и т.д.
*/

int Prompt(string message)
{
    System.Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int[,] GetArray(int row, int colum)
{
int[,] array = new int[row, colum];
for (int i = 0; i < row; i++)
{
    for (int j = 0; j < colum; j++)
    {
        array[i, j] = new Random().Next(0, 10);
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

int Sum(int[,] array)
{
    int summ = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        summ = array[i,i] + summ;
    }
    return summ;
}

int userRow = Prompt("Введите количество строк: ");
int userColum = Prompt("Введите количество столбцов: ");
int[,] userarray = GetArray(userRow, userColum);
PrintArray(userarray);
int userSum = Sum(userarray);
System.Console.WriteLine(userSum);