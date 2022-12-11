// Задача 29: Напишите программу, которая задаёт массив из 8 элементов 
//и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
//метод, который получает число с консоли
int GetNumber(string message)
{
    bool isCorrect = false;
    int result = 0;

    while(!isCorrect)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result) && result > 0)
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

int quantity = GetNumber("Введите кол-во элементов в массиве:\t");
int[] myArray= new int [quantity];

//метод ввода  элементов в массив
void InputArray(int[] arr)
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

InputArray(myArray);
PrintArray(myArray);


