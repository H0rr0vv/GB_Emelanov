//Задача 43: 
//Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


double FindIntersectionX(int b1, int k1, int b2, int k2)
{
    double x = (k2 * b2 - k1 * b1) / (b1 - b2);
    return x;
}

double FindIntersectionY(int b1, int k1, double x)
{
    double y = k1 * x + b1;
    return y;
}

void PrintPointIntersection(double x, double y)
{
    Console.WriteLine($"({x}, {y})");
}

Console.WriteLine("Первая прямая задаеттся уравнением y = k1 * x + b1");
Console.WriteLine("Введите значение b1");
int valb1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение k1");
int valk1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Вторая прямая задаеттся уравнением y = k2 * x + b2");
Console.WriteLine("Введите значение b2");
int valb2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение k2");
int valk2 = Convert.ToInt32(Console.ReadLine());



double pointX = FindIntersectionX(valb1, valk1, valb2, valk2);
double pointY = FindIntersectionY(valb1, valk1, pointX);

PrintPointIntersection(pointX, pointY);