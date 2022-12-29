// Задача 58: Задайте две матрицы. Напишите программу, которая будет
// находить произведение двух матриц.

 int [,] Array(int m,int n)
 {
    int[,] matrix = new int[m, n];
     for (int i = 0; i < matrix.GetLength(0); i++)
     {
        for (int j = 0; j < matrix.GetLength(1); j++)
          {
            matrix[i, j] = new Random().Next(1,10);
            Console.Write("{0} ", matrix[i, j]);
          }
        Console.WriteLine();
     }
     return matrix;
Console.WriteLine();
 }

void MultiMatrix(int[,] matrix1,int[,] matrix2)
{
    int[,] newMatrix =new int[matrix1.GetLength(0),matrix1.GetLength(0)];
    for (int i = 0; i < newMatrix.GetLength(0); i++)
      {
       for (int k = 0; k < newMatrix.GetLength(1); k++)
         {
         for (int j = 0; j < matrix1.GetLength(1); j++)
         {
           newMatrix[i, k] += matrix1[j, k]*matrix2[i, j];  
         }
 Console.Write("{0} ", newMatrix[i, k]);
}
    Console.WriteLine();
}
 //Console.ReadLine();
}
Console.Write("Введите количество строк в матрице1: ");
int row1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов в матрице1: ");
int columns1 = int.Parse(Console.ReadLine()!);
int[,] arr1 = Array(row1,columns1);
Console.Write("Введите количество строк в матрице2: ");
int row2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов в матрице2: ");
int columns2 = int.Parse(Console.ReadLine()!);
int[,] arr2 = Array(row2,columns2);
MultiMatrix(arr1,arr2);