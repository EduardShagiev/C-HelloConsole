// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
 double[,,] n = new double[2, 2, 2]
 {
    {
        {66,25},
        {27,90}
    },
    {
        {34,26},
        {41,55}
    }   
 };
 
 //Ввод числа с консоли
int GetNumber(string message)
{
    int result = 0;
    while (true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result) && result > 0)
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
double[,,] CreateArray(int p, int m, int n)
{
    double[,,] array = new double[p,m, n];
    return array;
}
//Заполнение массива
void FillingArray(double[,,] array)
{

    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
           for (int k = 0; k < array.GetLength(2); k++)
           {
              array[i, j,k] = random.Next(10, 100);
           }
          
        }
    }
}
//Печать массива
void PrintThirdArray(double[,,] array)
{
        for (int x = 0; x < array.GetLength(0); x++)
        {
            System.Console.WriteLine();
            for (int y = 0; y < array.GetLength(1); y++)
            {
                 System.Console.WriteLine();
                for (int z = 0; z <array.GetLength(2); z++)
                {
                    Console.Write ($"{array[x,y,z]}[{x},{y},{z},] ");
                }
                 
            }
        }
}   

int Psize = GetNumber("Введите кол-во страниц p в двумерном массиве ");
int Msize = GetNumber("Введите кол-во строк  m в двумерном массиве ");
int Nsize = GetNumber("Введите кол-во столбцов n в двумерном массиве ");
double[,,] A = CreateArray(Psize, Msize,Nsize);
FillingArray(A);
PrintThirdArray(A);
System.Console.Write("\nМамсив  заранее определён");
PrintThirdArray(n);
