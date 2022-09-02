// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, 
// на пересечении которых расположен наименьший элемент массива.


Console.WriteLine("Введите двумерный массив m*n");
Console.Write("\nВведите m -> ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите n -> ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[,] matrix = new int[m, n];

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        matrix[i, j] = new Random().Next(1, 10);
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();

int indexRaw = -1;
int indexCol = -1;

void FindMinElement(int[,] matrix)
{
    int min = matrix[0, 0];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < min)
            {
                min = matrix[i, j];
                indexRaw = i;
                indexCol = j;
            }

        }

    }
    Console.Write($"Найдено минимальное значение в массиве -> {min} с индексами i = {indexRaw}, j = {indexCol}");

}

void DeleteNewMatrix(int[,] matrix, int indexRaw, int indexCol)
{
    int[,] matrix1 = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            if (i >= indexRaw)
            {
                if (j >= indexCol) matrix1[i, j] = matrix[i + 1, j + 1];
                else if (j < indexCol) matrix1[i, j] = matrix[i + 1, j];
            }

            else if (i < indexRaw)
            {
                if (j >= indexCol) matrix1[i, j] = matrix[i, j + 1];
            }
            if (j < indexCol) matrix1[i, j] = matrix[i, j];
            Console.Write(matrix1[i, j] + " ");
        }
        Console.WriteLine();
    }

}
Console.WriteLine();


FindMinElement(matrix);
Console.WriteLine("\nНовый массив:\n");
DeleteNewMatrix(matrix, indexRaw, indexCol);
