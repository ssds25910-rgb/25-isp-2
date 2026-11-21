mas[] mass = new mas[3];
for (int i = 0; i < mass.Length; i++)
{
    Console.WriteLine($"Сообщение {i + 1}");
    Console.Write("Эмеил отправителя: ");
    mass[i].SE = Console.ReadLine();
    Console.Write("Эмеил получателя: ");
    mass[i].RE = Console.ReadLine();
    Console.Write("Дата отправки(гг-мм-дд): ");
    mass[i].SD = DateOnly.Parse(Console.ReadLine());
    Console.Write("Время отправки (чч:мм): ");
    mass[i].ST =TimeOnly.Parse(Console.ReadLine());
    Console.Write("Размер сообщения: ");
    mass[i].SizeKb = double.Parse(Console.ReadLine());
    Console.WriteLine();
    Console.WriteLine();
}
Console.WriteLine(" Все отправленные сообщения ");
DateOnly today = DateOnly.FromDateTime(DateTime.Today);

for (int i = 0; i < mass.Length; i++)
{
   
    int daysPassed = today.DayNumber - mass[i].SD.DayNumber;
    Console.WriteLine(
 $"От: {mass[i].SE} | Кому: {mass[i].RE} | " +
 $"Дата: {mass[i].SD} {mass[i].ST} | " +
 $"Размер: {mass[i].SizeKb} Кб | Прошло дней: {daysPassed}");
    Console.WriteLine();
}

Console.Write("Введите искомую дату: ");
DateOnly targetDate = DateOnly.Parse(Console.ReadLine());

Console.Write("Введите начало интервала времени (чч:мм): ");
TimeOnly startTime = TimeOnly.Parse(Console.ReadLine());

Console.Write("Введите конец интервала времени (чч:мм): ");
TimeOnly endTime = TimeOnly.Parse(Console.ReadLine());

Console.WriteLine("Отправители:");
bool found = false;

for (int i = 0; i < mass.Length; i++)
{
    
    if (mass[i].SD == targetDate &&
        mass[i].ST >= startTime &&
        mass[i].ST <= endTime)
    {
        Console.WriteLine($"- {mass[i].SE} (время: {mass[i].ST}, получатель: {mass[i].RE})");
        found = true;
    }
  
    
}
Console.WriteLine();
struct mas
{
 public string SE;
 public string RE;
 public DateOnly SD;
 public TimeOnly ST;
 public double SizeKb; 
}
 