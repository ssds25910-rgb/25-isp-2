//задание 3.26
Console.Write("Введите трехзначное число ");
int n = int.Parse(Console.ReadLine());
int a = n % 10;
int b = n % 100 / 10;
int c = n % 1000 / 100;
Console.WriteLine($"1={a}{b}{c}\n2={a}{c}{b}\n3={b}{a}{c}\n4={b}{c}{a}\n5={c}{a}{b}\n6={c}{b}{a}");


//try
//{
//    Console.Write("Введите количество килограмм ");
//    int kg=int.Parse(Console.ReadLine());
//    int c = kg / 100;
//    Console.WriteLine($"Количество центнеров {c}");
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}


//try
//{
//    Console.Write("Введите количество килограмм ");
//    int kg = int.Parse(Console.ReadLine());
//    int t = kg / 1000;
//    Console.WriteLine($"Количество тон {t}");
//}
//catch(Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}


//try
//{
//    Console.Write("Введите количество метров ");
//    int m = int.Parse(Console.ReadLine());
//    int k =  m/ 1000;
//    Console.WriteLine($"Количество Километров {k}");
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}


//try
//{
//    int n = 234/7;
//    Console.WriteLine($"Количество недель {n}");
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}


//try
//{
//    Console.Write("Введите четырех значное число ");
//    int n = int.Parse(Console.ReadLine());
//    int a = n % 10;
//    int b = n % 100 / 10;
//    int c = n % 1000 / 100;
//    int d = n / 1000;
//    int s = a + b + c + d;
//    int f = a * b * c * d;
//    Console.WriteLine($"{ a }{ b }{ c }{ d }\ns={ s }\nf={ f}");
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}
