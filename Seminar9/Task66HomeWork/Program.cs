// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

int SumMandN(int m, int n)
{
    int res = m;
    if (m == n) return 0;
    m++;
    res = m + SumMandN(m, n);
    return res;
}

void SumFromMToN(int m, int n)
{
    Console.Write(SumMandN(m - 1, n));
}

SumFromMToN(m, n);