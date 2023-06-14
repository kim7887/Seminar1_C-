// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введиде первое число");
string? numdurString = Console.ReadLine();
int a = Convert.ToInt32(numdurString);

Console.WriteLine("Введите второе число");
string? numdurstring = Console.ReadLine();
int b = Convert.ToInt32(numdurstring);
if ( a > b)
{
    Console.WriteLine("max="+a);
    Console.WriteLine("min="+b);   
}
if ( b > a)
{
    Console.WriteLine("max="+b);
    Console.WriteLine("min="+a);
}
else
{
    Console.WriteLine("ошибка");
}