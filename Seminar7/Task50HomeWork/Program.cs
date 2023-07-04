// Задача 50. Напишите программу, которая на вход принимает 
// позиции элемента в двумерном массиве, и возвращает значение 
// этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого числа в массиве нет
// 1, 2 -> 2

void FillMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = Random.Shared.Next(1, 10);
        }
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i,j] + "   ");
        }
        Console.WriteLine();
    }
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] matrix = new int[10, 10];
FillMatrix(matrix);
PrintMatrix(matrix);

int rows = ReadInt("Введите индекс строки: ");
int columns = ReadInt("Введите индекс столбца: ");

if (rows < matrix.GetLength(0) && columns < matrix.GetLength(1)) Console.WriteLine(matrix[rows, columns]);
else Console.WriteLine($"{rows}, {columns} -> такого числа в массиве нет");