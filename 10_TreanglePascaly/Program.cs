void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)// matrix.GetLength(0)-считает количество строк в массиве matrix
    {
        for (int j = 0; j < matr.GetLength(1); j++)//matrix.GetLength(1) - считает количество столбцов в массиве matrix
        {
            if (matr[i, j]!=0) Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }

}

void FillArray(int[,] array)
{
    array [0,0]=1;
    for (int i = 1; i < array.GetLength(0); i++)
    {
        for (int j = 1; j < array.GetLength(1)-1; j++)
        {
            array[i, 0]=1;
            array[i,j]=array[i-1,j-1]+array[i-1,j];
        }
    }
}

Console.WriteLine("Введите число N");
int n = Convert.ToInt16(Console.ReadLine());

int[,] matrix = new int[n, n];

PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);