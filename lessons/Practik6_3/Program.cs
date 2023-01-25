// **Задача 39:** Напишите программу, которая перевернёт одномерный массив
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)

// [1 2 3 4 5] -> [5 4 3 2 1]

// [6 7 3 6] -> [6 3 7 6]

void input_array(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(1, 11);
}

void release(int[] array)
{
    for(int i = 0; i < array.Length / 2; i++)
    {
        int temp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = temp;

    }
}

Console.Clear();
Console.Write("Введите кол-во элементов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
input_array(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
release(array);
Console.WriteLine($"Конечный массив: [{string.Join(", ", array)}]");