// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку 
// с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов:
// 1 строка

int[,] Array(int m, int n, int minValue,int maxValue)
{
    int[,] arr = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            arr[i, j] = new Random().Next(minValue,maxValue);
        }                                                         
    }
    return arr;
}
void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i,j] + " ");
        }
        Console.WriteLine();
    }
}
void SumMinRow(int[,] table)
{
    int minRowSum = int.MaxValue, indexMinRow = 0;
    for (int i = 0; i < table.GetLength(0); i++)
         {
             int rowSum = 0;
             for (int j = 0; j < table.GetLength(1); j++)
            {
                rowSum += table[i, j];
                
            if (rowSum < minRowSum)
                {
                    minRowSum = rowSum;
                    indexMinRow = i + 1;
                }
             }
}
Console.WriteLine($"Строка с наиманьшей суммой {indexMinRow}");
}
Console.Write("Введите количество строк в матрице: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов в матрице: ");
int columns = int.Parse(Console.ReadLine()!);
int[,] arr = Array(row,columns,0,10);
PrintArray(arr);
SumMinRow(arr);
