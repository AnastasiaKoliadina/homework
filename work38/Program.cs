// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным 
// и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Write("Введите массив [");
double[] CreatArray()
{
double[] array = new double[8];
for (int i = 0; i < array.Length; i++)
{
array[i] = Math.Round(new Random().NextDouble(), 2);
Console.Write($"{array[i]}");
Console.Write( " ");
}
Console.Write("]\n");
return array;
}
void DifNum(double[] arr)
{
    double Max = arr[0];
    double Min = arr[0];
    for(int i = 0; i< arr.Length;i++)
    {
      if (arr[i] > Max)
      {
        Max = arr[i];
      }
      else if (arr[i] < Min) 
      Min = arr[i];
    }
     //else if (arr[i < Min]) Min = arr[i];
    Console.WriteLine($"Максимальное число {Max}");
    Console.WriteLine($"Минимальное число {Min}");
Console.WriteLine($"Разница Max и Min: {Math.Round(Max-Min, 2)}");
}
  DifNum(CreatArray());
