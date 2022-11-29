// Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4, 8 -> 2, 4, 6, 8
Console.WriteLine("Введите число");
string s = Console.ReadLine() ?? "";
int value = Math.Abs(Convert.ToInt32(s));
for (int i = 1; i <= value; i++)
{
   if (i % 2 == 0)
    {
         Console.Write(i + " ");
    }
}