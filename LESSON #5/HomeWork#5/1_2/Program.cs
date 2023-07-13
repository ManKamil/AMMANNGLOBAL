


/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76*/

void Print(double[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();
}

double[] MassNums(int size, int from, int to)
{
    double[] arr = new double[size];
    Random n_new = new Random ();

    for (int i = 0; i < size; i++)
        arr[i] = Math.Round(n_new.NextDouble() * (to-from) + from, 2);
    return arr;
}

void EqualMaxMin(int[] arr){
    double max = 0;
    double min = 0;

    for(int i = 1; i < arr.Length; i ++)
    {
           if (max < arr[i]);
               max = arr[i];
               else if(min > arr[i])
                      min = arr[i];

    }
        Console.WriteLine($"max {max}, min {min}.  ");
        ConsoleWrite($"Difference: {max} - ({min}) = {Math.Round(max - min)}")

}
int num1 = int.Parse(Console.ReadLine()!);
int num2 = int.Parse(Console.ReadLine()!);
int num3 = int.Parse(Console.ReadLine()!);

double[]mass = MassNums(num1, num2, num3);
Print(Mass);
 EqualMaxMin(mass);