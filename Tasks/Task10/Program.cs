//Задача 10: 
//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

Console.WriteLine("Введите трехзначное число");
int value = Convert.ToInt32(Console.ReadLine());

int SecontDigit(int val)
{
    int result = val / 10 % 10;
    return result;
}

Console.WriteLine(SecontDigit(value));
