//48. Показать двумерный массив размером m×n 
//заполненный целыми числами

int[,] CreateArray (int m, int n, int min, int max)
{
    int[,] arr = new int [m,n];
    Random rnd = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
           arr[m, n] = rnd.Next(min, max + 1);
        }
    }
    return arr;
}

void PrintArray (int[,] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j]);
        }
        if (i < arr.Length - 1) Console.Write(", ");
    }
    Console.Write("]");
}


int[,] array = CreateArray(3, 4, 0, 10);
PrintArray(array);
