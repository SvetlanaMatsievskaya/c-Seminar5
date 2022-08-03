
double Max(double[]matr)
{
    double max = matr[0];
    for (int i = 0; i < matr.Length; i++)
    {
        if (matr[i] > max) max = matr[i];
         
    }
return(max);
}
double Min(double[]col)
{
    double min = col[0];
    for (int j = 0; j < col.Length; j++)
    {
        if (col[j]< min) min = col[j];
    }
return(min);
}
double[] matrix = {5.6, 10.2, 356.9, 57.1, 1.3, 456.7};

Console.WriteLine(Max(matrix)-Min(matrix));