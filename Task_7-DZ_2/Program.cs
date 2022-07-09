// Домашнее задание 2. Поисх мах их 3-х
Console.WriteLine("введите первое число");
string? inNumber1 = Console.ReadLine();
Console.WriteLine("введите второе число");
string? inNumber2 = Console.ReadLine();
Console.WriteLine("введите третье число");
string? inNumber3 = Console.ReadLine();
if (inNumber1 != null && inNumber2 != null && inNumber3 != null)
{
    int number1 = int.Parse(inNumber1);
    int number2 = int.Parse(inNumber2);
    int number3 = int.Parse(inNumber3);
    int maxNumber = number1;
    if (number2 > maxNumber)
    {
        maxNumber=number2;
    }
    if (number3>maxNumber)
    {
        maxNumber=number3;
    }
    Console.Write("максимальное число - ");
    Console.Write(maxNumber);
}