//Задача 2 программа принимает на вход 2 числа, и выдает какое больше,какое меньше

Console.Write("Проверим, какое число больше, а какое меньше. Введите первое число: ");
int first = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int second = Convert.ToInt32(Console.ReadLine());

if (first > second)
{
    Console.WriteLine($"Число {first}, больше числа {second} :{first} > {second}");
}
else
{
    Console.WriteLine($"Число {second} больше числа {first} :{second} > {first}");
}
