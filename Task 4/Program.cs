// Напишите программу которая принимает на вход три числа, и выдает максимальное из этих чисел
Console.Write("Проверим, какое число из трех максимальное. Введите первое число: ");
int first = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int second = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число: ");
int third = Convert.ToInt32(Console.ReadLine());

int max = first;

if (first > max) max = first;
if (second > max) max = second;
if (third > max) max = third;

Console.WriteLine($"Максимальное число:  {max}");