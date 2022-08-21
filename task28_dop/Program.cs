/* Дополнительная задача (необязательная)
Задача 28*: Напишите программу, в которой задается массив чисел(ввод может быть с клавиатуры, либо можете сами задавать массив чисел) 
и выдаёт произведение чисел от 1 до N, каждого элемента этого массива.
{2, 3, 4} -> 2, 6, 24
{5, 3, 6, 2, 5, 1} -> 6, 720, 2, 120, 1
*/
Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = new int [N];
for (int i = 0; i < N; i++)
{
    Console.Write($"\nВведите {i +1 }й элемент массива: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
int res = 0;
Console.WriteLine();
int Resalt(int i)
{
    if (i == 1) return 1;
 
    return i * Resalt(i - 1);
}
for (int j = 0; j < N; j++)
{
    res = Resalt(array[j]);

    Console.WriteLine($"Индекс = [{j}]\n Произведение чисел от 1 до {array[j]} = {res}.\n");
}






// int[] array =new int[3]{2, 3, 4};
// for (int i = 0; i < array.Length; i++)
// {
//     Console.Write(array[i].ToString() + " ");
// }
// int N = array[2];

// double Cycle(int x)
// {
//     double res = 1;
//     for (int i = 1; i <= N; i++)
//     {
//         res = res * i;
//         Console.WriteLine(res);
//     }
//     return res;

// }
// Console.WriteLine($"Произведение чисел от 1 до {N} равно {Cycle(N)}");






// void Resalt(int[] array)
// {
//     int n = 1;
//     for (int i = 0; i <= array.Length; i++)
//     {

//         n = n * i;
//         Console.WriteLine();
//         Console.Write($" Индекс= {i} значение= {array[n]} = {n}");
//         for (int j = 0; j < array[i]; j++)
//         {
//             int res = 0;
//             res = j + 1;

//         }
//         return;

//     }
// }

// Resalt(array);


//Console.WriteLine($"{array.ToString }! = {array.Length}");
// foreach (var v in array) 
// Console.Write($"Массив = { v + " "}"); //Console.WriteLine($"{i}! = {Factorial(i)}");
// int lenarr = array.Length;
// Console.WriteLine($"количество элементов массива: {lenarr}");


// double CycleRes(int[] arr)
// {
//      double res = 0;
//         for (int i = 1; i <= resarr; i++)
//         {
//             res = resarr * i;
//             Console.WriteLine(res);
//         }
//         return res;
// }



// 
// //CycleRes(array);




// void PrintArray(int[] array)
// {
//     for (int i = 0; i < lenarr; i++)
//     {
//         Console.Write($"{array[i]}");
//     }
// }





// void ResaltArray(int[] array)
// {
//     int resalt = 0;
//     for (int i = 1; i < n; i++)
//     {
//         resalt = resalt * i;
//         Console.Write($" {resalt}");
//     }
// }

// PrintArray(array);
// Console.WriteLine();
// ResaltArray(array);

// Console.WriteLine("Введите количество элементов массива:");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] arr = new int[size];
// for (int i = 0; i < size; i++)
// {
//     Console.WriteLine($"Введите {i + 1} элемент массива");
//     arr[i] = Convert.ToInt32(Console.ReadLine());
// }

// void PrintArray(int[] arr)  // Метод вывода массива
// {

//     for (int i = 0; i < size; i++)
//     {
//         Console.Write($"{arr[i]} ");
//     }
//     Console.WriteLine();
// }
// double ResaltArray(int r)
// {
//     double res = 1;
//     for (int j = 1; j <= r; j++)
//     {
//         res = (int)arr[i] * j;
//         Console.WriteLine($"{j} = {res}");
//     }
//     return res;
// }


// // Console.WriteLine(size);
// PrintArray(arr);
// ResaltArray(array);

// //Console.WriteLine(arr);



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
