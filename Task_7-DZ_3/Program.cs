// Домашнее задание 3. Проверка числа начетность
Console.WriteLine("Введите число");
string? inNumber = Console.ReadLine();
if (inNumber != null)
{
    int number = int.Parse(inNumber);
    if (number%2 == 0)
    {
        Console.WriteLine("число четное");
    }
    else{
        Console.WriteLine("число нечетное");
    }
}