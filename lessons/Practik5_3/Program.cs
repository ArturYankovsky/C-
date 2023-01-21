// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
//4; массив [6, 7, 19, 345, 3] -> нет
//-3; массив [6, 7, 19, 345, 3] -> да

void input_array(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-9, 10);
}

string poisk(int[] array)
{
    Console.WriteLine("Введите число для поиска: ");
    int m = Convert.ToInt32(Console.ReadLine());
    for(int i = 0; i < array.Length; i++)
        if(m == array[i])
            return "да";
    return "нет";
}

Console.Clear();
Console.Write("Введите кол-во элементов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
input_array(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
Console.WriteLine(poisk(array));
