// Домашее задание 4. Вывод четных чисел от 1 до N
Console.WriteLine("Введите число");
string? inNumber = Console.ReadLine(); 
if (inNumber != null)
{
    int number = int.Parse(inNumber);
    string line = "";              // задаем пустую строку
    int countNumber = 2;  // присваиваем счетчику значение 2. Т.к. выводим четные числа от 1, т.е. начем сразу с 2
    if (number > 1)
    {
        while (countNumber < number)    // проверка: если наш счетчик меньше введенного чила, то остаемся в цикле
        {
            line = line + countNumber + ", ";  // добавляем в строку значение счетчика
            countNumber = countNumber + 2;     // увеличиваем счетчик на 2, т.к. нам нужны тольк очетные числа
        }
        if (number % 2 == 0)   // проверяем само введенное число на четность, чтобы добавить его в строку
        {
            line = line + number;
        }
        char[] del = {',', ' '};     
        // создали массив del с типом char, в который вложили ',' и пробел (эти символы будем удалять с конца)
        string lineItog = line.TrimEnd(del);  
        // создали новую строку lineItog, обрадились к методу TrimEnd, чтобы с троке line удалить "," и пробел
        Console.WriteLine(lineItog);
    }
    else
    {
        Console.WriteLine("нет значений, удовлетворяющих условию");
    }
}
