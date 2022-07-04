/*Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/
Console.WriteLine("Программа выведе таблицу кубов чисел от 1 до N");
Console.WriteLine(" Введите число для вычесления набора кубов чисел");
int num = Convert.ToInt32(Console.ReadLine());

int count = 1;
int square;
while (count <= num)
{
    square = count * count * count;
    Console.WriteLine($"{count,5} -> {square, 6} ");
    count++;
}