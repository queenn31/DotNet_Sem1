﻿Console.WriteLine("Чтобы узнать какое число больше введите два числа.");
int a, b;
Console.WriteLine("Введи первое число: ");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи второе число: ");
b = Convert.ToInt32(Console.ReadLine());
 
bool Chto0 = a > b;
bool Chto1 = a == b;
bool Chto2 = a < b;
 
if (Chto0)
{
    Console.WriteLine($"Число {a} больше чем {b}");
}
else if (Chto1)
{
    Console.WriteLine($"Числа {a} и {b} равны");
}
else
{
    Console.WriteLine($"Число {b} больше чем {a}");
}
