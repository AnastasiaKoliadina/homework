// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Write("Введите массив [");
int[] CreatArray()
{
int[] array = new int[4];
for (int i = 0; i < array.Length; i++)
{
array[i] = new Random().Next(100, 1000);
Console.Write($"{array[i]}");
Console.Write( ",");
}
Console.Write("]\n");
return array;
}
void CountNum(int[] arr)
{
   int count = 0;
   foreach (int el in arr)
   {
    if (el % 2==0)
    count++;
   }
   Console.WriteLine($"Количество четных чисел {count}");
}
CountNum(CreatArray());