// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9



void FillArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)// matrix.GetLength(0)-считает количество строк в массиве matrix
    {
        for (int j = 0; j < matr.GetLength(1); j++)//matrix.GetLength(1) - считает количество столбцов в массиве matrix
        {
            matr[i, j] = Convert.ToDouble(new Random().Next(0,100))/Convert.ToDouble(new Random().Next(1,100));
        }
    }

}

void PrintArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)// matrix.GetLength(0)-считает количество строк в массиве matrix
    {
        for (int j = 0; j < matr.GetLength(1); j++)//matrix.GetLength(1) - считает количество столбцов в массиве matrix
        {
            // string result = string.Format("{0:n2}", matr[i, j]);
            // Console.Write($"{result}  ");
            Console.Write($"{matr[i, j].ToString("n2")}  ");
        }
        Console.WriteLine();
    }

}

Console.Write("Ведите количество строк в матрице ");
int m = Convert.ToInt16(Console.ReadLine());

Console.Write("Ведите количество столбцов в матрице");
int n = Convert.ToInt16(Console.ReadLine());

double[,] matrix = new double[m, n];

FillArray(matrix);
PrintArray(matrix);
