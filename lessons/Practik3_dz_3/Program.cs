Console.Clear();

Console.WriteLine("Введите N: ");
int N = Convert.ToInt32(Console.ReadLine());
int a = 0;

for (int i = 1; i <= N; i++){
    a = i * i * i;
    Console.Write(a + " ");
}

