
void FillArray(int[] coll)
{
    for (int i = 0; i < coll.Length; i++)
    {
    coll[i] = new Random().Next(1,100);
    Console.Write($"{coll[i]} ");
    }
Console.WriteLine();
}

int SumOddIndex(int[] matr)    
{
    int summa = 0;
    for (int j = 0; j < matr.Length; j++)
    {
        if (j%2 != 0) summa+=matr[j];
    }
return(summa);
}
 


int[] array = new int[6];
FillArray(array);
Console.WriteLine(SumOddIndex(array));