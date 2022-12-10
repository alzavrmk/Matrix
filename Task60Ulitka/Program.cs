Console.Write("Ведите размерность квадратной  матрицы ");
int n = Convert.ToInt16(Console.ReadLine());

// Console.Write("Ведите количество столбцов в матрице ");
// int n = Convert.ToInt16(Console.ReadLine());

int[,] matrix = new int[n, n];
// void FillArray(int[,] matr)
// {
// int n = matrix.GetLength(1);
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
            Console.WriteLine($"m[{i}, {j}]={matrix[i,j]}; flag={flag}; vector={vector} min={min}  max={max}");              
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
            Console.WriteLine($"m[{i}, {j}]={matrix[i,j]}; flag={flag}; vector={vector} min={min}  max={max}");       
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
            Console.WriteLine($"m[{i}, {j}]={matrix[i,j]}; flag={flag}; vector={vector} min={min}  max={max}");       
        }
        vector = "up";
    }

    if (flag == 2) break;

if ( vector == "up")
    {
        j = min;
        flag = 0;
        for (i = max - 1; i >= min + 1; i--)
        {
            matrix[i, j] = index++;
            flag++;
            // Console.WriteLine($"m[{i}, {j}]={matrix[i,j]}; flag={flag}; vector={vector} min={min}  max={max}");     
        }
        vector = "rigth";
        max--;
        min++;

    }

}

// if (vector == "left")
// {
//     matrix[i-1,j]=index++;
//     matrix[i-1,j+1]=index++;
// }
// else
// {
//     matrix[i+1,j]=index++;
//     matrix[i+1,j-1]=index++;
// }

// Console.WriteLine($"m[{i}, {j}]={matrix[i,j]}; flag={flag}; vector={vector} min={min}  max={max}");  


// void PrintArray(int[,] matr)
// {

Console.WriteLine($" {i}, {j}, {vector}, {min}, {max}");
for (i = 0; i < n; i++)// matrix.GetLength(0)-считает количество строк в массиве matrix
{
    for (j = 0; j < n; j++)//matrix.GetLength(1) - считает количество столбцов в массиве matrix
    {
        Console.Write($"{matrix[i, j].ToString("d2")}  ");
        //onsole.Write($"{matr[i, j].ToString("n2")}  ");
    }
    Console.WriteLine();
}








// // int n = matr.GetLength(1);
//     int min = 0;
//     int max = n - 1;
//     string vector = "rigth";// Направление обхода
//     int index=0;// Числа массива
//     int flag=0;
//     int i=0;
//     int j=0;

//     // while (n != 2)
//     // {
//         if (vector == "rigth")
//         {
//             i = min;
//             flag = 0;
//             for (j = min; j <= max; j++)
//             {
//                 matrix[i,j]=index++;
//                 flag++; 
//                 Console.WriteLine($"m[{i}, {j}]={matrix[i,j]}; flag={flag}; vector={vector} ");             
//             }
//             vector="down";
//         }

//     //if (flag==2) break;
//     Console.WriteLine();

//          if (vector == "down")
//         {
//             j=max;
//             flag=0;

//             for (i = min+1; i <= max; i++)
//             {
//                 matrix[i, j] = index++;
//                 flag++;
//             Console.WriteLine($"m[{i}, {j}]={matrix[i,j]}; flag={flag}; vector={vector} "); 
//             }
//             vector = "left";            
//         }

//     //     if (flag==2) break;
//         Console.WriteLine();

//         if (vector == "left")
//         {
//             i=max;
//             flag=0;
//             for (j = max-1; j >=min; j--)
//             {
//                 matrix[i, j] = index++;
//                 flag++;
//                 Console.WriteLine($"m[{i}, {j}]={matrix[i,j]}; flag={flag}; vector={vector} "); 
//             }
//             vector = "up";
//         }

//     //      if (flag==2) break;
//      Console.WriteLine();

//         if (vector == "up")
//         {
//             j=min;
//             flag=0;
//             for (i = max-1; i >= min+1; i--)
//             {
//                 matrix[i, j] = index++;
//             }
//             vector = "rigth";
//             max++;
//             min--;
//             Console.WriteLine($" {min}, {max} ");
//         }

//     // }

// if (i>j)
// {
//     matr[i-1,j]=index++;
//     matr[i-1,j+1]=index++;
// }
// else
// {
//     matr[i+1,j]=index++;
//     matr[i+1,j-1]=index++;

// }

// FillArray(matrix);
// PrintArray(matrix);