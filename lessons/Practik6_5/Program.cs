// **Задача 42:** Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.Clear();
int n = Convert.ToInt32(Console.ReadLine());
string res = "";
while(n > 0)
{
res = Convert.ToString(n % 2) + res;
n /= 2;
}
Console.WriteLine(res);