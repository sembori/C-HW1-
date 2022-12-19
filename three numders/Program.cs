using static System.Console;

WriteLine("Введите три чиcлa, наибольшее из которых вы хотите найти!");
Write("Первое число: ");
int a = int.Parse(ReadLine()!);
Write("Так, теперь второе число:");
int b = int.Parse(ReadLine()!);
Write("И наконец - число номер три:");
int c = int.Parse(ReadLine()!);
int max = a;

if (b > max)
{
    max = b;
}
if (c > max)
{
    max = c;
}

    WriteLine($"Наибольшее число {max}");
