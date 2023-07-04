// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,7; 5,7; 3,7; 3.

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}


void PrintArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


void PrintArray1D(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "; ");
    }
    Console.WriteLine();
}

int rows = 5;
int colums = 5;
int[,] matrix = new int[rows, colums];
FillArray(matrix);
PrintArray2D(matrix);

double[] stolMatrix = new double[matrix.GetLength(1)];

for (int i = 0; i < matrix.GetLength(1); i++)
{
    double result = 0;
    for (int j = 0; j < matrix.GetLength(0); j++)
    {
        result += matrix[j, i];
    }
    stolMatrix[i] = result / matrix.GetLength(0);
}

Console.Write("Среднее арифметическое всех столбцов массива равно ");
PrintArray1D(stolMatrix);