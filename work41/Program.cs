// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел 
// больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


void CountNum(string[] Number)
{
    int count = 0;
    foreach (string el in Number)
    {
        if(int.Parse(el) > 0)
        count++;
    }
    Console.WriteLine($"Количество положительных чисел: {count}");
}
Console.WriteLine("Введите числа через запятую ");
string[] Number = (Console.ReadLine()!).Split(',');
CountNum(Number);


