// 1. Задайте двумерный массив. Напишите программу,
//    которая поменяет местами первую и последнюю строку массива.

//Решение Ильи
/*
Console.Write("Кол-во строк ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Кол-во столбцов ");
int col = int.Parse(Console.ReadLine()!);
int[,] matrix = new int[row, col];

Console.Write("Введите минимальное значение элемента массива : ");
int min = int.Parse(Console.ReadLine()!);
Console.Write("Введите максимальное значение элемента массива : ");
int max = int.Parse(Console.ReadLine()!);

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}
void FillArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(min, max + 1);
        }
    }
}

void Obmen(int[,] matrix)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        (matrix[0, j], matrix[row - 1, j]) = (matrix[row - 1, j], matrix[0, j]);
    }

}
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
Obmen(matrix);
PrintArray(matrix);*/



void RandomArray(int[,] array)
{
    Random random = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(0, 50);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j], 4}");
        }
        System.Console.WriteLine();
    }
}

void ChangeRow(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        (array[0, j], array[array.GetLength(0) - 1, j]) = (
            array[array.GetLength(0) - 1, j],
            array[0, j]
        );
    }
}


Console.Write("Введите число строк массива: ");
int str = int.Parse(Console.ReadLine()!);
Console.Write("Введите число столбцов массива: ");
int col = int.Parse(Console.ReadLine()!);


Console.WriteLine();
int[,] NewArray = new int[str, col];

RandomArray(NewArray);
PrintArray(NewArray);
Console.WriteLine();
ChangeRow(NewArray);
PrintArray(NewArray);