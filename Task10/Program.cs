// Напишите программу, которая принимает на вход трехзначное число а на выходе показывает последнюю цифру этого числа
//
Console.Write("Enter Number = ");
int N = Math.Abs(int.Parse(Console.ReadLine())); //Определяем модуль числа
int NTemp = N;
int count = 0; // запускаем счетчик разрядов

while (NTemp > 0)
{
    NTemp /= 10;
    count++;
}
if (count - 3 >= 0)
{
    while (count - 3 > 0) // число из последних трех разрядов
    {
        N = N / 10;
        count--;
    }
    Console.WriteLine($"Тhird number {N % 10}"); // определяем число
}
else
{
    Console.WriteLine("No third number");
}
