// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

/// Ввод числа с консоли и проверка на корректность
double GetNumber(string message)
{
    bool isCorrect = false;
    double result = 0;

    while(!isCorrect)
    {
        Console.WriteLine(message);

        if(double.TryParse(Console.ReadLine(), out result)&& result > 0)
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
/// Точка пересечения
void IntersectionPodouble(double b1,double k1,double b2,double k2)
{
   double x=0,y=0;    
   
   if (k1!=k2)
   {  
        x = (b2-b1)/(k1-k2);
        y = (k2*x)+b2;
        Console.WriteLine($"Координаты пересечения ({x};{y})");
        
   }  
    else  {Console.WriteLine("Линии параллельны");}

}

double b1new=GetNumber("Введите чсило b1");
double k1new=GetNumber("Введите чсило k1");
double b2new=GetNumber("Введите чсило b2");
double k2new=GetNumber("Введите чсило k2");
IntersectionPodouble(b1new,k1new,b2new,k2new);

