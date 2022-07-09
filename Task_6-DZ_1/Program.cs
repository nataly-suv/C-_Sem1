// Домашнее задание 1. Поиск максимального
Console.WriteLine("Введите первое число");
string? inNumber1 = Console.ReadLine();
Console.WriteLine("Введите второе число");
string? inNumber2 = Console.ReadLine();
if (inNumber1 != null && inNumber2 != null)
{
    int number1 = int.Parse(inNumber1);
    int number2 = int.Parse(inNumber2);
    if (number1 > number2)
    {
        Console.Write("Максимальное число - ");
        Console.Write(number1);
    }
    else
    {
        Console.Write("Максимальное число - ");
        Console.Write(number2);
    }
}
