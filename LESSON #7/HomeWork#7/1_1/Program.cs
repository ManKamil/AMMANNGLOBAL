
/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/

void Print(double[,] arr)
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

string FindElement(int[,] arr, int f, int s)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);

    if (f>row || f<=0 || s>column || s<=0)
        return $"{f} {s} -> not in the array";
    return $"arr[{f}, {s} = {arr[f - 1, s - 1]} - > is in the array";

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