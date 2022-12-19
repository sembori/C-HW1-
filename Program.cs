using static System.Console;

WriteLine("Введите два чиcлa, которые вы хотите сравнить!");
Write("Первое число: ");
int a = int.Parse(ReadLine()!);
Write("Второе число:");
int b = int.Parse(ReadLine()!);

if (a > b)
{
    WriteLine($"Число {a} больше");
}
else if (b > a)
{
    WriteLine($"Число {b} больше");
}
else
{
    WriteLine("Числа равны");

}
