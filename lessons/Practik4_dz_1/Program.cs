Console.Clear();

Console.WriteLine("Введите два числа: ");
int n = Convert.ToInt32(Console.ReadLine());
int m = Convert.ToInt32(Console.ReadLine());
int proizv = 1;
for(int i = 1; i <= m; i++)
{
    proizv = proizv * n;
}

Console.Write(proizv);
