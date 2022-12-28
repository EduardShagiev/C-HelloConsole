//Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
//A (3,6); B (2,1) -> 5,09 
//A (7,-5); B (1,-1) -> 7,21  AB = √(xb - xa)2 + (yb - ya)2

double DistBetPoint (int x1, int y1, int x2, int y2)
{
  double result = Math.Sqrt(((x2 - x1)*(x2 - x1)) + ((y2-y1)*(y2-y1)));
  return result;
} 

Console.WriteLine(DistBetPoint(3,6,2,1));
Console.WriteLine(DistBetPoint(7,-5,1,-1));

// string NumbersRes(int a , int b)
// {
//     if (a<=b) return $"{a} " + NumbersRes(a+2,b);
//     else return String.Empty;
// }
// System.Console.WriteLine(NumbersRes(1,10));

// int SumRec(int n)
// {
//     if (n==0) return 0;
//     else return n+SumRec(n-1);
// }
// System.Console.WriteLine(SumRec(15));

// int FactorialRec(int n)
// {
//     if (n==1) return 1;
//     else return n*FactorialRec(n-1);
// }
// System.Console.WriteLine(FactorialRec(6));

// int DegreelRec(int a, int n)
// {
//     //return n==0 ? 1 : DegreelRec(a,n-1)*a;
//     if (n==0) return 1;
//     else return DegreelRec(a,n-1)*a;
// }
// System.Console.WriteLine(DegreelRec(2,4));