// 1. Напишите программу, которая на вход принимает два числа и проверяет,
// является ли первое число квадратом второго.

Console.WriteLine("Введите 2 числа для сравнения их квадрата");

int A = int.Parse(Console.ReadLine()!);

int B = int.Parse(Console.ReadLine()!);

if (A/B == B)
 {
    Console.WriteLine("YES");
 }
else
{
    Console.WriteLine("NO");
    
}
