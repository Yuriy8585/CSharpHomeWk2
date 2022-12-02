// Напишите программу, которая принимает на вход трехзначное число а на выходе показывает последнюю цифру этого числа
//
Console.Write("Enter Number = ");
int N = int.Parse(Console.ReadLine());

int a = 0;
double b = 0;

a = N%10;
b = N/10;

Console.Write("Last Number = ");
Console.WriteLine(a);
Console.Write("Previous Number = " + " " + b);
