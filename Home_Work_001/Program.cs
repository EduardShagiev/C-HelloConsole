// Напишите программу, которая на вход принимает два числа и выдаёт, 
//какое число большее, а какое меньшее. a = 5; b = 7 -> max = 7

Console.WriteLine("Введите первоe число A");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число B");
int b = Convert.ToInt32(Console.ReadLine());
if (a>b)
{
    Console.WriteLine($"Число A={a} большее");
} 
else if(b>a) 
{1
    Console.WriteLine($"Число B={b} большее");
}
else 
{
    Console.WriteLine("Оба числа равные");
}
