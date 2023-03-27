/*
Задача 65:
Задайте значения M и N.
Напишите программу, которая выведет все натуральные 
числа в промежутке от M до N.
*/

Console.WriteLine("Введите певрое натуральное число");
int numberM = Convert.ToInt32(Console.WriteLine());
Console.WriteLine("Введите второе натуральное число");
int numberN = Convert.ToInt32(Console.WriteLine());

NaturelNumbers(numberM, numberN);


void NaturelNumbers (int numM, int numN)
{
    if(numM < numN)
    {
        NaturelNumbers (numM, numN - 1);
        Console.Write($"{numN} ");
    }
    else if (numM > numN)
    {
        Console.Write($"{numM} ");
        NaturelNumbers (numM - 1, numN);
    }
    else
    {
        Console.Write($"{numM} ");
    }
}