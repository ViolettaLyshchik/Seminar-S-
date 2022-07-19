/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/
/*формулы
X=(b2-b1)/(k1-k2)
Y = (x*k1+b1)

 (k1-k2) если знаменатель равно 0 прямые перпендикулярны 
(1+k1*k2)
k1==k2&& b1 != b2 пряямые паралельны
k1==k2 && b1==b2 прямые совпадают*/




Console.WriteLine("Tочкa пересечения двух прямых");

double[,] coef = new double[2, 2]; // 2мерный массив для отрезков
double[] crossPoint = new double[2];// точка пересечеия xy

void InputValue() // метод получения коофициентов k1,b1,K2,b2 от пользователя заполняя массив
{
    for (int i = 0; i < coef.GetLength(0); i++)
    {
        Console.Write($"Введите значения для {i + 1}-го уравнения (y = k * x + b): ");
        for (int j = 0; j < coef.GetLength(1); j++)
        {
            if (j == 0) Console.Write("Введите значене k: ");
            else Console.Write("Введите значение b: ");
            coef[i, j] = Convert.ToInt32(Console.ReadLine());
        }
    }
}

double[] CroossPoint(double[,] coef)
{
    crossPoint[0] = (coef[1, 1] - coef[0, 1]) / (coef[0, 0] - coef[1, 0]); // X=(b2-b1)/(k1-k2)
    crossPoint[1] = crossPoint[0] * coef[0, 0] + coef[0, 1]; //Y = (x*k1+b1)
    return crossPoint;
}

void Output(double[,] coef)
{

    if (coef[0, 0] == coef[1, 0] && coef[0, 1] == coef[1, 1]) // k1==k2 && b1==b2
    {
        Console.Write("Прямые совпадают, и имеют множество точек пересечения");

    }
    else if (coef[0, 0] == coef[1, 0] && coef[0, 1] != coef[1, 1])//k1==k2&& b1 не равно b2
    {
        Console.Write("Прямые параллельны, точек пересечения нет");
    }
    else if (1 + coef[0, 0] * coef[1, 0] == 0) //формула нахождения угла   (k1-k2) / ((1+k1*k2)если равно 0 то прямые перпендикулярны)

    {
        CroossPoint(coef);
        Console.Write($"Прямые перпендикулярны.Точка пересечения прямых: ({crossPoint[0]}, {crossPoint[1]})");
    }
    else
    {
        CroossPoint(coef);
        Console.Write($"Точка пересечения прямых: ({crossPoint[0]}, {crossPoint[1]})");
    }
}

InputValue();
Output(coef);



