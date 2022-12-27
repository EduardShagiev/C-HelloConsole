// //Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
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
// //Создание массива
// double[,] CreateArray(int m, int n)
// {
//     double[,] array = new double[m,n];
//     return array;
// }
// //Заполнение массива
// void FillingArray(double[,] array)
// {
   
//     Random random = new Random();
//     for (int i = 0; i <array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i,j]= random.Next(-10,10);//+ random.NextDouble();
//         }
//     }
// }
// //Печать массива
// void PrintArray(double[,] array)
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
////////////////////////////////////////////////////////////
// void PrintArray(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//             Console.Write(String.Format("{0,2:0.#}", arr[i, j]));
//         Console.WriteLine();
//     }
// }

// int[,] arr =
// {
//     { 1, 4, 7, 2 },
//     { 5, 9, 2, 3 },
//     { 8, 4, 2, 4 },
//     { 5, 2, 6, 7 }
// };

// int[] line0 = new int[arr.GetLength(1)];
// int[] line1 = new int[arr.GetLength(1)];

// for (int i = 0; i < line0.Length; i++)
//     line0[i] = arr[0, i];

// for (int i = 0; i < line0.Length; i++)
//     line1[i] = arr[arr.GetLength(0)-1, i];

// PrintArray(arr);

// for (int i = 0; i < line0.Length; i++)
//     arr[0, i] = line1[i];
// for (int i = 0; i < line0.Length; i++)
//     arr[arr.GetLength(0) - 1, i] = line0[i];

// Console.WriteLine();
// Console.WriteLine();
// PrintArray(arr);
////////////////////////////////////////////////////////////////////////////////
// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
//В случае, если это невозможно, программа должна вывести сообщение для пользователя.
// void PrintMatrix(int[,] mtrx)
// {
//     for (int i = 0; i < mtrx.GetLength(0); i++)
//     {
//         for (int j = 0; j < mtrx.GetLength(1); j++)
//         {
//             Console.Write($"{mtrx[i, j]} ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// int[,] GenerateRandomMatrix(int min, int max, int m, int n)
// {
//     int[,] mtrx = new int[m, n];
//     Random r = new Random();
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             mtrx[i, j] = r.Next(min, max + 1);
//         }
//     }
//     return mtrx;
// }

// int[,] Transpose(int[,] mtrx)
// {
//     int m = mtrx.GetLength(0);
//     int n = mtrx.GetLength(1);
//     int[,] result = new int[n, m];
//     for (int i = 0; i < n; i++)
//     {
//         for (int j = 0; j < m; j++)
//         {
//             result[i, j] = mtrx[j, i];
//         }
//     }
//     return result;
// }

// int[,] randMatrix = GenerateRandomMatrix(0, 9, 4, 6);
// PrintMatrix(randMatrix);
// PrintMatrix(Transpose(randMatrix));
/////////////////////////////////////////////////////////////////////////////////////////////
//Задача 57: Составить частотный словарь элементов двумерного массива. 
//Частотный словарь содержит информацию о том, 
//сколько раз встречается элемент входных данных.
// 1, 2, 3 
// 4, 6, 1 
// 2, 1, 6
// 1 встречается 3 раза 
// 2 встречается 2 раз 
// 3 встречается 1 раз 
// 4 встречается 1 раз 
// 6 встречается 2 раза
// void PrintMatrix(int[,] mtrx)
// {
//     for (int i = 0; i < mtrx.GetLength(0); i++)
//     {
//         for (int j = 0; j < mtrx.GetLength(1); j++)
//         {
//             Console.Write($"{mtrx[i, j]} ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// int[,] GenerateRandomMatrix(int min, int max, int m, int n)
// {
//     int[,] mtrx = new int[m, n];
//     Random r = new Random();
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             mtrx[i, j] = r.Next(min, max + 1);
//         }
//     }
//     return mtrx;
// }
// void CalculateNumbers (int[,] matrix)
// {
//     int m = matrix.GetLength(0);
//     int n = matrix.GetLength(1);
//     int numberOfElements = m * n;
//     int number = 0;
//     int count = 0;
//     int total = 0;

//     while (total != numberOfElements)
//     {
//         for (int i = 0; i < m; i++)
//         {
//             for (int j = 0; j < n; j++)
//             {
//                 if(matrix[i, j] == number)
//                 {
//                     count++;
//                 }
//             }
//         }
//         if(count>0)
//             System.Console.WriteLine($"Число {number} встречается {count} раз;");
//         total+= count;
//         count = 0;
//         number++;
//     }
// }

// int[,] randMatrix = GenerateRandomMatrix(0, 100, 4, 6);
// PrintMatrix(randMatrix);
// CalculateNumbers(randMatrix);

///Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, 
//которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим 
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7

// int GetNumber(string message)
// {
//     int result = 0;

//     while(true)
//     {
//         Console.WriteLine(message);

//         if(int.TryParse(Console.ReadLine(), out result))
//         {
//             break;
//         }
//         else
//         {
//             Console.WriteLine("Ввели не число");
//         }
//     }

//     return result;
// }

// void FillArrayRandomNumbers(int[,] matrix)
// {
//     Random rnd = new Random();
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = rnd.Next(1, 10);
//         }
//     }
// }

// void PrintArray(int[,] mtrx)
// {
//     for (int i = 0; i < mtrx.GetLength(0); i++)
//     {
//         for (int j = 0; j < mtrx.GetLength(1); j++)
//         {
//             Console.Write($"{mtrx[i, j]} ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// int[,] DeleteRowColoumn(int[,] matrix)
// {
//     int[,] newArr = new int[matrix.GetLength(0) - 1,matrix.GetLength(1) - 1];
//     int a = 0;
//     int b = 0;
//     int x=0, y=0;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         if (i == x)
//             continue;
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (j == y)
//                 continue;
//             newArr[a, b] = matrix[i, j];
//             b++;
//         }
//         b = 0;
//         a++;
//     }
//     return newArr;
// }

// int m = GetNumber("Введите количество строк:");
// int n = GetNumber("Введите количество столбцов:");
// int[,] matrix = new int[m, n];
// FillArrayRandomNumbers(matrix);
// PrintArray(matrix);
// PrintArray(DeleteRowColoumn(matrix));

///////////////////////////////////////////////////
// var people = new Dictionary<int, string>()
// {
//     [5] = "Tom",
//     [6] = "Sam",
//     [7] = "Bob"
// };

//     Console.WriteLine($"key: {people[6]}");

 string arr ="14723124368973253671";
 char[] line= arr.ToCharArray();
Dictionary<char, int> dict = new Dictionary<char, int>();
    for (int i = 0; i < line.Length; i++)
    {
        if (dict.ContainsKey(line[i]))
            dict[line[i]]++;
        else
            dict.Add(line[i], 1);
    }
    foreach (char key in dict.Keys)
        Console.WriteLine("символ [{0}], количество [{1}] ", key, dict[key]);

