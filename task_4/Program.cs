// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите первое число");
string?numberString = Console.ReadLine();
int a = Convert.ToInt32(numberString);
Console.WriteLine("Введите второе число");
string? numberstring = Console.ReadLine();
int b = Convert.ToInt32(numberstring);
Console.WriteLine("Введите третье число ");
string? numberstringg =Console.ReadLine();
int c = Convert.ToInt32(numberstringg);

int max = a;
if (max<b)
{
    Console.WriteLine(max=b);
}
if (max<c)
{
    Console.WriteLine(max=c);
}
Console.WriteLine("max="+max);