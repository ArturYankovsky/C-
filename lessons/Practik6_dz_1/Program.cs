//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

//0, 7, 8, -2, -2 -> 2

//1, -7, 567, 89, 223-> 3

Console.Clear();
Console.WriteLine("Введите числа через пробел: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int m = 0;

for(int i = 0; i < size.Length; i++)
{
    if(size[i] > 0) m = m + 1;
}

Console.WriteLine($"{"Количество чисел больше нуля: "}{m}"); 