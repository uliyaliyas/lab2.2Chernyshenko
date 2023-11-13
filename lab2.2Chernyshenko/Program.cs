Console.Write("Здравствуйте, введите Ваш балл диплома от 3 до 5: ");
double b = double.Parse(Console.ReadLine());
Console.Write("Теперь введите ваш стаж работы по специальности от 0 до 5: ");
int s = int.Parse(Console.ReadLine());
double k = 1; //коэффицент
if (s < 2)
{
    k = 13;
}
else if (s >= 2 && s <= 5)
{
    k = 16;
}
double r = s * k;
if (r >= 45)
{
    Console.Write("Поздравляем! Вы приняты в магистратуру.");
}
else Console.Write("К сожалению, ваш рейтинг не достаточен для поступления в магистратуру.");
