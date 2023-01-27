void FillArray(double[] a)
{
  for(int i = 0; i < a.Length; i++)
  {
    Console.Write($"Введите дробное число № {i + 1}: ");
    a[i] = Convert.ToDouble(Console.ReadLine());
  }
}
void FindDiff(double[] a)
{
  double elemMax = a[0], elemMin =a[0];
  foreach(double elem in a)
  {
    if(elem > elemMax)
      elemMax = elem;
    else if(elem < elemMin)
      elemMin = elem;
  }

  Console.WriteLine($"Разность максимального и минимального числа массива равна: {elemMax - elemMin}");
}

Console.Clear();
Console.Write("Введите длину массива: ");
int LenArray = Convert.ToInt32(Console.ReadLine());
double [] nums = new double[LenArray];
FillArray(nums);
Console.WriteLine(string.Join(", ",nums));
FindDiff(nums);