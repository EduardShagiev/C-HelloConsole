// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] matrix = new int[,]
{
    {1,4,7,2},
    {5,9,2,3},
    {8,4,2,4},
};

// Print array
void PrintArray(int[,] array)
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
// Sort array
int[,] SortRows(int[,] array)
{
    int value=0;
   
    for (int i = 0; i <array.GetLength(0); i++)
    {
        for (int j = 0; j <array.GetLength(1); j++)
        {
            for (int k = j+1; k <array.GetLength(1); k++)
            {
                if (array[i,j]<array[i,k])
                {
                    value= array[i,j];
                    array[i,j]=array[i,k];
                    array[i,k]=value;
                }
            }   
        }   
    }
    return array;
}

PrintArray(matrix);
int[,] newmatrix = SortRows(matrix);
PrintArray(newmatrix);


