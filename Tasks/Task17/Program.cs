//Задача 17:
//Напишите программу, которая принимает на вход коордитаты точки (X и Y),
//причем X != 0 и Y != 0 и выдае номер чевери плоскости, в которой
//находится эа точка.

//X>0 Y>0 = 1
//X>0 Y<0 = 2
//X<0 Y<0 = 3
//X<0 Y>0 = 4

Console.WriteLine("Введите коордитаты точки");
Console.WriteLine("Введите X: ");
int coordinataX = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Y: ");
int coordinataY = Convert.ToInt32(Console.ReadLine());

int quarter = NumberOfQuarter(coordinataX, coordinataY);

string result = quarter > 0 
                ? $"Указанные координаты соответствуют четверти {quarter}" 
                : "ВВедены некорректные координаты";

Console.WriteLine(result);

int NumberOfQuarter(int x, int y)
{
    if (x > 0 && y > 0) return 1;
    if (x > 0 && y < 0) return 2;
    if (x < 0 && y < 0) return 3;
    if (x < 0 && y > 0) return 4;
    return 0;
}