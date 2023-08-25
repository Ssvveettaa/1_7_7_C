// Задача 49:
// Задайте двумерный массив.
// Найдите элементы, у которых оба индекса чётные,
// и замените эти элементы на их квадраты.

// Например, изначально массив выглядел вот так:    Новый массив будет выглядеть вот так:
//                                      1 4 7 2                                 1 4 49 2
//                                      5 9 2 3                                 5 9  2 3
//                                      8 4 2 4                                64 4  4 4

//                                      5 2 7 2                                25 2 49 2
//                                      2 2 2 2                                 2 2  2 2
//                                      8 2 6 2                                64 2 36 2

int[,] CreateMatrixRandomInt(int rows, int columns, int min, int max)
{
    int[,] mtrx = new int[rows, columns];
    var random = new Random();
    for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        for (int j = 0; j < mtrx.GetLength(1); j++)
        {
            mtrx[i, j] = random.Next(min, max + 1);
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

void SquaredElemMatrixBothIndexEven(int[,] mtrx) // ReplaceEvenRowsColumnsSquare
{
    for (int i = 0; i < mtrx.GetLength(0); i += 2)
    {
        for (int j = 0; j < mtrx.GetLength(1); j += 2)
        {
            mtrx[i, j] *= mtrx[i, j];
        }
    }
}

// int[,] matrix = new int[3, 4] { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };
// int[,] matrix = new int[3, 4] { { 5, 2, 7, 2 }, { 2, 2, 2, 2 }, { 8, 2, 6, 2 } };
int[,] matrix = CreateMatrixRandomInt(3, 4, 1, 9);
OutputMatrix(matrix);
Console.WriteLine();

SquaredElemMatrixBothIndexEven(matrix);
OutputMatrix(matrix);
