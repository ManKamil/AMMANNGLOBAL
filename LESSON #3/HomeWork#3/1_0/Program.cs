// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

/*Console.Clear();
Console.WriteLine("Задача 10 ");
Console.Write("Введи трёхзначное число: ");
int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(threeDigitNumber);
Console.WriteLine("вторая цифра этого числа -> "+stringNumber[1]);*/

/*void numA(int num);
{
    if (num % 100 == 0) ;
        
}
int num = int.Parse(Console.ReadLineLine());
numA(num);*/

Console.WriteLine("Please write a numbers: ");


int numbers = int.Parse(Console.ReadLine()!);
int result = 0;
{
   result = (numbers/10); 
}
Console.WriteLine(result%10);
