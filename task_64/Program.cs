// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.


try
{
    Console.WriteLine("Введите значение N (целое число): ");
    int N = Convert.ToInt32(Console.ReadLine());
    Console.Write($"N = {N} -> ");
    int recursion(int N)
    {
        if (N > 0)
        {
            
            Console.Write($"{N} ");
            
            N = N - 1;
            recursion(N);
        }
        return N;
    }
    recursion(N);
}
catch
{
    Console.Write("Нужно было вводить целое число!");
}