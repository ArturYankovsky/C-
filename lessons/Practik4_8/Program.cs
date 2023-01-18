// Написать программу, которая заполняет массив из 8ми элементов нулями и единицами в случайном порядке.

Console.Clear();
int n = 8;
int[] array = new int[n];
for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(0,2);
Console.WriteLine($"[{string.Join(", ", array)}]");
