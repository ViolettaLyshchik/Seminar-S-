﻿/*Задача 42: Напишите программу, которая будет преобразовывать
десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10*/


/* ПЕРВЫЙ СПОСОБ
Console.Write("Введите деятичное число для преобразования в двоичное число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите основание системы счисления: ");
int baseNum = Convert.ToInt32(Console.ReadLine());

int d10 = 1;// переменная для разворота записи результата
int result = 0;
while (number != 0)
{
    result = result + number % baseNum * d10;
    number = number / baseNum;
    d10 = d10 = 10;
}
Console.WriteLine(result);*/

int a = 13;
void ToBin(int n)
{
    if (n == 0) return;
    ToBin(n / 2);
    Console.Write(n % 2);
}
ToBin(a);