/*
напишите метод, которая на вход принимает число (number), 
а на выходе выводит все чётные числа от 1 до number (включительно), 
разделеные знаком табуляции.
number = 5 -> 2    4
number = 8 -> 2    4    6    8
*/ 
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
 for (int count = 2; count <= number; count += 2)
        {
            Console.Write($"{count}\t");
        }
