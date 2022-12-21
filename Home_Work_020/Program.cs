// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4. 
// 0,5 7 -2 -0,2 
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int GetNumber (string message)
{
    int result =0;
    while (true)
    {   
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(),out result)&& result>0)
        {
            break;
        }
        else 
        {
            Console.WriteLine("Ввели не корректное значениеб повторите ввод\n");
        }
    }
    return result;
}
//Создание массива
double[,] CreateArray(int m, int n)
{
    double[,] array = new double[m,n];
    return array;
}
//Заполнение массива
void FillingArray(double[,] array)
{
   
    Random random = new Random();
    for (int i = 0; i <array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j]= random.Next(-10,10);//+ random.NextDouble();
        }
    }
}
//Печать массива
void PrintArray(double[,] array)
{
    Console.WriteLine($"Массив:{array.GetLength(0)}x{array.GetLength(1)}");
   for (int i = 0; i <array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j]+" ");
        }
            Console.WriteLine();
    }
}

int msize = GetNumber("Введите кол-во строк  m в двумерном массиве");
int nsize = GetNumber("Введите кол-во столбцов n в двумерном массиве");
double[,] massive = CreateArray(msize,nsize);
FillingArray(massive);
PrintArray(massive);