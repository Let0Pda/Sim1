// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

Console.Write("\nВведите A -> ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите B -> ");
int B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int Pow(int a, int b)
{
    if (b == 0)
    {
        return 1;
    }
    return a * Pow(a, b - 1);
}
Console.WriteLine(Pow(A, B)); // как не надо писать код

// Console.Write("\nВведите A -> ");
// int A = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите B -> ");
// int B = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();

// double Сqueen(double n, double m)
// {
//     if (m == 0)
//     {
//         return 0;
//     }
//     Сqueen(n, m - 1);
//     return Math.Pow(n, m);

// }
// Console.WriteLine(Сqueen(A, B));