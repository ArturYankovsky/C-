// procedure
Console.Clear();


void test(ref int a)
{
    a += 5;
}

int n = 0;
test(ref n);
Console.WriteLine(n);
