// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в 
// каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] GetArray(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(1,10);
            Console.Write($"{result[i, j]} ");
        }    
        Console.WriteLine();                                                     
    }
    return result;
}
void AverageSumNum(int[,] arr)
{
    for(int j = 0; j < arr.GetLength(1); j++)
    {
        double Sum = 0;
        for (int i = 0; i< arr.GetLength(0); i++)
        {
            Sum = Sum+ arr[i,j];
        }
        double averegeSum = Math.Round(Sum/arr.GetLength(0),1);
        Console.Write($"{Sum/arr.GetLength(0)} " +"");
    }

}

Console.WriteLine("Введите количество строк: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов: ");
int b = int.Parse(Console.ReadLine()!);
AverageSumNum(GetArray(a, b));