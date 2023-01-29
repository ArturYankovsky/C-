//Задача 57: Составить частотный словарь элементов двумерного массива. 
//Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.


bool check(int[] array, int n)
{
    for (int i = 0;i < array.Length; i++)
    {
        if (array[i] == n)
            return false;
    }
    return true;
}

int InputMatrix(int[,] matrix, int[] array)
{
    int k = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 11); // [-10, 10]
            Console.Write($"{matrix[i, j]} \t");
            if (check(array, matrix[i,j]))
            {
                array[k] = matrix[i,j];
                k++;
            }
        }
        Console.WriteLine();
    }
    return k;
}

void Release(int[,] matrix, int [] array, int array_len)
{
    for (int k = 0; k <= array_len; k++)
    {
        int count = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (array[k] == matrix[i,j])
                count++;
            }
        }
        Console.WriteLine($"Элемент {array[k]} - {count} раз");
    }
}

Console.Clear();
Console.Write("Введите размер матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[] array = new int[size[0] * size[1]];
// size[0] - row
// size[1] - column
int[,] matrix = new int[size[0], size[1]];
Console.WriteLine("Начальный матрица:");
int k = InputMatrix(matrix, array);
Release(matrix, array, k);

// Console.WriteLine("Конечная матрица:");
// PrintMatrix(Release(matrix));


