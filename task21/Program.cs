Console.Clear();
Console.Write("Введите координату x точки А: ");
int xA = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату y точки А: ");
int yA = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату z точки А: ");
int zA = int.Parse(Console.ReadLine()!);

Console.Write("Введите координату x точки B: ");
int xB = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату y точки B: ");
int yB = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату z точки B: ");
int zB = int.Parse(Console.ReadLine()!);

double AB = Math.Sqrt(Math.Pow(xB - xA, 2) + Math.Pow(yB - yA, 2) + Math.Pow(zB - zA, 2));
Console.WriteLine(Math.Round(AB, 2));

// Console.WriteLine($"{AB:f2}");
// Console.WriteLine($"{AB:0.00}");
// Console.WriteLine(AB.ToString("#.00"));
