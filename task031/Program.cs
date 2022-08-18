// 31. Задать массив из 12 элементов, заполненных числами из [-9,9]. 
// Найти сумму положительных/отрицательных элементов массива



// int[] array = new int[12];
// int sumPositive = 0;
// int sumNegative = 0;
// Random rand = new Random();
// for (int i = 0; i < array.length; i++)
// {
//     array[i] = rand.Next(-9, 10);
// }
// Console.WriteLine('[' + string.Join(", ", array) + ']');
// for (int i = 0; i < arrat.length; i++)
// {
//     if (array[i] > 0)
//     {
//         sumPositive = array[i];
//     }
//     else
//     {
//         sumNegative = array[i];
//     }
// }
// Console.Write($"Сумма положительных чисел = {sumPositive}, а отрицательных {sumNegative}");

int fillAray(int size, int leftRange, int rinhtRange)
{
    Random rand = new Random();
    int[] arr = new int[size];

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(leftRange, rinhtRange + 1);
    }
    return arr;
}
void sumPositiveAndsumNegative(int[] arr, out int sumPositive, out int sumNegative)
{
    sumPositive = 0;
    sumNegative = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            sumPositive += arr[i];
        }
        else
        {
            sumNegative += arr[i];
        }
    }
}
int array = fillAray(5, -9, 9);
sumPositiveAndsumNegative(array, out int sumP, out int sumN);
Console.WriteLine('[' + string.Join(", ", array) + ']');
Console.WriteLine($"Сумма положительных чисел = {sumP}, а отрицательных ={sumN}");



/*
int n = 12;
int min = -9;
int max = 9;

int[] CreateArray(int n, int min, int max)
{
    int[] array = new int[n];

    for (int i = 0; i < n; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

int[] PutSums(int[] arr)
{
    int[] sums = new int[2];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < 0) sums[0] += arr[i];
        else sums[1] += arr[i];
    }
    return sums;
}

void PritArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
    System.Console.WriteLine();
}

PritArray(PutSums(CreateArray(n, min, max)));

// если нужно вывести сам массив, то так:

int[] array = CreateArray(n, min, max);
PritArray(array);
PritArray(PutSums(array));
*/