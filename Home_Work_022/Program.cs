// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
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
//Печать двумерного массива
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
//Печать одномерного массива
void PrintArrayOne(double[] array)
{
  Console.WriteLine("Массив из средне арифметических значений ");
    for (int i = 0; i <array.Length; i++)
    {
            
        Console.Write(array[i]+" ");
    }
}
//Cреднее арифметическое элементов в каждом столбце
double[] AverageSum(double[,] array)
{
    double[] sum = new double[array.GetLength(1)];
    double[] average = new double[array.GetLength(1)];
    int j=0;
    while (j<array.GetLength(1))
    {   
        
        for (int i = 0; i < array.GetLength(0); i++)
        {
          sum[j]+=array[i,j];
        }
        average[j]=sum[j]/array.GetLength(0); 
        j++;
    }
    return average;
}

int msize = GetNumber("Введите кол-во строк  m в двумерном массиве");
int nsize = GetNumber("Введите кол-во столбцов n в двумерном массиве");
double[,] massive = CreateArray(msize,nsize);
FillingArray(massive);
PrintArray(massive);
double[] val =AverageSum(massive);
PrintArrayOne(val);


