// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
//метод, который получает число с консоли
int GetNumber(string message)
{
    bool isCorrect = false;
    int result = 0;

    while(!isCorrect)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result) && result > 0)
        {
            isCorrect = true;
        }
        else
        {
            Console.WriteLine("Некорректный ввод. Введите число больше 0.");
        }
    }

    return result;
}

double Degree(int a, int b)
{
    double result= Math.Pow(a,b);
    return result;
}
int A = GetNumber("Введите A");
int B = GetNumber("Введите B");
Console.WriteLine($"Число A в степени B = {Degree(A,B)}");

