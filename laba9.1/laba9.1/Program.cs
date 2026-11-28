class ComplexNumber
{
    public double Real 
    { get; set; }
    public double Imaginary { get; set; }
    private ComplexNumber(double real, double imaginary)
    {
        Real = real;
        Imaginary = imaginary;
    }
    private ComplexNumber MultiplyByScalar(double number)
    {
        return new ComplexNumber(Real * number, Imaginary * number);
    }
    private double GetArgument()
    {
        double radians = Math.Atan2(Imaginary, Real);
        return radians * (180.0 / Math.PI);
    }

    private string GetInfo()
    {
        string sign = Imaginary >= 0 ? "+" : "-";
        return $"{Real} {sign} {Math.Abs(Imaginary)}i";
    }
    static void Main()
    {
        Console.Write("Введите действительную часть комплексного числа: ");
        double real = double.Parse(Console.ReadLine());

        Console.Write("Введите мнимую часть комплексного числа: ");
        double imag = double.Parse(Console.ReadLine());

        ComplexNumber z = new ComplexNumber(real, imag);
        Console.WriteLine($"Исходное число: {z.GetInfo()}");

        double angle = z.GetArgument();
        Console.WriteLine($"Аргумент числа: {angle:F2}°");

        Console.Write("Введите число для умножения: ");
        double factor = double.Parse(Console.ReadLine());

        ComplexNumber result = z.MultiplyByScalar(factor);
        Console.WriteLine($"Результат умножения: {result.GetInfo()}");
    }
}

