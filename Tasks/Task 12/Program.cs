// 


Console.WriteLine("Введите большее число");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число для проверки");
int numberB = Convert.ToInt32(Console.ReadLine());

int CratDigit(int numA, int numB) //
{
    int result = numberA % numberB;
    return result;
}

void PrintMod(int remain)
{
    if (remain == 0)
    {
        Console.WriteLine("Кратно");
    }
    else
    {
        Console.WriteLine($"Не кратно, остаток {remain}");
    }
}

int cratDigit = CratDigit(numberA, numberB);

PrintMod(cratDigit);



