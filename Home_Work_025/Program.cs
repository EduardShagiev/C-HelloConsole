// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
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
double[,] CreateArray(int m, int n)
{
    double[,] array = new double[m, n];
    return array;
}
//Заполнение массива
void FillingArray(double[,] array)
{

    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(0, 10);//+ random.NextDouble();
        }
    }
}
//Печать массива
void PrintTwoArray(double[,] array,string msg)
{
    Console.WriteLine($"Массив {msg}");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

//Умножение матриц A и B
//Операция умножения матрицы A на матрицу B определена только для согласованных матриц, 
// у которых число столбцов матрицы A равно числу строк матрицы B:
double[,] MatrixMultiplication(double[,] matrixA, double[,] matrixB)
{

    if ((matrixA.GetLength(0)) != (matrixB.GetLength(1)))
    {
        throw new Exception("Умножение не возможно! Количество столбцов первой матрицы не равно количеству строк второй матрицы.");
    }

    double[,] matrixC = new double[matrixA.GetLength(0), matrixB.GetLength(1)];

    for (int i = 0; i < matrixA.GetLength(0); i++)
    {
        for (int j = 0; j < matrixB.GetLength(1); j++)
        {
            matrixC[i, j] = 0;

            for (int k = 0; k < matrixA.GetLength(1); k++)
            {
                matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
            }
        }
    }

    return matrixC;
}

int Amsize = GetNumber("Введите кол-во строк  m в двумерном массиве A");
int Ansize = GetNumber("Введите кол-во столбцов n в двумерном массиве A");
double[,] A = CreateArray(Amsize, Ansize);
FillingArray(A);

int Bmsize = GetNumber("Введите кол-во строк  m в двумерном массиве B");
int Bnsize = GetNumber("Введите кол-во столбцов n в двумерном массиве B");
double[,] B = CreateArray(Bmsize, Bnsize);
FillingArray(B);

PrintTwoArray(A,"A");
PrintTwoArray(B, "B");



double[,] C = MatrixMultiplication(A, B);
PrintTwoArray(C,"C");


double[,] Anew = new double[,]
{
    {2,4},
    {3,2}
};
PrintTwoArray(Anew,"Anew");
double[,] Bnew = new double[,]
{
    {3,4},
    {3,3}
};
PrintTwoArray(Bnew,"Bnew");
double[,] Cnew = MatrixMultiplication(Anew, Bnew);
PrintTwoArray(Cnew,"Cnew");