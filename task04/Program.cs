/*
максимальное из трех чисел
*/
Console.WriteLine("Введите число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число: ");
int number3 = Convert.ToInt32(Console.ReadLine());
int max = number1;
if(number1 > number2 && number1 > number3){
  max = number1;
}
    if(number2 > number1 && number3 > number2){
      max = number3;
    }
    Console.WriteLine(max);

