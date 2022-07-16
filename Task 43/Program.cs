/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/

Console.WriteLine("Tочкa пересечения двух прямых");

double[,] coef = new double[2,2]; // 2мерный массив для отрезков
double[] crossPoint = new double[2];// точка пересечеия

void InputCoef() // метод получения коофициентов k1,b1,K2,b2 от пользователя
{
    for (int i = 0; i < coef.GetLength(0); i++)
    {
        Console.Write($"Введите коэффициенты {i + 1}-го уравнения (y = k * x + b): ");
        for (int j = 0; j < coef.GetLength(1); j++)
        {
            if (j == 0) Console.Write($"Введите коэффициент k: ");
            else Console.Write($"Введите коэффициент b: ");
            coef[i, j] = Convert.ToInt32(Console.ReadLine());
        }
    }
}

double[] Decision(double[,] coef)
{
    crossPoint[0] = (coef[1, 1] - coef[0, 1]) / (coef[0, 0] - coef[1, 0]);   //решение с иннета 
    crossPoint[1] = crossPoint[0] * coef[0, 0] + coef[0, 1];
    return crossPoint;
}

void OutputResponse(double[,] coef)
{
    if (coef[0, 0] == coef[1, 0] && coef[0, 1] == coef[1, 1])
    {
        Console.Write($"Прямые совпадают");
    }
    else if (coef[0, 0] == coef[1, 0] && coef[0, 1] != coef[1, 1])
    {
        Console.Write($"Прямые параллельны");
    }
    else
    {
        Decision(coef);
        Console.Write($"Точка пересечения прямых: ({crossPoint[0]}, {crossPoint[1]})");
    }
}

InputCoef();
OutputResponse(coef);




