// **Задача 40:** Напишите программу, которая принимает на вход три числа и проверяет,
// может ли существовать треугольник с сторонами такой длины.


// ❗ **Теорема о неравенстве треугольника:** каждая сторона треугольника меньше суммы двух других сторон.


// **Задача 42:** Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

void InputArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
array[i] = new Random().Next(1, 11); // [1, 10]
}

string Triangle(int[] array)
{
if(array[0] < array[1] + array[2] &&
array[1] < array[0] + array[2] &&
array[2] < array[0] + array[1])
return "yes";
return "no";
}


Console.Clear();
int[] array = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
Console.WriteLine(Triangle(array));
