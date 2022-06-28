int SecondDigit(int number)
{
    int result = number/10%10;
    return result;
}

bool numIsCorrect(int number)
{
    bool result = (number > 99) & (number < 1000);
    return result;
}

Console.WriteLine("Введите трёхзначное число");
int num = Convert.ToInt32(Console.ReadLine());
if (numIsCorrect(num)) Console.WriteLine("Вторая цифра введённого Вами числа - " + SecondDigit(num));
else Console.WriteLine("Вы ввели некорректное число");
