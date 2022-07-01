Console.WriteLine("Проверим рабочий или выходной день. Введите число от 1 до 7:  ");
int dayNum = Convert.ToInt32(Console.ReadLine());
while (dayNum > 7)
{
    Console.Write("Введено число не соответствующее дню недели. Введите число от 1 до 7: ");
    dayNum = Convert.ToInt32(Console.ReadLine());
}

if (dayNum >= 1 && dayNum <= 5)
{
    Console.Write("Рабочий день");
}
else
{
    Console.Write(" Выходной ");
}
