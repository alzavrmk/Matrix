// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void PrintArrayMatrix(int[,] matr)
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

double[] ArithMeanColumns(int[,] matr)
{
    int columns = matr.GetLength(1);
    int rows = matr.GetLength(0);
    double[] arithMeanCol = new double[columns];

    for (int j = 0; j < columns; j++)// matrix.GetLength(0)-считает количество строк в массиве matrix
    {
        int sum = 0;
        for (int i = 0; i < rows; i++)//matrix.GetLength(1) - считает количество столбцов в массиве matrix
        {
            sum = sum + matr[i, j];
        }
        arithMeanCol[j] = Convert.ToDouble (sum)/ Convert.ToDouble(rows);
    }
    return arithMeanCol;
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++) Console.Write($"{array[i]}   ");
    Console.WriteLine();
}


Console.Write("Ведите количество строк в матрице ");
int m = Convert.ToInt16(Console.ReadLine());

Console.Write("Ведите количество столбцов в матрице ");
int n = Convert.ToInt16(Console.ReadLine());

int[,] matrix = new int[m, n];

FillArray(matrix);
PrintArrayMatrix (matrix);
Console.WriteLine();
PrintArray (ArithMeanColumns(matrix));



