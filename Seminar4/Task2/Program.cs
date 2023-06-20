// Задача 26: Напишите программу, которая принимает на вход 
//  число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int ReadInt()
{
    Console.WriteLine("Введите целое число");
    return Convert.ToInt32(Console.ReadLine());
}
int Func(int number)
{
    int colvo = 1;
    while(number >= 10)
    {
        number = number / 10;
        colvo ++;
    }

    return colvo;
}
int number = ReadInt();
int colvo1 = Func(number);
Console.WriteLine($"Количество цифр в числе {number} равно {colvo1}");