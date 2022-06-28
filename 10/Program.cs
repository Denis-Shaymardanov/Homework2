int SecondDigit(int number)
{
    int result = number/10%10;
    return result;
}

bool numIsCorrect(int number)
{
    int quotient = number/100;

    bool result = (quotient != 0) & (quotient < 10);
    return result;
}

Console.WriteLine("Введите трёхзначное число");
int num = Convert.ToInt32(Console.ReadLine());
if (numIsCorrect(num)) Console.WriteLine("Вторая цифра введённого Вами числа - " + SecondDigit(num));
else Console.WriteLine("Вы ввели некорректное число");
