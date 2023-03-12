//Задача 20:
//Напишите программу, которая принимает на вход координаты двух точек
//и находит расстояние между ними в 2D пространстве

Console.WriteLine("Введите коордитаты первой точки");
Console.WriteLine("Х: ");
int APointX = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Y: ");
int APointY = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите коордитаты второй точки");
Console.WriteLine("Х: ");
int BPointX = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Y: ");
int BPointY = Convert.ToInt32(Console.ReadLine());

double distance = Math.Round(Distanse(APointX, APointY, BPointX, BPointY), 2, MidpointRounding.ToZero);
Console.WriteLine(distance);

double Distanse (int AX, int AY, int BX, int BY)
{
    int rangeX = AX - BX;
    int rangeY = AY - BY;
    double result = Math.Sqrt((rangeX * rangeX) + (rangeY * rangeY));
    return result;
}