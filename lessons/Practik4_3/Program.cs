// function
// Вывести наибольшее число из двух

int test(int a, int b)
{
    if(a > b)
        return a;
    return b;
}

Console.Clear();
int n = Convert.ToInt32(Console.ReadLine());
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(test(n , m));



