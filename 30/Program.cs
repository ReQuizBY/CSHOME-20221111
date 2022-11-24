// 30. Написать программу вычисления произведения чисел от 1 до N

//Подпрограмма
int MultiResult(int x)
{
    int multip = 1;
    for (int i = 1; i <= x; i++)
    {
       multip=multip*i;
    }
    return multip;
}

//Основной программой
System.Console.WriteLine("Введите число N:");
int N = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Произведения от 1 до {N} = " + MultiResult(N));
