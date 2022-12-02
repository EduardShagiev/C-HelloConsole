void fillarray(int[] collection)
{
    int lenghtCol=collection.Length;
    int index =0;
    
    while (index<lenghtCol)
    {
        collection[index]=new Random().Next(1,10);
        index++;
    }
}
void PrintArray(int[] collectionP)
{
    int Length= collectionP.Length;
    int index = 0;
    while (index<Length)
    {
        Console.Write(collectionP[index]+ " ");
        index++;
    }
}
int FindPosInArray(int[] collection, int findpos)
{
   int count =collection.Length;
   int index=0;
   int pos= -1;

    while (index<count)
    {
        if (collection[index]==findpos)
        {
            pos=index;
            break;
        }
    index++;
    }
    return pos;
}

int[] array = new int[10];

fillarray(array);
PrintArray(array);
Console.WriteLine();
int posindex= FindPosInArray(array,4);
Console.WriteLine(posindex);