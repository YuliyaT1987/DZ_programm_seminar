// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

void ShowResult(bool value) // Выводит текстовое сообщение
{
    if (value)
    {
        Console.WriteLine("Это палиндром");
    }
    else
    {
        Console.WriteLine("Это не палиндром");
    }
}

bool isPalindrome(string number) // Определяет является ли число (слово) палиндромом
{
    for (int i = 0; i < number.Length / 2; i++)
    {
        if (number[i] != number[number.Length - 1 - i])
        {
            return false;
        }
    }
    return true;
}

string GetInput(string text) // Выдает запрос на ввод числа (слова)
{
    Console.Write(text);
    return Console.ReadLine();
}

string input = GetInput("Введите число или слово: ");
ShowResult(isPalindrome(input));