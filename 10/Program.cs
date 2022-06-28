//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1
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
