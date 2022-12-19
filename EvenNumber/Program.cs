using static System.Console;

WriteLine("Давайте проверим. является ли число четным?");
Write("Введите число: ");
int a = int.Parse(ReadLine()!);

if (a%2 == 0){
    WriteLine($"Число {a} - четное!");
}else{
    WriteLine($"Увы, число {a} - нечетное. Стыдно не знать!");
}