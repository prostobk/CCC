Console.WriteLine("Введите первое число a: ");
string? numberStringOne = Console.ReadLine();

Console.WriteLine("Введите второе число b: ");
string? numberStringTwo = Console.ReadLine();

int numberIntOne = Convert.ToInt32(numberStringOne);
int numberIntTwo = Convert.ToInt32(numberStringTwo);

if (numberIntOne > numberIntTwo)
{
    Console.WriteLine($"max = {numberIntOne}");
}
else
{
    Console.WriteLine($"max = {numberIntTwo}");
}
if (numberIntTwo > numberIntOne)
{
    Console.WriteLine($"min = {numberIntOne}");
}
else
{
    Console.WriteLine($"min = {numberIntTwo}");
}