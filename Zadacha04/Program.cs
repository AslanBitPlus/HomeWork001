// Задача 4: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

int N = 24;

Console.Write("Все четные числа от 1 до ");
Console.WriteLine(N);
    
int Num = 1; 

while (Num <= N)
{
    if (Num%2 == 0)
    {
        Console.Write(Num);
        Console.Write("  ");
    }
    Num ++;
}