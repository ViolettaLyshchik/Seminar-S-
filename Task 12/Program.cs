﻿/* 12 Напишите программу, которая будет принимать на вход два чила 
и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1,
топрограмма выводит остаток от деления.
31,5 -> не кратно,остаток 4
16, 4-> кратно*/

Console.Write("Проверим, является ли второе чисто кратным первому. Введите первое число: ");
int first = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int second = Convert.ToInt32(Console.ReadLine());

if (first % second == 0) Console.Write($"Первое число {first} кратно числу {second}");
else Console.Write($"Число {first} НЕ кратно {second}. Остаток от деления {first % second}");
