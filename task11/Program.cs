
/*напишите программу, которая выводит случайно трехзначное число
и удаляет вторую цифру этого числа.
456 -> 6
782 -> 72
918 -> 98
*/

int number = new Random().Next(100, 1000);
System.Console.WriteLine(number);

int first = number / 100;
int last = number % 10;

System.Console.WriteLine(first);
System.Console.WriteLine(last);