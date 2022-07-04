/*Напишите программу, которая принимает на вход число (N) и выдает таблицу квадратов чисел от 1 до N.
5-> 1,4,9,16,25
2-> 1,4*/

Console.WriteLine(" Введите число для вычесления набора квадратов чисел");
int num = Convert.ToInt32(Console.ReadLine());

int count = 1;
int square;
while (count <= num)
{
    square = count * count;
    Console.WriteLine($"{count,5} -> {square, 5} ");
    count++;
}