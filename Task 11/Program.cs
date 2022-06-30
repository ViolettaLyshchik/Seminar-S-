/* 11. напишите программу, которое выводит случайное трехзначное число и удаляет вторую цифру этого числа
456->46
782->72*/

Console.WriteLine("Программа выдает  цифру трехзачного числа введенного пользователем");
Console.Write("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
while ( num < 100 || num > 999)
{
    Console.Write("Введено не трехзначное число. Введите трехзначное число: ");
    num = Convert.ToInt32(Console.ReadLine());
}
 int firstDigit = (num / 100) * 10;      //или в одну строку
 int thirdDidit = (num % 10);            //записать
 int result = firstDigit + thirdDidit;   //
 Console.WriteLine($"Полученное двухзначное число: {result}");              //Console.WritLine(nam / 100 * 10 + num % 10);

 
