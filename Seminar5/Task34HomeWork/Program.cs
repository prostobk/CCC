// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] GetMyRandomArray()
{
    int[] array = new int[5];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(100, 1000);
    }

    return array;
}

int ColvoChisel(int[] masiv)
{
    int sumChisel = 0;
    for (int i = 0; i < masiv.Length; i++)
    {
        if (masiv[i] % 2 == 0)
        {
            sumChisel += 1;
        }
    }
    return sumChisel;
}

int[] myArray = GetMyRandomArray();
int colvo = ColvoChisel(myArray);
Console.WriteLine($"{string.Join(", ", myArray)}");
Console.WriteLine($"Количество положительных чисел в массиве равно {colvo}");