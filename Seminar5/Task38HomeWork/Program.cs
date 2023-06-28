// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double[] GetRandomArray()
{
    double[] array = new double[5];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.NextDouble() * 100;
    }
    return array;
}

double FindMax(double[] massiv)
{
    double max = massiv[0];
    for (int i = 0; i < massiv.Length; i++)
    {
        if (max < massiv[i])
        {
            max = massiv[i];
        }
    }
    return max;

}

double FindMin(double[] massiv)
{
    double min = massiv[0];
    for (int i = 0; i < massiv.Length; i++)
    {
        if (min > massiv[i])
        {
            min = massiv[i];
        }
    }
    return min;

}

double[] array = GetRandomArray();
double max = FindMax(array);
double min = FindMin(array);
Console.WriteLine($"{string.Join(", ", array)}");
Console.WriteLine($"Максимальный элемент в массиве - {max}");
Console.WriteLine($"Минимальный элемент в массиве - {min}");
Console.WriteLine($"Разница между ними равна {max - min}");