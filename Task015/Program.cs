// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

bool Holiday(int num)
{
    if (num == 6 || num == 7)
    {
        return true;
    }
    return false;
}

Console.WriteLine("Введите число: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

if (dayNumber >0 && dayNumber < 6)
{
   Console.WriteLine("Это будний день");
}
else if (dayNumber >5)
{
    bool result = Holiday (dayNumber);
    Console.WriteLine("Это выходной");
}
else
{
    Console.WriteLine("Ошибка ввода");
}