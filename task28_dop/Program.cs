/* Дополнительная задача (необязательная)
Задача 28*: Напишите программу, в которой задается массив чисел(ввод может быть с клавиатуры, либо можете сами задавать массив чисел) 
и выдаёт произведение чисел от 1 до N, каждого элемента этого массива.
{2, 3, 4} -> 2, 6, 24
{5, 3, 6, 2, 5, 1} -> 6, 720, 2, 120, 1
*/

Console.WriteLine("Введите количество элементов массива:");
int size = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[size];
for (int i = 0; i < size; i++)
{
    Console.WriteLine($"Введите {i + 1} элемент массива");
    arr[i] = Convert.ToInt32(Console.ReadLine());
}

void PrintArray(int[] arr)  // Метод вывода массива
{

    for (int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}
double ResaltArray(int r)
{
    double res = 1;
    for (int j = 1; j <= r; j++)
    {
        res = (int)arr[i] * j;
        Console.WriteLine($"{j} = {res}");
    }
    return res;
}


// Console.WriteLine(size);
PrintArray(arr);
ResaltArray(array);

//Console.WriteLine(arr);



// int A = Cycle(array, 1);
// Console.WriteLine(A);

// int Cycle(int[] array, int i)
// {
//     int sum = 1;
//     for (int count = 1; count < array[i]; count++)
//     {
//         sum = sum * count;
//     }
//     return sum;
// }
