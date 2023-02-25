// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке 
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] Massiv = GetMatrix(4,4, 1, 9);

Print(Massiv);

Console.WriteLine($"-------->{Search(Massiv)} строка");


int[,] GetMatrix(int Rows, int Colums, int min, int max)        //рандомная интовая матрица
{
    int[,] matrix = new int[Rows, Colums];
    for (int i = 0; i < Rows; i++)
    {
        for (int j = 0; j < Colums; j++)
        {
            matrix[i, j] = new Random().Next(min, max + 1);
        }
    }
    return matrix;
}

void Print(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}

int SumOneRow(int[,] array, int i)
{
    int sumLine = array[i, 0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        sumLine += array[i, j];
    }
    return sumLine;
}

int Search(int[,] array)
{
    int min = SumOneRow(array, 0);
    int count = 0;
    int i = 0;

    while (i < array.GetLength(0))
    {
        if (min < SumOneRow(array, i))
        {
            i++;
        }
        else
        {
            min = SumOneRow(array, i);
            count = i+1;
            i++;
        }

    }
    return count;
}