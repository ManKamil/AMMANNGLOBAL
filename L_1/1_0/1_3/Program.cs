//Напишите программу, которая на вход принимает одно число
// (N), а на выходе показывает все целые числа в промежутке от -N до N.
Console.WriteLine("Write a number please");

int num = int.Parse(Console.ReadLine()!);
int count = -num;


while (count<=num)
{
    Console.WriteLine(count);

    count++; 
    //count=count+1
}