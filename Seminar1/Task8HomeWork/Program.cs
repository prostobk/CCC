Console.WriteLine("Введите число N: ");
string? numberStringOne = Console.ReadLine();
int numberIntOne = Convert.ToInt32(numberStringOne);
for (int i = 1; i<=numberIntOne; i++)
{
    if (i % 2 == 0)
    Console.WriteLine(i);
}