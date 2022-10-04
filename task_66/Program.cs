// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. 
// Выполнить с помощью рекурсии.

Console.WriteLine("Введите значение M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение N: ");
int n = Convert.ToInt32(Console.ReadLine());
int sum = 0;
Console.Write($"M = {m}, N = {n} -> ");
int SumNumbers (int m, int n, int sum)
{
    if (m <= n)
    {
        sum = sum + m;
        m++;
        sum = SumNumbers(m, n, sum);
    }
    return sum;
}
Console.Write(SumNumbers(m, n, sum));