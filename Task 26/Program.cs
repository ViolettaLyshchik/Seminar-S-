/* 26 Написать программу, которая принимает на вход число и выдает количество цифр в числе*/

Console.WriteLine("Данная программа покажет количество цифр в числе. Введите число : ");
int num = Convert.ToInt32(Console.ReadLine());

int DigitsCount (int a )
{
    int digitsCounter = 0;
    while(a !=0)
    {
        a /= 10;
        digitsCounter++;
    }
    return digitsCounter;
}
int amoundOfDigits = DigitsCount(num);
Console.Write($" Количество цифр в числе {num}  = {amoundOfDigits}");