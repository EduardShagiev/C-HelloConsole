// Работа с методами 

// void Method1(string msg, int count)
// {
//     int i=0;
//     while (i<count)
//     {   
//           Console.WriteLine(msg); 
//           i++;
//     }
 
// }
// Method1(msg:"Проврека текста", count: 2);
// Method1( count: 2,msg:"New msg");
///////////
// int Method2()
// {
//     return DateTime.Now.Year;
// }

// Console.WriteLine(Method2());

//////
// string result= String.Empty;

// for (int i = 1; i < 10; i++)
// {
//     for (int j = 1; j < 10; j++)
//     {
//         Console.WriteLine($"{i} * {j} = {i*j}");
//     }
//     Console.WriteLine();
// }
///////////////////////////////////////
//рАБОТА со строкрй
// string str = "Сегодня мы углубимся в тему и выделим 4 основных группы методов, а также будем использовать их на практике. И познакомимся с новыми языковыми конструкциями, в частности, циклом.";
// string ReplaceMethod(string text, char oldvalue, char newvalue)
// {
//         string result =String.Empty;
//         int lenght=text.Length;
//         for (int i = 0; i < lenght; i++)
//         {
//             if (text[i] == oldvalue) result=result + $"{newvalue}";
//             else result = result + $"{text[i]}";
//         }
//         return result;
// }
// string newtext = ReplaceMethod(str,'с','П');
// System.Console.WriteLine(newtext);
/////////////////////////////////////////
//Сортировка по макс
int[] arr  = {2,6,2,8,9,3,5,6,21,6,12,675,53,99};

void Printarr(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SortMax(int[] array)
{
    for (int i = 0; i < array.Length-1; i++)
    {
        int minpositon=i;
        for (int j = i+1; j < array.Length; j++)
        {
            if (array[j]>array[minpositon])
            {
                minpositon=j;
            }
        }
        int tempvalue = array[i];
        array[i]=array[minpositon];
        array[minpositon]=tempvalue;
    }  
}
Printarr(arr);
SortMax(arr);
Printarr(arr);
