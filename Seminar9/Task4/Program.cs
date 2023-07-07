// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

int number = 145;

int SummaChisel(int chislo)
{
    if (chislo <= 0) return 0;
    return SummaChisel(chislo / 10) + (chislo % 10);
}

int result = SummaChisel(number);
Console.WriteLine(result);