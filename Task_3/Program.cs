// третья задача на 1-ом семинаре. Вывести день недели по номеру
Console.WriteLine("Введите число от 1 до 7");
string? inNumber = Console.ReadLine();
if (inNumber != null)
{
    int number = int.Parse(inNumber);
    // string[] dayOfWeek = new string[7];
    // dayOfWeek[0] = "понелельник";
    // dayOfWeek[1] = "вторник";
    // dayOfWeek[2] = "среда";
    // dayOfWeek[3] = "четверг";
    // dayOfWeek[4] = "пятница";
    // dayOfWeek[5] = "суббота";
    // dayOfWeek[6] = "воскресенье";
    // Console.WriteLine(dayOfWeek[number-1]);
    switch (number)
    {
        case 1:
            Console.WriteLine("понедельник");
            break;
        case 2:
            Console.WriteLine("вторник");
            break;
        case 3:
            Console.WriteLine("среда");
            break;
        case 4:
            Console.WriteLine("четверг");
            break;
        case 5:
            Console.WriteLine("пятница");
            break;
        case 6:
            Console.WriteLine("суббота");
            break;
        case 7:
            Console.WriteLine("воскресенье");
            break;
    }
}