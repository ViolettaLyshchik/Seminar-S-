//Напишите программу которая принимает на вход число N и выдает произведение чисел от 1 до N

Console.WriteLine("Произведение чисел от 1 до N. Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

int Prodact(int num)
{
    int prodact = 1;

    for (int i = 1; i <= n; i++)
    {
        prodact = prodact * i;
    }
    return prodact;
}

int res = Prodact(n);
Console.WriteLine($"Произведение чисел от 1 до {n} = {res}");
