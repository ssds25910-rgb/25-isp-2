//using ClassLibrary1;

//Random random = new Random();
//int[] mas = new int[random.Next(10, 10)];
//for (int i = 0; i < mas.Length; i++)
//{
//    mas[i] = random.Next(10, 50);
//    Console.WriteLine(mas[i] + ",");

//}
//Console.WriteLine();
//Console.WriteLine($"Сумма массива:{OurClassLibrary.MultimMatrix(mas)}")


using ClassLibrary1;

double[,] mas = new double[5, 5];
Random rand = new Random();

for (int i = 0; i < mas.GetLength(0); i++)
{
    for (int j = 0; j < mas.GetLength(1); j++)
    {
        mas[i, j] = rand.NextDouble();
        Console.Write($"{mas[i, j],8:F2}");
    }
    Console.WriteLine();
}

Console.WriteLine();

double[] result = OurClassLibrary.MultimMatrix(mas);
string fR = string.Join("  ", result.Select(x => $"{x:F2}"));

Console.WriteLine($"Одномерный массив, содержащий максимальный элемент главной матрицы: {fR}");