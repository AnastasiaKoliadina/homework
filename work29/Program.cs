// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int [] СreatArray()
{
    int[] array = new int [8];
    for(int i = 0; i<8; i++)
    {
    array[i] = new Random().Next(0, 100);
    }
    return array;
}
void PrintRandArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i<7; i++)
Console.Write(arr[i] + ",");
Console.Write(arr[7] + "]");
}
PrintRandArray(СreatArray());

//Еще один способ решения задачи.
//старайтесь избегать магических чисел, например в задаче 29 вместо 8 и 7 можно заменить на:
int[] СreatArray()
{
int[] array = new int[8];
for (int i = 0; i < array.Length; i++)
{
array[i] = new Random().Next(0, 100);
}
return array;
}
void PrintRandArray(int[] arr)
{
Console.Write("[");
for (int i = 0; i < arr.Length - 1; i++)
Console.Write(arr[i] + ",");
Console.Write(arr[arr.Length - 1] + "]");
}
PrintRandArray(СreatArray());