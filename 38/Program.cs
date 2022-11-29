// 38. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

int[] RandomIntArray(int N,int min,int max)
{
    int[] a=new int[N];
    Random random=new Random();
    for(int i=0;i<N;i++)
        a[i]=random.Next(0,150);
    return a;
}



void Print(int[] a)
{
    for(int i=0;i<a.Length;i++)
        System.Console.Write($"{a[i],5}");
}

int S(int[] a)
{
    int s=0;
    foreach(int el in a)
    {
    if (el>=10 && el<=99)
         s++;
    }
    return s;
}

int N=123;
int[] a=RandomIntArray(N,0,150);
Print(a);
System.Console.WriteLine();
System.Console.WriteLine($"{S(a)}");