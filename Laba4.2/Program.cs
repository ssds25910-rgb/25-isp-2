
Console.WriteLine("Введите n");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите m");
int m = int.Parse(Console.ReadLine());
int[,] mas = new int[n, m];
for (int i = 0; i < mas.GetLength(0); i++)
{
    for (int j = 0; j < mas.GetLength(1); j++)
    {
        mas[i, j] = int.Parse(Console.ReadLine()!);
    }
}
int[] max_row = new int[n];
int[] max_colum = new int[n];
for (int i = 0; i < mas.GetLength(0); i++)
{
    int min = mas[i, 0];
    int k=0;
    for (int j = 1; j < mas.GetLength(1); j++)
    {
        if (mas[i, j] < min)
        {
            min = mas[i, j];
            k = j;
        }
    }
    max_row[i] = min;
    max_colum[i] = k;
}
int max = max_row[0];
int maxi = 0;
for (int i = 1; i < max_row.Length; i++)
{
    if (max_row[i] > max)
    {
        max = max_row[i];
        maxi = i;
    }
}
Console.WriteLine(maxi + " " + max_colum[maxi]);
