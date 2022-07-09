// четвертая задача на 1-ом семинаре. Вывести целые числа от -N до N
// Console.WriteLine("Введите положительное число");
// string? inNumber = Console.ReadLine();
// if (inNumber != null)
// {
//     int number = int.Parse(inNumber);
//     int startNumber = number * -1;
//     string line = "";
//     while (startNumber < number)
//     {
//         line = line + startNumber + ", ";
//         startNumber++;
//     }
//     line = line + number;
//     Console.WriteLine(line);
// }

Console.WriteLine("Введите положительное число");
string? inNumber = Console.ReadLine();
if (inNumber != null)
{
    int number = int.Parse(inNumber);
    int startNumber = 1;
    string line = "0";
    while (startNumber <= number)
    {
        line = startNumber * (-1) + ", " + line + ", " + startNumber + ", ";
        startNumber++;
    }
        Console.WriteLine(line);
}