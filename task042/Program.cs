// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10


void PrintBinary(int N)
{
    if (N <= 0) return;
    Console.Write($" {N % 2}");
    PrintBinary(N / 2);
    Console.Write($" [{N % 2}]");
}


Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());

PrintBinary(number);

// Console.WriteLine("Введите число ");
// int number = Convert.ToInt32(Console.ReadLine());
// string result = String.Empty;
// while (number != 0)
// {
//     result += Convert.ToString(number % 2);
//     number = number / 2;
// }
// Console.WriteLine(result);




// void ReverseArray(int[] arr)
// {
//     int temp = 0;
//     for (int i = 0; i < arr.Length / 2; i++)
//     {
//         temp = arr[i];
//         arr[i] = arr[arr.Length - 1 - i];
//         arr[arr.Length - 1 - i] = temp;
//     }
// }
// Console.Write("Введите целое число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int ost = 0;
// int num = number;
// int count = 0;
// for (int i = 0; i <= num; i++)
// {
//     ost = number % 2;
//     number = number / 2;
//     Console.Write(ost);
//     count++;
//     if (number <= 0) break;


// }
// //Console.WriteLine(count);

// int[] arr = new int[count];
// for (int j = 0; j < arr.Length; j++)
// {
//     ost = number % 2;
//     number = number / 2;
//     arr[j] = ost;
//     //if(number<=0) break;
//     ReverseArray(arr);
//     Console.WriteLine(string.Join(",", arr));
