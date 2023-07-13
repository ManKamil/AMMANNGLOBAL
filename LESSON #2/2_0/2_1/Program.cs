





// 1. Напишите программу, которая выводит случайное число
//    из отрезка [10, 99] и показывает наибольшую цифру числа.

int Max(int num)
{
    if (num/10 > num % 10 )
    return num/10;

    return num % 10;
    
}
int RNum = new Random().Next (10,100);
Console.WriteLine("" + RNum);
int result = Max(RNum);
Console.WriteLine("" + result);