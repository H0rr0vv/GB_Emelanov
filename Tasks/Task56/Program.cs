/*Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку 
с наименьшей суммой элементов.
Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке 
и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows,columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix; 
}

void PrintMatrix (int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j], 4}");
        }
        Console.WriteLine("");
    }
}

int FindMinSumRow (int[,] matrix)
{
    int temp = 0;
    int res = 0;
    int indRow = 0;
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            temp = temp + matrix[i, j];
        }
        
        if (res == 0) res = temp;
        
        if (res > temp)
        {
            res = temp;
            indRow = i;
        }
    }
    return indRow;
}



int[,] array2d = CreateMatrixRndInt(3, 4, 0, 10);
PrintMatrix(array2d);
int indMinSumRow = FindMinSumRow(array2d);
Console.WriteLine("");
Console.WriteLine($"Минимальная сумма элементов в {indMinSumRow} строке");