//Задача 4: 
//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.WriteLine("Введите перовoе число");
int valueA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int valueB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int valueC = Convert.ToInt32(Console.ReadLine());

int Compare(int valA, int valB, int valC)
{
    if (valA > valB)
    {
        if (valA > valC)
        {
            return valA;
        }
        else
        {
            return valC;
        }
    }
    else
    {
        if (valB > valC)
        {
            return valB;
        }
        else
        {
            return valC;
        }
    }
}

int compare = Compare(valueA, valueB, valueC);
Console.WriteLine($"max = {Compare(valueA, valueB, valueC)}");