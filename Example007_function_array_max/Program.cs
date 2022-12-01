// Функция находения максимального значения в масиве целых чисел

Console.WriteLine("Input 7 value by space ");
string s = Console.ReadLine()?? "";
string[] sarr= s.Split();
int[] valarr = new int[7];
for (int i = 0; i < sarr.Length; i++)
{
    valarr[i] = int.Parse((sarr[i]));
   // Console.Write(valarr[i]+ ", ");
}

int functionmax(int[] x)
{
int max_value=0;
int index=0;
while(index <7)
{
  if (x[index]>max_value)
  {
        max_value= x[index];
  }  
  index++;
 }
return max_value;
}

Console.WriteLine("Max value =" + functionmax(valarr));