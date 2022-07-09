// Домашее задание 4. Вывод четных чисел
Console.WriteLine("Введите число");
string? inNumber = Console.ReadLine();
if (inNumber != null)
{
    int number = int.Parse(inNumber);
    string line = "";
    int countNumber = 2;
    if (number > 1)
    {
        while (countNumber < number)
        {
            line = line + countNumber + ", ";
            countNumber = countNumber + 2;
        }
        if (number % 2 == 0)
        {
            line = line + number;
        }
        Console.WriteLine(line);
    }
    else
    {
        Console.WriteLine("нет значений, удовлетворяющих условию");
    }
}