// Задача 51:
// Задайте двумерный массив.
// Найдите сумму элементов, находящихся на главной диагонали:
// с индексами (0,0); (1,1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1 + 9 + 2 = 12.

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

int SumElemMainDiagonalMatrix(int[,] mtrx)
{
    int sum = 0;
    int j = 0;
    for (int i = 0; i < mtrx.GetLength(0) && i < mtrx.GetLength(1); i++)
    {
        j = i;
        sum += mtrx[i, j];
    }
    return sum;
}

// int[,] matrix = new int[3, 4] { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };
int[,] matrix = CreateMatrixRandomInt(3, 4, 1, 9);
OutputMatrix(matrix);
Console.WriteLine();

int result = SumElemMainDiagonalMatrix(matrix);
Console.WriteLine($"Сумма элементов, находящихся на главной диагонали: {result}.");
