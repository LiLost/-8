// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] GetArray1(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];

    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }

    return result;
}

void PrintArray1(int[,] inArray1)
{
    for (int i = 0; i < inArray1.GetLength(0); i++)
    {
        for (int j = 0; j < inArray1.GetLength(1); j++)
        {
            Console.Write($"{inArray1[i, j]}\t ");
        }
        Console.WriteLine();
    }
}

int[,] GetArray2(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];

    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }

    return result;
}

void PrintArray2(int[,] inArray2)
{
    for (int i = 0; i < inArray2.GetLength(0); i++)
    {
        for (int j = 0; j < inArray2.GetLength(1); j++)
        {
            Console.Write($"{inArray2[i, j]}\t ");
        }
        Console.WriteLine();
    }
}

int[,] SortArray(int[,] inArray1, int[,] inArray2)
{
    int[,] result = new int[inArray1.GetLength(0), inArray2.GetLength(1)];

        for (int i = 0; i < result.GetLength(0); i++)
        {
            for (int j = 0; j < result.GetLength(1); j++)
            {
                int sum = 0;
                for (int k = 0; k < inArray1.GetLength(1); k++)
                {
                    sum += inArray1[i, k] * inArray2[k, j];
                }
                result[i, j] = sum;
            }
        }
        Console.WriteLine("Произведение этих двух матриц равно:");
        return result;
    }

    Console.Clear();
    Console.Write("Введите количество строк в массиве: ");
    int row1 = int.Parse(Console.ReadLine()!);
    Console.Write("Введите количество столбцов в массиве: ");
    int columns1 = int.Parse(Console.ReadLine()!);

    int[,] array1 = GetArray1(row1, columns1, 1, 10);
    PrintArray1(array1);
    Console.WriteLine();


    Console.Write("Введите количество строк в массиве: ");
    int row2 = int.Parse(Console.ReadLine()!);
    Console.Write("Введите количество столбцов в массиве: ");
    int columns2 = int.Parse(Console.ReadLine()!);

    int[,] array2 = GetArray2(row2, columns2, 1, 10);
    PrintArray2(array2);
    Console.WriteLine();

    PrintArray2(SortArray(array1, array2));