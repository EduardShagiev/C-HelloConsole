// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int NaturalRec(int M, int N)
{
    return M<=N ?  M + NaturalRec(M+1,N) : 0 ;
}
System.Console.WriteLine(NaturalRec(1,20));

