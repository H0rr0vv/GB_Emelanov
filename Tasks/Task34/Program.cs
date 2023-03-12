//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2


Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
int value = 0;


void FeelArrThreeDigitNumber(int[] arr)
{
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(100, 1000);
    }
}


void PrintArray(int[] arr)
{
    Console.Write("[");

    

    for (int i = 0; i < size; i++)
    {
        Console.Write(arr[i]);
        if (i < size - 1) Console.Write(", ");
    }
    
    Console.Write("]");
}


int EvenNumber (int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) value++;
    }
    return value;
}

PrintArray();
Console.Write(value);

