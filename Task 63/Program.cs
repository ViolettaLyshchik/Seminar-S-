/*Задача 63: Задайте значение N. Напишите программу, которая выведет
все натуральные числа в промежутке от 1 до N.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6"*/

Console.Clear();
Console.Write("Задайте число: ");
int num = int.Parse(Console.ReadLine());
NaturalNumber(num);
void NaturalNumber(int num)
{
    if (num == 0) return;
    NaturalNumber(num - 1);// при престановке стоки после Cons.w ,в обратном порядке вывод
    Console.Write($"{num} ");
}