// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] 
// сумма положительных чисел равна 29, сумма отрицательных равна -20.

int[] GetRandomArray()
{
    int[] array = new int[12];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(-9, 10);
    }
    return array;
}

int SumPosEl(int[] massive)
{
    int sumOfPositiveElements = 0;
    for (int i = 0; i < massive.Length; i++)
    {
        if (massive[i] > 0)
        {
            sumOfPositiveElements += massive[i];
        }
    }

    return sumOfPositiveElements;
}

int SumNegEl(int[] massive)
{
    int sumOfNegElements = 0;
    for (int i = 0; i < massive.Length; i++)
    {
        if (massive[i] < 0)
        {
            sumOfNegElements += massive[i];
        }
    }

    return sumOfNegElements;
}

int [] myArray = GetRandomArray();
int sumPositive = SumPosEl(myArray);
int sumNegative = SumNegEl(myArray);

Console.WriteLine($"[ {string.Join(", ", myArray)} ]");
Console.WriteLine($"Сумма положительных элементов равна = {sumPositive}");
Console.WriteLine($"Сумма отрицательных элементов равна = {sumNegative}");