/*Задача 57: Составить частотный словарь элементов двумерного массива.
Частотный словарь содержит информацию о том, сколько раз встречается элемент
входных данных.*/

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
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < arr.Length - 1) Console.Write(arr[i] + ",");
        else Console.Write(arr[i] + "]");
    }
}
int[] FromMatrixToArray(int[,] array)
{
    int[] result = new int[array.GetLength(0) * array.GetLength(1)];
    int count = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            result[count] = array[i, j];
            count++;
        }
    }
    return result;
}



Console.Write("Введите количество строк: ");
int row = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int col = Convert.ToInt32(Console.ReadLine());

int[,] array = GenMatrixRnd(row, col, 1, 10);
int[] result = FromMatrixToArray(array);
Array.Sort(result);
int[,] Dictionary(int[] array)
{
    int amountOfLines = array.Distinct().ToArray().Length;
    int[,] result = new int[2, amountOfLines];
    // заполняем ключи словаря
    for (int i = 0; i < result.GetLength(1); i++)
    {
        result[0, i] = array.Distinct().ToArray()[i];
    }
    // заполняем значения словаря
    int currentElem = array[0];
    int positionOfvalue = 0;
    int counterOfuniqes = 1;
    for (int j = 1; j < array.Length; j++)
    {
        if (currentElem == array[j])
        {
            counterOfuniqes++;
        }
        if (currentElem != array[j] || j == array.Length - 1)
        {
            currentElem = array[j];
            result[1, positionOfvalue] = counterOfuniqes;
            counterOfuniqes = 1;
            positionOfvalue++;
        }
    }
    return result;
}


PrintMatrix(array);
Console.WriteLine();
PrintArray(result);
Console.WriteLine();
int[,] res = Dictionary(result);
PrintMatrix(res);
