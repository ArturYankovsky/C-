// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 9
// [6 7 3 6] -> 36 21

void input_array(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-9, 10);
}

void proizv(int[] array)
{
    for(int i = 0; i <= array.Length / 2; i++)
        Console.Write($"{array[i] * array[array.Length - 1 - i]} ");
}

Console.Clear();
Console.Write("Введите кол-во элементов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
input_array(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
proizv(array);
