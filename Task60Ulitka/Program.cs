Console.Write("Ведите размерность квадратной  матрицы ");
int n = Convert.ToInt16(Console.ReadLine());

int[,] matrix = new int[n, n];
FillArray (matrix);
PrintArray (matrix);


void FillArray(int[,] matrix)
{
    int n = matrix.GetLength(0);
    int min = 0;
    int max = n - 1;
    string vector = "rigth";// Направление обхода
    int index = 0;// Числа массива
    int flag = 0;
    int i = 0;
    int j = 0;

    while (n != 2)
    {
        if (vector == "rigth")
        {
            i = min;
            flag = 0;
            for (j = min; j <= max; j++)
            {
                matrix[i, j] = index++;
                flag++;
                //Console.WriteLine($"m[{i}, {j}]={matrix[i, j]}; flag={flag}; vector={vector} min={min}  max={max}");
            }
            vector = "down";
        }

        if (flag == 2) break;

        if (vector == "down")
        {
            j = max;
            flag = 0;

            for (i = min + 1; i <= max; i++)
            {
                matrix[i, j] = index++;
                flag++;
                //Console.WriteLine($"m[{i}, {j}]={matrix[i, j]}; flag={flag}; vector={vector} min={min}  max={max}");
            }
            vector = "left";
        }

        if (flag == 2) break;

        if (vector == "left")
        {
            i = max;
            flag = 0;
            for (j = max - 1; j >= min; j--)
            {
                matrix[i, j] = index++;
                flag++;
                //Console.WriteLine($"m[{i}, {j}]={matrix[i, j]}; flag={flag}; vector={vector} min={min}  max={max}");
            }
            vector = "up";
        }

        if (flag == 2) break;

        if (vector == "up")
        {
            j = min;
            flag = 0;
            for (i = max - 1; i >= min + 1; i--)
            {
                matrix[i, j] = index++;
                flag++;
                //Console.WriteLine($"m[{i}, {j}]={matrix[i, j]}; flag={flag}; vector={vector} min={min}  max={max}");
            }
            vector = "rigth";
            max--;
            min++;
        }
        if (flag == 2) break;

    }
    //Console.WriteLine($" {i}, {j}, {vector}, {min}, {max}");

    if (vector == "left")
    {
        i = max;
        for (j = max - 1; j >= min; j--)
        {
            matrix[i, j] = index++;
        }
        i = max - 1;
        for (j = min; j <= max - 1; j++)
        {
            matrix[i, j] = index++;
        }
    } 
    else
    if (vector == "rigth")
    {
        matrix[min, min] = index++;
        matrix[min, min+1] = index++;
        matrix[min+1, min+1] = index++;
        matrix[min+1, min] = index++;
    }
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)// matrix.GetLength(0)-считает количество строк в массиве matrix
    {
    for (int j = 0; j < matrix.GetLength(1); j++)//matrix.GetLength(1) - считает количество столбцов в массиве matrix
    {
        Console.Write($"{matrix[i, j].ToString("d3")}  ");
        //onsole.Write($"{matr[i, j].ToString("n2")}  ");
    }
    Console.WriteLine();
}

}
