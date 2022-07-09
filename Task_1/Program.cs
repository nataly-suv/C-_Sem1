// первая задача на 1-ом семинаре. Поиск квадрата числа
Console.WriteLine("Введите число");
String? innumber = Console.ReadLine();
if (innumber != null)
{
    int number = int.Parse(innumber);
    //int outNumber = number*number;
    int outNumber = (int)Math.Pow(number, 2);
    Console.Write("ответ: ");
    Console.Write(outNumber);
}