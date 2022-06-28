//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

string IsHoliday(int number)
{
    bool isHoliday = (number==6|number==7);
    string result = "Нет";
    if (isHoliday) result = "Да";
    return result;
}

bool numIsCorrect(int number)
{
    bool result = (number > 0) & (number < 8);
    return result;
}

Console.WriteLine("Введите число, обозначающее день недели");
int num = Convert.ToInt32(Console.ReadLine());
if (numIsCorrect(num)) Console.WriteLine("Это выходной - " + IsHoliday(num));
else Console.WriteLine("Вы ввели неправильное число");
