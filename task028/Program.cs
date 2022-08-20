/*
Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
4 -> 24 
5 -> 120
*/

Console.Clear();
Console.WriteLine();
Console.Write("Введите число: ");
string? writeN = Console.ReadLine();
int N = Convert.ToInt32(writeN);

double Cycle(int x)
{
    double comp = 1;
    for (int num = 1; num <= x; num++)
    {
        comp = comp * num;
        Console.WriteLine(comp);
    }
    return comp;

}
Console.WriteLine($"Произведение чисел от 1 до {N} равно {Cycle(N)}");
Console.WriteLine();
