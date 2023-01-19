// array
Console.Clear();
Console.WriteLine("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(1,11);
    
Console.WriteLine($"[{string.Join(", ", array)}]");



