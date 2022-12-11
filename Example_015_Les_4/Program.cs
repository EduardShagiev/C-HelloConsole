//Задача 26: Напишите программу, которая принимает 
//на вход число и выдаёт количество цифр в числе.
//456 -> 3
//78 -> 2
// //89126 -> 5
// int CountOfDigits(int x)
// {
//     int cnt = 0;
//     while (x > 0)
//     {
//         cnt += 1;
//         x /= 10;
//     }
//     return cnt;
// }

// Задача 28: Напишите программу, которая принимает на вход число N и 
//выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

// int Factorial(int N)
// {
//     int i=1;
//     int fact = 1;
//     while (i<=N)
//     {
//         fact=fact*i;
//         i++;
//     }
//     return fact;
// }
// Console.WriteLine(Factorial(4));

// int GetNumber(string message)
// {
//     bool isCorrect = false;
//     int result = 0;

//     while(!isCorrect)
//     {
//         Console.WriteLine(message);

//         if(int.TryParse(Console.ReadLine(), out result) && result > 0)
//         {
//             isCorrect = true;
//         }
//         else
//         {
//             Console.WriteLine("Некорректный ввод. Введите число больше 0.");
//         }
//     }
//         return result;3
// }
// GetNumber("Введите число больше 0:");

//Задача 30: Напишите программу, которая выводит массив из 8 элементов,
// заполненный нулями и единицами в случайном порядке.
//[1,0,1,1,0,1,0,0]

int [] arr=new int[8];
int i=0;
while (i<arr.Length)
{
   arr[i]=new Random().Next(0,2);
   Console.WriteLine(arr[i]);
   i++; 
}




