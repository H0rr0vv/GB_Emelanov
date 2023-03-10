//Задача 29: Напишите программу, 
//которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

int[] array = {1, 2, 5, 7, 19, 6, 7, 33};

void PrintArray(int[] arr)
{
    Console.Write("[");

    for (int i = 0; i < arr.Lenght; i++)
    {
        Console.Write(arr[i]);
        if (i < arr.Lenght) Console.Write(", ");
    }
    
    Console.Write("]");
}

PrintArray(array);