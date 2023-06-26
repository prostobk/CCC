// Задача 25: Напишите функцию, которая принимает на вход два числа (A и B)
//  и возводит число A в натуральную степень B. НЕ ИСПОЛЬЗОВАТЬ MATH.POW()
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int NumberInt()
{
    Console.WriteLine("Введите число");
    return Convert.ToInt32(Console.ReadLine());
}
int ExponInt()
{
    Console.WriteLine("Введите степень");
    return Convert.ToInt32(Console.ReadLine());
}

int number = NumberInt();
int exponent = ExponInt();
Console.WriteLine(Math.Pow(number, exponent));