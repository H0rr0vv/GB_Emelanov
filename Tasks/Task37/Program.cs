//Задача 37:
//Найдите произведение пар чисел в одномерном массиве.
//Парой считается первый и последний элемент, 
//второй и предпоседний и т.д.
//Результат запишите в новом массиве.
//[1 2 3 4 5] -> 5 8 3 
//[6 7 3 6] -> 36 21


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

int[] CompArray(int[] arr)
{
    int size = arr.Length;
	int[] temp = new int[size / 2];
	
    if (arr.Length % 2 == 0)
    {
        for (int i = 0; i < temp.Length; i++)
        {
            temp[i] = arr[i] * arr[arr.Length - 1 - i];
        }
    }

    else 
    {
        temp = new int[size / 2 + 1];
        for (int i = 0; i <= temp.Length - 1; i++)
        {
            temp[i] = arr[i] * arr[arr.Length - 1 - i];
            if (i == temp.Length -1) temp[i] = arr[i];
        }
    }

    return temp;
}

int[] array = CreateArray(5, 1, 10);
int[] newArray = CompArray(array);

PrintArray(array);
Console.Write(" -> ");
PrintArray(newArray);