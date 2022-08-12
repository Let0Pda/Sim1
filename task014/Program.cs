/* See https://aka.ms/new-console-template for more informationЗадача 14. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
14 -> нет
46 -> нет
161 -> да */

/*
Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a % 7 == 0 && a % 23 == 0)
{
    Console.WriteLine($"Число {a} кратно 7 и 23");
}
else
{
    Console.WriteLine("Число не кратно");
}
*/

Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
switch (a % 7)
{
    case 0 when a % 23 == 0:
        Console.WriteLine($"Число {a} кратно 7 и 23");
        break;
    default:
        Console.WriteLine("Число не кратно");
        break;
}