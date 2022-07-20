/*Задача 52.Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/





int[,] GenMatrixRnd(int row, int col, int min, int max)
{
    int[,] array = new int[row, col];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(min, max + 1);
        }
    }
    return array;
}
void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j == 0) Console.Write("[");
            if (j < array.GetLength(1) - 1) Console.Write(array[i, j] + ",");
            else Console.Write(array[i, j] + "]");
        }
        Console.WriteLine();
    }
}

double[] AvgCol(int[,] matrix)
{
    double[] array = new double[matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        int sum = 0;
        for (int j = 0; j <matrix.GetLength(0); j++)
        {
            sum += matrix[j,i];
        }
           array[i]= (double) sum / matrix.GetLength(0);
        Console.WriteLine();
    }
    return array;

}
void PrintArray(double[] array)
{
            for (int j = 0; j < array.Length; j++)
        {
            if (j == 0) Console.Write("[");
            if (j < array.Length - 1) Console.Write(array[j] + ",  ");
            else Console.Write(array[j] + "]");
        }
        Console.WriteLine();
}







Console.Write("Введите количество строк: ");
int lines = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int col = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите минимальное значение диапазона: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите максимальное значение диапазона: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] genArray = GenMatrixRnd(lines, col, min, max);
PrintMatrix(genArray);


double[] array = AvgCol(genArray);
PrintArray(array);

