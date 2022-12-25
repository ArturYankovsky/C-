Console.Clear();

//Console.WriteLine("Введите пятизначное число: ");
//string n = Console.ReadLine();

//if (n.Length == 5){
    //if (n[1] == n[5] && n[2] == n[4]) Console.WriteLine("Да");
   // else Console.WriteLine("Нет");

//else Console.WriteLine("Вы ввели не пятизначное число!");

Console.WriteLine("Введите пятизначное число: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a / 100000 == 0 && a / 10000 != 0){
    int a1 = a / 10000;
    int a2 = a % 10;
    int a3 = a / 1000;
    int a4 = a3 % 10;
    int a5 = a % 100;
    int a6 = a5 / 10;
    if (a1 == a2 && a4 == a6) Console.WriteLine ("Да");
    else Console.WriteLine("Нет");
}
else Console.WriteLine ("Вы ввели не пятизначное число!");