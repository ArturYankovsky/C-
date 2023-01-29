// Домашняя задача 52 через массивы
//

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(0, 11); // [-10, 10]
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

double[] Release(int[,] matrix)
{
    double[] res = new double[matrix.GetLength(1)];
    for (int j = 0; j < matrix.GetLength(0); j++)
    {
        double sum = 0;
        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            sum += matrix[i,j];
        }
        res[j] = Math.Round(sum/matrix.GetLength(0), 2);
    }
    return res;
}


Console.Clear();
Console.Write("Введите размер матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
// size[0] - row
// size[1] - column
int[,] matrix = new int[size[0], size[1]];
Console.WriteLine("Начальный массив:");
InputMatrix(matrix);
PrintMatrix(matrix);

double[] res = Release(matrix);
Console.WriteLine();
Console.WriteLine(String.Join(' ', res));
