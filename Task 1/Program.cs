Console.Write("Проверим, является ли первое чисто квадратом второго. Введите первое число: ");
int first = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int second = Convert.ToInt32(Console.ReadLine());

if (second * second == first)
{
    Console.WriteLine($"Да, первое число, является квадратом второго {second} * {second} = {first}");
}
else
{
    Console.WriteLine($"Нет, первое число не является квадратом второго {second} * {second} != {first}");
}

