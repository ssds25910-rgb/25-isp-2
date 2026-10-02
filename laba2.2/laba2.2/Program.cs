//легко
//try
//{
//    Console.Write("Введите x ");
//    double x = double.Parse(Console.ReadLine());
//    if (x < 4) Console.WriteLine("первоя область");
//    else Console.WriteLine("вторая область");

//}
//catch (Exception e)
//{
//    Console.WriteLine(e.Message);
//}

//средне
//try
//{
//    Console.Write("введите x");
//    double x = double.Parse(Console.ReadLine());
//    Console.Write("введите y");
//    double y = double.Parse(Console.ReadLine());
//    double max, min;
//    if (x > y) { max = y; min = x; }
//    else { max = x; min = y; }
//    Console.WriteLine($"max={max}, min{min}");

//}
//catch (Exception e)
//{ Console.WriteLine(e.Message); }

//try
//{
//    Console.Write("введите a ");
//    double a = double.Parse(Console.ReadLine());
//    Console.Write("введите b ");
//    double b = double.Parse(Console.ReadLine());
//    Console.Write("введите c ");
//    double c = double.Parse(Console.ReadLine());
//    if ((a < b) && (b < c)) Console.WriteLine($"{a}<{b}<{c}");
//    else Console.WriteLine("Не выполнено");

//}
//catch (Exception e)
//{ Console.WriteLine(e.Message); }



//try
//{
//    Console.Write("введите a ");
//    int m = int.Parse(Console.ReadLine());
//    int a = m / 100;
//    int b = m / 10 % 10;    
//    int c = m % 10;
//    if ((a == 4 || b == 4 || c == 4) || (a == 7 || b == 7 || c == 7))
//        Console.WriteLine("Yes");
//    else Console.WriteLine("No");
//    if ((a == 3 || b == 3 || c == 3) || (a == 6 || b == 6 | c == 6) || (a == 9 || b == 9 || c == 9)) Console.WriteLine("Yes");

//    else Console.WriteLine("No");

//}
//catch (Exception e)
//{ Console.WriteLine(e.Message); }


try
{
    Console.Write("введите дни ");
    int day = int.Parse(Console.ReadLine());
    int dayw = day % 7;
    if (dayw == 1) Console.WriteLine("Понедельник"); 
    else if (dayw == 2) Console.WriteLine("Вторник");
    else if (dayw == 3) Console.WriteLine("Среда");
    else if (dayw == 4) Console.WriteLine("Четверг");
    else if (dayw == 5) Console.WriteLine("Пятница");
    else if (dayw == 6) Console.WriteLine("Суббота");
    else Console.WriteLine("Воскресенье"); 
}
catch (Exception e)
{ Console.WriteLine(e.Message); }
