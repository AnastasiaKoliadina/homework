//Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

Console.Write("Введите число: ");
int X = int.Parse(Console.ReadLine()!);

int a = X % 100;
int a2 = a /10;
int a1 = a % 10;
int b = X / 1000;
int b1 = b / 10;
int b2 = b %10;
if(b1 == a1 && b2 == a2)
{
    Console.WriteLine("палиндром");
}
else
{
    Console.WriteLine("не является палиндромом");
}
