Console.Clear();

Console.WriteLine("Введите число от 1 до 7: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a < 1 | a > 7) Console.WriteLine ("Вы ввели цифру не из диапазона!");
else{
    if (a == 6 | a == 7) Console.WriteLine("Да");
    else Console.WriteLine("Нет");
}