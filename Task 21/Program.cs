/*Задача. Написать программу, которая принимает на вход координаты двух точек
и находит расстояние мнжду ними в 3D пространстве*/
Console.WriteLine("Программа по координатам двух точек выводит расстояние между ними в 3D пространстве");
Console.WriteLine("Введите координаты точки А");
Console.Write("X: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Z: ");
int z1 = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Введите координаты точки B ");
Console.Write("X: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Z: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double Distans(int xt1, int yt1, int xt2, int yt2, int zt1, int zt2)
{
   
    double result = 0.0;
    result = Math.Sqrt(Math.Pow(x2 - x1,2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 -z1,2));
    return Math.Round(result, 2);
}

double result = Distans(x1, y1, z1, x2, y2, z2);
Console.WriteLine($"Расстояние между точкой А и В: {result}");
