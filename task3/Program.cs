// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


int numRows=4;
int numColumns=4;
int numMinValue=1;
int numMaxValue=9;

int[,] Matrix1 = GetMatrix(numRows, numColumns, numMinValue, numMaxValue);
int[,] Matrix2 = GetMatrix(numRows, numColumns, numMinValue, numMaxValue);

Print(Matrix1, Matrix2);
Console.WriteLine("Произведение двух матриц:");

PrintNew(NewMatrix(Matrix1, Matrix2));

int[,] GetMatrix(int Rows, int Colums, int min, int max)     
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

void Print(int[,] matrix, int[,] matrix2)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.Write("| ");
        for (int k = 0; k < matrix2.GetLength(1); k++)
        {
            Console.Write(matrix2[i, k] + " ");
        }
        Console.WriteLine();
    }
}
void PrintNew(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < 100) Console.Write(" " + matrix[i, j] + " ");
            else Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] NewMatrix(int[,] matrix, int[,] matrix2)
{
    int[,] newmatrix = new int[matrix2.GetLength(1), matrix.GetLength(1)];

    for (int k = 0; k < matrix.GetLength(0); k++)
    {

        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            int sum = 0;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                sum += matrix[k, j] * matrix2[j, i];
            }
            newmatrix[k, i] = sum;
        }
    }
    return newmatrix;
}
