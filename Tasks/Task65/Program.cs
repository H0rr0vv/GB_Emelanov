/*
Задача 65:
Задайте значения M и N.
Напишите программу, которая выведет все натуральные 
числа в промежутке от M до N.
*/

Console.WriteLine("Введите певрое натуральное число");
int numberM = 2;
	//Convert.ToInt32(Console.WriteLine());
Console.WriteLine("Введите второе натуральное число");
int numberN = 5;
	//Convert.ToInt32(Console.WriteLine());

NaturelNumbers(numberM, numberN);


void NaturelNumbers (int numM, int numN)
{
    if (numM > numN) return;
    NaturelNumbers (numM, numN - 1);
    Console.Write($"{numN} ");
}