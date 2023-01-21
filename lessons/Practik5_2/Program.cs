// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
//[-4, -8, 8, 2] -> [4, 8, -8, -2]

void input_array(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-9, 10);
}

void zamena(int[] array)
{
    int sumP = 0, sumN = 0;
    for(int i = 0; i < array.Length; i++)
        if (array[i] > 0)
            array[i] *= -1;
        else
            array[i] *= -1;
   
}

Console.Clear();
Console.Write("Введите кол-во элементов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
input_array(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
zamena(array);
Console.WriteLine($"[{string.Join(", ", array)}]");

