/*
 Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

//System.Console.WriteLine("Введите число: ");
//int userNumber = Convert.ToInt32(Console.ReadLine());

//int[] num = new int[8];
//int[] array = {1,5,7,10,4,8,9,11,15};
//System.Console.WriteLine(array[8]);
static void Main(int[] args)
{
    int[] myArray;
    myArray = new int[8] {1,2,5,7,8,23,4,3,15};
   /* myArray[0] = 1;
    myArray[1] = 2;
    myArray[3] = 5;
    myArray[4] = 7;
    myArray[5] = 9;
    myArray[6] = 11;
    myArray[7] = 8;
    myArray[8] = 15;*/

    for (int i = 0; i < myArray.Length; i++)
    {
       Console.WriteLine(myArray);
    }
    Console.ReadLine();
}

