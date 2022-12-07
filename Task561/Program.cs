void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)// matrix.GetLength(0)-считает количество строк в массиве matrix
    {
        for (int j = 0; j < matr.GetLength(1); j++)//matrix.GetLength(1) - считает количество столбцов в массиве matrix
        {
            matr[i, j] = new Random().Next(0, 10);
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

int NumberMin(int[] array)//Метод находит номер минимального элемента в массиве
{   
  int min = array[0];
    int i = 1;
    int numberMin = 0;
    while (i < array.Length)
    {
        if (array[i] < min)
        {
            min = array[i];
            numberMin = i;
        }
        i++;
    }
    return numberMin;
}

int NumStringMinSumm(int[,] matr)//Метод находит номер строки с минимальной суммой элементов
{
    int row = matr.GetLength(0);
    int columns = matr.GetLength(1);
    int[] arraySum = new int[row];//Массив для хранения суммы элементов каждой строки
    int sum = 0;

    for (int i = 0; i < row; i++)
    {
        sum = 0;
        for (int j = 0; j < columns; j++)
        {
            sum = sum + matr[i, j];
        }
        arraySum[i] = sum;
    }

    return NumberMin(arraySum);
}

Console.Write("Ведите количество строк в матрице ");
int m = Convert.ToInt16(Console.ReadLine());

Console.Write("Ведите количество столбцов в матрице ");
int n = Convert.ToInt16(Console.ReadLine());

int[,] matrix = new int[m, n];

FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
Console.WriteLine($"Номер строки с минимальной суммой элементов равен {NumStringMinSumm(matrix)}");
