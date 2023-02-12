// string path = "C:\\Users\\Eduard Shagiev\\Desktop\\C#_LESSON\\Example_20_rec";
// void CatalogInfo(string path, string intend = "")
// {
//     DirectoryInfo catalog = new DirectoryInfo(path);
   
//     DirectoryInfo[] catalogs = catalog.GetDirectories();
  
//     for (int i = 0; i < catalogs.Length; i++)
//     {
//         System.Console.WriteLine($"{intend}{catalogs[i].Name}");
//         CatalogInfo(catalogs[i].FullName,intend + " ");
//     }
//     FileInfo[] files = catalog.GetFiles();

//     for (int i = 0; i < files.Length; i++)
//     {
//         System.Console.WriteLine($"{intend}{files[i].Name}");
//     }
// }
// CatalogInfo(path);


//////Башня игра
// DateTime dt = DateTime.Now;
// void Towers( string with = "1", string on = "3", string some = "2", int count =5)
// {
//     if (count > 1 ) Towers(with,some,on,count -1);
//     System.Console.WriteLine($"{with} >> {on}");
//     if (count>1) Towers(some,on,with,count-1);
// }
// Towers();
// Console.WriteLine((DateTime.Now-dt).TotalMilliseconds);
/////////////////////////////////////////////////////////////////////////////////////
// В массивe из size элементов. Нужно найти максимальную сумму из m подряд идущих элeментов. 
System.Console.WriteLine("Ввидите число");
int m= Convert.ToInt32(Console.ReadLine());

int[] array = {4, 5, 0, 7, 4, 4, 6, 2 ,6, 3 ,56,243,53,66,45,54,1313,553};

int max = 0;
for (int i = 0; i < m; i++) max += array[i];

int temp = max;
for (int i = 1; i < array.Length - m; i++)
{
  temp = temp - array[i - 1] + array[i + (m - 1)];
  if (temp > max) max = temp;
}
Console.WriteLine(max);