// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


int SumDigNumber(int number)
{
    int sum = 0;
while(number>0)
{
     int N = number % 10;
     sum = sum + N;
     number = number / 10;
}
return sum;
}
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
Console.Write($"Сумма цифр в числе {n}= {SumDigNumber(n)}");

