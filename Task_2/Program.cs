// вторая задача на 1-ом семинаре. Яв-ля ли первое число квадратом второго
Console.WriteLine("Введите первое число");
string? inNumber1 = Console.ReadLine();
Console.WriteLine("Введите второе число");
String? inNumber2 = Console.ReadLine();
if (inNumber1 != null && inNumber2 != null)
{
    int number1 = int.Parse(inNumber1);
    int number2 = int.Parse(inNumber2);
    // if (number1 == number2 * number2)
    // {
    //     Console.Write("Yes");
    // }
    // else
    // {
    //     Console.Write("No");
    // }
    if (Math.Sqrt(number1) == number2)
    {
        Console.Write("Yes");
    }
    else
    {
        Console.Write("No");
    }
}