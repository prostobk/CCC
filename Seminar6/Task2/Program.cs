// Задача 40: Напишите программу, которая принимает на вход
// три числа и проверяет, 
//  может ли существовать треугольник со сторонами такой длины.

Console.WriteLine("Введите первую сторону треугольника ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите вторую сторону треугольника ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третью сторону треугольника ");
int c = Convert.ToInt32(Console.ReadLine());

if (a < b + c && b < a + c && c < a + b)
{
    Console.WriteLine("Такой треугольник может существовать");
}
else Console.WriteLine("Такой треугольник невозможен!");