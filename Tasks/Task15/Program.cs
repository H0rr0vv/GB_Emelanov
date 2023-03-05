//Задача 15: 
//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

Console.WriteLine("Введите номер дня недели");
int numberOfWeek = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(WeekEnd(numberOfWeek) ? "да" : "нет");

bool WeekEnd(int numOfWeek)
{
    return numOfWeek == 6 || numOfWeek == 7;
}
