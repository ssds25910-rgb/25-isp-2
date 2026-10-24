Console.WriteLine("|        x       |       y      |");
Console.WriteLine("---------------------------------");
for (double x = -1; x <= 2; x += 0.2)
{
    double y;
    if (x > 0)
    {
        y = 0;
        double factorial = 1;
        
        for (int k = 1; k <= 5; k++)
        {
            factorial *= k; 
            y += Math.Pow(x, k) / factorial;
        }
    
    }
    else
    {
        y = Math.Atan(Math.Pow(Math.PI, x));
    }
    Console.WriteLine($"|      {x:f1}      |      {y:f4}   |");
}
Console.WriteLine("--------------------------------");