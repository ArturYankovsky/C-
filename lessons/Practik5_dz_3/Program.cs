// Задача 38: Задайте массив чисел. Найдите разницу между максимальным и минимальным элементов массива.

//[3 7 22 2 78] -> 76

void input_array(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(1, 11);
}

void Razn(int[] array)
{
    int max = 0; int min = 0; int razn = 0;
        for (int j = 1; j < array.Length - 1; j++)
        {
            if(array[j] > array[max]) max = j;
            else
                if(array[j] < array[min]) min = j;
        }
    razn = array[max] - array[min];
    Console.WriteLine(razn);
    
    
}

Console.Clear();
Console.Write("Введите кол-во элементов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
input_array(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
Razn(array);