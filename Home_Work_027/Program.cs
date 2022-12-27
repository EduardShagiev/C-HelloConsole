// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
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
            Console.WriteLine("Ввели не корректное значение повторите ввод\n");
        }
    }
    return result;
}
int m=GetNumber("Введите размер матрицы");
int[][] matrix = new int[m][];

for (int i = 0; i<m; i++)
{
    matrix[i]= new int[m];
}

int startCol=0,endCol=m-1, startRow=0,endRow=m-1;
int counter=1;

int[][] FillingArrayBySpiral(int[][] array)
{
    
    while (startCol<=endCol && startRow<=endRow)
    {
        for (int i = startCol; i<=endCol; i++)
        {
            array[startRow][i]=counter;
            counter++;
        }
        startRow++;

        for (int i = startRow; i<= endRow; i++)  
        {
            array[i][endCol]=counter;
            counter++;
        }
        endCol--;

        for (int i = endCol; i>=startCol; i--)  
        {
            array[endRow][i]=counter;
            counter++;
        }
        endRow--;

         for (int i = endRow; i>=startRow; i--)  
        {
            array[i][startCol]=counter;
            counter++;
        }
        startCol++;
    }
   
    return array;
}

void PrintTwoArray(int[][] array)
{
    Console.WriteLine($"Массив");
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = 0; j < array[i].Length; j++)
        {
            Console.Write(array[i][j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

FillingArrayBySpiral(matrix);
PrintTwoArray(matrix);

