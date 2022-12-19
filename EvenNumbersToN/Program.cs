using static System.Console;

Write("Введите число: ");
int N = int.Parse(ReadLine()!);
int n = 1;
if (N <= 1)
{
    WriteLine("Введите большее число");
}
else
{
    while (n <= N)
    {
        if (n % 2 == 0)
        {
            Write($"{n} ");
            n++;
        } 
        else{
            n++;
        }
    }
}