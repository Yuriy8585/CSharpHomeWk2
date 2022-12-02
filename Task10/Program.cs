// Напишите программу, которая принимает на вход трехзначное число а на выходе показывает последнюю цифру этого числа

Console.Wright("Enter Number = ");
int N = int.Parse(Console.ReadLine());

int a = 0;
int b = 0;

a = N%10;
b = N/10;

Console.Wright("Last Number = ");
Console.Wrightline(a);
Console.Wright("Previous Number = " + " " + b);
