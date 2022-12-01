// Функция находения максимального значения в масиве целых чисел

Console.WriteLine("Input value by space ");
string s = Console.ReadLine()?? "";
string[] sarr= s.Split();
int[] valarr = new int[sarr.Length];

for (int i = 0; i < sarr.Length; i++)
{
    bool result = int.TryParse(sarr[i], out valarr[i]);
    if (result)
    {    
        Console.WriteLine("Операция конвертации успешна");
    }
    else
    {  
        Console.WriteLine("Не удалось конвертировать");
    }
}
int funserchmaxval(int[] x)
{
int max_value=0;
int index=0;
while(index <x.Length)
{
  if (x[index]>max_value)
  {
        max_value= x[index];
  }  
  index++;
 }
return max_value;
}

Console.WriteLine("Max value =" + funserchmaxval(valarr));

   // for (int i = 0; i < sarr.Length; i++)
   // {
   // valarr[i] = int.Parse((sarr[i]));
   // Console.Write(valarr[i]+ ", ");
   //  }