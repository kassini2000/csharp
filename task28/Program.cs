/*
Напишите программу, которая принимает на вход 
число N и выдает произведение чисел от 1 до N
*/

int Rrompt(string message)
{
    System.Console.WriteLine(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int MultNumber(int a)
{
    int result = 1;
    for(int i = 1; i < a; i++)
    {
        result = result + i;
    }
    return result;
}

int a = Rrompt("Введите число: ");
int result = MultNumber(a);
System.Console.WriteLine(result);
