﻿/*
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
int i = 1;

Console.Write("Числа от 1 до " + num + " в кубе: ");

while (i <= num)
{
    Console.Write((i * i * i) + ", ");
    i++;
}