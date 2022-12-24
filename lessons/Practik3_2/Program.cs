Console.Clear();

Console.WriteLine("Введите номер четверти: ");
int x = Convert.ToInt32(Console.ReadLine());

if (x < 1 | x > 4) Console.WriteLine("Неправильный номер четверти, их всего 4!");
else if (x == 1) Console.WriteLine("(x>0,y>0)");
else if (x == 2) Console.WriteLine("(x<0,y>0)");
else if (x == 3) Console.WriteLine("(x<0,y<0)");
else if (x == 4) Console.WriteLine("(x>0,y<0)");
