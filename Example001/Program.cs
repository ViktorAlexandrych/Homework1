﻿Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());
int max = 0;
int min = 0;
if (a > b)
{
	max = a;
	min = b;
}
else if (b > a)
{
	max = b;
	min = a;
}
Console.WriteLine("Максимальное число: " + max + " Минимальное число: " + min);