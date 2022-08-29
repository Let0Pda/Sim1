//  Задача 46: Задайте двумерный массив размером m на n, заполненый случайными цклыми числами.
// m = 3, n = 4.
// 1 2 8 19
// 5 -2 33 -2
// 77 3 8 1

Console.WriteLine("Задайте двумерный массив m x n");
Console.Write("\nВведите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write($"\nДвумерный массив размера 'm = {m}' на 'n = {n}':\n");
int[,] matrix = new int[m, n];
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        matrix[i, j] = new Random().Next(-100, 101);
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}