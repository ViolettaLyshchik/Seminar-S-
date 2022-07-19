// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9
Console.Clear();
double[,] GenMatrixRnd(int row, int col, int min, int max)
{
    double[,] array = new double[row, col];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.NextDouble()*10;
        }
    }
    return array;
}
void PrintMatrix(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j == 0) Console.Write("[");
            if (j < array.GetLength(1) - 1) Console.Write(Math.Round(array[i, j],2) + "  ;  ");
            else Console.Write(Math.Round(array[i, j],2) + "]");
        }
        Console.WriteLine();
    }
}
double[,] arrayResult = GenMatrixRnd(3, 4, 1,20);
PrintMatrix(arrayResult);