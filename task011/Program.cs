/* Задача 11. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
456 -> 46
782 -> 72
918 -> 98 
// Мой код
int n = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число: {n}");
int a = n / 100;
int b = n % 10;
Console.WriteLine($"{a}{b}"); 
*/
// вариант работы со строкой
/*
int n = new Random().Next(100, 1000).ToString();
Console.WriteLine($"Случайное число: {n}");
string s = n.ToString();
int f = int.Parse(s[0].ToString());
int l = int.Parse(s[s.Length - 1].ToString());
Console.WriteLine($"{f}{l}");
*/
