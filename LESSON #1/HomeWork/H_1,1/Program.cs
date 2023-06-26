//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.WriteLine("Please, insert first number");
double A = double.Parse(Console.ReadLine()!);

Console.WriteLine("Please, insert second number");
double B = double.Parse(Console.ReadLine()!);

Console.WriteLine("Please, insert third number");
double C = double.Parse(Console.ReadLine()!);

double max = 0;

if (A > B) {
    max = A;
}
else {
    max = B;
}

if (C > max){
     max = C;
}


Console.WriteLine("Maximal number=");
Console.WriteLine(max);