// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу,
// которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 11); // [1, 10]
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

void Release(int[,] matrix)
{
    int min_v = matrix[0, 0], min_row = 0, min_col = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if( min_v > matrix[i,j])
            {
                min_v = matrix[i,j];
                min_row = i;
                min_col = j;
            }
        }
    }
    Console.WriteLine($"{min_v} ({min_row};{min_col})");

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        if (i != min_row) {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j != min_col)
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
    }
}

Console.Clear();
Console.Write("Введите размер матрицы: ");
int[] coord = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[coord[0], coord[1]];
Console.WriteLine("Начальный массив");
InputMatrix(matrix);
Console.WriteLine("Конечный массив");
Release(matrix);