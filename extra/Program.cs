int[] DateGenerate(int marks)
{
  int[] MarksList = new int[marks];
  for(int i = 0; i < marks; i++)
  {
    MarksList[i] = new Random().Next(1, 32);
  } 
  return MarksList;
}

int CountMark(int[] marks, int n)
{
  int MarkCount = 0;
  foreach(int m in marks)
  { 
    if (m % 2 == n % 2)
      MarkCount += 1;
  }
  int [] MarkDays = new int [MarkCount];
  int count = 0;
  foreach(int m in marks)
  {
    if (m % 2 == n % 2)
    {
      MarkDays[count] = m;
      count+=1; 
    }
  }
  Console.WriteLine($"Вася получил {n}: {string.Join(", ", MarkDays)} числа");
  return MarkCount;
}

string ResultMark(int a, int b)
{
  if (a > b) return Convert.ToString(3); // "NO"
  return Convert.ToString(4); // "YES"
}


Console.Clear();
int qtMarks = new Random().Next(3, 12);
int[] DaysWithMarks = DateGenerate(qtMarks);
int DayWith3 = CountMark(DaysWithMarks, 3);
int DayWith4 = CountMark(DaysWithMarks, 4);



Console.WriteLine($"Итоговая оценка Васи: {ResultMark(DayWith3, DayWith4)}");