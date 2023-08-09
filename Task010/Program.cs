// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int SecondDigit (int num)
{
    int doubleDigit = num/10;
    int secondDigit = doubleDigit%10;
    return secondDigit;
}

Console.WriteLine ("Введите трехзначное число: ");
int number = Convert.ToInt32 (Console.ReadLine ());
if (number >= 100 && number <= 999)
{
    int result = SecondDigit(number);
    Console.WriteLine ($"Вторая цифра введенного числа: {result}");
}
else
{
    Console.WriteLine ($"Ошибка ввода");
}