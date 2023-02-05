// Написать программу, которая складывает два числа

int sum(int a, int b)
{
    if (b == 0)
        return a;
    return sum(a + 1, b - 1);
}

Console.Clear();
Console.Write("Введите первое число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int m= Convert.ToInt32(Console.ReadLine());

Console.WriteLine(sum(m, n));


