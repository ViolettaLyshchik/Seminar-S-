/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5'-'
78 -> третьей цифры нет
32679 -> 6*/

Console.WriteLine("Программа выдает третью цифру числа введенного пользователем");
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int Third(int num)
{
    while (num >= 1000)
    {
        num = num / 10;
    }
    num = num % 10;
    return num;
}

if (num < 100) Console.Write("Третьей цифры нет");
else Console.Write($"Третья цифра числа: {Third(num)}");