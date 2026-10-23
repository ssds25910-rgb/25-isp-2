
try
{
    Console.Write("Введите k:");
    int k = int.Parse(Console.ReadLine());
    double q = 1;
    for (int n = 1; n <= k; n++)
    {if (k == 3 || k == -7 || k >= 0)
        {
            double s = 0;
            if (k == 3 || k == -7) continue;
            long f = k * (k - 1);
            q += Math.Pow((k - 3), k - 5) * (k + 7) / f;
        }
    }
    Console.WriteLine($"s={q:F2}");
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
