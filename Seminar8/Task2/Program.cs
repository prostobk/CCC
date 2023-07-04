// Задача 55: Задайте двумерный массив. Напишите программу, 
// которая заменяет строки на столбцы. 

const int ROWS = 3;
const int COLUMNS = 4;
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

int[,] MatrixNew(int[,] matrix)
{
    int rowCount = matrix.GetLength(0);
    int columnCount = matrix.GetLength(1);
    int[,] matrixT = new int[columnCount, rowCount];
    for (int i = 0; i < rowCount; i++)
    {
        for (int j = 0; j < columnCount; j++)
        {
            matrixT[j, i] = matrix[i, j];
        }
    }
    return matrixT;
}

int[,] myMatrix = GetRandomMatrix(ROWS, COLUMNS);
PrintMatrix(myMatrix);
Console.WriteLine();
int[,] matrixT = MatrixNew(myMatrix);
PrintMatrix(matrixT);