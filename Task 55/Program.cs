/*Задача 55: Задайте двумерный массив. Напишите программу,
которая заменяет строки на столбцы. В случае, если это
невозможно, программа должна вывести сообщение для
пользователя.*/






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



int[,] ChangeRow(int[,] array)
{
    int row = array.GetLength(0);
    int col = array.GetLength(1);
    int[,] swapArray = new int[row, col];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            swapArray[i,j]= array[j,i];
        }
    }
    return swapArray;
}
Console.Write("Введите количество строк: ");
int row = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int col = Convert.ToInt32(Console.ReadLine());
if(col!=row)
{
    Console.WriteLine("Количество стобцов и строк должно быть одинаковым:  ");
    col = Convert.ToInt32(Console.ReadLine());
}

int[,] array = GenMatrixRnd(row, col, 1, 10);
PrintMatrix(array);
int[,] arrayRes = ChangeRow(array);
Console.WriteLine();
PrintMatrix(arrayRes);
