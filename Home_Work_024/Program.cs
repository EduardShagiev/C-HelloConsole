// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер
// строки с наименьшей суммой элементов: 1 строка
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
            array[i,j]= random.Next(0,10);//+ random.NextDouble();
        }
    }
}
//Печать массива
void PrintTwoArray(double[,] array)
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
    Console.WriteLine();
}
void PrintOneArray(double[] array)
{
    Console.WriteLine("Массив с суммами строк:");
   for (int i = 0; i <array.Length; i++)
    {     
         Console.Write(array[i]+" ");     
    }
    System.Console.WriteLine();
}
//Сумма элементов строки
double[] SumInRows(double[,] matrix)
{
    double[] temp = new double[matrix.GetLength(0)];
    
    for (int i = 0; i <matrix.GetLength(0); i++)
    {   double summa=0;

        for (int j = 0; j <matrix.GetLength(1); j++)
        {
            summa+=matrix[i,j];
        }
        temp[i]= summa;
    }
    return temp;
}
//Поиск строки с наименьшей суммой элементов
int FindMinElem(double[] arr)
{   
    int stroka=0;
    double[] min= new double[1];
    min[0]=arr[0];
    for (int i = 0; i <arr.Length; i++)
    {
        if(min[0]>arr[i])
        {
            min[0]=arr[i];
            stroka=i;
        }
    }
    return stroka;
}

int msize = GetNumber("Введите кол-во строк  m в двумерном массиве");
int nsize = GetNumber("Введите кол-во столбцов n в двумерном массиве");
double[,] massive = CreateArray(msize,nsize);
FillingArray(massive);
PrintTwoArray(massive);
double[] onearray = SumInRows(massive);
PrintOneArray(onearray);
int index = FindMinElem(onearray);
System.Console.WriteLine($"Cтрока с наименьшей суммой элементов: {index+1}");