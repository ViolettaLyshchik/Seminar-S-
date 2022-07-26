/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/
Console.Clear();
Console.Write("Задайте число M: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Задайте число N: ");
int n = int.Parse(Console.ReadLine());
int sum=0;
int temp = m;

if (m > n)
{
    m = n;
    n = temp;
}

SumElements(m, n, temp=0);

void SumElements(int m, int n, int sum)
{
    sum = sum + n;
    if (n <= m)
    {
        Console.Write($"Сумма элементов= {sum} ");
        return;
    }
    SumElements(m, n - 1, sum);
}

