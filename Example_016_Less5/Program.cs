// Задача 39: Напишите программу, которая перевернёт 
// одномерный массив (последний элемент будет на первом месте,
// а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]
/*int GetNumber(string message)
{
    int result;
    while(true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число.");
        }
    }

    return result;
}

int[] InitArray(int dimension)
{
    Random rnd = new Random();
    int[] array = new int[dimension];

    for (int i = 0; i < dimension; i++)
    {
        array[i] = rnd.Next(1,10);
    }

    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int[] ReverseArray(int [] array)
{
    int [] result = new int[array.Length];
    int count = 0;

    for (int i = array.Length - 1; i >= 0; i--)
    {
        result[count] = array[i];
    //  result[array.lenght-i-1] = array[i];
        count++;
    }
    return result;
}
int dimension = GetNumber("Введите размерность массива");
int[] array = InitArray(dimension);
PrintArray(array);

int[]result = ReverseArray(array);
PrintArray(result);

Array.Reverse(result);


// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет,
// может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.
bool doCalculation(int a, int b, int c)
{
    return a < b + c && b < a + c && c < a + b;
}


int a = 3;
int b = 3;
int c = 3;

Console.WriteLine($"Стороны: {a}, {b}, {c}");

string ne = doCalculation(a, b, c) ? "" : " не";////тернарные операторы

Console.WriteLine($"Треугольник{ne} может существовать");*/

// Задача 42: Напишите программу, которая будет 
// преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

int a  = 11;
string c= Convert.ToString(a,2);
System.Console.WriteLine(c);  

string GetBinaryFromDecimal(int decimalNumber)
{
    // 11 % 2 = 5.5 = 1
    // 5 % 2 = 2.5 = 1
    // 2 % 2 = 1 = 0
    // 1 % 2 = 0.5 = 1
    int number = decimalNumber;
    int ostatok = 0;
    string result = String.Empty;

    while (number >= 1)
    {
        ostatok = number % 2;
        number /= 2;
        if (ostatok != 0)
        {
            result += "1";
        }
        else
        {
            result += "0";
        }
    }
    return new string (result.Reverse().ToArray());
}
Console.WriteLine(GetBinaryFromDecimal(11));
Console.WriteLine(GetBinaryFromDecimal(158));

// //Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8
Console.WriteLine("Введите число");
int Num = Convert.ToInt32(Console.ReadLine());
int fib1 = 1;
int fib2 = 1;
int len = 0;
Console.Write($"0 {fib1} {fib2} ");
while(len < Num - 2){
    int fib_sum = fib1 + fib2;
    fib1 = fib2;
    fib2 = fib_sum;
    len++;
    Console.Write($"{fib_sum} ");
}

int N = 100;
int x1 = 0;
int x2 = 1;
int res = 0;
string str = "0 1 ";

for (int i = 2; i <= N; i++)
{
    res = x2 + x1;
    x1 = x2;
    x2 = res;
    str += res.ToString() + " ";
}

Console.WriteLine(str);

// Задача 45: Напишите программу, которая будет создавать копию 
// заданного массива с помощью поэлементного копирования.



// Напишите программу, в которой описан статический метод для 
// вычисления двойного факториала. Например 6!! = 6 * 4 * 2 = 48, 
// 5!! = 5 * 3 * 1 = 15. Предложите версию метода без рекурсии и с 
// рекурсией
// int[] InitArray(int dimension)
// {
//     int[] array = new int[dimension];
//     Random rnd = new Random();

//     for (int i = 0; i < dimension; i++)
//     {
//         array[i] = rnd.Next(10, 100);
//     }

//     return array;
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }

//     Console.WriteLine();
// }

// Random rnd = new Random();
// int r = rnd.Next(100);

// int dimension = r;
// int[] array = InitArray(dimension);

// static int[] mami(){
//     int[] arr = new int [2];
//     for(int i = 0; i < array.Length; i++){

//     }
//     return array;
// }
