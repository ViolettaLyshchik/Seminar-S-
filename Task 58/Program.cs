/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/
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
            if (j < array.GetLength(1) - 1) Console.Write(array[i, j] + " , ");
            else Console.Write(array[i, j] + "]");
        }
        Console.WriteLine();
    }
}
void MultiplyMatrix(int[,] arrayFirst, int[,] arraySecond, int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k <arrayFirst.GetLength(1); k++)
      {
        sum += arrayFirst[i,k] * arraySecond[k,j];
      }
      array[i,j] = sum;
    }
  }
}

Console.Write("Введите количество строк первой матрицы: ");
int row1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов первой матрицы: ");
int col1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество строк второй матрицы: ");
int row2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов второй матрицы: ");
int col2 = Convert.ToInt32(Console.ReadLine());
if(col2!=row1)
{
    Console.WriteLine($"Количество стобцов второй матрицы, должно быть равным количеству строк первой матрицы. Задайте {row1} столбцов:  ");
    col2 = Convert.ToInt32(Console.ReadLine());
}
int[,] arrayFirst= GenMatrixRnd(row1, col1, 1, 10);
PrintMatrix(arrayFirst);
Console.WriteLine();
int[,] arraySecond= GenMatrixRnd(row2, col2, 1, 10);
PrintMatrix(arraySecond);

int[,] array = new int[row1,col2];

MultiplyMatrix(arrayFirst, arraySecond, array);
Console.WriteLine($"\nПроизведение первой и второй матриц:");
PrintMatrix(array);