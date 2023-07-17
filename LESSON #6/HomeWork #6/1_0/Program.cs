/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/

int Wirtg(int Num){
    int count = 0;
    for (i = 1; i <= num; i++){
        Console.Write($"Число {i}: ");
        int a = int.Parse(Console.ReadLine()!);
        if (a>0) count ++;
    }
    return count;
}
Console.Write("Сколько чисел хотели бы ввести?: ");
int a = int.Parse(Console.ReadLine()!);
int resilt = checked(a);
Console.WriteLine($"Кол-во чисел больше 0: {result}");