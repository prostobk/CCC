// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] GetRandomArray()
{
    int[] array = new int[10];

    for (int i = 0; i <array.Length; i++)
    {
        array[i] = Random.Shared.Next(1, 3);
    }
    return array;
}

int SumNechElement(int[] mass)
{
    int sumNech = 0;
    for (int i = 1; i <= mass.Length; i = i+2)
    {
        sumNech += mass[i];
    }
    return sumNech;
}

int[] myArray = GetRandomArray();
int sum = SumNechElement(myArray);
Console.WriteLine($"{string.Join(", ", myArray)}");
Console.WriteLine($"Сумма нечётных элементов равна {sum}");