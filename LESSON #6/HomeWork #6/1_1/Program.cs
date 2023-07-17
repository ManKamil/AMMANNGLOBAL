/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/

void ZeroZero(double k1, double b1, double k2, double b2)
{
        double k_num = k1 - k2;
        if (k_num!=0)
        {
            double x = (b2-b1)/(k1-k2);
            double y = k1 * x + b1;
            Console.WriteLine($"point({x}; {y})");
        }
    else if (k2 == k2 && b2 == b2)
        Console.WriteLine("There are an an infinite number of intersection points. ");
    else
        Console.WriteLine("There is no intersection point");
}