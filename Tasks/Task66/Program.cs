/*
Задача 66: Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных 
элементов в промежутке от M до N. 
Выполнить с помощью рекурсии.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/


Console.WriteLine("Введите певрое натуральное число");
int numberM = 2;
	//Convert.ToInt32(Console.WriteLine());
Console.WriteLine("Введите второе натуральное число");
int numberN = 5;
	//Convert.ToInt32(Console.WriteLine());

SumMToN(numberM, numberN);


int SumMToN (int numM, int numN)
{
    if (numM > numN) return;
    SumMToN (numM, numN - 1);
    Console.Write($"{numN} ");
}