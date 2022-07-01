Console.WriteLine("Кратно ли число 7 и 23.Введите число:");

int num = Convert.ToInt32(Console.ReadLine());

if (num % 7 == 0 && num % 23 == 0)
{
    Console.Write($"{num} кратно и 7, и 23");

}
else
{
    Console.Write($"{num} не кратно 7 и 23. ");
}