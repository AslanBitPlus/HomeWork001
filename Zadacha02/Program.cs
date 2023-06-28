// Задача 4: Напишите программу, которая принимает 
// на вход три числа и выдаёт максимальное из этих чисел.

int a = 2, b = 3, c = 7;

int max = a;

if (b > max)
{
    max = b;
}

if (c > max)
{
    max = c;
}

Console.Write("Max = ");
Console.WriteLine(max);
