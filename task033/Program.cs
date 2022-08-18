// адача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
//4; массив [6, 7, 19, 345, 3] -> нет
//-3; массив [6, 7, 19, 345, 3] -> да

int[] array = new int[12];
Random rand = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(-9, 10);
}
Console.WriteLine('[' + string.Join(", ", array) + ']');
Console.WriteLine("Введите целое число: ");
int N = Convert.ToInt32(Console.ReadLine());
int j = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] == N)
    {
        j++;
    }

}
if (j > 0)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}
