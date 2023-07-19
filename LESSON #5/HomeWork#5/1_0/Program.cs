/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/





void Print(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
        Console.Write($"{arr[i]} ");

    Console.WriteLine();
}

int[] MassNums(int size, int from, int to)
{
    int[] arr = new int[size];

    for (int i = 1; i < size; i++)
        arr[i] = new Random().Next(from, to + 1);

    return arr;
}
void RanNums(int []arr) 
{
    int count = 0;

    for (int i = 0; i < arr.Length; i++){
         if (arr[i] % 2 == 0)
               count ++;
    } 
}

int num = int.Parse(Console.ReadLine()!);
int start = int.Parse(Console.ReadLine()!);
int stop = int.Parse(Console.ReadLine()!);
int[]mass = MassNums(num, start, stop);
Print(mass);
Console.WriteLine(RanNums(Mass));



//Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.*/

/*Console.Write("Введите количество элементов массива: ");
int a = int.Parse(Console.ReadLine()!);
int[] randomArray = new int[a];

void mass(int a)
{
for (int i = 0; i < a; i++)
{
randomArray[i] = new Random().Next(99,999);
Console.Write(randomArray[i] + " " );
}

}

int kolichestvo(int[] randomArray)
{
int kol = 0;
for (int i = 0; i < randomArray.Length; i++)
{
if (randomArray[i] % 2 == 0)
kol = kol + 1;
}
return kol;
}*/