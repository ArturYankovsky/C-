Console.Clear();

int[] array = new int[8];

Console.Write("Введите элементы массива: ");
int n = Convert.ToInt32(Console.ReadLine());

int i = 7;

while(n > 0)
    {
        int a = n % 10;
        array[i] = a;
        n = n / 10;
        i--;
    }
    
Console.WriteLine($"[{string.Join(", ", array)}]");
