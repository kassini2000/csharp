/*
Внутри класса Answer напишите метод ShowCube, который принимает на вход число (N) 
и выводит таблицу кубов чисел от 1 до N (включительно) 
каждое на новой строке.
N = 3
1 
8 
27

N = 5 
1 
8 
27 
64 
125
*/

System.Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= 0; i++)
{  
    System.Console.WriteLine(Math.Pow(i, 3) + " ");
}


/* полиндрон цикл
System.Console.WriteLine("Введите число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

int reverse = 0;
int count = 0;
for(int i = userNumber; i > 0; i /= 10)
{
    reverse = (reverse * 10) + (i % 10);
    count++;
}
if (reverse == userNumber)
{
    System.Console.WriteLine("true");
}
else if (count != 5)
{
    System.Console.WriteLine("Это не пятизначное число");
    System.Console.WriteLine("\t\t\t\t\t false");
}
else System.Console.WriteLine("false");
*/
