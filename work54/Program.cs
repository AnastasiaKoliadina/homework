//Задача 54: Задайте двумерный массив. Напишите программу, которая
// упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] NewArray(int m, int n)
{
    int[,] arr = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            arr[i, j] = new Random().Next(1,10);
            Console.Write($"{arr[i, j]} ");
        }    
        Console.WriteLine();                                                     
    }
    Console.Write("Исходный массив ");
    Console.WriteLine();
    return arr;
}

int[,] TemporaryArray(int[,] array)
{
    int m = 0;
    int[] tempArray = new int[array.GetLength(1)];
    while (m < array.GetLength(0))
    {
        for (int n = 0; n < array.GetLength(1); n++)
            tempArray[n] = array[m,n];

             Array.Sort(tempArray);
             Array.Reverse(tempArray);

        for(int n = 0; n < array.GetLength(1); n++)
            array[m,n] =tempArray[n];
        m++;
    }
    return array;
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
    Console.Write("Отсортированный массив ");
}    
 
// PrintArray(TemporaryArray(NewArray(a,b)));

Console.WriteLine("Введите количество строк: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов: ");
int b = int.Parse(Console.ReadLine()!);
PrintArray(TemporaryArray(NewArray(a,b)));




// void PrintArray(int[,] matrix)
// {
//     for (int k = 0; k < matrix.GetLength(0); k++)
//     {
//         for (int l = 0; l < matrix.GetLength(1); l++)
//         {
//             Console.Write(matrix[k, l] + " ");
//         }
//         Console.WriteLine();
//     }
// }
// void StingArr(string[] args,int row,int col)
// {
//      int[,] arr = GenerateArray(row, col);
//       Console.WriteLine("Исходный массив");
// }
//  PrintArray(arr);
