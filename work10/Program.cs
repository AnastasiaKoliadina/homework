﻿//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого
//числа.
//456 -> 5
//782 -> 8
//918 -> 1


Console.Write("Введите число N ");
int N = int.Parse(Console.ReadLine());

int number = N/10;

int x = number%10;

Console.WriteLine("Второе число:" + x);