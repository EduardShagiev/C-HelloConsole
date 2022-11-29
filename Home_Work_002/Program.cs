//Напишите программу, которая принимает на вход три числа и
// выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7, 44 5 78 -> 78, 22 3 9 -> 22
Console.WriteLine("Введите три числа через пробел");
string s = Console.ReadLine() ?? "";
string[] s_arr = s.Split();
int max_value=0;
int index=0;
while(index <3)
{
  if (int.Parse(s_arr[index])>max_value)
  {
        max_value= int.Parse(s_arr[index]);
  }  
  index++;
}
Console.WriteLine($" Max= {max_value}");

