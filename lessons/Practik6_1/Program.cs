int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();

foreach (int i in size)
    Console.WriteLine(i);