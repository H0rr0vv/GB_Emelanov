/*
Задача 57:
Составить частотный словарь элементов двумерного массива. 
Частотный словарь содржит информацию о том,
сколько раз встречается элемент входных данных
{1, 9, 9, 0, 2, 8, 0, 9}

0 встречается 2 раза
1 встречается 1 раза
2 встречается 1 раза
8 встречается 1 раза
9 встречается 3 раза
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


