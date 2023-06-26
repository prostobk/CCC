// Задача 32: Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

int[] GetRandomArray()
{
    int[] array = new int[5];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(-15, 16);
    }
    return array;
}

int[] masterArray = GetRandomArray();

for (int i = 0; i < masterArray.Length; i++)
{
    masterArray[i] = - masterArray[i];
}

Console.WriteLine($"Начальный массив [ {string.Join(", ", GetRandomArray())} ]");
Console.WriteLine($"Инвертированный массив [ {string.Join(", ", masterArray)} ]");