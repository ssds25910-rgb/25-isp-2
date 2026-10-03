//try
//{
//    Console.WriteLine("Введите номер карты");
//    Console.Write("+2=10  " + "смена цвета=11  " +
//        "смена цвета +4=12");
//    int n = int.Parse(Console.ReadLine());
//    Console.WriteLine("Введите цвет карты");
//    Console.Write("красный=1" +
//        "желтый=2" +
//        "зеленый=3" +
//        "синий=4");
//    int m = int.Parse(Console.ReadLine());
//    switch (n) {
//        case 0:
//            Console.WriteLine("0");
//            break;
//        case 1:
//            Console.WriteLine("1");
//            break;
//        case 2:
//            Console.WriteLine("2");
//            break;
//        case 3:
//            Console.WriteLine("3");
//            break;
//        case 4:
//            Console.WriteLine("4");
//            break;
//        case 5:
//            Console.WriteLine("5");
//            break;
//        case 6:
//            Console.WriteLine("6");
//            break;
//        case 7:
//            Console.WriteLine("7");
//            break;
//        case 8:
//            Console.WriteLine("8");
//            break;
//        case 9:
//            Console.WriteLine("9");
//            break;
//        case 10:
//            Console.WriteLine("+2");
//            break;
//        case 11:
//            Console.WriteLine("Смена цвета");
//            break;
//        case 12:
//            Console.WriteLine("Смена цвета+4");
//            break;

//    }

//    switch (m) {
//        case 1:
//            Console.WriteLine("красный");
//            break;
//        case 2:
//            Console.WriteLine("желтый");
//            break;
//        case 3:
//            Console.WriteLine("зеленый");
//            break;
//        case 4:
//            Console.WriteLine("синий");
//            break;
//    }
//}
//catch (Exception e)
//{
//    Console.WriteLine(e.Message);
//}

//try
//{
//    Console.WriteLine("Введите баланс вашей карточки: ");
//    int n = int.Parse(Console.ReadLine());
//    int m = n % 10;
//    if ((n%100 >= 11) && (n%100 <=14))
//        Console.WriteLine($"{n} рублей");
//    else
//        switch (m)
//        {
//            case 1:
//                Console.WriteLine($"{n} рубль");
//                break;
//            case 2:
//            case 3:
//            case 4:
//                Console.WriteLine($"{n} рубля");
//                break;
//            case 0:
//            case 5:
//            case 6:
//            case 7:
//            case 8:
//            case 9:
//                Console.WriteLine($"{n} рублей");
//                break;
//        }
//}
//catch (Exception e)
//{
//    Console.WriteLine(e.Message);
//}
using System.Diagnostics.CodeAnalysis;

try
{
    Console.WriteLine("введите номер варианта");
    int n = int.Parse(Console.ReadLine());
    Console.WriteLine("введите x");
    double x = int.Parse(Console.ReadLine());
    double a = 0, b = 0, c = 0, y = 0;
    switch (n)
    {
        case 1:
            a = 3.2; b = -0.7; c = 2.2;
            break;

        case 2:
            a = 10.5; b = -2.5; c = 5.6;
            break;

        case 3:
            a = 5.4; b = 3; c = 2.6;
            break;
        default: break;
    }
    if (Math.Abs(1 - x * x) == a + c)
    {
        y = (x * Math.Pow(Math.PI, a)) + (Math.Pow(Math.PI, b * Math.PI));
    }
    else if (Math.Abs(1 - x * y) > a + c)
    {
        y = (Math.Pow(Math.Sin(a * x), 2)) + (Math.Cos(b * Math.PI));
    }
    else if (Math.Abs(1 - x * a) < a + c)
    {
        y = Math.Sqrt(a + Math.Pow(b, 4) +Math.Pow(c*x*x,0.2));
    }
    Console.WriteLine($"y= {y}");
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}