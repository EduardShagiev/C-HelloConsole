// : Задайте массив заполненный случайными положительными 
//трёхзначными числами. Напишите программу, 
//которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

/// Ввод числа с консоли и проверка на корректность
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
///Заполнение массива случайными числами 
int [] ArrayFilling(int size)
{
    Random random = new Random();
    int[] array = new int[size];

    for (int i = 0; i < array.Length; i++)
    {
        array[i]= random.Next(100,999);
    }
    return array;
}
///Печать массива 
void PrintArray(int[] array)
{
    int i=0;
    while(i<array.Length)
    {
        Console.Write(array[i]+ ",");
        i++;
    }
    Console.WriteLine();
}
///Подсчёт кол-ва нечет. чисел в массиве 
int FineEvenNumber(int[] arr)
{
    int count =0;
    for (int i = 0; i <arr.Length; i++)
    {
        if(arr[i]%2==0)
        {
            count++;
        }
    }
    return count;
}
int number = GetNumber("Введите значение длины массива");
int [] newarray= ArrayFilling(number);
PrintArray(newarray);
int newcount= FineEvenNumber(newarray);
Console.WriteLine($"Число четных значений в массиве = {newcount}");