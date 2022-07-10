/*Задача 33: Задайте массив. Напишите программу, которая
определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
3; массив [6, 7, 19, 345, 3] -> да*/

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
    Console.WriteLine($"Сгенерированный массив из {array.Length} элементов: ");
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < array.Length - 1) Console.Write($"{array[i]} , ");
        else Console.WriteLine($"{array[i]} ]");
    }
}
bool SearchElem(int[] array, int elem)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == elem) return true;
    }
    return false;
}

void PrintRes(bool resSearch)
{
    string res =resSearch ? "Заданный элемент присутствует в массиве" : "Заданный элемент отсутствует в массиве";
    Console.WriteLine(res);
}

/*Console.Write("Введите расзмер массива: ");
int insize = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное число диапазона: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное число диапазона: ");
int max = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение элемента для поиска: ");
int elem = Convert.ToInt32(Console.ReadLine());*/


//int[] genarr = CreateArrayRndInt(insize, min, max);
int[] arr = {6, 7, 19, 345, 3};

PrintArray(arr);
bool resultSearch = SearchElem(arr, 2); 
PrintRes(resultSearch);
