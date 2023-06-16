// Напишите программу, которая по
//  заданному номеру четверти, показывает диапазон возможных
//  координат точек в этой четверти (x и y).
Console.WriteLine("Введите номер четверти 1-4");
int numQ = Convert.ToInt32(Console.ReadLine());
if (numQ == 1)
{
    Console.WriteLine("x > 0, Y > 0");
}
else if (numQ == 2)
{
    Console.WriteLine("x > 0, y > 0");
}
else if (numQ == 3)
{
    Console.WriteLine("x < 0, y > 0");
}
else if (numQ == 4)
{
    Console.WriteLine("x < 0, y < 0");
}
else
{
    Console.WriteLine("Wrong Hole!!");
}