/* Задача 31 Задать массив из 12 элементов, заполненный случайными числами из 
промежутка [-9,9]. найти сумму отрицательных и положительных  элементов массива.*/



int[] CreateArrayRndInt(int size, int begin, int end)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(begin, end +1);

    }
    return array;
}
int[] GetSumNegPosElem(int[] array)
{
    int sumNeg = 0;
    int sumPos = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0)
        {
            sumNeg += array[i];
        }
        else
        {
            sumPos += array[i];
        }
    }
        return new[] { sumNeg, sumPos };
    
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < array.Length - 1) Console.Write(array[i] + ",");
        else Console.Write(array[i] + "]");
    }
}
int[] resArray = CreateArrayRndInt(12, -9, 9);
PrintArray(resArray);
int[] sumNegPosElem = GetSumNegPosElem(resArray);
Console.WriteLine();
Console.WriteLine($"Сумма положительных чисел = {sumNegPosElem[1]}");
Console.WriteLine($"Сумма отрицательных чисел = {sumNegPosElem[0]}");

