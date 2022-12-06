// Напишите программу, которая принимает на вход число 
//(N) и выдаёт таблицу квадратов чисел 
// от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4
Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());

void SQRT(int value)
{
  for (int i = 1; i <= value; i++)
  {
    int result = i*i; 
    Console.Write( result + " ");
  }  
}
SQRT(N);
