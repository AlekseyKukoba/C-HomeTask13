// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5 
// 78 -> третьей цифры нет 
// 32679 -> 6
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
bool ValidateNumber(int number)
{
    if(number < 100)
    {
        Console.WriteLine("Третьей цифры нет");
        return false;
    }
    return true;
}
int GetThirdRank(int number)
{
    while (number > 999)
    {
        number /= 10;
    }
    return number % 10;
}
if (ValidateNumber(number))
{
Console.WriteLine(GetThirdRank(number));
}

