// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

Console.Write("Введите значение M:\t");
int start = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение N:\t");
int end = Convert.ToInt32(Console.ReadLine());

string OutputFromTo(int start, int end)
{
    if (start == end) return end.ToString();
    return start + " " + OutputFromTo(start + 1, end);
}
Console.Write($"Печать чисел от {start} до {end}:\n{OutputFromTo(start, end)}");