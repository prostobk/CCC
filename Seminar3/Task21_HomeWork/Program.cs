// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координату X первой точки");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату Y первой точки");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату Z первой точки");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату X второй точки");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату Y второй точки");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату Z второй точки");
int z2 = Convert.ToInt32(Console.ReadLine());

double skobka1 = Math.Pow(x1 - x2, 2);
double skobka2 = Math.Pow(y1 - y2, 2);
double skobka3 = Math.Pow(z1 - z2, 2);
double result = Math.Sqrt(skobka1 + skobka2 + skobka3);
Console.WriteLine($"{result:f2}");