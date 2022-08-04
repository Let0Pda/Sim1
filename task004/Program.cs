Console.WriteLine("Введите целое число: ");
int N = Convert.ToInt32(Console.ReadLine());
int M = -N;
while (M <= N)
{
    Console.Write(M+" ");
    M++;
}
Console.WriteLine();