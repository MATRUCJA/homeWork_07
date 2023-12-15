//Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

Console.Write("Введите размер массива:\t");
int n = Convert.ToInt32(Console.ReadLine());

int[] CreateArray(int size)//создание массива
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(1, 100);
    }
    return array;
}
int[] array = CreateArray(n);
Console.WriteLine($"Исходный массив:\n {string.Join(" ", array)}");
int i = 0;
void ReverseArray(int[] array, int i)
{

    if (i < array.Length)
    {
        Console.Write($"{array[array.Length - i - 1]} ");
        i++;
        ReverseArray(array, i);
    }
}
Console.WriteLine($"Перевернутый массив:");
ReverseArray(array, i);

