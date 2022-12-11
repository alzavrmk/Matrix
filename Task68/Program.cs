// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

UInt64 Ackerman(UInt64 n, UInt64 m)
{
    while (n != 0)
    {
        if (m == 0)
            m = 1;
        else
            m = Ackerman(n, m - 1);
        n = n - 1;
    }
    return m + 1;
}

Console.WriteLine("Введите число: "); 
UInt64 a = Convert.ToUInt64(Console.ReadLine()); 
Console.WriteLine("Введите число:  "); 
UInt64 b = Convert.ToUInt64(Console.ReadLine()); 
Console.WriteLine(Ackerman(a, b));