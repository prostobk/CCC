Console.WriteLine("Введите первое число: ");
string? numberStringOne = Console.ReadLine();

Console.WriteLine("Введите второе число: ");
string? numberStringTwo = Console.ReadLine();

Console.WriteLine("Введите третье число: ");
string? numberStringThree = Console.ReadLine();

int numberIntOne = Convert.ToInt32(numberStringOne);
int numberIntTwo = Convert.ToInt32(numberStringTwo);
int numberIntThree = Convert.ToInt32(numberStringThree);

int max = numberIntOne;

if (max < numberIntTwo) max = numberIntTwo;
if (max < numberIntThree) max = numberIntThree;

Console.WriteLine("Максимальное из этих чисел " + max);