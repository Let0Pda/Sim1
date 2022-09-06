// Напишите программу, которая выведет все натуральные числа от M до N

int M = 9;
int N = 1;
void PrintNumbers(int number1, int number2)
{
    if (number1 > number2)
    {
        return;
    }
    Console.Write($"{number1} ");
    PrintNumbers(number1 + 1, number2);
}
if (M < N)
{
    PrintNumbers(M, N);
}
else
{
    PrintNumbers(N, M);
}