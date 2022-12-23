// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}


Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
Console.WriteLine();

Console.WriteLine("Вводим индексы массива для поиска элемента");
Console.Write("Введите индекс строки: ");
int iRows = int.Parse(Console.ReadLine()!);
Console.Write("Введите индекс столбца: ");
int jColumns = int.Parse(Console.ReadLine()!);

if (iRows >= array.GetLength(0) || jColumns >= array.GetLength(1))
{
    Console.WriteLine("В массиве нет элемента с такими индексами");
}
else
{
    Console.WriteLine($"на строке {iRows} в столбце {jColumns} находится элемент {array[iRows, jColumns]}");
}
