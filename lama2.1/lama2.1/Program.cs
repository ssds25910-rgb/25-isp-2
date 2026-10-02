try
{
    Console.Write("Введите x - ");
    double x = double.Parse(Console.ReadLine());
    Console.Write("Введите y - ");
    double y = double.Parse(Console.ReadLine());
    bool isInside = (x >= -2) && (x <= 2) && (y >= -1) && (y >= 1);
    Console.WriteLine(isInside);
}
catch (Exception ex)
{ Console.WriteLine(ex.Message); }