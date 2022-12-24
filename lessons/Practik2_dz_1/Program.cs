//Console.Clear();

//int n = new Random().Next(100,1000);

//int n1 = n / 10;
//int n2 = n1 % 10;

//Console.WriteLine(n);
//Console.WriteLine(n2);


Console.WriteLine("Введите трехзначное число: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a / 1000 == 0 && a / 100 != 0){
    int a1 = a % 100;
    int a2 = a1 / 10;
    Console.WriteLine(a2);
}
else Console.WriteLine ("Вы ввели не трехзначное число!");