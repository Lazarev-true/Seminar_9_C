// Напишите программу вычисления функции 
// Аккермана с помощью рекурсии. Даны 
// два неотрицательных числа m и n.

Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());

int FunctionAckermann(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    if ((m > 0) && (n == 0))
    {
        return FunctionAckermann(m - 1, 1);
    }
    if ((m > 0) && (n > 0))
    {
        return FunctionAckermann(m - 1, FunctionAckermann(m, n - 1));
    }
    return FunctionAckermann(m, n);
}

if(m >= 0 && n >= 0)
{
    Console.WriteLine($"Функция Аккермана  A({m}, {n}) = {FunctionAckermann(m, n)}");
}
else
{
    Console.WriteLine("Некорректное число");
}
