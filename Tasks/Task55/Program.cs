/*
Задача 55:
Задайте двумерный массив. 
Напишите программу, которая заменяет строки на столбцы.
В случае, если это невозможно, 
программа должна вывести сообщение для пользователя

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

int[,] ChangeRowColumn (int[,] matrix)
{
    int[,] newMatrix = new int[arr.GetLength(1), arr.GetLength(0)];
    for (int i = 0; i < newMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < newMatrix.GetLength(1); j++)
        {
            newMatrix[i, j] = matrix[j, i];
        }
    }
    return newMatrix;
}

int[,] array2d = CreateMatrixRndInt(3, 4, 0, 10);
int[,] newArray2d = ChangeRowColumn(array2d);
PrintMatrix(array2d);
newArray2d = ChangeRowColumn(array2d);
Console.WriteLine("");
PrintMatrix(newArray2d);







