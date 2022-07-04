/*Напишите программу, которая по заданному номеру четверти, показывает диапазон
возможных координат точек в этой четверти (x и y)*/

Console.WriteLine("данная программа по номеру координатной четверти выводит диапазон возможных значений X и Н ");
Console.Write("Введите четверть ");
int quarter = Convert.ToInt32(Console.ReadLine());

string Coord (int q)
{
    switch (q)
    {
        case 1:
            return "Диапазон возможных координат X > 0 и Y > 0";
           
        case 2:
            return "Диапазон возможных координат X < 0 и Y > 0";
           
        case 3:
            return "Диапазон возможных координат X < 0 и Y < 0";
           
        case 4:
            return "Диапазон возможных координат X > 0 и Y < 0";
            
        default:
            return "Dведена некоректная четверть";
            
    }

}

string result = Coord(quarter);
Console.WriteLine(result);