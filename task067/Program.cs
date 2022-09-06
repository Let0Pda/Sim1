// Задача 67:Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int Summa(int n)
{
    if (n == 0)
    {
        return 0;
    }
    return n % 10 + Summa(n / 10);
}
Console.WriteLine(Summa(n));

// Console.WriteLine("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int m = 0;
// int Summa(int sum)
// {
//     if (sum == 0)
//     {
//         return 0;
//     }
//     Summa(sum / 10);
//     return m = m + (sum % 10);
// }
// Console.WriteLine(Summa(n));