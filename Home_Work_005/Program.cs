//  Напишите программу, которая принимает на вход трёхзначное
// число и на выходе показывает вторую цифру этого числа.
// 456 -> 5 782 -> 8 918 -> 1

Console.WriteLine("Ввидите число");
int number = Convert.ToInt32(Console.ReadLine());

int SecondNumber(int value)
{
    int result = (value%100)/10; 
    return result; 
} 
Console.WriteLine(SecondNumber(number));