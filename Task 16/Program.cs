Console.Write("Проверим, является ли одно число квадратом другого. Введите первое число: ");
int firstNum = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int secondNum = Convert.ToInt32(Console.ReadLine());

if (firstNum * firstNum == secondNum | secondNum * secondNum == firstNum)
{
    Console.Write("Одно из чисел является квадратом другого.");
}

else
{
    Console.Write("Ни одно из чисел не является квадратом другого.");
}
