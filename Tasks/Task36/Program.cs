//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0


Console.WriteLine("Введите массив");
int[] array = new int[4];


void FeelArrThreeDigitNumber(int[] arr)
{
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(0; 100);
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

PrintArrayArray();
