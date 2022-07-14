/*Задача 40: Напишите программу, которая принимает на вход три
числа и проверяет, может ли существовать треугольник с сторонами
такой длины.
Теорема о неравенстве треугольника: каждая сторона треугольника
меньше суммы двух других сторон.*/


bool adle;
string answer;
Console.Write("Введите првую сторону треугольника А: ");
int a =Convert.ToInt32 (Console.ReadLine());
Console.Write("Введите првую сторону треугольника B: ");
int b = Convert.ToInt32 (Console.ReadLine());
Console.Write("Введите првую сторону треугольника C: ");
int c = Convert.ToInt32 (Console.ReadLine());

adle = ChekabilitiTriacl(a, b, c);
answer = ShowAnswer(adle);
Console.Write(answer);

bool ChekabilitiTriacl(int a, int b, int c)
{
    if (a < (b + c) && b < (a + c) && c < (a + b))
    {
        return true;
    }
    else
    {
        return false;
    }
}
string ShowAnswer(bool abiliti)
{
    if (abiliti)
    {
        return "Треугольник возможен";
    }
    else
    {
        return "Треугольник НЕ возможен";
    }
}



