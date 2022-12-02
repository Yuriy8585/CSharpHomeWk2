// Напишите программу, которая принимает на вход цифру, которая приниамет на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным

Console.Write("Enter Number of the week form 1 to 7 = ");
int a = int.Parse(Console.ReadLine());
if (a == 1)
{
    Console.Write("Monday No");
}

if (a == 2)
{
    Console.Write("Tuesday No");
}

if (a == 3)
{
    Console.Write("Wednesday No");
}

if (a == 4)
{
    Console.Write("Thursday No");
}

if (a == 5)
{
    Console.Write("Friday No");
}

if (a == 6)
{
    Console.Write("Saturday Yes");
}

if (a == 7)
{
    Console.Write("Sunday Yes");
}

