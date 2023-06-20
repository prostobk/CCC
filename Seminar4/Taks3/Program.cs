// Задача 28: Напишите программу, которая принимает на вход число N
// и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

int ReadInt(string message)
{
    Console.WriteLine("Введите целое число");
    return Convert.ToInt32(Console.ReadLine());
}

int SumFrom1ToA(int a)
{
    int pro = 0;
    for (int i = 1; i <= a; i++)
    {
        pro = i * i;
    }

    return pro;
}

int number = ReadInt("Введите сообщение");
int proizv = SumFrom1ToA(number);
Console.WriteLine($"Произведение чисел от 1 до {number} равна {proizv}");