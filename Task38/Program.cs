﻿
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

void FillArray(double[]collection)
{
    for (int i = 0; i < collection.Length; i++)
    {
        Random rand = new Random();
        collection[i] = rand.Next(-100, 100) + rand.NextDouble();
    }
}
double[] matrix = new double[10];
FillArray(matrix);
Console.WriteLine(Max(matrix)-Min(matrix));