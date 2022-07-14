/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

-1, -7, 567, 89, 223-> 3*/

Console.WriteLine("Количество чисел больше нуля");
Console.Write($"Введите количество чисел: ");
int num = Convert.ToInt32(Console.ReadLine());
int[] arrayNumber = new int[num];

void InputNumbers(int num)
{
for (int i = 0; i < num; i++)
  {
    Console.Write($"Введите {i+1} число: ");
    arrayNumber[i] = Convert.ToInt32(Console.ReadLine());
  }
}


int EvenNum(int[] arrayNumber)
{
  int count = 0;
  for (int i = 0; i < arrayNumber.Length; i++)
  {
    if(arrayNumber[i] > 0 ) 
    count ++; 
  }
  return count;
}

InputNumbers(num);

Console.WriteLine($"Количество чисел > 0 = {EvenNum(arrayNumber)} ");