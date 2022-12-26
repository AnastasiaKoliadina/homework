// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// [1,7] -> такого числа в массиве нет ([1,7] это позиция по индексам, 1- строка и 7 -столбец)

int [,] array(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(1,10);
            Console.Write($"{result[i,j]} ");    
        }                 
        Console.WriteLine();                                         
    }
    return result;
}
void Position(int [,] matrix, int x, int y)
{
     if (x > matrix.GetLength(0)-1 || y > matrix.GetLength(1)-1)
   Console.WriteLine($"Позиции с координатами {x},{y} не существует");
        else Console.WriteLine($"Значение позиции с координатами {x},{y} = {matrix[x,y]}");
    
}

Console.WriteLine("Введите количество строк: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов: ");
int b = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите индекс строки: ");
int k = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите индекс столбца: ");
int l = int.Parse(Console.ReadLine()!);
Position(array(a,b),k,l);