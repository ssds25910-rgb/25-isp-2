

Console.Write("Введите x");
double x = double.Parse(Console.ReadLine());
Console.Write("Введите y");
double y = double.Parse(Console.ReadLine());
Console.Write("Введите a");
double a = double.Parse(Console.ReadLine());
double G = (Math.Pow(Math.Cos(Math.Abs(y + x)), 3) - (x + y)) / (Math.Pow(Math.Atan(x + a), 4)) * (Math.Pow (x, 5));
Console.WriteLine($"G={G:f5}");