// Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя)
Console.WriteLine("Введите число");

int number = Convert.ToInt32(Console.ReadLine());
number = number * number;
Console.WriteLine($"Квадрат числа равен -  {number}");
