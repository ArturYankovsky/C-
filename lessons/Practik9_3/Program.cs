

string rec(int m, int n)
{
     if (n == m)
         return $"{n}";
     return rec(m, n - 1) + $" {n}";
 }

 Console.Clear();
 Console.Write("Введите первое число: ");
 int n = Convert.ToInt32(Console.ReadLine());
 Console.Write("Введите первое число: ");
 int m = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine(rec(n, m));
