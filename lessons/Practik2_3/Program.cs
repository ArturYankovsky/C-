Console.Clear();

Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a % 7 == 0 && a % 23 == 0){
    Console.WriteLine("да");
}
else Console.WriteLine("нет");
