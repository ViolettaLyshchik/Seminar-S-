/*Задача 67: Напишите программу, которая будет принимать на вход число и
возвращать сумму его цифр.
453 -> 12
45 -> 9*/
Console.Clear();
Console.Write("Задайте число : ");
int num = int.Parse(Console.ReadLine());
int sum = SumNum(num, 0);
Console.WriteLine(sum);


int SumNum(int num, int sum)
{
    sum += num % 10;
    if (num / 10 == 0) return sum;
    else return SumNum(num / 10, sum);
}