//Задача 32:
//Напишите программу замена элементов массива:
//положительные элементы замените на
//соответствующие отрицательные, и наоборот.
//[-4, -8, 8, 2] -> [4, 8, -8, -2]

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

int[] ReverseArray(int[] arr)
{
    int[] reverseArr = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        reverseArr[i] = arr[i] * -1;
    }
	return reverseArr;
}

int[] array = CreateArray(4, -9, 9);
int[] reverseArray = ReverseArray(array);
PrintArray(array);
Console.Write(" -> ");
PrintArray(reverseArray);