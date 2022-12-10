// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int Summa (int m, int n)
{
    if (m==n) return m;
    return m+Summa(m+1,n);
}

Console.WriteLine("Введите число: "); 
int a = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Введите число: "); 
int b = Convert.ToInt32(Console.ReadLine()); 

if (a<b)
Console.WriteLine($"Сумма чисел от {a} до {b} равна: {Summa(a,b)}"); 
else 
Console.WriteLine($"Сумма чисел от {b} до {a} равна: {Summa(b,a)}"); 
