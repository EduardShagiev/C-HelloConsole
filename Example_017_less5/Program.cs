// // Amn=m+n;
// int GetNumber (string message)
// {
//     int result =0;
//     while (true)
//     {   
//         Console.WriteLine(message);
//         if (int.TryParse(Console.ReadLine(),out result)&& result>0)
//         {
//             break;
//         }
//         else 
//         {
//             Console.WriteLine("Ввели не корректное значениеб повторите ввод\n");
//         }
//     }
//     return result;
// }
// int[,] InitMatrix( int m , int n)
// {
//     int[,] matrix = new int[m,n];
//     Random random =new Random();
//     for (int i = 0; i <matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i,j]= i+j;
//         }
//     }    
//     return matrix;
// }

// void PrintArray(int[,] array)
// {
//     Console.WriteLine($"Массив:{array.GetLength(0)}x{array.GetLength(1)}");
//    for (int i = 0; i <array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i,j]+" ");
//         }
//             Console.WriteLine();
//     }
// }

// int row = GetNumber("Ввидете ко-во строк");
// int collums = GetNumber("Ввидете ко-во столбцов");
// int[,] arr = InitMatrix(row,collums);
// PrintArray(arr);


////////////////////////////////////////////////////////////////////////////////////////////////
///задайте думерный массив. Найдите элементы у которых оба индекса четные, и замените эти эдементы на их квадрат
// 1 4 7 2
// 5 8 2 3
// 8 4 2 4 Для пользователя  (8=64)

// int[,] masive =
// {
//     {1,4,7,2},
//     {5,8,2,3},
//     {8,4,2,4}
// }; 

// for (int i = 0; i <masive.GetLength(0) ; i++)
// {
//     for (int j = 0; j <masive.GetLength(1); j++)
//     {
//         if (((i+1)%2==0)&&((j+1)%2==0)) masive[i,j]*=masive[i,j];
//     }
// }
//  void PrintArray(int[,] array)
// {
//     Console.WriteLine($"Массив:{array.GetLength(0)}x{array.GetLength(1)}");
//    for (int i = 0; i <array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i,j]+" ");
//            // Console.Write(String.Format("{0,2:0.#}", array[i,j]));
//         }
//             Console.WriteLine();
//     }
// }

// PrintArray(masive);

///////////////////////////////////////////////////////////////////////////////////////////
//Задайте двумерный массив.  Найдите сумму элементов  находящейся на главной диагонали 1+8+2=11

int[,] masive =
{
    {1,4,7,2},
    {5,8,2,3},
    {8,4,2,4}
}; 
int sum=0;
// обязательно проверка на квадратность матрицы (rows=collums)
for (int i = 0; i <masive.GetLength(0) ; i++)
{
    sum+=masive[i,i]; 
}
System.Console.WriteLine(sum);


