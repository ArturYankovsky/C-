Console.Clear();

int n = new Random().Next(100,1000);
int n1 = n / 100;
int n2 = n % 10;
Console.WriteLine(n);


Console.WriteLine($"{n1}{n2}");