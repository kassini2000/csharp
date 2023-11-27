/*
Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/


int Prompt(string message)
{
    System.Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int[] GetArray(string mess, int size)
{
int[] result = new int[size];
for (int i = 0; i < size; i++)
{
    result[i] = Prompt(mess);
}
return result;
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
    System.Console.WriteLine("]");
    System.Console.WriteLine();
}

int CountNum(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0) count++;
    }
    return count;
}
int userSize = Prompt("Введите длину массива: ");

int[] userarray = GetArray("Введите число для массива: ", userSize);
PrintArray(userarray);
int userCount = CountNum(userarray);
System.Console.WriteLine(userCount);