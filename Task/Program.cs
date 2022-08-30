//   Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

//  Console.WriteLine("Введите A: ");
//    int A = int.Parse(Console.ReadLine());
//    Console.WriteLine("Введите B: ");
//    int B = int.Parse(Console.ReadLine());

//    void FindDegree(int A, int B)
//    {
//     int result = 1;
//     for ( int i =1; i<= B; i++)
//     {
//         result = result * A;
//     }
//       Console.WriteLine(result);
//    }
//     FindDegree( A,B );

 
// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

// Console.WriteLine("Введите число: ");
// int number = int.Parse(Console.ReadLine());

// int sum = 0;
// while (number > 0)
// {
//     sum = sum + number % 10;
//     number /= 10;
// }
//   Console.WriteLine(sum);

//Задача 29 Напишите массив от мин до макс
Console.WriteLine("Введите длину массива : ");
int lenArray = int.Parse(Console.ReadLine());
Console.WriteLine("minValue : ");
int minValue = int.Parse(Console.ReadLine());
Console.WriteLine("maxValue : ");
int maxValue = int.Parse(Console.ReadLine());

int[] randomArray = new int[lenArray];
for (int i = 0; i < randomArray.Length; i++)
{
    randomArray[i] = new Random().Next(minValue,maxValue);
    Console.Write(randomArray[i] + " ");
}
