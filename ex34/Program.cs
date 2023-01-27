void FillArray(int[] a)
{
  for(int i = 0; i < a.Length; i++)
  {
    a[i] = new Random().Next(100, 1000);
  }
}
void CountEven(int[] a)
{
  int count = 0;
  foreach(int elem in a)
  {
    if(elem % 2 == 0) count +=1;
  }
  Console.WriteLine(count);
}

Console.Clear();
Console.Write("Введите длину массива: ");
int LenArray = Convert.ToInt32(Console.ReadLine());
int [] nums = new int[LenArray];
FillArray(nums);
Console.WriteLine(string.Join(", ",nums));
CountEven(nums);