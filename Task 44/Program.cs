/*Задача 44: Не используя рекурсию, выведите первые N чисел
Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8*/

Console.Write("Число фибоначи: ");
int n = Convert.ToInt32(Console.ReadLine());

int first = 0;
int second = 1;
int fibonachi = 0;
 Console.Write($"{first}  ");
Console.Write($"{second}  ");
for (int i = 2; i < n; i++)
{
    fibonachi = first+second;
    Console.Write($"{fibonachi}  ");
    first= second;
    second =fibonachi;
}
