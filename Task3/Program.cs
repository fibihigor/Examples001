/*
Задача 6 Напишите программу, которая на вход принимает число и выдает, являеться ли число четным (делиться ли оно на два без остатка)
Пример:
4 -> да
- 3 -> да
7 -> да
*/

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int remain = num % 2;
if (remain == 0)
{
    Console.WriteLine("Число " + num + " четное?");
    Console.WriteLine("ДА!");
}
else
{
    Console.WriteLine("Число " + num + " четное?");
    Console.WriteLine("НЕТ!");
}