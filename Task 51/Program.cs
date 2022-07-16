/*Задача 51: Задайте двумерный массив. Найдите сумму
элементов, находящихся на главной диагонали (с индексами
(0,0); (1;1) и т.д.*/


Console.Write("Введите количество строк: ");
int lines = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int col = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите минимальное значение диапазона: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите максимальное значение диапазона: ");
int max = Convert.ToInt32(Console.ReadLine());

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
int SumDiagElem(int[,] array)
{
    int sumDiagElem = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        {
            sumDiagElem += array[i, i];
        }
    }
    return sumDiagElem;
}


int[,] genArray = GenMatrixRnd(lines, col, min, max);
PrintMatrix(genArray);
int resultSum = SumDiagElem(genArray);
Console.WriteLine($"Сумма элементов на главной диагонали = {resultSum}");
