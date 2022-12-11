// Console.WriteLine("Введите числа через запятую");
// string ins=Console.ReadLine()??"";
// void inputarr(string str)
// {
//     int[]  arr = new int[8];
//     string[] s=str.Split(",");
//     int i=0;
//     Console.Write("[");
//     while(i<s.Length)
//     {
//         arr[i]=Convert.ToInt32(s[i]);
//         Console.Write("{0},", arr[i]);
//         i++;
//     }
//     Console.Write("]");
// }
// inputarr(ins);

Random ramdom = new Random();
int[,,] array = new int[3,3,3];

for (int i = 0; i < array.GetLength(0); i++)
{       
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int k = 0; k < array.GetLength(2); k++)
        {
            array[i,j,k]= ramdom.Next(100);
        }
    }
}

for (int i = 0; i < array.GetLength(0); i++)
{    Console.WriteLine("Page"+ (i+1));   
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int k = 0; k < array.GetLength(2); k++)
        {
            Console.Write(array[i,j,k]+" ");  
        }
        Console.WriteLine();
    }
    Console.WriteLine("=====================");
}