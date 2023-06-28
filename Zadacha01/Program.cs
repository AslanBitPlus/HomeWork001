// Задача 2: Напишите программу, которая на вход принимает два числа
// и выдаёт, какое число большее, а какое меньшее

int a = 10;
int b = 2;

int max = a;

if (b > max)
{
    max = b;
}
Console.Write("Max = ");
Console.WriteLine(max);
