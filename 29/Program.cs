//29. Подсчитать сумму цифр в числе. Сделать подпрограмму.

//Подпрограмма
int SumNum(int x)
{
    int sum = 0;
    for (int i = 0; i <= x; i++)
    {
        sum = sum + x % 10;
        x = x / 10;
    }
    return sum;
}

//Основной программой
System.Console.WriteLine("Введите число N:");
int N = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Сумма цифр числа {N} = " + SumNum(N));




