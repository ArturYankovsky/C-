Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

for (int i = 2; i <= a; i = i + 2)
{
    Console.Write(i + " ");
}