/*адача 45: Напишите программу, которая будет создавать
копию заданного массива с помощью поэлементного
копирования.*/

int[] CreateArrayRndInt(int size, int begin, int end)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(begin, end + 1);
    }
    return array;
}
void PrintArray(int[] array)
{

    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < array.Length - 1) Console.Write(array[i] + " , ");
        else Console.WriteLine(array[i] + "]");
    }
}
int[] CopyArray(int[] array)
{
    int[] copy = new int[array.Length];
    for (int i = 0; i < copy.Length; i++)
    {
        copy[i] = array[i];
    }
    return copy;
}
int[] massive = CreateArrayRndInt(5, 1, 10);
PrintArray(massive);
int[] copymasive = CopyArray(massive);
PrintArray(copymasive);