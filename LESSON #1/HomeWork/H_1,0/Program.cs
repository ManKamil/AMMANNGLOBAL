﻿//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.WriteLine("Please, insert first number: ");
int A = int.Parse(Console.ReadLine())!;

Console.WriteLine("Please, second number: ");
int B = int.Parse(Console.ReadLine()!)!;



if(A>B)
{
     int maximum = A;
     int minimum = B;
     
     Console.WriteLine("max="+A);
     Console.WriteLine("min="+B);
}
else 
{
     int maximum = B;
     int minimum = A;

     Console.WriteLine("max="+B);
     Console.WriteLine("min="+A);
}

