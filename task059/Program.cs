// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, 
// на пересечении которых расположен наименьший элемент массива.


Console.WriteLine("Введите двумерный массив m*n");
Console.Write("\nВведите m -> ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите n -> ");
int n = Convert.ToInt32(Console.ReadLine());

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
Console.WriteLine("\n");

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }

}



void FindMinElement(int[,] matrix, ref int index1, ref int index2)
{
    int min = matrix[0, 0];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < min)
            {
                min = matrix[i, j];
                index1 = i;
                index2 = j;
            }

        }

    }
    Console.WriteLine($"Найдено минимальное значение в массиве -> {min}\n");

}

int[,] DeleteNewMatrix(int[,] matrix, int index1, int index2)
{
    int[,] matrix1 = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    int offset1 = 0;
    int offset2 = 0;
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        if (i == index1) offset1++;
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            if (j == index2) matrix1[i, j] = matrix[i + offset1, j + offset2];
            else matrix1[i, j] = matrix[i + 1, j];

        }
        //offset1 = 0;
        // offset2 = offset2[j];
    }

    return matrix1;
}

int minI = 0;
int minJ = 0;

FindMinElement(matrix, ref minI, ref minJ);
Console.WriteLine("Новый массив\n");
//Console.Write(NewMatrix(matrix, minI, minJ));
PrintMatrix(DeleteNewMatrix(matrix, minI, minJ));
