/* Напишите программу, которая принимает на вход координаты точки (X и Y), причем
X не равен 0 и Y не равен 0 и выдает номер четверти плоскости, в которой находится эта точка.*/

Console.WriteLine("Введите координаты точки X и Y");
Console.Write("X : ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Y : ");
int y = Convert.ToInt32(Console.ReadLine());

string Quarter(int xc, int yc)
{
    
    if (xc > 0 && yc > 0) return "Первая четверть";
    if (xc < 0 && yc > 0) return "Вторая четверть";          /*метод*/
    if (xc < 0 && yc < 0) return "Третья четверть";
    if (xc > 0 && yc < 0) return "Четвертая четверть";
    return "Введны не корректные координаты";
}

string result = Quarter(x, y);
Console.WriteLine(result);
/*if (x > 0 && y > 0) Console.WriteLine("Первая четверть");
else if (x < 0 && y > 0) Console.WriteLine("Вторая четверть");
else if (x < 0 && y < 0) Console.WriteLine("Третья четверть");
else if (x > 0 && y < 0) Console.WriteLine("Четвертая четверть");
else Console.WriteLine("Введны не корректные координаты");*/

/*string Quarter(int xc, int yc)
{
    string result = "";
    if (x > 0 && y > 0) return "Первая четверть";
    if (x < 0 && y > 0) return "Вторая четверть";
    if (x < 0 && y < 0) return "Третья четверть";
    if (x > 0 && y < 0) return "Четвертая четверть";
    return "Введны не корректные координаты";
}*/

