﻿/*Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/

Console.Clear();
Console.Write("Программа выведет все натуральные числа в промежутке от N до 1. ");
Console.Write("Задайте число N: ");
int num= int.Parse(Console.ReadLine());
NaturalNumber(num);
void NaturalNumber(int num)
{
    if (num == 0) return;
     Console.Write($"{num} ");
    NaturalNumber(num - 1);// при престановке стоки после Cons.w ,в обратном порядке вывод
    
}