﻿//  Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine ("Данная программа показывает все четные числа от 1 до N");
Console.Write ("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= number; i ++) if (i % 2 == 0)
{
    Console.Write(i);
    Console.Write(" ");
}
