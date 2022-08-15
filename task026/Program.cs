/* Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5
*/

Console.Clear();
Console.WriteLine("Задача 26");
Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
n = Math.Abs(n);
string s = Convert.ToString(n);

Console.WriteLine(s.Length);