// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int ThirdDigit(int num)
{
    while (num >= 1000)
    {
        num = num / 10;
    }
    int thirdDigit = num % 10;
    return thirdDigit;
}

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 100)
{
    int result = ThirdDigit(number);
    Console.WriteLine($"Третья цифра введенного числа: {result}");
}
if (number >= 0 && number < 100)
{
    Console.WriteLine("Третьей цифры нет");
}
if (number <0)
{
    Console.Write("Ошибка ввода");
}