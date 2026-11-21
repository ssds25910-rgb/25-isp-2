//person tom = new person();
//tom.Name = "vasya";
//tom.age = 18;
//Console.WriteLine($"Его имя {tom.Name}");
//Console.WriteLine($"{tom.Name} {tom.age} лет");

//struct person
//{
//    public string Name;
//    public int age;
//}


//Comp[] comps = new Comp[5];
//for (int i = 0; i < comps.Length; i++)
//{
//    Console.Write("Введите название компьютера:");
//    comps[i].name = Console.ReadLine()!;
//    Console.Write("Введите частоту:");
//    comps[i].frequency = int.Parse(Console.ReadLine()!);
//    Console.Write("Введите память:");
//    comps[i].memory = int.Parse(Console.ReadLine()!);
//    Console.Write("Введите наличие DVD: Да/Нет?");
//    string dvd = Console.ReadLine()!;
//    if (dvd == "Да") comps[i].DVD = true;
//    else comps[i].DVD = false;
//    Console.Write("Введите цену:");
//    comps[i].price = decimal.Parse(Console.ReadLine()!);
//    Console.WriteLine();
//}
//for (int i = 0; i < comps.Length; i++)
//{
//    if (comps[i].DVD) comps[i].Print();
//}
//struct Comp
//{
//    public string name;
//    public int frequency;
//    public int memory;
//    public bool DVD;
//    public decimal price;
//    public void Print()
//    {
//        Console.WriteLine($"Название:{name}, частота:{frequency}, память {memory}, {((DVD) ? "DVD" : "")}, цена:{price}");
//    }

//}

using System.Data;


foot[] foots = new foot[5];
for( int i = 0;i < foots.Length;i++)
{
    Console.Write("Введите фамилию: ");
    foots[i].fio = Console.ReadLine();
    Console.Write("Введите Дату (гггг-мм-дд): ");
    foots[i].date = DateTime.Parse(Console.ReadLine()!);
    Console.Write("Введите Место рождения: ");
    foots[i].place =Console.ReadLine();
    Console.Write("Введите Амплуа: ");
    foots[i].amplua = Console.ReadLine();
    Console.Write("Введите количество игр: ");
    foots[i].game =int.Parse(Console.ReadLine());
    Console.Write("Введите количество Желтых карт: ");
    foots[i].yellcard = int.Parse(Console.ReadLine());
    Console.WriteLine();
}

for (int i = 0;i<foots.Length;i++)
{
    bool found = false;
    int age = DateTime.Now.Year - foots[i].date.Year;
    if (foots[i].date.Date > DateTime.Now.AddYears(-age)) age--;
    double cardGame = foots[i].game > 0 ? (double)foots[i].yellcard / foots[i].game : 0;
    if (age > 20 && cardGame <= 0.1)
    {
        foots[i].Print();
        found = true;
    }
}


struct foot
{
    public string fio;
    public DateTime date;
    public string place;
    public string amplua;
    public int game;
    public int yellcard;
    public void Print()
    {
        Console.WriteLine($"{fio} |  {date:d} | {place} | {amplua} | Игр: {game} | Карточек: {yellcard}");
    }
}
