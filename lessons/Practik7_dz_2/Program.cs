// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

//Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(-10, 11); // [-10;10]
            Console.Write($"{matrix[i, j]} \t");
        }
    Console.WriteLine();
    }
}


int Release(int[,] matrix){
int result = 0;
int first = 0;
int second = 0;
Console.Write("Введите позицию интересующего элемента: ");
int n = Convert.ToInt32(Console.ReadLine());
first = n / 10;
second = n % 10;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (first == i && second == j)
                result = matrix[i, j];
        } 
        
    }
    if (result == 0) Console.WriteLine("Такого элемента нет в массиве");
        else Console.WriteLine(result);
    return result;
    
}


Console.Clear();
Console.Write("Введите размер матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
Console.WriteLine("Начальная матрица: ");
InputMatrix(matrix);
Console.WriteLine();
Release(matrix);


