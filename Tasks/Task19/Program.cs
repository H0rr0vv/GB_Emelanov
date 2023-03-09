//Задача 19:
//Напишите программу, которая принимает на вход пятизначное число 
//и прорверяет, является ли оно палиндромом
//14212 -> нет
//12821 -> да
//23432 -> да

Console.WriteLine("Введите пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());

if (number / 10000 !> 0)
{
    Console.WriteLine(PalindromTest(number) ? "да" : "нет");
}
else
{
    Console.WriteLine("Вы ввели НЕ пятизначное число!");
}

bool PalindromTest (int num)
{
    int firstElement = num / 10000;
    int secondElement = num / 1000 % 10;
    int fourElement = num / 10 % 10;
    int fiveElement = num % 10;
    return firstElement == fiveElement && secondElement == fourElement;
}
