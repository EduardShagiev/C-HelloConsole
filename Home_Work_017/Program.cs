/* Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76 */
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
///Заполнение массива  случайными вещ. числами 
double [] ArrayFilling(int size)
{
    Random random = new Random();
    double[] array = new double[size];

    for (int i = 0; i < array.Length; i++)
    {
        array[i]= random.Next(0, 100) + random.NextDouble();
    }
    return array;
}
///Печать массива 
void PrintArray(double[] array)
{
    int i=0;
    while(i<array.Length)
    {
        Console.Write(array[i]+ "; ");
        i++;
    }
    Console.WriteLine();
}

// Поиск макс и мин значения в массиве
(double,double ) MaxMinValue(double[] array)
{
    double max=0.0, min = 0.0;
    int maxindex=0, minindex=0;

    for (int i = 0; i <array.Length; i++)
    {
        if (array[i]> array[maxindex])
        {
            maxindex=i;
        }
        if (array[i]< array[minindex])
        {
            minindex=i;
        }
        max=array[maxindex];
        min =array[minindex];
    }
    return (max,min);
}


int number = GetNumber("Введите значение длины массива");
double[] newarray= ArrayFilling(number);
PrintArray(newarray);
(double maxv,double minv) = MaxMinValue(newarray);
Console.Write ($"Разница между max={maxv} и min={minv} ->{maxv-minv}");