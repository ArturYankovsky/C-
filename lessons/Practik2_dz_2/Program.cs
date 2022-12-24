Console.Clear();

Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int i = a;
int i1 = 0;

if (a / 100 == 0) Console.WriteLine("третьей цифры нет");
else {
    while (i / 1000 != 0){
        i = i / 10;
    }
i1 = i % 10;
Console.WriteLine(i1);}
