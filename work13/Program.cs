//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.Write("Введите число ");
int n = Math.Abs(int.Parse(Console.ReadLine()!));
int nTemp = n;
int count = 0;

while (nTemp>0)
{
    nTemp/=10;
    count++;
}
if (count-3>=0)
{
    int rank = (int)Math.Pow(10, count-3);
    int result = n / rank % 10;
    Console.WriteLine($"Третья цифра: {result}");
}
else
{
    Console.WriteLine("нет третьей цифры");
}