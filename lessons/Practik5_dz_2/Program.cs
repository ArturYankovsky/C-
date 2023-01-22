// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

//[3, 7, 23, 12] -> 19

//[-4, -6, 89, 6] -> 0

void input_array(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(0, 11);
}

int release(int[] array)
{
    int c = 0; 
    for(int i = 0; i < array.Length; i = i + 2)
        c = c + array[i];
    return c;
}

Console.Clear();
Console.Write("Введите кол-во элементов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
input_array(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
Console.WriteLine(release(array));