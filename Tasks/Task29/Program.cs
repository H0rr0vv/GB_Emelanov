//Задача 29: Напишите программу, 
//которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

int[] arr = {1, 2, 5, 7, 19, 6, 7, 33};

void PrintArray(int[] array)
{
    int count = array.Lenght;

    Console.Write("[");

    for (int i = 0; i < count; i++)
    {
        Console.Write(array[i]);
        if (i < count) Console.Write(", ");
    }
    
    Console.Write("]");
}