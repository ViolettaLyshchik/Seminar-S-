/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/
Console.WriteLine($"Сумма элементов массива, стоящих на нечётных позициях: ");
Console.Write($"Введите количество элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int SumOddPos(int size, int min, int max)
{
    int[] array = new int[size];
    int sumOddPos = 0;
    Console.Write("Получившийся массив: ");

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max);

        Console.Write(array[i] + " , ");

        if (i % 2 != 1)
        {
            sumOddPos += array[i];
        }
    }
    return sumOddPos;
}

int sumOddPos = SumOddPos(size, 1, 100);

Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях = {sumOddPos}");