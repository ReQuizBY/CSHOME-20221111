//69. Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.

int[,] Random2DArray(int n,int m,int min=0,int max=10)
{
    int[,] a=new int[n,m];
    Random random=new Random();
    for(int i=0;i<n;i++)
         for(int j=0;j<m;j++)
                a[i,j]=random.Next(min,max+1);
    return a;
}

void Order2DArrayLines(int[,] a)
{
  for (int i = 0; i < a.GetLength(0); i++)
  {
    for (int j = 0; j < a.GetLength(1); j++)
    {
      for (int k = 0; k < a.GetLength(1) - 1; k++)
      {
        if (a[i, k] < a[i, k + 1])
        {
          int temp = a[i, k + 1];
          a[i, k + 1] = a[i, k];
          a[i, k] = temp;
        }
      }
    }
  }
}

void Print2DArray(int[,] a)
{
for(int i=0;i<a.GetLength(0);i++)
        {
     for(int j=0;j<a.GetLength(1);j++)
        System.Console.Write($"{a[i,j],4}");
           System.Console.WriteLine();
        }
}

int[,] a=Random2DArray(4,4);
Print2DArray(a);
System.Console.WriteLine();
Order2DArrayLines(a);
Print2DArray(a);