int Max(int[]matr)
{
    int max = matr[0];
    for (int i = 0; i < matr.Length; i++)
    {
        if (matr[i] > max) max = matr[i];
         
    }
return(max);
}
int Min(int[]col)
{
    int min = col[0];
    for (int j = 0; j < col.Length; j++)
    {
        if (col[j]< min) min = col[j];
    }
return(min);
}

void FillArray(int[]collection)
{
    for (int i = 0; i < collection.Length; i++)
    {
        Random rand = new Random();
        collection[i] = rand.Next(-100, 100);
    }
}
int[] matrix = new int[10];
FillArray(matrix);
for (int i = 0; i < matrix.Length; i++)
{
    Console.Write($"{matrix[i]} ");
}
Console.WriteLine(Max(matrix)-Min(matrix));
