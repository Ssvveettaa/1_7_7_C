// Задача 46:
// Задайте двумерный массив размером m x n,
// заполненный случайными целыми числами.

// m = 3, n = 4.

//      0:  1:  2:  3:
// 0:   1   4   8  19
// 1:   5  -2  33  -2
// 2:  77   3   8   1

int[,] CreateMatrixRandomInt(int rows, int columns, int min, int max)
{
    int[,] mtrx = new int[rows, columns]; // Массив заполнен нулями.    // Перебор сначала по строкам, а потом по столбцам.
    var random = new Random(); // GetLength(0) – Измерение массива.     // Для перебора сначала по столбцам, а потом по строкам:
    for (int i = 0; i < mtrx.GetLength(0); i++) // i – для строк.       // Здесь использовать: "j" и GetLength(1) – по столбцам.
    {
        for (int j = 0; j < mtrx.GetLength(1); j++) // j – для столбцов.// Здесь использовать: "i" и GetLength(0) – по строкам.
        {
            mtrx[i, j] = random.Next(min, max + 1);                     // Здесь ничего не меняем (принято: "i" – строки, "j" – столбцы).
        }
    }
    return mtrx;
}

void OutputMatrix(int[,] mtrx)
{
    for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        Console.Write("["); // Можно вывести "|" вместо "[", или вовсе убрать вывод символа.
        for (int j = 0; j < mtrx.GetLength(1); j++)
        {
            Console.Write($"{mtrx[i, j], 6}"); // ! Отступ слева 6 символов, выравнивание по правому краю.
        }
        Console.WriteLine("  ]"); // Можно вывести "  |" вместо "  ]" или только Console.WriteLine();
    }
}

// int[,] array2d = new int[3, 4] { { 1, 4, 8, 19 }, { 5, -2, 33, -2 }, { 77, 3, 8, 1 } };
int[,] matrix = CreateMatrixRandomInt(3, 4, -100, 100);
OutputMatrix(matrix);
