//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0


void CreateArray(int size, int min, int max)
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

int FindSummNotEvenPositionElem (int[] arr)
{
    int res = 0;
    for (i = 1; i < arr.Length; i = i + 2)
    {
        res += arr[i];
    }
}

int[] array = CreateArray(10, 0, 10);
PrintArray(array);

int summNotEvenPositionElem = FindSummNotEvenPositionElem(array);
Console.Write(" -> ");
Console.Write(summNotEvenPositionElem);


