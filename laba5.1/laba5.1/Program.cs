
Console.WriteLine("Введите массив символов из 13 элементов (десятичное число):");
string inp = Console.ReadLine();
char[] charA = new char[13];
for (int i = 0; i < 13; i++)
{
    charA[i] = i < inp.Length ? inp[i] : ' ';
}
string numberStr = new string(charA);
if (int.TryParse(numberStr, out int number))
{
    if (number <= 0 || number > 3999)
    {
        Console.WriteLine("Ошибка");
    }
    else
    {
        string rNumber = ConvertToRoman(number);
        Console.WriteLine($"Число {number} в римской системе: {rNumber}");
    }
}
else
{
    Console.WriteLine("Ошибка");
}
string ConvertToRoman(int number)
{
    int[] values = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
    string[] Numerals = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };

    string result = "";

    for (int i = 0; i < values.Length; i++)
    {
        while (number >= values[i])
        {
            number -= values[i];
            result += Numerals[i];
        }
    }

    return result;
}
