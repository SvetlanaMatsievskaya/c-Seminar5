int CountPositiveNumbers(int[] col)
{
  int CountPositive = 0;
  for (int j = 0; j < col.Length; j++)
{
    if (col[j]%2 == 0) CountPositive+=1;
  
}
return CountPositive;  

}
 
void FillArray (int[] array)
{
  for (int i = 0; i < array.Length; i++)
{
  array[i] = new Random().Next(100,1000);
  Console.Write($"{array[i]} ");
}
Console.WriteLine();
}
int[] arr = new int[5];
FillArray(arr);
Console.WriteLine(CountPositiveNumbers(arr));
