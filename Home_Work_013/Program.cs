// Задача 27: Напишите программу, которая принимает 
//на вход число и выдаёт сумму цифр в числе.
// 452 -> 11  82 -> 10  9012 -> 12
string GetNumber(string message)
{
    Console.WriteLine(message);
   string str =Console.ReadLine()??"";
   return str;    
}

int Summa(string str)
{
    char[] s =str.ToCharArray();
    int result =0;
    int i =0;
    int[] temporary = new int[s.Length];
    while (i<s.Length)
    {
        temporary[i]+=(int)char.GetNumericValue(s[i]);
        result+=temporary[i]; 
        i++;
    }
    return result;
}
string value = GetNumber("Введите число");
Console.WriteLine((Summa(value)));
