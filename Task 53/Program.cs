/*Задача 53: Задайте двумерный массив. Напишите программу,
которая поменяет местами первую и последнюю строку
массива.*/
Console.Write("Введите количество строк: ");
int row = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int col = Convert.ToInt32(Console.ReadLine());



Console.Clear();
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

void ChangeRow(int[,] array)
{
    int index1 = 0;
    int index2 = array.GetLength(0) - 1;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        int row = array[index1, i];
        array[index1, i] = array[index2, i];
        array[index2, i] = row;
    }
}
int[,] array = GenMatrixRnd(row, col, 1, 10);
PrintMatrix(array);
ChangeRow(array);
Console.WriteLine();
PrintMatrix(array);