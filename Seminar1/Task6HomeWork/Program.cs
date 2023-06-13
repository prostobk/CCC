Console.WriteLine("Введите число для проверки на чётность: ");
string? numberStringOne = Console.ReadLine();

int numberIntOne = Convert.ToInt32(numberStringOne);

if (numberIntOne %2 == 0)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}