// Напишите программу, которая принимает на вход 
// пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет 12821 -> да 23432 -> да
Console.WriteLine("Введите число");
string s = Console.ReadLine() ?? "";
char[] str = s.ToCharArray();

void CheckPalim(char[] value)
{
    int len = value.Length;
    int first = 0;
    int last = len - 1;
    bool Palindrome = true;
    while (first < last)
    {
        if (str[first] == str[last])
        {
            first = first + 1;
            last = last - 1;
        }
        else
        {
            Palindrome = false;
            break;
        }
    }
    if (Palindrome) { Console.Write("Чиcло палиндром"); }
    else { Console.Write("Чиcло не палиндром"); }
}

CheckPalim(str);

