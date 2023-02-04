// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 6 16
// 9 6

void InputMatrix(int[,] firstMatrix)
{
    for (int i = 0; i < firstMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < firstMatrix.GetLength(1); j++)
            firstMatrix[i, j] = new Random().Next(1, 6); // [-10, 10]
    }
}

void PrintMatrix(int[,] firstMatrix)
{
    for (int i = 0; i < firstMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < firstMatrix.GetLength(1); j++)
            Console.Write($"{firstMatrix[i, j]} \t");
        Console.WriteLine();
    }
}

void Release(int[,] firstMatrix, int[,] secondMatrix)
{
    int[,] r = new int[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];
    if (firstMatrix.GetLength(0) != secondMatrix.GetLength(0) || firstMatrix.GetLength(1) != secondMatrix.GetLength(1)) 
        Console.WriteLine ("Матрицы перемножить нельзя");
    else
        for (int i = 0; i < firstMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < secondMatrix.GetLength(0); j++)
            {
                    r[i,j] = firstMatrix[i,j] * secondMatrix[i,j];
                    Console.Write($"{r[i,j]} \t");
            }
            Console.WriteLine();
        }
}

Console.Clear();
Console.Write("Введите размер первой матрицы: ");
int[] size1 = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] firstMatrix = new int[size1[0], size1[1]];

Console.Write("Введите размер второй матрицы: ");
int[] size2 = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] secondMatrix = new int[size2[0], size2[1]];

Console.WriteLine("Первая матрица:");
InputMatrix(firstMatrix);
PrintMatrix(firstMatrix);

Console.WriteLine("Вторая матрица:");
InputMatrix(secondMatrix);
PrintMatrix(secondMatrix);

Console.WriteLine("Конечная матрица:");
Release(firstMatrix, secondMatrix);