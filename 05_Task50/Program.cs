// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.






void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)// matrix.GetLength(0)-считает количество строк в массиве matrix
    {
        for (int j = 0; j < matr.GetLength(1); j++)//matrix.GetLength(1) - считает количество столбцов в массиве matrix
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }

}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)// matrix.GetLength(0)-считает количество строк в массиве matrix
    {
        for (int j = 0; j < matr.GetLength(1); j++)//matrix.GetLength(1) - считает количество столбцов в массиве matrix
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }

}

void ElementExists(int[,] matr, int x, int y)
{
    int m = matr.GetLength(0);
    int n = matr.GetLength(1);
    if (x <= m && y <= n)
    {
        Console.WriteLine($"Элемент с координатами ({x}, {y}) равен {matr[x-1, y-1]}");
    }
    else
    {
        Console.WriteLine($"Элемент с координатами ({x}, {y}) в данной матрице не существует");
    }
}

Console.Write("Ведите номер строки ");
int numRows = Convert.ToInt16(Console.ReadLine());

Console.Write("Ведите номер столбца");
int numColumns = Convert.ToInt16(Console.ReadLine());

int[,] matrix = new int[10, 10];
FillArray(matrix);
PrintArray(matrix);
ElementExists(matrix,numRows, numColumns);

