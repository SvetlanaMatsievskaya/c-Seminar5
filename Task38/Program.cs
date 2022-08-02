
int Max(int[]matr)
{
    int m = 0;
    for (int i = 0; i < matr.Length; i++)
    {
        if (matr[i] > m) m = matr[i];
         
    }
return(m);
}

int[] matrix = {5,10,356,57,9,1};
Console.WriteLine(Max(matrix));