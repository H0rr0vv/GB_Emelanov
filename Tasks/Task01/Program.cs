// 1. Напишите программу, которая на вход принимает два
//числа и проверяет, является ли первое число квадратом
//
//a = 25, b = 5 -> да
//a = 2, b = 10 -> нет
//a = 9, b = -3 -> да
//a = -3 b = 9 -> нет

Console.WriteLine("Введите два числа");
int number1 = Convert.ToInt32(Console.ReadLine("Введите первое число"));
int number2 = Convert.ToInt32(Console.ReadLine("Введите второе число"));
if (number2 == number1 * number1) {
    Console.WriteLine()
}