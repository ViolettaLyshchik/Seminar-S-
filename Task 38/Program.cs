/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2*/

double[] GenArrayRnd(int size)
{
    double[] array = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(1, 100);
    }
    return array;
}
void PrintArray(double[] array)
{
    Console.WriteLine($"Сгенерированный массив из {array.Length} элементов: ");
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < array.Length - 1) Console.Write($"{array[i],2} ,");
        else Console.WriteLine($"{array[i],2} ]");
    }
}
double MaxElem(double[] array)
{
    double max = array[0];

    for (int i = 1; i < array.Length; i++)
    {
        if (max < array[i])
        {
            max = array[i];
        }
    }
    return max;
}

double MinElem(double[] array)
{
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {

        if (min > array[i])
        {
            min = array[i];
        }
    }
    return min;
}
Console.WriteLine("Разница между максимальным и минимальным элементом в массиве.");
Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

double[] MyArr = GenArrayRnd(size);
PrintArray(MyArr);
double max = MaxElem(MyArr);
double min = MinElem(MyArr);
Console.WriteLine(Math.Round(max - min, 2));