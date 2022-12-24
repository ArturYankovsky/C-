Console.Clear();

Console.WriteLine("Введите координату x: ");
double x = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координату y: ");
double y = Convert.ToDouble(Console.ReadLine());

if (x > 0 && y > 0) Console.WriteLine("I");
else if (x < 0 && y > 0) Console.WriteLine("II");
else if (x < 0 && y < 0) Console.WriteLine("III");
else Console.WriteLine("IV");
