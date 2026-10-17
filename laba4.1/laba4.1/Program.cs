//using System.Collections;

//int[] mas1 = new int[5];
//int[] mas2 = {1,4,2,9,3};
//int[] mas3 = mas2;
//mas3[3] = 12;
//Console.WriteLine(mas3[3]);
//Console.WriteLine(mas2[3]);

//ввод вручную
//int[] mas4 = new int[5];
//for (int i = 0; i < mas4.Length; i++)
//    mas4[i] = int.Parse(Console.ReadLine());
//for (int i = 0; i < mas4.Length; i++)
//    Console.Write($"{mas4[i]}");

//ввод по формуле
//int[] mas5 = new int[5];
//for (int i = 0;i < mas5.Length; i++)
//{ 
//    mas5[i] = 2 * i + 1;
//    Console.WriteLine($"{mas5[i]}");
//}
//Console.WriteLine();

// генератор случайных чисел
//Random rnd = new Random();
//int[] mas6 = new int[rnd.Next(1, 15)];
//for (int i = 0; i < mas6.Length; i++)
//{
//    mas6[i] = rnd.Next(1, 800);
//    Console.WriteLine($"{mas6[i]}");
//    if (i == 777)
//        Console.WriteLine("джекпот");
//}
//Console.WriteLine();


//try
//{
//    int[] mas = new int[10];
//    Random rnd = new Random();
//    for (int i = 0; i < mas.Length; i++)
//    {
//        mas[i] = rnd.Next(-7, 8);
//        Console.Write($"{mas[i]} ");
//    }
//    Console.WriteLine();
//    Console.Write("введиет n ");
//    int n = int.Parse(Console.ReadLine());
//    int index = -1;
//    int less_n = 0;
//    for(int i = 0;i < mas.Length; i++)
//    {
//        if (mas[i] == n) index = i;
//        if (mas[i] < n) less_n++;
//    }
//    Console.WriteLine($"Индекс последнего вхождения {n}={index}") ;
//    Console.WriteLine($"Количество элементов меньших {n}={less_n}");

//}
//catch(Exception e)
//{
//    Console.WriteLine(e.Message);
//}

//try
//{
//    Console.Write("Введите n ");
//    int n = int.Parse(Console.ReadLine());
//    Random rnd = new Random();
//    int[] mas = new int[n];
//    for (int i = 0; i < mas.Length; i++)
//    {
//        mas[i] = rnd.Next(-10, 11);
//        Console.Write($" {mas[i]}");
//    }
//    Console.WriteLine();
//    int max = mas[0];
//    for (int i = 1; i < mas.Length; i++)
//    {
//        if (mas[i] > max) max = mas[i];
//    }
//    Console.WriteLine($"max={max}");
//}
//catch (Exception e)
//{
//    Console.WriteLine(e.Message);
//}

//отсортировать элементы массивов по возростанию
//Random rnd = new Random();
//int[] mas = new int[rnd.Next(10, 200)];
//for (int i = 0; i < mas.Length; i++)
//{
//    mas[i] = rnd.Next(10, 10000 );
//    Console.WriteLine($"{mas[i]} ");
//}
//Console.WriteLine();
//for (int i = 0; i < mas.Length; i++)
//{
//    for (int j = i + 1; j < mas.Length; j++)
//    {
//        if (mas[i] > mas[j])
//        {
//            int temp = mas[i];
//            mas[i] = mas[j];
//            mas[j] = temp;
//        }
//    }
//}
//foreach (int i in mas) Console.Write($"{i} ");
//Console.WriteLine();

//try
//{
//    Console.Write("Введитпе n ");
//    int n = int.Parse(Console.ReadLine());
//    int m = 1;
//    Random rnd = new Random();
//    int[] mas = new int[n];
//    for (int i = 0; i < mas.Length; i++)
//    {
//        mas[i] = rnd.Next(-19, 26);
//        Console.Write($" {mas[i]}");
//        if (mas[i] % 2 != 0) m *= mas[i];
//    }
//    Console.WriteLine();
//    Console.WriteLine($"Произведение");


//}
//catch(Exception e)
//{
//    Console.WriteLine(e.Message);
//}

//try
//{
//    Console.Write("Введите размер");
//    int n = int.Parse(Console.ReadLine());
//    int s = 0;
//    int[] mas = new int[n];
//    for (int i = 0; i < mas.Length; i++)
//    {
//        mas[i] = int.Parse(Console.ReadLine());
//        if (mas[i] == 0) s++;
//    }
//    Console.WriteLine();
//    Console.WriteLine($"Количество 0 = {s}");
//}
//catch (Exception e)
//{
//    Console.WriteLine(e.Message);
//}

//int? val = null;
//Console.WriteLine();
//int? x = 5;
//int? w = x + 7;
//int d = x.Value + 7;

//string? text = null;
//string name = text ?? "tom";

//int? id = null;
//int personalid = id ?? 1;
//Console.WriteLine(personalid);

using System.Runtime.InteropServices;

Random rnd = new Random();
string[] mas = new string[12];
for (int i = 0; i < mas.Length; i++)
{ 
    mas[i] = Convert.ToString (rnd.Next(1,5),2);
    Console.Write($"{mas[i]}, ");
}
Console.WriteLine();
int m = 0;
string[] res = new string[12];
for (int i = 0;i < mas.Length-1;i++)
{
    int k = 0;
    if (res.Contains(mas[i])) continue;
    for (int j = i+1;j<mas.Length;j++)
    {
        if (mas[i] == mas[j]) k++;
    }
    if(k<=2)
    {

        res[m]= mas[i];
        m++;
    }
}
foreach (string s in res) Console.Write($"{s} ");