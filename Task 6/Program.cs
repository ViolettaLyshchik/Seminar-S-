//Напишите программу, которая на вход принимает число и выдает, является ли число четным
Console.Write("Проверим, является ли число четным. Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 2 ==0)
{
    Console.WriteLine($"Число {num}, четное.");
}
else
{
    Console.WriteLine($"Число {num}, не четное.");
}

