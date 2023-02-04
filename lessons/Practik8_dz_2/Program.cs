// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(0, 6); // [-10, 10]
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} \t");
        Console.WriteLine();
    }
}

void Release(int[,] matrix, int[] array)
{
    int sum = 0;
    int sum2 = 0;
    int k = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {   
            sum2 += matrix[i, j];
        }
        sum = sum2; 
        array[k] = sum;
        sum2 = 0;
        k++;
    }
    int min = array[0], index = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (min > array[i])
        {
            min = array[i];
            index = i;
        } 
    }
    Console.WriteLine($"{"Наименьшая сумма в строке: "}{index + 1}");
}

Console.Clear();
Console.Write("Введите размер матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[] array = new int[size[0]];
int[,] matrix = new int[size[0], size[1]];
Console.WriteLine("Начальный матрица:");
InputMatrix(matrix);
PrintMatrix(matrix);

Release(matrix, array);