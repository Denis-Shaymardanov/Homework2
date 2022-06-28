//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

int ThirdDigit(int number)
{
    while (number > 999) number = number/10;
    int result = number%10;
    return result;
}

bool lengthMoreThan2(int number)
{
    bool result = number > 99;
    return result;
}

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
if (lengthMoreThan2(num)) Console.WriteLine("Третья цифра введённого Вами числа - " + ThirdDigit(num));
else Console.WriteLine("Третьей цифры нет");
