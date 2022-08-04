int N = 0;
while(N < 100 || N >999)
{
Console.WriteLine("Введите трехзначное число: ");
N = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Последняя цифра числа: " + N % 10);
