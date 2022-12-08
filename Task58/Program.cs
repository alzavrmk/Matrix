// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

void FillArray(int[,,] matr)
{//Создаем и заполняем одномерный массив двузначными числами, каждое из которых равно предидущему 
//увеличенному на некоторое случайное число из диапозона от 1..9
    int[] number = new int[8];
    number[0] = new Random().Next(10, 40);
    for (int i = 1; i < 8; i++)
    {
        number[i] = number[i - 1] + new Random().Next(1, 10);
    }
   
//Перемешиваем элементы полученного массива 
    for (int i = 0; i < 8; i++)
    {
        int x = new Random().Next(0, 8);
        if (i != x)
        {
            int buffer = number[i];
            number[i] = number[x];
            number[x] = buffer;

        }
    }
    
    //Заполняем трехмерный массив полученными числами
    int index=0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++)
            {
                matr[i, j, k] = number[index] ;
                index++;
            }

        }
    }
    
}


void PrintArray(int[,,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++)
            {
                Console.Write($"{matr[i, j, k]} ({i},{j},{k})     ");
            }
            Console.WriteLine();
        }

    }

}

int[,,] array = new int[2, 2, 2];
FillArray(array);
PrintArray(array);

