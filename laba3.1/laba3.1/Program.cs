//int k = 0;
//int s = 0;
//int n;
//do
//{
//    n = int.Parse(Console.ReadLine());
//    s = s + n;
//    k = k+1;
//}
//while (n !=0);
//k = k - 1;
//Console.WriteLine($"{s}, {k}"); 

//int k = 6;
//Console.WriteLine(++k);
//Console.WriteLine(k);

//double s = 0;
//int k = 0;
//do
//{
//    try
//    {
//        int n = int.Parse(Console.ReadLine());
//        if (n < 0) break;
//        s += n;
//        k++;
//    }
//    catch (Exception e)
//    {
//        Console.WriteLine(e.Message);
//    }
//}
//while (true);
//Console.WriteLine($"{s / k:F2}");

//Console.Write("введите число ");
//int n = int.Parse(Console.ReadLine());
//int k3 = 0;
//int klast = 0;
//int  kodd = 0;
//int sumgreater5 =0;
//long multgreater7 = 0;
//int k05 = 0;
//int last = n % 10;
//while (n != 0) 
//{
//    int temp = n % 10;
//    if (temp == 3) k3++;
//    if (temp == last) klast++;
//    if (temp%2==0) kodd++;
//    if (temp>5) sumgreater5+=temp;
//    if(temp>7) multgreater7*=temp;
//    if (temp==0||temp == 5) k05++;
//    n/=10;
//}
//Console.WriteLine($"количество 3;{k3}");
//Console.WriteLine($"Последняя цифра втречается;{klast}");
//Console.WriteLine($"Количество четных;{kodd}");
//Console.WriteLine($"Сумма болше 5;{sumgreater5}");
//Console.WriteLine($"произведение цивр >7;{multgreater7}");
//Console.WriteLine($"0 и 5 встречаются{k05} раз");
//Console.WriteLine($"количество 3;{k3}");

//for(int i = 1;i<=9;i++)
//{
//    for(int j = 1; j <= 9; j++)
//    {
//        Console.WriteLine($"{i}*{j}={i*j} ");
//    }
//    Console.WriteLine();
//}

//for (int i = 10; i <=50; i += 10) 
//{
//    int c = i / 10;
//    for (int j = 0;j<c;j++)
//    {
//        Console.Write(i + " "); 
//        }
//    Console.WriteLine();

//}

//Console.WriteLine("Введите числа");
//while (true)
//{
//    double n;
//    n = int.Parse(Console.ReadLine());
//    if (n < 0)
//    {
//        break;
//    }
//    if (n >= 3 && n <= 13)
//    {
//        Console.WriteLine($" {n} входит в интервал");
//    }
//    else { Console.WriteLine($"{n} не входит в интервал"); }
//}

//Console.WriteLine("Введите числа");
//int n;
//n = int.Parse(Console.ReadLine());
//do
//{
//    n = int.Parse(Console.ReadLine());
//}
//while ();
//while (n!=0)
//{

//if (n >= 3 && n <= 13)
//{
//    Console.WriteLine($" {n} входит в интервал");
//}
//else { Console.WriteLine($"{n} не входит в интервал"); }
//if (n < 0)
//{
//    break;
//}
//}

Console.WriteLine("Вводите числа");
int n;
do
{
    n = int.Parse(Console.ReadLine());


    if (n >= 3 && n <= 13)
    {
        Console.WriteLine($"Число {n} входит в интервал 3, 13");
    }
    else
    {
        Console.WriteLine($"Ошибка");
    }
}
while (n >= 0);





