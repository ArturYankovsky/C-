//Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
//Найдите сумму отрицательных и положительных элементов массива.
//Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

void input_array(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-9, 10); //[-9; 9]
}

void release(int[] array)
{
    int sumP = 0, sumN = 0;
    for(int i = 0; i < array.Length; i++)
        if (array[i] > 0)
            sumP += array[i];
        else
            sumN += array[i];
    Console.WriteLine($"+{sumP}  {sumN}");
}

Console.Clear();
Console.Write("Введите кол-во элементов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
input_array(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
release(array);