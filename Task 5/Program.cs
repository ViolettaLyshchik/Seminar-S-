//Целые числа от -N до N
Console.Write ("Введите целое число");
int number = Convert.ToInt32(Console.ReadLine());
for (int index = -number; index <= number; index++)
{
    Console.Write($"{index} ");
}
