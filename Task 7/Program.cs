//  Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа
Console.WriteLine("Программа выдает последнюю цифру трехзачного числа введенного пользователем");
Console.Write("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int answer;
while ( num < 100 || num > 999)
{
    Console.Write("Введено не трехзначное число. Введите трехзначное число: ");
    num = Convert.ToInt32(Console.ReadLine());
}
answer = num % 10;
Console.Write($"Последняя цифра числа {num}: {answer} ");