// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
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
    Console.WriteLine($"Максимальные возможные индексы двумерного массива [{array.GetLength(0)-1};{array.GetLength(1)-1}]");
}
//Поиск значения в двумерном массиве 
void FindValueInArray(double[,] arr, int posm,int posn)
{
    if (posm<arr.GetLength(0) && posn<arr.GetLength(1))
    {
        double value= arr[posm,posn];
        Console.WriteLine($" Число на позиции [{posm};{posn}] = {value}");
    }
    else Console.WriteLine("Такого элемента нет");
          
}

int msize = GetNumber("Введите кол-во строк  m в двумерном массиве");
int nsize = GetNumber("Введите кол-во столбцов n в двумерном массиве");
double[,] massive = CreateArray(msize,nsize);
FillingArray(massive);
PrintArray(massive);
int pmsize = GetNumber("Введите позицию строки в двумерном массиве");
int pnsize = GetNumber("Введите позицию столбца  в двумерном массиве");
FindValueInArray(massive,pmsize,pnsize);