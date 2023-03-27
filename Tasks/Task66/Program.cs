/*
Задача 66: Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных 
элементов в промежутке от M до N. 
Выполнить с помощью рекурсии.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/


Console.WriteLine("Введите МЕНЬШЕЕ натуральное число");
int numberM = 4;
	//Convert.ToInt32(Console.WriteLine());
Console.WriteLine("Введите БОЛЬШЕЕ натуральное число");
int numberN = 8;
	//Convert.ToInt32(Console.WriteLine());



Console.WriteLine($"M = {numberM}; N = {numberN} -> {SumOfNumbers(numberM, numberN)}");



int SumOfNumbers (int numM, int numN)
{
    if(numM == numN + 1) return 0;
    return numN + SumOfNumbers(numM, numN - 1);
}