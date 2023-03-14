//Задача 31: Задайте массив из 12 элементов,
//заполненный случайными элементами из промежутка [-9, 9].
//Найдите сумму отрицательных и положительных элементов массива.
//[3, 9, -8, 1, 0, -7, 2, -1, 8, -3, -1, 6]
//сумма положительных чисел равна 29, сумма отрицательных равна -20



int[] CreateArray(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i]);
        if (i < arr.Length - 1) Console.Write(", ");
    }
    
    Console.Write("]");
}

int SummPositive (int[] arr)
{
    int summ = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) summ += arr[i];
    }
    return summ;
}

int SummNegative (int[] arr)
{
    int summ = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < 0) summ += arr[i];
    }
    return summ;
}


int[] array = CreateArray(12, -9, 9);
PrintArray(array);

int summPositive = SummPositive(array);
int summNegative = SummNegative(array);

Console.WriteLine($"Сумма положительных чисел равна {summPositive}, ");
Console.WriteLine($"Сумма отрицательных чисел равна {summNegative} ");