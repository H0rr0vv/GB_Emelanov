//Задача 27: Напишите программу, 
//которая принимает на вход число 
//и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

Console.WriteLine("Введите число, сумму цифр которого надо посчитать");
int number = Convert.ToInt32(Console.ReadLine());


int summOfNumber = SummOfNumber (number);
Console.WriteLine(summOfNumber);

int SummOfNumber (int num)
{
    int result = 0;
    for (int i = num; i <= 0; i = num / 10)
    {
        result = result + (i / 10);
    }
    return result;
}