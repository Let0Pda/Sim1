//Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

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
for (int i = 0; i < n; i++)
{
    int temp = matrix[0, i];
    matrix[0, i] = matrix[m - 1, i];
    matrix[m - 1, i] = temp;

}
Console.WriteLine();
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}