// Напишите программу, которая выведет все натуральные числа от M до N

int N = 5;
int M = 100;
void PrintNumbers(int number1, int number2)
{
    if (number1 > number2)
    {
        return;
    }
    Console.Write($"{number1} ");
    PrintNumbers(number1 + 1, number2);
}
PrintNumbers(N, M);