int number = Random.Shared.Next(100, 1000);
Console.WriteLine(number);
int minDigit = number / 100;
Console.WriteLine(minDigit);
int maxDigit = number % 10;
Console.WriteLine(maxDigit);
Console.WriteLine(minDigit * 10 + maxDigit);