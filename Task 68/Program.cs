/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 3, n = 2 -> A(m,n) = 29*/

Console.Clear();
Console.Write("Задайте число M: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Задайте число N: ");
int n = int.Parse(Console.ReadLine());

int RecursionAkk(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return RecursionAkk(m - 1, 1);
    }
    else
    {
        return RecursionAkk(m - 1, RecursionAkk(m, n - 1));
    }
}
Console.WriteLine(RecursionAkk(m, n));


