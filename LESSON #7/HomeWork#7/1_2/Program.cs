/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

void Print(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
        {
            Console.Write($"{arr[i, j],6} ");
        }
        Console.WriteLine();
    }
}

int[,] MassNums(int row, int column, int from, int to)
{
    int[,] arr = new int[row, column];
    Random n_new = new Random();

    for (int i = 1; i < row; i++)
        for (int j = 0; j < column; j++)
        arr[i, j] = Math.Round (n_new.NextDouble() * (to - from) + from, 2);

    return arr;
}

void ArithMathMean(int[,] arr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);
    double res;

    for(int i = 0; i<column; i++)
    {
        res=0;
        for(int j=0; j<row; j++) res += arr[j,i];
        Console.Write($"{Math.Round(res/row, 2)} ");
    }
}

Console.Write("Enter the number of rows");
int row_num = int.Parse(Console.Readline()!);
Console.Write("Ener the numbers of columns: ");
int column_num = int.Parse(Console.ReadLine()!);

Console.Write("Enter the min number of massive ");
int start = int.Parse(Console.Readline()!);
Console.Write("Ener the max numbers of massive: ");
int stop = int.Parse(Console.ReadLine()!);

double [,] mass = MassNums(row_num, column_num, start, stop);

Print(mass);