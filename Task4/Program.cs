/*
Задача 8  Напише программу, которая на вход принимаем число (N), а на выходе показывает  все четные числа от 1 до N
Пример:
5 -> 2, 4
8 -> 2, 4, 6, 8
*/

﻿Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int even = 2;

while (num >= even)
{
    Console.Write(even + " ");
    even = even + 2;
}