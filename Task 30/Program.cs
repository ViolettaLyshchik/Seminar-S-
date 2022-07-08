// 30 Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке

/*int[] array = new int[8];
int len = array.Length;
int index = 0;
/*Random rnd = new Random();
while (index < array.Length)
{
    array[index] = rnd.Next(0, 2);
    index++;
}*/

/*for (int i = 0; i < len; i++)
{
    if (i == 0) Console.Write("[");
    if (i < len - 1) Console.Write(array[i] + ",");
    else Console.Write(array[i] + "]");
}*/

int[] ArrayBin(int size)
{
    int[] array = new int[size];
    int index = 0;

    Random rnd = new Random();
    while (index < array.Length)
    {
        array[index] = rnd.Next(0,2);
        index++;
    }
    return array;
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
int[] resArray = ArrayBin(8);
PrintArray(resArray);





