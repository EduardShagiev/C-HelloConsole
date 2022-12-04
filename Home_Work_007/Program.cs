// Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да 7 -> да 1 -> нет
Console.WriteLine("Ввидите число от 1 до 7");
int  value = Convert.ToInt32((Console.ReadLine()??""));
if (value <8)
{
    if (value < 6) Console.WriteLine($"{value} -> Не выходной день");
    else Console.WriteLine($"{value} -> Выходной день");
}
else Console.WriteLine("Не правильный ввод числа");