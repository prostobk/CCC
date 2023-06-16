// Напишите программу, которая принимает на вход 
// координаты двух точек и находит расстояние 
// между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("Введите координату X первой точки");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату Y первой точки");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату X второй точки");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату Y второй точки");
int y2 = Convert.ToInt32(Console.ReadLine());

// Math.Pow(x, 2) - квадрат
// Math.Sqrt(x) - корень

double skobka1 = Math.Pow(x1 - x2, 2);
double skobka2 = Math.Pow(y1 - y2, 2);
double result = Math.Sqrt(skobka1 + skobka2);
Console.WriteLine($"{result:f2}");