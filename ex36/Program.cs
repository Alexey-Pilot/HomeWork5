void FillArray(int[] a)
{
  for(int i = 0; i < a.Length; i++)
  {
    a[i] = new Random().Next(-100, 101);
  }
}
void SummOddIndex(int[] a)
{
  int sum = 0; 
  for(int i = 0; i < a.Length; i++)
  {
    if ( i % 2 == 1)
    {
      sum += a[i];
    }
  }
  Console.WriteLine($"Сумма чисел с нечетными индечксами равняется: {sum}");
}


Console.Clear();
Console.Write("Введите длину массива: ");
int LenArray = Convert.ToInt32(Console.ReadLine());
int [] nums = new int[LenArray];
FillArray(nums);
Console.WriteLine(string.Join(", ",nums));
SummOddIndex(nums);