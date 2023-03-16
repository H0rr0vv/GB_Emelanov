//Задача 45:
//Не используя рекурсию, выведите первые N чисел Фибоначчи.
//Первые два числа Фибоначчи: 0 и 1.
//Если N = 7 -> 0 1 1 2 3 5 8


int[] Fibonachi (int n)
{
    int[] fib = new int[n];
    fib[0] = 0;
    fib[1] = 1;
    for (int i = 2; i <= n; i++)
    {
        fib[i] = fib[i - 1] + fib[i - 2];
    }
    return fib;
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

Console.WriteLine("Введите количество первых чисел Фибоначчи");
int N = Convert.ToInt32(Console.ReadLine());
int[] fibonachi = Fibonachi(N);
PrintArray(fibonachi);