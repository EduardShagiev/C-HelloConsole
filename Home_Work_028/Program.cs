// Задача 64: Задайте значение N. Напишите программу, 
//которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
string NaturalRec(int N)
{
    return N>=1 ?  $"{N}, " + NaturalRec(N-1) : String.Empty ;
}
System.Console.WriteLine(NaturalRec(8));