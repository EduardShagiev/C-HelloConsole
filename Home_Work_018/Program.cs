// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

/// Ввод числа с консоли и проверка на корректность
int GetNumber(string message)
{
    bool isCorrect = false;
    int result = 0;

    while(!isCorrect)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result))//&& result > 0
        {
            isCorrect = true;
        }
        else
        {
            Console.WriteLine("Некорректный ввод. Введите число больше 0.");
        }
    }

    return result;
}
//метод ввода  элементов в массив
void InputArray(int[] arr, int quantity)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i]=GetNumber($"Введите элемент массива под индексом {i}:");
    }
    Console.Write($"Массив из {quantity} элементов: [");
}
//Печать массива
void PrintArray(int[] array)
{
    for (int i = 0; i <array.Length; i++)
    {
        Console.Write("{0},",array[i]); 
    }
    Console.Write("]");
}
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
int  CountNumber(int[] massive)
{   
    int count=0;
    for (int i = 0; i <massive.Length; i++)
    {
        if (massive[i]>0) 
        {
            count++; 
        }
    }
    return count;
}

int quantity = GetNumber("Введите кол-во элементов в массиве:\t");
int[] myArray= new int [quantity];

InputArray(myArray,quantity);
PrintArray(myArray);
System.Console.WriteLine();
Console.WriteLine($"Кол-во чисел больше нуля = {CountNumber(myArray)}");
