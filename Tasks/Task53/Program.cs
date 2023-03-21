/*
Задача 53: 
Задайте двумерный массив. Напишите программу, которая поменяет
местами первую и последнюю строку массива.

НЕ ДОДЕЛАН


*/

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

int[,] ChangeFirstEndRow (int[,] matrix)
{
    int[] tempArr = new int[matrix.GetLength(0)];
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        tempArr[j] = matrix[0, j];
        matrix[0, j] = matrix[matrix.GetLength(0) - 1, j];
        matrix[matrix.GetLength(0) - 1, j] = tempArr[j];
    }
	return matrix;
}

int[,] array2d = CreateMatrixRndInt(3, 4, 0, 10);
PrintMatrix(array2d);
array2d = ChangeFirstEndRow(array2d);
PrintMatrix(array2d);