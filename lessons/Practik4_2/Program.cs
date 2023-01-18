// array double
Console.Clear();
Console.WriteLine("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
double[] array = new double[n];
for (int i = 0; i < array.Length; i++)
    array[i] = Math.Round(new Random().NextDouble() * (50 - 10) + 10, 2);
Console.WriteLine($"[{string.Join(" ; ", array)}]");
