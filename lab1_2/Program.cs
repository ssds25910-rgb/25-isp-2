try
{
    Console.WriteLine("Введите Длину отрезка a");
    int a = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите Длину отрезка b");
    int b = int.Parse(Console.ReadLine());
    int d = a / b;
    Console.WriteLine($"Количество отрезков:{d}");

}
catch (Exception ez)
{ Console.WriteLine(ez.Message); }
