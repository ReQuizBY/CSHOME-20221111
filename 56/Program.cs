// 56 Написать программу копирования массива

int[] RandomIntArray(int size = 5, int min = 0, int max = 100)
{
    int[] a = new int[size];
    Random random = new Random();
    for (int i = 0; i < size; i++)
        a[i] = random.Next(min, max + 1);
    return a;
}

void Print(int[] a)
{
    for (int i = 0; i < a.Length; i++)
        System.Console.Write($"{a[i],5}");
}

void PrintDouble(int[] a)
{
    int[] copy = new int[a.Length];
    for (int i = 0; i < a.Length; i++)
    {
        copy[i] = a[i];
        System.Console.Write($"{copy[i],5}");
    }
}

int[] a = RandomIntArray(5, 1, 5);
Print(a);
System.Console.WriteLine();
System.Console.WriteLine("Копия массива");
PrintDouble(a);