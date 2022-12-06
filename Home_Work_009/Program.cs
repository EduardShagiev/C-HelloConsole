// Напишите программу, которая принимает на вход 
// пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет 12821 -> да 23432 -> да
Console.WriteLine("Введите число");
string s = Console.ReadLine()??"";
char[] str = s.ToCharArray();

void CheckPalim(char[] value)
{
  int len=value.Length;
  int index=0;
  bool Palindrome=true;
  int last = len-1;
  while (index<len)
  {
   
    if (str[index]==str[last])
    {
        last=last-1;  
    }
    else Palindrome = false;
    index++;
  }
  if (Palindrome) {Console.Write ("Чиcло палиндром");}
  else  {Console.Write ("Чиcло не палиндром");}
}

 CheckPalim(str);

