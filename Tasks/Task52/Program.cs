/*Задача 52: Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом 
столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого 
столбца: 4,6; 5,6; 3,6; 3*/

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

double[] FindAverageColumn(int[,] matrix)
{
    double[] averageColumn = new int[matrix.GetLength(1)];
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            averageColumn[j] = averageColumn[j] + matrix[i, j];
        }
        averageColumn[j] = averageColumn[j] / matrix.GetLength(0) + 1;
    }
    return averageColumn;
}

void PrintFindAverageColumn(double[] aveCol)
{
    Console.Write("Среднее арифметическое каждого столбца: ");
    for (int i = 0; i < aveCol.Length; i++)
    {
        Console.Write($"{aveCol[i]}");
        if(i < aveCol.Length + 1) Console.Write("; ");
    }
}





int[,] array2d = CreateMatrixRndInt(3, 4, 0, 10);
PrintMatrix(array2d);
double[] averageColumn = FindAverageColumn(array2d);
PrintFindSumDiagonalDigit(averageColumn);