// Задача 48:
// Задайте двумерный массив размером m x n.
// Каждый элемент в массиве находится по формуле: Aij = i + j.
// Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

int[,] CreateMatrixElemSumIndices(int rows, int columns) // CreateMatrixElemSumIAndJ
{
    int[,] mtrx = new int[rows, columns];
    for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        for (int j = 0; j < mtrx.GetLength(1); j++)
        {
            mtrx[i, j] = i + j;
        }
    }
    return mtrx;
}

void OutputMatrix(int[,] mtrx)
{
    for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < mtrx.GetLength(1); j++)
        {
            Console.Write($"{mtrx[i, j], 5}");
        }
        Console.WriteLine("   ]");
    }
}

int[,] matrix = CreateMatrixElemSumIndices(3, 4);
OutputMatrix(matrix);
