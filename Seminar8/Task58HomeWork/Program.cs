// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 6 16
// 9 6

const int ROWS = 3;
const int COLUMNS = 3;

int[,] GetRandomMatrix(int row, int columns)
{
    int[,] matrix = new int[row, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Random.Shared.Next(1, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

void SumMatrix(int[,] firstMartrix, int[,] secondMartrix, int[,] resultMatrix)
{
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < firstMartrix.GetLength(1); k++)
            {
                sum = firstMartrix[i, j] * secondMartrix[i, j];
            }
            resultMatrix[i, j] = sum;
        }
    }
}

int[,] firstMatrix = GetRandomMatrix(ROWS, COLUMNS);
PrintMatrix(firstMatrix);
Console.WriteLine();
int[,] secondMatrix = GetRandomMatrix(ROWS, COLUMNS);
PrintMatrix(secondMatrix);
Console.WriteLine();
int[,] resultMatrix = GetRandomMatrix(ROWS, COLUMNS);
SumMatrix(firstMatrix, secondMatrix, resultMatrix);
PrintMatrix(resultMatrix);