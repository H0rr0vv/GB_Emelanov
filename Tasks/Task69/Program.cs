/*
Задача 69:
Напишите программу, которая на вход принимает два числа
А и В, и возводит число А в целую степень В с помощью рекурсии

А = 3; В = 5 -> 243
А = 2; В = 3 -> 8
*/

int NumberAToNumberB(int a, int b)
{
    if (b == 1) return a;
    return a * NumberAToNumberB(a, b - 1);
}

Console.WriteLine("Введите первое число");
int numberA = 3;
//Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int numberB = 5;
//Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"A = {numberA}; B = {numberB} -> {NumberAToNumberB(numberA, numberB)}");