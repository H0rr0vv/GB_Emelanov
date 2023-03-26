/*Задача 60. ...Сформируйте трёхмерный массив 
из неповторяющихся двузначных чисел. Напишите программу, 
которая будет построчно выводить массив, добавляя индексы 
каждого элемента.
Массив размером 2 x 2 x 2
Результат:
66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)*/

int[,,] CreateMatrixRndInt(int rows, int columns, int depth, int min, int max)
{
    int[,,] matrix = new int[rows, columns, depth];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = rnd.Next(min, max + 1);
                for (int l = 0; l < matrix.GetLength(0); l++)
                {
                    for (int m = 0; m < matrix.GetLength(1); m++)
                    {
                        for (int n = 0; n < matrix.GetLength(2); n++)
                        {
                            if(matrix[i, j, k] == matrix[l, m, n])
                            {
                                matrix[i, j, k] = rnd.Next(min, max + 1);
                                l = 0;
                                m = 0;
                                n = 0;
                            }
                        }
                    }
                }
            }
        }
    }
    return matrix;
}

void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"{matrix[i, j, k]}({i},{j},{k}) ");
            }
        }
        Console.WriteLine("");
    }
}

int[,,] matrix = CreateMatrixRndInt(3, 4, 5, 0, 100);
PrintMatrix(matrix);