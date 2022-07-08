// 24 Напишите программу, которая принимает на вход число (А) и выдает сумму чисел от 1 до А
Console.WriteLine("Данная программа посчитает сумму чисел о 1 до a");
Console.WriteLine("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());

/*int sum = 0;

for (int i = 1; i <= a ; i++)
{
    sum=sum +i;
    if (i<a)
    {
        Console.Write($"{i} + ");
    }
    else
    {
        Console.Write($"{i} =  ");
    }
}
Console.WriteLine($"Сумма чисел от 1 до {a} = {sum}");*/

int Sum(int num)
{
    int sum = 0;

    for (int i = 1; i <= a; i++)
    {
        sum = sum + i;
    }
    return sum;
}

int res = Sum(a);
Console.WriteLine($"Сумма чисел от 1 до {a} = {res}");
