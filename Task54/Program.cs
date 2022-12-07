// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)// matrix.GetLength(0)-считает количество строк в массиве matrix
    {
        for (int j = 0; j < matr.GetLength(1); j++)//matrix.GetLength(1) - считает количество столбцов в массиве matrix
        {
            matr[i, j] = new Random().Next(1, 40);
        }
    }

}
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
void SortString(int[] array)
{
    int buf = 0;
    int maximum = 0;
    int indexMaximuma = 0;

    for (int j = 0; j < array.Length; j++)
    {
        maximum = array[j];
        indexMaximuma = j;
        for (int i = j + 1; i < array.Length; i++)
        {
            if (array[i] > maximum)
            {
                maximum = array[i];
                indexMaximuma = i;
            }
        }
        buf = array[j];
        array[j] = array[indexMaximuma];
        array[indexMaximuma] = buf;

    }
}
void SortRowMatrix(int[,] matrix)
{
    int[] arr = new int[matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            arr[j] = matrix[i, j];
        }
        SortString(arr);
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j]=arr[j];
        }
    }
}


Console.Write("Ведите количество строк в матрице ");
int m = Convert.ToInt16(Console.ReadLine());

Console.Write("Ведите количество столбцов в матрице ");
int n = Convert.ToInt16(Console.ReadLine());

int[,] matrix = new int[m, n];

FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
SortRowMatrix(matrix);
PrintArray(matrix);
