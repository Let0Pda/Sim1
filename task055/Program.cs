// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

Console.WriteLine("Введите двумерный массив m*n");
Console.WriteLine("Введите m");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите n");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[m, n];
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        matrix[i, j] = new Random().Next(0, 10);
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();
int[,] matrix1 = new int[n, m];
for (int j = 0; j < n; j++)
{
    for (int i = 0; i < m; i++)
    {
        matrix1[j, i] = matrix[i, j];
        Console.Write(matrix1[j, i] + " ");
    }
    Console.WriteLine();
}