// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

int number = 10;

void Perechislenie(int lastNumber)
{
    if (lastNumber <= 0) return;
    Perechislenie (lastNumber - 1);
    Console.Write (lastNumber + ", " );
}
Perechislenie(number);