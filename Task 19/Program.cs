/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/
Console.WriteLine("Программа проверяет, является ли число палиндромом");
Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
while (number < 10000 || number > 99999)
{
    Console.Write("Введено не пятизначное число. Введите пятизначное  число: ");
    number = Convert.ToInt32(Console.ReadLine());
}
int pal = 0;
int num = number;

while (number > 0)
{
    pal = pal * 10 + number % 10;
    number /= 10;
}
Console.WriteLine(num == pal ? "число является палиндромом " : "число не является палиндромом ");