//47. Написать программу копирования массива

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

int[] CopyArray (int[] arr)
{
    int[] newArr = new int[arr.Length];
    for (int i = 0; i < newArr.Length; i++)
    {
        newArr[i] = arr[i];
    }
    return newArr;
}

int[] array = CreateArray(4, 0, 10);
PrintArray(array);
int[] newArray = CopyArray(array);
PrintArray(newArray);