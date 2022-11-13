// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];

    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }

    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}\t ");
        }
        Console.WriteLine();
    }
}

void SortArray(int[,] array)
{
    if (array.GetLength(0) != array.GetLength(1))
    {
        int sum;
        int minSum = 0;
        int result = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            minSum += array[0, j];
        }
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum = 0;
            for (int j = 0; j < array.GetLength(1); j++)
            {
                sum += array[i, j];
            }
            if (sum < minSum)
            {
                minSum = sum;
                result = i;
            }
        }
        Console.WriteLine($"Строка с наименьшей суммой: {result}");
    }
    else
    {
        Console.WriteLine("Это не прямоугольник");
    }
}



Console.Clear();
Console.Write("Введите количество строк в массиве: ");
int i = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов в массиве: ");
int j = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(i, j, 1, 10);
PrintArray(array);
Console.WriteLine();
SortArray(array);
