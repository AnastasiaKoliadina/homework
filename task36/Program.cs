// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

Console.Write("Введите массив [");
int[] CreatArray()
{
int[] array = new int[7];
for (int i = 0; i < array.Length; i++)
{
array[i] = new Random().Next(-10, 100);
Console.Write($"{array[i]}");
Console.Write( ",");
}
Console.Write("]\n");
return array;
}
void SumNumbers(int[]arr)
{
   int S = 0;
   for(int i = 0; i<arr.Length; i++)
   {
    if (i % 2 != 0) S = S + arr[i];
   }
Console.WriteLine($"Сумма элементов нечетных позиций {S}");
}
SumNumbers(CreatArray());