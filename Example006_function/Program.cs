// double f(double x)
// {
//     double result_x = x * x + 1;
//     return result_x;
// }

//Console.WriteLine(f(23.5));

int[] numbers = { 7, 2, 6, 4, 5 };
foreach (int i in numbers)
{
    Console.Write(i + ", ");
}

char[] gender = {'m','f','m','m','m','f','f','m','m','f'};
int male = 0, female = 0;
foreach (char g in gender)  
    {
         if (g == 'm')
            male++;
        else if (g =='f')
            female++;
    }
Console.WriteLine(" ");            
Console.WriteLine("Number of male = {0}", male);
Console.WriteLine("Number of female = {0}", female);