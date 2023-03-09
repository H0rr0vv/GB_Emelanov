//Задача 21
//Напишите программу, которая принимает на вход координаты 
//двух точек и находит расстояние между ними в 3D пространстве.

//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите коордитаты первой точки");
Console.WriteLine("Х: ");
int APointX = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Y: ");
int APointY = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Z: ");
int APointZ = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите коордитаты второй точки");
Console.WriteLine("X: ");
int BPointX = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Y: ");
int BPointY = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Z: ");
int BPointZ = Convert.ToInt32(Console.ReadLine());


double distance = Math.Round(Distanse(APointX, APointY, APointZ, BPointX, BPointY, BPointZ), 2, MidpointRounding.ToZero);
Console.WriteLine(distance);

double Distanse (int AX, int AY, int AZ, int BX, int BY, int BZ)
{
    int rangeX = AX - BX;
    int rangeY = AY - BY;
    int rangeZ = AZ - BZ;
    double result = Math.Sqrt((rangeX * rangeX) + (rangeY * rangeY));
    result = Math.Sqrt((result * result) + (rangeZ * rangeZ));
    return result;
}
