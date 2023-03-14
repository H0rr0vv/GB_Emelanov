//Задача 33:
//Задайте массив.
//Напишите программу, которая определяет, присутствует ли 
//заданное число в массиве.
//4; массив [6, 7, 19, 345, 3] -> нет


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

bool FindElem (int elem, int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (elem == arr[i]) return true;
	}
    return false;
}

int[] array = CreateArray(5, 0, 345);
Console.WriteLine("Введите искомый элемент");
int element = Convert.ToInt32(Console.ReadLine());
Console.Write($"{element}; массив ");
PrintArray(array);
Console.Write(" -> ");
Console.Write(FindElem(element, array) ? "да" : "нет");