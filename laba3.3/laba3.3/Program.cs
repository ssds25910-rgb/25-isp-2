//try
//{
//    Console.Write("Введите n:");
//    int n = int.Parse(Console.ReadLine());
//    Console.Write("Введите x:");
//    double x = double.Parse(Console.ReadLine());
//    double s = 0;
//    for (int i = 1; i < n; i++)
//    {
//        s += Math.Sin((2 * i - 1) * Math.Pow(x, 2 * i - 1));
//    }
//    Console.WriteLine($"s={s:f2}");
//}
//catch (Exception e)
//{
//    Console.WriteLine(e.Message);
//}

try
{
    Console.Write("Введите n:");
    int n = int.Parse(Console.ReadLine());
    Console.Write("Введите x:");
    double x = double.Parse(Console.ReadLine());
    double s = 0;
    double t = (x - 1) / (x + 1);
    for (int i = 1; i < n; i++)
    {
        int o = 2 * i - 1; 
        s += Math.Pow(t, o) / o;
    }
    Console.WriteLine($"s={s:f4}");
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}