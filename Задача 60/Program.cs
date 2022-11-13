// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] GetArray(int m, int n, int p, int minValue, int maxValue)
{
    int[,,] result = new int[m, n, p];

    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
            for (int z = 0; z < p; z++)
            {
                result[i, j, z] = new Random().Next(minValue, maxValue + 1);
            }
    return result;
}

void PrintArray(int[,,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int z = 0; z < inArray.GetLength(2); z++)
            {
                Console.Write($"{inArray[i, j, z]}\t ");
            }
            Console.WriteLine();
        }
    }
}

void SortArray(int[,,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int k = 0; k < inArray.GetLength(2); k++)
            {
                Console.WriteLine($"{inArray[i, j, k]} = ({j}, {k}, {i} \t ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}


Console.Clear();
Console.Write("Введите количество строк в массиве: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов в массиве: ");
int columns = int.Parse(Console.ReadLine()!);
Console.Write("Введите высоту в массиве: ");
int vesota = int.Parse(Console.ReadLine()!);

int[,,] array = GetArray(row, columns, vesota, 10, 99);

PrintArray(array);
Console.WriteLine();
SortArray(array);

