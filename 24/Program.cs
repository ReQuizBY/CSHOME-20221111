// Вывести на экран таблицу квадратов чисел от 1 до N

System.Console.WriteLine("Введите кол-во чисел N:");
int N = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Квадрат числа");
for (int i = 1; i <= N; i++)
{
    System.Console.WriteLine( $"{i}^2 = "+ Math.Pow(i, 2));
}