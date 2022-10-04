// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

Console.WriteLine("Введите значение M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write($"m = {m}, n = {n} -> A(m,n) = ");
int A(int m, int n)
{
    if (m == 0) return n + 1;
    else if ((n == 0) && (m > 0))
    return A(m - 1, 1);
    else return A(m - 1, A(m, n - 1));
}
Console.Write(A(m,n));