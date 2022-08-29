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
            if (j == index2) offset2++;
            matrix1[i, j] = matrix[i + offset1, j + offset2];


            offset1 = 0;
            offset2 = 0;

        }
    }
    return matrix1;
}

int minI = 0;
int minJ = 0;

FindMinElement(matrix, ref minI, ref minJ);
Console.WriteLine("Новый массив\n");
//Console.Write(NewMatrix(matrix, minI, minJ));
PrintMatrix(DeleteNewMatrix(matrix, minI, minJ));




















// Console.WriteLine("Вариант 2");
// int[,] GetMatrix(int rows, int columns, int min, int max)
// {
//     int[,] matrix = new int[rows, columns];
//     var rnd = new Random();
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = rnd.Next(min, max);
//         }
//     }
//     return matrix;
// }

// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write(matrix[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// void FindMinElement(int[,] matrix, ref int indexI, ref int indexJ)
// {
//     int min = int.MaxValue;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (matrix[i, j] < min)
//             {
//                 min = matrix[i, j];
//                 indexI = i;
//                 indexJ = j;
//             }
//         }
//     }
// }

// int[,] DeleteRowAndColumnByIndexes(int[,] matrix, int indexI, int indexJ)
// {
//     int[,] matrixNew = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
//     int offsetI = 0;
//     int offsetJ = 0;
//     for (int i = 0; i < matrixNew.GetLength(0); i++)
//     {
//         if (i == indexI) offsetI++;
//         for (int j = 0; j < matrixNew.GetLength(1); j++)
//         {
//             if (j == indexJ) offsetJ++;
//             matrixNew[i, j] = matrix[i + offsetI, j + offsetJ];
//         }
//         offsetI = 0;
//         offsetJ = 0;
//     }

//     return matrixNew;
// }

// int[,] matrixOld = GetMatrix(4, 4, 0, 10);
// Console.WriteLine("Исходная матрица");
// PrintMatrix(matrixOld);
// int minI = 0;
// int minJ = 0;
// //Console.WriteLine();
// FindMinElement(matrixOld, ref minI, ref minJ);
// Console.WriteLine();
// PrintMatrix(DeleteRowAndColumnByIndexes(matrixOld, minI, minJ));
