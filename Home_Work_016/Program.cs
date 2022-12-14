/*Задайте одномерный массив, заполненный случайными числами.
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */
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
        array[i]= random.Next(0,10);
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
///Сумма элементов, стоящих на нечётных позициях.
int SummaOddPos(int[] arr)
{
    int summ =0;
    int i=1;
    while(i<arr.Length)
    {
        summ+=arr[i];
        i+=2;
    }
    return summ;
}

int number = GetNumber("Введите значение длины массива");
int [] newarray= ArrayFilling(number);
PrintArray(newarray);
int newsumm= SummaOddPos(newarray);
Console.WriteLine($"Сумма значений в нечетных позицияъ массива  = {newsumm}");