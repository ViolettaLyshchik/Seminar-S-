//Напишите программу,которая выводит случайное число из отрезка [10,99] и показывает наибольшую цифру числа

int rndNum = new Random().Next(10,100);
Console.WriteLine($"Случайное число из отрезка 10 - 99 => {rndNum}");

int firstDigit = rndNum / 10;
int secondDigit = rndNum % 10;
int maxDigit = 0;

if(firstDigit > secondDigit) maxDigit = firstDigit;
else maxDigit = secondDigit;

Console.WriteLine($"Наибольшая цифра числа {rndNum} => {maxDigit}");

