/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
1, 7 -> такого числа в массиве нет*/



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

int CearchElement (int[,] array,int row,int col)
{
  int num = array[row -1, col -1];
  return num;
}






Console.Write("Введите количество строк: ");
int lines = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int col = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите минимальное значение диапазона: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите максимальное значение диапазона: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] genArray= GenMatrixRnd(lines,col,min,max);
PrintMatrix(genArray);

Console.Write("Введите индекс строки: ");
int indexRow = Convert.ToInt32(Console.ReadLine());

while (indexRow > lines)
{
  Console.Write($"Такого значения нет.Максимальное значение строки {lines}. Повторите ввод: ");
  indexRow = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine();

Console.Write("Введите индекс столбца: ");
int indexCol = Convert.ToInt32(Console.ReadLine());

while (indexCol > col)
{
  Console.Write($"Такого значения нет.Максимальное значение столбца {col}. Повторите ввод: ");
  indexCol = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine();


int number = CearchElement(genArray,indexRow,indexCol);
Console.Write($"Полученное значение елемента: {number}");