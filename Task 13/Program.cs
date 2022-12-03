// Напишите программу, которая выводит третью цифру заданного числа и сообщает что третьей цифры нет

Console.Write("Enter Number = ");
int N = int.Parse(Console.ReadLine());

int a = 0;
//int b = 0;

a = N%10;
//b = N/10;

Console.Write("Last Number = ");
Console.WriteLine(a);
//Console.Write("Previous Number = " + " " + b);
