//Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка).
//4 -> да, -3 -> нет, 7 -> нет
Console.WriteLine("Введите число");
string s = Console.ReadLine() ?? "";
int value = Math.Abs(Convert.ToInt32(s));
if (value%2 ==0)
{
 Console.WriteLine($"Число {value} четное");   
}
else
{
    Console.WriteLine($"Число {value} не четное");  
}
