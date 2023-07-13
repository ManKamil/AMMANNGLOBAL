// 1. Задайте двумерный массив размера m на n,
//    каждый элемент в массиве находится по формуле: Aₘₙ = m+n.
//    Выведите полученный массив на экран.


void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j],3} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    Console.WriteLine("\nМассив:");
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = i+j;
        }
    }
}



Console.WriteLine("Введите количество столбцов ");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество строк ");
int n = int.Parse(Console.ReadLine()!);
int[,] matrix = new int[m, n];
FillArray(matrix);
PrintArray(matrix);


/*void PrintArray(int[,] matrix)
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
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            matrix[i, j] = i+j;
        }

    }
}
FillArray(matrix);
PrintArray(matrix);*/

/*void Print(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)        
            Console.Write($" {arr[i, j], 4} ");        
        Console.WriteLine();       
    }
    Console.WriteLine();
}

int[,] MassNums(int row, int column)
{
    int[,] arr = new int[row, column];

    for (int i = 0; i < row; i++)      
        for (int j = 0; j < column; j++)        
            arr[i, j] = i+j;                
    
    return arr;
}

Console.Write("Enter the number of rows: ");
int row_num = int.Parse(Console.ReadLine()!);
Console.Write("Enter the number of columns: ");
int column_num = int.Parse(Console.ReadLine()!);

int[,] mass = MassNums(row_num, column_num);
Console.WriteLine();
Print(mass);*/